using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace eRAMO.FB.Business.Helpers
{
    public class Html5ImageUploaderHelper
    {
        public static string SaveBase64ImageToFile(byte[] base64Image, string imagePath, string fileName)
        {
            FileStream fs = new FileStream(string.Format("{0}{1}.jpg", HttpContext.Current.Server.MapPath("~" + imagePath), fileName), FileMode.OpenOrCreate);
            fs.Write(base64Image, 0, base64Image.Length);
            fs.Close();

            return string.Format("{0}{1}.jpg", imagePath, fileName);
        }

        public static byte[] ResizeImage(byte[] originalImage, int newWidth, int newHeight)
        {
            Bitmap startBitmap = CreateBitmapFromBytes(originalImage);
            Bitmap newBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(newBitmap))
            {
                graphics.DrawImage(startBitmap, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(0, 0, startBitmap.Width, startBitmap.Height), GraphicsUnit.Pixel);
            }

            byte[] newBytes = CreateBytesFromBitmap(newBitmap);
            return newBytes;
        }

        public static byte[] CreateBytesFromBitmap(Bitmap newBitmap)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(newBitmap, typeof(byte[]));
        }

        public static Bitmap CreateBitmapFromBytes(byte[] image)
        {
            ImageConverter ic = new ImageConverter();
            Image img = (Image)ic.ConvertFrom(image);
            return new Bitmap(img);
        }

        public static byte[] GetImageFromUploader(string _values)
        {
            JObject values = JObject.Parse(_values);
            var coverImage = values["data"].Value<string>().Split(new char[] { ',' }, 2);
            return Convert.FromBase64String(coverImage[1]);
        }

        public static byte[] GetImageFromUploaderData(string bytes)
        {
            var coverImage = bytes.Split(new char[] { ',' }, 2);
            return Convert.FromBase64String(coverImage[1]);
        }
    }
}
