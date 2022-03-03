using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OOPAflevering.Codes
{
    internal static class GetEnumDesc
    {
        public static string GetDescription(this Enum value)
        {
            var type = value.GetType();

            var fi = type.GetField(value.ToString());

            var descriptions = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return descriptions.Length > 0 ? descriptions[0].Description : value.ToString();
        }
    }
}
