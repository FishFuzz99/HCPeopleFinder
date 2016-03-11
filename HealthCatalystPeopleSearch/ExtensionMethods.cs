using HealthCatalystPeopleSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace HealthCatalystPeopleSearch
{
    public static class ExtensionMethods
    {
        public static Image ConvertByteArrToImage(this byte[] byteArr)
        {
            MemoryStream memoryStream = new MemoryStream(byteArr);
            Image image = Image.FromStream(memoryStream);
            return image;
        }

        public static byte[] ConvertImageToByteArr(this Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }

        public static bool ContainsAny(this string str, params string[] arrValues)
        {
            if (!string.IsNullOrEmpty(str) || arrValues.Length > 0)
            {
                foreach (string value in arrValues)
                {
                    if (str.ToLower().Contains(value.ToLower()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
