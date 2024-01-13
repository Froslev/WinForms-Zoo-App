using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurparkenWinForms
{
    class wolf : animal
    {
        public wolf(int _Age, string _Name) : base(_Age, _Name)
        {
            Favourite_food = "Älgkött";

        }


        public override void FeedAnimal(string food)
        {
            base.FeedAnimal(food);
            
        }

    }
}
