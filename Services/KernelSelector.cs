namespace ConvolutionImageProcessing.Services {
    using ConvolutionImageProcessing.Enums;

    public class KernelSelector {
        public float[,] GetKernalPreset(KernelPresets kernelPresets) {
            return kernelPresets switch {
                // Edge detection
                KernelPresets.Sobel_X => ConvolutionKernals.Sobel_X,
                KernelPresets.Sobel_Y => ConvolutionKernals.Sobel_Y,
                KernelPresets.Laplacian => ConvolutionKernals.Laplacian,
                KernelPresets.Prewitt_X => ConvolutionKernals.Prewitt_X,
                KernelPresets.Prewitt_Y => ConvolutionKernals.Prewitt_Y,
                KernelPresets.Roberts_X => ConvolutionKernals.Roberts_X,
                KernelPresets.Roberts_Y => ConvolutionKernals.Roberts_Y,
                KernelPresets.Outline => ConvolutionKernals.Outline,
                KernelPresets.Diagonal45 => ConvolutionKernals.Diagonal45,
                KernelPresets.Diagonal135 => ConvolutionKernals.Diagonal135,
                KernelPresets.KirschNorth => ConvolutionKernals.KirschNorth,

                // Blur filters
                KernelPresets.Gaussian => ConvolutionKernals.Gaussian,
                KernelPresets.BoxBlur => ConvolutionKernals.BoxBlur,
                KernelPresets.MotionBlur => ConvolutionKernals.MotionBlur,
                KernelPresets.LightBlur => ConvolutionKernals.LightBlur,

                // Sharpening
                KernelPresets.Sharpen => ConvolutionKernals.Sharpen,
                KernelPresets.StrongSharpen => ConvolutionKernals.StrongSharpen,
                KernelPresets.HighBoost => ConvolutionKernals.HighBoost,
                KernelPresets.EdgeEnhance => ConvolutionKernals.EdgeEnhance,

                // Stylization
                KernelPresets.Emboss => ConvolutionKernals.Emboss,
                KernelPresets.Emboss45 => ConvolutionKernals.Emboss45,
                KernelPresets.RippleEffect => ConvolutionKernals.RippleEffect,

                // Utility
                KernelPresets.Identity => ConvolutionKernals.Identity,

                _ => throw new ArgumentOutOfRangeException(nameof(kernelPresets), "Unknown filter type")
            };
        }
    }
}
