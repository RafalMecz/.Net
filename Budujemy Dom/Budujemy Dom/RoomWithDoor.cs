using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budujemy_Dom
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDesciption) : base(name,decoration)
        {
            DoorDescription = doorDesciption;
        }

        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }
    }
}
