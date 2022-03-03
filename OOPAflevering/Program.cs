using OOPAflevering.Codes;

ConsoleKeyInfo cki;

while (true)
{
    Console.WriteLine("Vælg uddannelseslinje: ");
    Console.WriteLine("1) Programmering");
    Console.WriteLine("2) Support");
    Console.WriteLine("3) Infrastruktur");

    Console.WriteLine("\nVælg 1, 2 eller 3: ");
    cki = Console.ReadKey();
    Console.Clear();

    if (cki.Key == ConsoleKey.D1)
    {
        Course a = new Course(SchoolingCategory.Programmeringslinje);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(a.ToString());
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.Write("Af alle fag, har ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(a.SchoolingName);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" følgende fag vist med");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" grøn: \n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------------------------------------------");


        List<string> list = a.Courses;
        List<TECPerson> list2 = a.Teachers;

        list.Sort();


        foreach (var item in a.Courses)
        {
            if (a.SchoolingCourses.Contains(item))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine(item);
        }


        Console.WriteLine();
        Console.WriteLine("Lærer: ");

        list2.Sort();

        foreach (var s in list2)
        {
            if (s.FullName == a.GetTeacher())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s.FullName);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            { 
                Console.WriteLine(s.FullName);
            }
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------------------------------------------\n");



    }
    else if (cki.Key == ConsoleKey.D2)
    {
        Course a = new Course(SchoolingCategory.Supporterlinje);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(a.ToString());
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.Write("Af alle fag, har ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(a.SchoolingName);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" følgende fag vist med");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" grøn: \n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------------------------------------------");


        List<string> list = a.Courses;
        List<TECPerson> list2 = a.Teachers;

        list.Sort();


        foreach (var item in a.Courses)
        {
            if (a.SchoolingCourses.Contains(item))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine(item);
        }


        Console.WriteLine();
        Console.WriteLine("Lærer: ");

        list2.Sort();

        foreach (var s in list2)
        {
            if (s.FullName == a.GetTeacher())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(s.FullName);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine(s.FullName);
            }
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------------------------------------------\n");
    }
    else if (cki.Key == ConsoleKey.D3)
    {
        Course a = new Course(SchoolingCategory.Infrastrukturlinje);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(a.ToString());
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.Write("Af alle fag, har ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(a.SchoolingName);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" følgende fag vist med");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" grøn: \n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------------------------------------------");


        List<string> list = a.Courses;
        List<TECPerson> list2 = a.Teachers;

        list.Sort();

        foreach (var item in a.Courses)
        {
            if (a.SchoolingCourses.Contains(item))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine(item);
        }


        Console.WriteLine();
        Console.WriteLine("Lærer: ");

        list2.Sort();

        foreach (var s in list2)
        {
            if (s.FullName == a.GetTeacher())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(s.FullName);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine(s.FullName);
            }
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------------------------------------------\n");
    }
}



