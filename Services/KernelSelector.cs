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

                // Blur filters
                KernelPresets.Gaussian => ConvolutionKernals.Gaussian,
                KernelPresets.BoxBlur => ConvolutionKernals.BoxBlur,
                KernelPresets.MotionBlur => ConvolutionKernals.MotionBlur,

                // Sharpening
                KernelPresets.Sharpen => ConvolutionKernals.Sharpen,
                KernelPresets.EdgeEnhance => ConvolutionKernals.EdgeEnhance,

                // Stylization
                KernelPresets.Emboss => ConvolutionKernals.Emboss,

                // Utility
                KernelPresets.Identity => ConvolutionKernals.Identity,

                // Default case
                _ => throw new ArgumentOutOfRangeException(nameof(kernelPresets), "Unknown filter type")
            };
        }
    }
}
