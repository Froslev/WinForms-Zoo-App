using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurparkenWinForms
{
    // Lejon subklass för animal

    class Lion : animal
    {

        // Konstruktor för lejon som anropar basklassens konstruktor och sätter favoritmat
        public Lion(int _Age, string _Name) : base(_Age, _Name)
        {
            Favourite_food = "Kött";
        }

        public override void FeedAnimal(string food)
        {
           
        }

        

    }
}
