namespace ConvolutionImageProcessing.Services {
    public static class ConvolutionKernals {
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

        public static readonly float[,] Gaussian = new float[,] {
            { 1/16f, 2/16f, 1/16f },
            { 2/16f, 4/16f, 2/16f },
            { 1/16f, 2/16f, 1/16f }
        };

        public static readonly float[,] BoxBlur = new float[,] {
            { 1f/9f, 1f/9f, 1f/9f },
            { 1f/9f, 1f/9f, 1f/9f },
            { 1f/9f, 1f/9f, 1f/9f }
        };

        public static readonly float[,] Sharpen = new float[,] {
            {  0, -1,  0 },
            { -1,  5, -1 },
            {  0, -1,  0 }
        };

        public static float[,] UserInputKernel { get; set; } = new float[3, 3];
    }
}