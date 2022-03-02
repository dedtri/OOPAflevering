﻿using System;
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
            List<string> SchoolingCourses = new List<string>();
            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {
                foreach (string item in Enum.GetNames(typeof(CourseCategory)))
                {
                    //SchoolingCourses.Contains("test").Add(item);
                }
            }
            
            foreach (string item in Enum.GetNames(typeof(CourseCategory)))
            {
                SchoolingCourses.Add(item);
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