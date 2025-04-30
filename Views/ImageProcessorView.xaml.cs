using System.Windows;
using ConvolutionImageProcessing.ViewModels;

namespace ConvolutionImageProcessing.Views
{
    /// <summary>
    /// Interaction logic for ImageProcessorView.xaml
    /// </summary>
    public partial class ImageProcessorView : Window
    {
        public ImageProcessorView()
        {
            InitializeComponent();
            DataContext = new ImageProcessorViewModel();
        }
    }
}
