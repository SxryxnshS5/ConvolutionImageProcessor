namespace ConvolutionImageProcessing.Enums {
    using System.ComponentModel;

    public enum KernelPresets {
        // Edge detection filters
        [Description("Edge detection - Sobel X")]
        Sobel_X,
        [Description("Edge detection - Sobel Y")]
        Sobel_Y,
        [Description("Edge detection - Laplacian")]
        Laplacian,
        [Description("Edge detection - Prewitt X")]
        Prewitt_X,
        [Description("Edge detection - Prewitt Y")]
        Prewitt_Y,
        [Description("Edge detection - Roberts Cross X")]
        Roberts_X,
        [Description("Edge detection - Roberts Cross Y")]
        Roberts_Y,
        [Description("Edge detection - Outline")]
        Outline,
        [Description("Edge detection - Diagonal 45°")]
        Diagonal45,
        [Description("Edge detection - Diagonal 135°")]
        Diagonal135,
        [Description("Edge detection - Kirsch North")]
        KirschNorth,

        // Blur filters
        [Description("Blur filter - Gaussian")]
        Gaussian,
        [Description("Blur filter - BoxBlur")]
        BoxBlur,
        [Description("Blur filter - Motion Blur")]
        MotionBlur,
        [Description("Blur filter - Light Blur")]
        LightBlur,

        // Sharpening filters
        [Description("Sharpening filter - Sharpen")]
        Sharpen,
        [Description("Sharpening filter - Strong Sharpen")]
        StrongSharpen,
        [Description("Sharpening filter - High Boost")]
        HighBoost,
        [Description("Sharpening filter - Edge Enhance")]
        EdgeEnhance,

        // Stylization
        [Description("Stylization - Emboss")]
        Emboss,
        [Description("Stylization - Emboss 45°")]
        Emboss45,
        [Description("Stylization - Ripple Effect")]
        RippleEffect,

        // Utility
        [Description("Utility - Identity (No-op)")]
        Identity
    }
}
