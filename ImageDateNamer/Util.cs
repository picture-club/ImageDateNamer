using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyPictures
{
    public static class ImageUtil
    {
        public static DateTime? GetDateTaken(Image img)
        {
            // EXIF property tag for "Date Taken" is 0x9003
            const int PropertyTagDateTaken = 0x9003;

            try
            {
                if (img.PropertyIdList.Contains(PropertyTagDateTaken))
                {
                    var propItem = img.GetPropertyItem(PropertyTagDateTaken);
                    string dateTakenStr = Encoding.ASCII.GetString(propItem.Value);
                    dateTakenStr = dateTakenStr.Trim('\0');
                    // EXIF format: "yyyy:MM:dd HH:mm:ss"
                    if (DateTime.TryParseExact(dateTakenStr,
                        "yyyy:MM:dd HH:mm:ss",
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out DateTime dt))
                    {
                        return dt;
                    }
                }
            }
            catch
            {
                // ignore if property missing or invalid
            }

            return null;
        }

        public static string GetPropStr(Image img, int propertyId)
        {
            try
            {
                if (img.PropertyIdList.Contains(propertyId))
                {
                    var propItem = img.GetPropertyItem(propertyId);
                    return Encoding.ASCII.GetString(propItem.Value).Trim('\0').Trim();
                }
            }
            catch { }
            return null;
        }

        public static void SaveImageInfoToFile(IMAGE_INFO info, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true, // makes JSON readable
            };

            string json = JsonSerializer.Serialize(info, options);
            File.WriteAllText(filePath, json);
        }

        public static IMAGE_INFO LoadImageInfoFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<IMAGE_INFO>(json);
        }
    }
}
