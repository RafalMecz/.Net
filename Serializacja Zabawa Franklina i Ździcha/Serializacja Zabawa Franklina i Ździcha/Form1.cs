using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializacja_Zabawa_Franklina_i_Ździcha
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpDateForm()
        {
            joelCashLabel.Text = joe.Name + " ma " + joe.Cash + " zł";
            bobCashLabel.Text = bob.Name + " ma " + bob.Cash + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
        }

        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Franklin" };
            bob = new Guy();
            bob.Name = "Żdzich";
            bob.Cash = 100;

            UpDateForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpDateForm();
            }
            else
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpDateForm();
        }

        private void JoeGiveToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(15));
            UpDateForm();
        }

        private void BobGiveToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(10));
            UpDateForm();
        }

        private void saveFranklin_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Plik_faceta.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void loadZdzich_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Plik_faceta.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpDateForm();
        }
    }
}