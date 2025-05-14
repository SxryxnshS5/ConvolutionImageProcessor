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
                // Edge detection
                KernalPresets.Sobel_X => ConvolutionKernals.Sobel_X,
                KernalPresets.Sobel_Y => ConvolutionKernals.Sobel_Y,
                KernalPresets.Laplacian => ConvolutionKernals.Laplacian,
                KernalPresets.Prewitt_X => ConvolutionKernals.Prewitt_X,
                KernalPresets.Prewitt_Y => ConvolutionKernals.Prewitt_Y,
                KernalPresets.Roberts_X => ConvolutionKernals.Roberts_X,
                KernalPresets.Roberts_Y => ConvolutionKernals.Roberts_Y,

                // Blur filters
                KernalPresets.Gaussian => ConvolutionKernals.Gaussian,
                KernalPresets.BoxBlur => ConvolutionKernals.BoxBlur,
                KernalPresets.MotionBlur => ConvolutionKernals.MotionBlur,

                // Sharpening
                KernalPresets.Sharpen => ConvolutionKernals.Sharpen,
                KernalPresets.EdgeEnhance => ConvolutionKernals.EdgeEnhance,

                // Stylization
                KernalPresets.Emboss => ConvolutionKernals.Emboss,

                // Utility
                KernalPresets.Identity => ConvolutionKernals.Identity,

                // Custom
                KernalPresets.UserInput => ConvolutionKernals.UserInputKernel,

                // Default case
                _ => throw new ArgumentOutOfRangeException(nameof(kernalPresets), "Unknown filter type")
            };
        }

    }
}
