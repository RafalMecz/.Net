using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom_ZabawaWChowanego
{
    class RoomWithDoor : RoomWithHidingPlace , IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDesciption) : base(name,decoration, hidingPlaceName)
        {
            DoorDescription = doorDesciption;
        }

        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }
    }
}
