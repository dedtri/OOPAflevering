using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPAflevering.Codes
{
    internal class Course : Schooling
    {
        public List<string> SchoolingCourses { get; set; }

        public Course(SchoolingCategory schoolingName) : base(schoolingName)
        {
                SetCourses();
        }

        public override void SetCourses()
        {
            base.SetCourses();
            SchoolingCourses = new List<string>();
            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {
                foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
                {
                    if (item.GetDescription().ToLower().Contains("programmering"))
                    {
                        SchoolingCourses.Add(GetEnumDesc.GetDescription(item).ToString());
                    }
                }
            }
            else if (SchoolingName == SchoolingCategory.Supporterlinje)
            {
                foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
                {
                    if (item.GetDescription().ToLower().Contains("server"))
                    {
                        SchoolingCourses.Add(GetEnumDesc.GetDescription(item).ToString());
                    }
                }
            }
            else if (SchoolingName == SchoolingCategory.Infrastrukturlinje)
            {
                foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
                {
                    if (item.GetDescription().ToLower().Contains("netværk"))
                    {
                        SchoolingCourses.Add(GetEnumDesc.GetDescription(item).ToString());
                    }
                }
            }


        }

        public override string GetTeacher()
        {
            var valid = Teachers.FirstOrDefault(a => a.Uddannelseslinje == SchoolingName);
            return valid.FullName;
        }

        public override string ToString()
        {
            return "** OOP H1 AfleveringsOpgave **";
        }
    }
}
