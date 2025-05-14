using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvolutionImageProcessing.Enums;

namespace ConvolutionImageProcessing.Services {
    public class KernalSelector {
        public float[,] GetKernalPreset(KernalPresets kernalPresets) {
            return kernalPresets switch {
                KernalPresets.Sobel_X => ConvolutionKernals.Sobel_X,
                KernalPresets.Sobel_Y => ConvolutionKernals.Sobel_Y,
                KernalPresets.Laplacian => ConvolutionKernals.Laplacian,
                KernalPresets.Gaussian => ConvolutionKernals.Gaussian,
                KernalPresets.BoxBlur => ConvolutionKernals.BoxBlur,
                KernalPresets.Sharpen => ConvolutionKernals.Sharpen,
                KernalPresets.UserInput => ConvolutionKernals.UserInputKernel,
                _ => throw new ArgumentOutOfRangeException(nameof(kernalPresets), "Unknown filter type")
            };
        }
    }
}
