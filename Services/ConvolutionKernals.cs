namespace ConvolutionImageProcessing.Services {
    public static class ConvolutionKernals {
        // Edge detection filters
        public static readonly float[,] Sobel_X = new float[,] {
            { -1, 0, 1 },
            { -2, 0, 2 },
            { -1, 0, 1 }
        };

        public static readonly float[,] Sobel_Y = new float[,] {
            { -1, -2, -1 },
            {  0,  0,  0 },
            {  1,  2,  1 }
        };

        public static readonly float[,] Laplacian = new float[,] {
            {  0, -1,  0 },
            { -1,  4, -1 },
            {  0, -1,  0 }
        };

        public static readonly float[,] Prewitt_X = new float[,] {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
        };

        public static readonly float[,] Prewitt_Y = new float[,] {
            { -1, -1, -1 },
            {  0,  0,  0 },
            {  1,  1,  1 }
        };

        public static readonly float[,] Roberts_X = new float[,] {
            { 1, 0 },
            { 0, -1 }
        };

        public static readonly float[,] Roberts_Y = new float[,] {
            { 0, 1 },
            { -1, 0 }
        };

        // Additional edge detection
        public static readonly float[,] Outline = new float[,] {
            { -1, -1, -1 },
            { -1,  8, -1 },
            { -1, -1, -1 }
        };

        public static readonly float[,] Diagonal45 = new float[,] {
            { 0,  1, 2 },
            { -1, 0, 1 },
            { -2, -1, 0 }
        };

        public static readonly float[,] Diagonal135 = new float[,] {
            { 2, 1, 0 },
            { 1, 0, -1 },
            { 0, -1, -2 }
        };

        public static readonly float[,] KirschNorth = new float[,] {
            {  5,  5,  5 },
            { -3,  0, -3 },
            { -3, -3, -3 }
        };

        // Blur filters
        public static readonly float[,] Gaussian = new float[,] {
            { 1f/16f, 2f/16f, 1f/16f },
            { 2f/16f, 4f/16f, 2f/16f },
            { 1f/16f, 2f/16f, 1f/16f }
        };

        public static readonly float[,] BoxBlur = new float[,] {
            { 1f/9f, 1f/9f, 1f/9f },
            { 1f/9f, 1f/9f, 1f/9f },
            { 1f/9f, 1f/9f, 1f/9f }
        };

        public static readonly float[,] MotionBlur = new float[,] {
            { 1f/9f, 0f,    0f    },
            { 0f,    1f/9f, 0f    },
            { 0f,    0f,    1f/9f }
        };

        public static readonly float[,] LightBlur = new float[,] {
            { 1f/10f, 1f/10f, 1f/10f },
            { 1f/10f, 2f/10f, 1f/10f },
            { 1f/10f, 1f/10f, 1f/10f }
        };

        // Sharpening filters
        public static readonly float[,] Sharpen = new float[,] {
            {  0, -1,  0 },
            { -1,  5, -1 },
            {  0, -1,  0 }
        };

        public static readonly float[,] StrongSharpen = new float[,] {
            {  0, -2,  0 },
            { -2, 11, -2 },
            {  0, -2,  0 }
        };

        public static readonly float[,] HighBoost = new float[,] {
            { -1, -1, -1 },
            { -1,  9, -1 },
            { -1, -1, -1 }
        };

        public static readonly float[,] EdgeEnhance = new float[,] {
            {  0,  0,  0 },
            { -1,  1,  0 },
            {  0,  0,  0 }
        };

        // Stylization filters
        public static readonly float[,] Emboss = new float[,] {
            { -2, -1, 0 },
            { -1,  1, 1 },
            {  0,  1, 2 }
        };

        public static readonly float[,] Emboss45 = new float[,] {
            { -1, -1,  0 },
            { -1,  0,  1 },
            {  0,  1,  1 }
        };

        public static readonly float[,] RippleEffect = new float[,] {
            { 0,  1,  0 },
            { -1, 0,  1 },
            { 0, -1,  0 }
        };

        // Utility
        public static readonly float[,] Identity = new float[,] {
            { 0, 0, 0 },
            { 0, 1, 0 },
            { 0, 0, 0 }
        };
    }
}
