using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OOPAflevering.Codes
{
    internal enum CourseCategory
    {
        [Description("Grundlæggende programmering")]
        Grundlæggendeprogrammering,
        [Description("Objektorienteret programmering")]
        Objektorienteretprogrammering,
        [Description("Objektorienteret programmering")]
        Webserver,
        [Description("Objektorienteret programmering")]
        Databaseserver,
        [Description("11111")]
        WANnetværk,
        [Description("sdfasdfasdfdsfads")]
        LANnetværk,
    }
}
