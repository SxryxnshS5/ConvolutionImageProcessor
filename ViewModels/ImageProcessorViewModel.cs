namespace ConvolutionImageProcessing.ViewModels {
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using System.Windows.Media.Imaging;
    using ConvolutionImageProcessing.Commands;
    using ConvolutionImageProcessing.Enums;
    using ConvolutionImageProcessing.Models;
    using Microsoft.Win32;

    public class ImageProcessorViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand LoadImageCommand { get; }
        public ICommand SaveImageCommand { get; }
        public ICommand ProcessImageCommand { get; }
        public Bitmap CurrentImage {
            get => currentImage;
            set {
                if(currentImage != value) {
                    currentImage = value;
                }

                RaisePropertyChanged();
            }
        }

        public Bitmap ResultImage {
            get => resultImage;
            set {
                if(resultImage != value) {
                    resultImage = value;
                }

                RaisePropertyChanged();
            }
        }

        public BitmapImage DisplayImage {
            get => displayImage;
            set {
                displayImage = value;
                RaisePropertyChanged();
            }
        }

        public BitmapImage ResultDisplayImage {
            get => resultDisplayImage;
            set {
                resultDisplayImage = value;
                RaisePropertyChanged();
            }
        }

        public KernelPresets SelectedKernelPreset {
            get => selectedKernelPreset;
            set {
                if(selectedKernelPreset != value) {
                    selectedKernelPreset = value;
                    RaisePropertyChanged();
                }
            }
        }

        public Array KernelPresetsList => Enum.GetValues(typeof(KernelPresets));

        private readonly ImageProcessorModel imageProcessorModel;
        private KernelPresets selectedKernelPreset;
        private Bitmap currentImage;
        private BitmapImage displayImage;
        private BitmapImage resultDisplayImage;
        private Bitmap resultImage;

        public ImageProcessorViewModel() {
            imageProcessorModel = new ImageProcessorModel();
            LoadImageCommand = new RelayCommand(LoadImage);
            ProcessImageCommand = new RelayCommand(Process);
            SaveImageCommand = new RelayCommand(SaveImage);
        }
        private void LoadImage() {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp;*.gif",
                Multiselect = true
            };

            if(openFileDialog.ShowDialog() == true) {
                var filepath = openFileDialog.FileName;
                var bitmap = imageProcessorModel.LoadImage(filepath);

                if(bitmap != null) {
                    currentImage = bitmap;
                }

                RaisePropertyChanged(nameof(CurrentImage));
                UpdateCurrentImage();
            }
        }

        private void SaveImage() {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif",
            };

            if(saveFileDialog.ShowDialog() == true) {
                string extension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();
                ImageFormat format = ImageFormat.Png; // Default

                switch(extension) {
                    case ".jpg":
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                imageProcessorModel.SaveImage(ResultImage, saveFileDialog.FileName, format);
            }
        }

        private void Process() {
            ResultImage = imageProcessorModel.ApplyConvolutionFilter(CurrentImage, SelectedKernelPreset);
            ResultDisplayImage = ConvertBitmapToBitmapImage(ResultImage);
        }

        private void UpdateCurrentImage() {
            if(currentImage != null) {
                DisplayImage = ConvertBitmapToBitmapImage(currentImage);
            }
        }

        private BitmapImage ConvertBitmapToBitmapImage(Bitmap bitmap) {
            using(MemoryStream ms = new MemoryStream()) {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ms.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        // Simple method with CallerMemberName so you can call RaisePropertyChanged() without parameters if you want
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
