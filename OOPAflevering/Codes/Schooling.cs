using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;



namespace OOPAflevering.Codes
{
    internal abstract class Schooling 
    {
        public SchoolingCategory SchoolingName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string> Courses { get; set; }

        public virtual void SetCourses()
        {
            
            Courses = new List<string>();

            foreach (string item in Enum.GetNames(typeof(CourseCategory)))
            {
                Courses.Add(item);
            }

            //foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
            //{
            //    Courses.Add(GetEnumDesc.GetDescription(item).ToString());
            //}

        }

        public abstract string GetTeacher();

        public Schooling(SchoolingCategory schoolingName)
        {
            SchoolingName = schoolingName;
            Teachers = new List<TECPerson>()
            {
                new() {FullName = "Niels Olesen", Uddannelseslinje = SchoolingCategory.Programmeringslinje },
                new() {FullName = "Bo Hansen", Uddannelseslinje = SchoolingCategory.Supporterlinje },
                new() {FullName = "Ole Nielsen", Uddannelseslinje = SchoolingCategory.Infrastrukturlinje }
            };
        }

    }
}
