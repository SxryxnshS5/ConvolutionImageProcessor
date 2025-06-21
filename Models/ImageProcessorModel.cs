namespace ConvolutionImageProcessing.Models {
    using System.Drawing;
    using System.Drawing.Imaging;
    using ConvolutionImageProcessing.Enums;
    using ConvolutionImageProcessing.Services;

    public class ImageProcessorModel {
        private KernelSelector kernalSelector;
        public ImageProcessorModel() {
            kernalSelector = new KernelSelector();
        }
        public Bitmap LoadImage(string filepath) {
            return new Bitmap(filepath);
        }

        public void SaveImage(Bitmap bitmap, string outputPath, ImageFormat format) {
            bitmap.Save(outputPath, format);
        }

        public Bitmap ApplyConvolutionFilter(Bitmap image, KernelPresets kernelPresets) {
            float[,] kernel = kernalSelector.GetKernalPreset(kernelPresets);
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            BitmapData sourceData = image.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            Bitmap result = new Bitmap(image.Width, image.Height);
            BitmapData resultData = result.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int kernelHeight = kernel.GetLength(0);
            int kernelWidth = kernel.GetLength(1);

            int kernelCenterY = kernelHeight / 2;
            int kernelCenterX = kernelWidth / 2;

            int sourceStride = sourceData.Stride;
            int destStride = resultData.Stride;

            IntPtr sourcePtr = sourceData.Scan0;
            IntPtr destPtr = resultData.Scan0;

            byte[] sourceValues = new byte[Math.Abs(sourceStride) * image.Height];
            byte[] resultValues = new byte[Math.Abs(destStride) * image.Height];

            System.Runtime.InteropServices.Marshal.Copy(sourcePtr, sourceValues, 0, sourceValues.Length);

            float kernelSum = 0f;
            for(int ky = 0; ky < kernelHeight; ky++)
                for(int kx = 0; kx < kernelWidth; kx++)
                    kernelSum += kernel[ky, kx];

            if(kernelSum == 0f) kernelSum = 1f;

            for(int y = 0; y < image.Height; y++) {
                for(int x = 0; x < image.Width; x++) {
                    float resultR = 0, resultG = 0, resultB = 0;

                    for(int ky = 0; ky < kernelHeight; ky++) {
                        for(int kx = 0; kx < kernelWidth; kx++) {
                            int sourceX = x + (kx - kernelCenterX);
                            int sourceY = y + (ky - kernelCenterY);

                            sourceX = Math.Max(0, Math.Min(sourceX, image.Width - 1));
                            sourceY = Math.Max(0, Math.Min(sourceY, image.Height - 1));

                            int sourceIndex = (sourceY * sourceStride) + (sourceX * 4);

                            float kernelValue = kernel[ky, kx];

                            resultB += sourceValues[sourceIndex] * kernelValue;
                            resultG += sourceValues[sourceIndex + 1] * kernelValue;
                            resultR += sourceValues[sourceIndex + 2] * kernelValue;
                        }
                    }

                    resultB /= kernelSum;
                    resultG /= kernelSum;
                    resultR /= kernelSum;

                    byte newB = (byte)Math.Max(0, Math.Min(255, resultB));
                    byte newG = (byte)Math.Max(0, Math.Min(255, resultG));
                    byte newR = (byte)Math.Max(0, Math.Min(255, resultR));

                    int destIndex = (y * destStride) + (x * 4);

                    resultValues[destIndex] = newB;
                    resultValues[destIndex + 1] = newG;
                    resultValues[destIndex + 2] = newR;
                    resultValues[destIndex + 3] = sourceValues[destIndex + 3];
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(resultValues, 0, destPtr, resultValues.Length);

            image.UnlockBits(sourceData);
            result.UnlockBits(resultData);

            return result;
        }
    }
}
