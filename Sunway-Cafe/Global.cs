using Sunway_Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe
{
    public static class Global
    {
        public static User user = new User();

        public static bool IsValid<T>(T model, out List<List<string>>err)
        {
            var validationContext = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            if (Validator.TryValidateObject(model, validationContext, results, true))
            {
                err = null;
                return true;
            }
            else
            {
                err = results.Select(x => new List<string> { x.MemberNames.First(), x.ErrorMessage }).ToList<List<string>>();
                return false;
            }
        }

        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                if (img != null)
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
                else
                {
                    return ms.ToArray();
                }
            }
        }

        public static DateTime ConvToDateTime(string dts)
        {
            var pattern = "dd/MM/yyy HH:mm:ss";
            return DateTime.ParseExact(dts, pattern, null);
        }

        public static string ConvToDateTimeString(DateTime dt)
        {
            return dt.ToString("dd/MM/yyy HH:mm:ss");
        }
    }
}
