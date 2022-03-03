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
        [Description("Web server")]
        Webserver,
        [Description("Database server")]
        Databaseserver,
        [Description("WAN netværk")]
        WANnetværk,
        [Description("LAN netværk")]
        LANnetværk,
    }
}
