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

        // Sharpening filters
        public static readonly float[,] Sharpen = new float[,] {
            {  0, -1,  0 },
            { -1,  5, -1 },
            {  0, -1,  0 }
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

        // Utility
        public static readonly float[,] Identity = new float[,] {
            { 0, 0, 0 },
            { 0, 1, 0 },
            { 0, 0, 0 }
        };

        // Custom input
        public static float[,] UserInputKernel { get; set; } = new float[3, 3];
    }
}
