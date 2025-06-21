namespace ConvolutionImageProcessing.Views {
    using System.Windows;
    using ConvolutionImageProcessing.ViewModels;

    /// <summary>
    /// Interaction logic for ImageProcessorView.xaml
    /// </summary>
    public partial class ImageProcessorView : Window {
        public ImageProcessorView() {
            InitializeComponent();
            DataContext = new ImageProcessorViewModel();
        }
    }
}
