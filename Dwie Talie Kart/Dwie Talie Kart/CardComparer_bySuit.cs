using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwie_Talie_Kart
{
    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.suits > y.suits)
                return 1;
            if (x.values > y.values)
                return -1;
            if (x.suits < y.suits)
                return -1;
            if (x.values < y.values)
                return 1;
            else
                return 0;
                     
        }
    }

}
