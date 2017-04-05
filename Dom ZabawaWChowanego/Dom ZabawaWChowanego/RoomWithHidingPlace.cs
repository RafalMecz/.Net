using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom_ZabawaWChowanego
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string direction, string hidingPlaceName) : base(name, direction)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; set; }
        public override string Description
        {
            get
            {
                return base.Description + " Ktoś może ukrywać się " + HidingPlaceName + ".";
            }
        }
    }
}
