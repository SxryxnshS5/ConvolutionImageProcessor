using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConvolutionImageProcessing.ViewModels
{
    public class ViewModel
    {
        public Image SelectedImage { get; set; }
        public Image LivePreview { get; set; }
    }
}
