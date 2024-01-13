using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurparkenWinForms
{
    // Subklass för bäver
    class Beaver : animal
    {
        public Beaver(int _Age, string _Name) : base(_Age, _Name)
        {
            Favourite_food = "Bark";
        }

        public override void FeedAnimal(string food)
        {

        }

    
    }
}
