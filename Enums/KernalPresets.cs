using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionImageProcessing.Enums
{
    public enum KernalPresets {
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

        // Blur filters
        [Description("Blur filters - Gaussian")]
        Gaussian,
        [Description("Blur filters - BoxBlur")]
        BoxBlur,
        [Description("Blur filters - Median Filter")]
        Median,
        [Description("Blur filters - Motion Blur")]
        MotionBlur,

        // Sharpening filters
        [Description("Sharpening filters - Sharpen")]
        Sharpen,
        [Description("Sharpening filters - Edge Enhance")]
        EdgeEnhance,

        // Stylization
        [Description("Stylization - Emboss")]
        Emboss,

        // Utility
        [Description("Utility - Identity (No-op)")]
        Identity,

        // Custom input
        [Description("Custom filter - User Input")]
        UserInput
    }

}
