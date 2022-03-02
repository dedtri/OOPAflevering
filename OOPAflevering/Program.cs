using OOPAflevering.Codes;


//Quiz del 1/5

//Udefra klasserne til venstre, og med det arve hierarki som klasserne implementer,
//hvilket af følgende 6 istantiering forneden vil IKKE vise fejl når implementeres?
//SVAR: 1, 2, 3 og 4

//MotorKøretøj motorKøretøj = new MotorKøretøj(); 
//MotorKøretøj motorKøretøj = new Bil();
//MotorKøretøj motorKøretøj = new Audi(); 
//Audi audi = new Audi();
//Audi audi = new Bil(); <- Fejler
//Audi audi = new MotorKøretøj(); <- Fejler

//Hvis man istantiere Audi klassen. Kan man igennem audi klassens instans se Mærke og HesteKræfter property’erne?
//SVAR: Ja

//Audi audi = new Audi();

//audi.HesteKræfter = 0;
//audi.Mærke = "";
//audi.Model = "";

//Hvis man istantiere MotorKøretøj klassen. Kan man igennem motorkøretøj instans se Mærke og Model property’erne?
//SVAR: Nej

//MotorKøretøj motorKøretøj = new MotorKøretøj();
//MotorKøretøj motorKøretøj2 = new Bil();
//MotorKøretøj motorKøretøj3 = new Audi();

//motorKøretøj.HesteKræfter = 0;
//motorKøretøj.Mærke = "";
//motorKøretøj.Model = "";

//motorKøretøj2.Mærke = "";
//motorKøretøj3.Model = "";


//Quiz del 2/5

//MotorKøretøj motorKøretøj = new()
//{
//    Biler = new List<Bil>()
//    {
//        new Bil() { Mærke = "Toyota", Model = "Aygo", HesteKræfter = 60 },
//        new Bil() { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
//        new Bil() { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }
//    }
//};


//List<Bil> list1 = motorKøretøj.Biler.Where(a => a.HesteKræfter > 60).ToList();

//Console.WriteLine("List1: ");
//foreach (Bil bil in list1)
//{
//    Console.WriteLine("Mærke: " + bil.Mærke + " " + "Model: " + bil.Model + " " + "HesteKræfter: " + bil.HesteKræfter);
//}



//List<Bil> list2 = motorKøretøj.Biler.Where(a => a.Mærke.ToLower().Contains("audi")).ToList();

//Console.WriteLine("List 2: ");
//foreach (Bil bil in list2)
//{
//    Console.WriteLine("Mærke: " + bil.Mærke + " " + "Model: " + bil.Model + " " + "HesteKræfter: " + bil.HesteKræfter);
//}



//Quiz del 3/5

//?? = Biler.Where(...); 
//?? = Biler.FirstOrDefault(...); 
//?? = Biler.First(...);

//Bil bil2, bil3;

//List<Bil> bil4 = motorKøretøj.Biler.Where(a => a.Mærke.ToLower() == "auddi").ToList();
//bil2 = motorKøretøj.Biler.First(a => a.Mærke.ToLower() == "auddi");
//bil3 = motorKøretøj.Biler.FirstOrDefault(a => a.Mærke.ToLower() == "adudi");

//1. Hvilket af de 3 kode linjer foroven returner en List<Bil>
//SVAR: Det gør Biler.Where(...); 
//2. Hvilket af de 3 kode linjer foroven returner en enkelt Bil objekt?
//SVAR: Det gør Biler.First(...); og Biler.FirstOrDefault(...); 
//3. Hvilket af de 3 kode linjer foroven returner null værdi hvis søge kondition ikke matcher med noget af data i listen?
//SVAR: Biler.FirstOrDefault(...); 
//4. Hvilket af de 3 kode linjer foroven vil CRASH applikationen hvis ingen match funket i søge kondition? 
//SVAR: Biler.First(...);


//Quiz del 4/5

//Alle bil skal have vægtafgift, derfor bør den ligge i Bil klassen.
//Men man ved ikke hvordan man skal implementer kode til udregning af vægt afgift i Bil
//klassen fordi det er afhængigt af bilens mærke og model. Som parent klasse kan Bil klasse ikke se data i childklassen.
//Hvad skal man gøre her? 

//SVAR: Du kan implementere en virtual metode i Bil.cs og override den i Audi.cs med en ny metode (med samme navn) 
//for at få fat i Audi.cs' data (model)


//Quiz del 5/5

//Angiv vilket metode til venstre er overloaded.
//SVAR: Det er "SetSyn" metoden der er overloaded. En Metode der tager 2 forskellige parametre, som kan udføre forskelligt kode.
