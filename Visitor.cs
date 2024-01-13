using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DjurparkenWinForms;

namespace DjurparkenWinForms
{
    // Visitor klassen
    public class Visitor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set;  }
        

        public Visitor(string _Name, string _LastName, int _Age)
        {
            FirstName = _Name;
            LastName = _LastName;
            Age = _Age;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return $"Förnamn: {FirstName}\nEfternamn: {LastName}\nÅlder: {Age} år";
        }

    }
}
