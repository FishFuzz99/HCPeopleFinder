using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HealthCatalystPeopleSearch
{
    [ValueConversion(typeof(Image), typeof(System.Windows.Media.ImageSource))]
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            Image image = (Image)value;
            var bitmap = new System.Windows.Media.Imaging.BitmapImage();

            bitmap.BeginInit();

            MemoryStream memoryStream = new MemoryStream();

            image.Save(memoryStream, ImageFormat.Bmp);
            memoryStream.Seek(0, SeekOrigin.Begin);

            bitmap.StreamSource = memoryStream;
            bitmap.EndInit();
            //memoryStream.Dispose();    //this breaks it?  
            return bitmap;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null; // only used one way to get it to display
        }
    }
}
