using System.Globalization;
using DjurparkenWinForms;
using System.Collections.Generic;
using System;


namespace DjurparkenWinForms
{



        // Klassen som "äger" djuren och lagrar dom i en array
        class zoo
        {
            private DateTime OpeningHoursStart;
            private DateTime OpeningHoursEnd;
            private int Price;

            private List<animal> AnimalList;
            private List<Visitor> VisitorList;

            public zoo(int price)
            {
                OpeningHoursStart = new DateTime(1, 1, 1, 9, 30, 0);
                OpeningHoursEnd = new DateTime(1, 1, 1, 17, 30, 0);

                Price = price;
                AnimalList = new List<animal>

                    {
                        new wolf(8, "Ghost"),
                        new Lion(12, "Simba"),
                        new LionCub(2, "Akira", 6),
                        new Beaver(37, "Lars")
                    };

                VisitorList = new List<Visitor>();
            }

            public void AddVisitor(Visitor visitor)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                VisitorList.Add(visitor);
                Console.WriteLine($"Besökare {visitor.FirstName} {visitor.LastName} har lagts till..");
                Console.ForegroundColor = ConsoleColor.White;
            }

            public void ShowVisitors()
            {
                Console.WriteLine("\nBesökare:");

                foreach (Visitor visitor in VisitorList)
                {
                    Console.WriteLine(visitor);
                }
            }

            public void ShowZooInfo()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nInformation angående Djurparken:");

                string openingHoursStartFormatted = OpeningHoursStart.ToString("HH:mm");
                string openingHoursEndFormatted = OpeningHoursEnd.ToString("HH:mm");
                Console.WriteLine($"Öppettider: {openingHoursStartFormatted} - {openingHoursEndFormatted}");

               
                
            }

            // Gör så att tiden kan se ut såhär 09:30 - 17:30 istället för 930 -1730
            private string FormatTime(int time)
            {
                DateTime timeAsDateTime = DateTime.ParseExact(time.ToString("0000"), "HHmm", CultureInfo.InvariantCulture);
                return timeAsDateTime.ToString("HH:mm");
            }

            public string GetOpeningHours()
            {
                return $"Öppettider: {OpeningHoursStart.ToString("HH:mm")} - {OpeningHoursEnd.ToString("HH:mm")}";
            }

        public int GetTicketPrice()
        {
            return Price;
        }
        public List<animal> GetAnimalList()
        {
            return AnimalList;
        }

        public List<Visitor> GetVisitorList()
        {
            return VisitorList;
        }



        // Metod för att köra huvudmenyn och interaktionerna med djuren
        public void Run()
            {

                bool exitMenu = false;

                while (!exitMenu)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nVälj ett alternativ:\n");
                    Console.WriteLine("1. Visa info angående Djurparken");
                    Console.WriteLine("2. Skriv ut alla djur");
                    Console.WriteLine("3. Mata ett djur");
                    Console.WriteLine("4. Lek med ett djur");
                    Console.WriteLine("5. Lägg till besökare");
                    Console.WriteLine("6. Visa besökare");
                    Console.WriteLine("7. Avsluta\n");


                    string userChoice = Console.ReadLine();
                    Console.WriteLine("\nSvar: " + userChoice);

                    // Skapar en switch meny så användaren kan välja att göra lite olika saker med programmet
                    switch (userChoice)
                    {
                        case "1":
                            ShowZooInfo();
                            break;

                        case "2":
                            print_animals();
                            break;

                        case "3":
                            feed();
                            break;

                        case "4":
                            play();
                            break;

                        case "5":
                            //Lägg till en besökare
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nAnge besökarens förnamn:");
                            string visitorFirstName = Console.ReadLine();

                            Console.WriteLine("Ange besökarens efternamn:");
                            string visitorLastName = Console.ReadLine();

                            Console.WriteLine("Ange besökarens ålder:");
                            int visitorAge;
                            while (!int.TryParse(Console.ReadLine(), out visitorAge))
                            {
                                Console.WriteLine("Ogiltig ålder. Var vänlig ange ett heltal..");
                            }

                            //Skapar ett Visitor objekt samt lägger till det i Visitorlistan
                            Visitor newVisitor = new Visitor(visitorFirstName, visitorLastName, visitorAge);
                            AddVisitor(newVisitor);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case "6":
                            ShowVisitors();
                            break;

                        case "7":
                            exitMenu = true;
                            break;

                        default:
                            Console.WriteLine("Ogiltigt val. Försök igen..");
                            break;

                    }

                }

            }

            // Metod för att skriva ut all djur i listan
            public void print_animals()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLista över alla djur:\n");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (animal currentAnimal in AnimalList)
                {
                    Console.WriteLine(currentAnimal);
                }


            }

            // Metod för att leka med ett djur
            public void play()
            {

                Console.WriteLine("\nVälj ett av djuren att leka med:\n");
                Console.WriteLine("1. Wolf");
                Console.WriteLine("2. Lion");
                Console.WriteLine("3. Lion cub");
                Console.WriteLine("4. Beaver\n");


                string lekVal = Console.ReadLine();
                Console.WriteLine("\nSvar: " + lekVal);

                // Skapar en switch meny så användaren kan välja vilket djur man ska leka med
                switch (lekVal)
                {
                    case "1":
                        AnimalList[0].interact();
                        break;

                    case "2":
                        AnimalList[1].interact();
                        break;

                    case "3":
                        AnimalList[2].interact(true);
                        break;

                    case "4":
                        AnimalList[3].interact(true);
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen..");
                        break;

                }

            }


            // Metod för att mata djuren
            public void feed()
            {
                Console.WriteLine("\nVälj ett av djuren att mata:\n");
                Console.WriteLine("1. Wolf");
                Console.WriteLine("2. Lion");
                Console.WriteLine("3. Lion cub");
                Console.WriteLine("4. Beaver\n");


                string matVal = Console.ReadLine();
                Console.WriteLine("\nSvar: " + matVal);

                // Skapar en switch meny så användaren kan välja vilket djur man ska mata
                switch (matVal)
                {
                    case "1":
                        AnimalList[0].FeedAnimal("Älgkött");
                        break;

                    case "2":
                        AnimalList[1].FeedAnimal("Kött");
                        break;

                    case "3":
                        AnimalList[2].FeedAnimal("Kött");
                        break;

                    case "4":
                        AnimalList[3].FeedAnimal("Bark");
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen..");
                        break;

                }
            }

        }

}