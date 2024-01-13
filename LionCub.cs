using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurparkenWinForms
{
    // Subklass till Lejon
    class LionCub : Lion
    {
        private int months;

        public LionCub(int _Age, string _Name, int _Months) : base(_Age, _Name)
        {
            months = _Months;
        }

        public override void FeedAnimal(string food)
        {
            base.FeedAnimal(food);

        }

    }


}

