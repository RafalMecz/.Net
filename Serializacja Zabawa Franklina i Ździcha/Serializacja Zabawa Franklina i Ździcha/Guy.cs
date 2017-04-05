using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serializacja_Zabawa_Franklina_i_Ździcha
{
    [Serializable]
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount >0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Nie ma wystarczającej ilości pieniędzy, aby Ci dać" + amount,
                    Name + " powiedział...");
                return 0;
            }

        }
        public int ReceiveCash(int amount)
        {
            if(amount>0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest ilość pieniędzy, jaka mogę wziąć",
                    Name + " powiedział...");
                return 0;
            }
        }
    }
}
