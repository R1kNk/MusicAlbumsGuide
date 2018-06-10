using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.SharedFormsMethods
{
   static class ImageMethods
    {
        static public byte[] ConvertFileToByteArray(string FileName)
        {
            Bitmap bitMap = new Bitmap(FileName);
            ImageFormat bmpFormat = bitMap.RawFormat;
            var imageToConvert = ConvertFileToImage(FileName);
            using (MemoryStream ms = new MemoryStream())
            {
                imageToConvert.Save(ms, bmpFormat);
                return ms.ToArray();
            }
        }
        static public Image ConvertFileToImage(string FileName)
        {
            Image imageToConvert = Image.FromFile(FileName);
            return imageToConvert;

        }
        static public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        static public Image ConvertByteArrayToImage(byte[] File)
        {
            System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
            foreach (byte b in File) memoryStream1.WriteByte(b);
            Image image1 = Image.FromStream(memoryStream1);
            return image1;


        }
        //
        public static Stream ToStream(this Image image)
        {
            
            var stream = new System.IO.MemoryStream();
            image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;
            return stream;
        }
    }
}

