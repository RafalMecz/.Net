using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_literki
{
    class State
    {
       public int Total = 0;
       public int Missed = 0;
       public int Correct = 0;
       public int Accuracy = 0;

        public void UpDate(bool parameter)
        {
            Total++;
            if(!parameter)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / Total;
        }

    }
}
