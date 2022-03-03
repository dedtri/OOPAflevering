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
        Console.ForegroundColor = ConsoleColor.White;
        Course a = new Course(SchoolingCategory.Programmeringslinje);
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
        //List<string> list3 = a.SchoolingCourses;

        list.Sort();


        foreach (var t in list)
        {
                Console.WriteLine(t);
        }

        Console.WriteLine();

        //foreach (var t in list3)
        //{
        //    Console.WriteLine(t);
        //}


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
    }
    else if (cki.Key == ConsoleKey.D2)
    {
        Course a = new Course(SchoolingCategory.Infrastrukturlinje);
    }
}



