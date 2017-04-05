using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwie_Talie_Kart
{
    class Card
    {
        public Suits suits;
        public Values values;

       /* public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        } */

        public Card(Suits suits, Values values)
        {
            this.suits = suits;
            this.values = values;
        }

        public string Name
        {
            get
            {
                return values.ToString() + " of " + suits.ToString();
            }
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
