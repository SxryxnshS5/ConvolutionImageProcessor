using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using ConvolutionImageProcessing.Enums;
using ConvolutionImageProcessing.Services;

namespace ConvolutionImageProcessing.Models {
    public class ImageProcessorModel {
        public Bitmap LoadImage(string filepath) {
            return new Bitmap(filepath);
        }

        public void SaveImage(Bitmap bitmap, string outputPath, ImageFormat format) {
            bitmap.Save(outputPath, format);
        }

        public Bitmap ApplyConvolutionFilter(Bitmap image, KernalPresets kernelPresets, KernalSelector kernalSelector) {
            float[,] kernel = kernalSelector.GetKernalPreset(kernelPresets);
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Lock the source image
            BitmapData sourceData = image.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            // Create destination image and lock it
            Bitmap result = new Bitmap(image.Width, image.Height);
            BitmapData resultData = result.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            // Apply convolution logic here using sourceData and resultData

            // Unlock bits
            image.UnlockBits(sourceData);
            result.UnlockBits(resultData);

            return result;
        }

    }
}
