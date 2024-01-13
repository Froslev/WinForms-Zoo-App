using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DjurparkenWinForms;

namespace DjurparkenWinForms
{
    
        // Abstrakt grundklass för alla djur
        public abstract class animal
        {

            protected int Age;
            public string Name { get; protected set; }
            public bool Hungry;
        public string Favourite_food;
            public bool HasPlayed;


            // Konstruktor som sätter egenskaper för ett djur
            protected animal(int _Age, string _Name)
            {
                Age = _Age;
                Name = _Name;
                Hungry = false;
                Favourite_food = "Köttbullar";
            }

            // Metod för att generera ett slumpat tal mellan 1 och 3
            protected int GetRandomNumber()
            {
                Random random = new Random();
                return random.Next(1, 3);
            }

            // Metod för att skriva ut resultatet av det slumpmässiga numret
            protected void PrintRandomResult(int resultat)
            {

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nNu kommer programmet att slumpa ett tal..\nIfall det slumpade talet blir 1, så kommer djuret få äta.\nBlir det 2 så får djuret inte mat och fortsätter att vara hungrig..");

                Console.WriteLine($"\nSlumpar talet...\nResultat: {resultat}\n");
            }



            // Virtuell metod för att låta djuret äta
            public virtual void FeedAnimal(string food)

            {
                int resultat = GetRandomNumber();
                PrintRandomResult(resultat);

                if (resultat == 1)
                {
                    Hungry = false;


                    if (food == Favourite_food)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"\n{Name} tuggar glatt i sig " + Favourite_food + " och är nöjd..");
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\n{Name} är hungrig och ute på jakt medans han drömmer om " + Favourite_food + "..");
                    Hungry = true;
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            // Metod för att få åldern på djuret
            public int GetAge()
            {
                // Returnerar åldern
                return Age;
            }

            // Metod för att få namnet på djuret
            public string GetName()
            {
                // Returnerar namnet
                return Name;
            }

            // Virtuell metod för att interagera med djuret (standardmetoden)
            public virtual void interact()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"\n{Name} viftar glatt på svansen när du klappar han på huvudet");
                Hungry = true;

                if (Hungry)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\nEftersom {Name} har lekt med dig så blev han nu väldigt hungrig..");
                    Console.WriteLine($"Hungerstatus: {Name} är hungrig..");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }

            // Virtuell metod för att interagera med djuret genom att kasta boll (överlagradade metoden)
            public virtual void interact(bool throwBall)
            {

                if (throwBall)
                {

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n..En djurskötare kastar bollen till {Name}..");

                    if (throwBall)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        if (Hungry && Age >= 12)
                        {
                            Console.WriteLine($"\nEftersom {Name} är {Age} år gammal så blir han ofta väldigt trött när han är hungrig. Så {Name} orkar inte jaga efter bollen just nu..\n");
                        }

                        else
                        {
                            Console.WriteLine($"\n{Name} springer glatt och jagar efter bollen..\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        

                        if (!Hungry)
                        {
                            Hungry = true;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine($"\nEftersom {Name} har lekt med dig så blev han nu väldigt hungrig..");
                            Console.WriteLine($"Hungerstatus: {Name} är hungrig..");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }

                    else
                    {
                        interact(); // Kallar bas "interact" klassen
                    }

                }

                else
                {
                    interact(); // Anropar meddelandet från originalmetoden "Interact()"	
                }

            }

            public override string ToString()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                return $"Djur: {GetType().Name}\nNamn: {Name}\nÅlder: {Age} år \nFavoritmat: {Favourite_food}\n";
                // Skriver ut "djur" objekten
            }
        }

    
}
