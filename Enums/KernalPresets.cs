using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionImageProcessing.Enums
{
    public enum KernalPresets
    {
        // Edge detection filters
        [Description("Edge detection - Sobel X")]
        Sobel_X,
        [Description("Edge detection - Sobel Y")]
        Sobel_Y,
        [Description("Edge detection - Laplacian")]
        Laplacian,

        // Blur filters
        [Description("Blur filters - Gaussian")]
        Gaussian,
        [Description("Blur filters - BoxBlur")]
        BoxBlur,

        // Sharpening filters
        [Description("Sharpening filters - Sharpen")]
        Sharpen,

        // Custom input
        [Description("Custom filter - User Input")]
        UserInput
    }
}
