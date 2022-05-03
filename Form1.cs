using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayoCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] loot = new string[10];
        double value;
        double fees;
        int Boss = 100;
        int cut1;
        int cut2;
        int cut3;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
            comboBox9.Enabled = true;
        }
        // The commented "Update();" are for the real-time updating of the calculations.
        // You can enable them if you wish.
        // Enjoy this little tool!
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            loot[0] = comboBox1.Text;
            //Update();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[1] = comboBox2.Text;
            //Update();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[2] = comboBox3.Text;
            //Update();
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[3] = comboBox4.Text;
            //Update();
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[4] = comboBox5.Text;
            //Update();
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[5] = comboBox6.Text;
            //Update();
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[6] = comboBox7.Text;
            //Update();
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[7] = comboBox8.Text;
            //Update();
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot[8] = comboBox9.Text;
            //Update();
        }
        public new void Update()
        {
            foreach (var item in loot)
            {
                switch (item)
                {
                    //Primary
                    case "Tequila":
                        value = 900000;
                        break;
                    case "Ruby Necklace":
                        value = 1000000;
                        break;
                    case "Bearer Bonds":
                        value = 1100000;
                        break;
                    case "Pink Diamond":
                        value = 1300000;
                        break;
                    case "Panther":
                        value = 1900000;
                        break;


                    //Secondary
                    case "Gold":
                        value = value + 332184;
                        break;
                    case "Cocaine":
                        value = value + 220095;
                        break;
                    case "Painting":
                        value = value + 189500;
                        break;
                    case "Weed":
                        value = value + 147870;
                        break;
                    case "Cash":
                        value = value + 86000;
                        break;
                }
            }
            // Hard Mode check + Primary value adjustment
            if (radioButton1.Checked == true)
            {
                value = value * 1.10;
            }

            //Fees + Player take calculation
            fees = value * 0.12;

            double PlayerTake = value - fees;
            //Labels display the money
            label10.Text = ("Value: " + String.Format("{0:C0}", value));
            label11.Text = ("Fees: " + String.Format("{0:C0}", fees));
            label16.Text = ("Player Take: " + String.Format("{0:C0}", PlayerTake));

            //Math + Displaying of the cuts
            cut1 = int.Parse(textBox2.Text);
            cut2 = int.Parse(textBox3.Text);
            cut3 = int.Parse(textBox4.Text);

            int tempCutBoss = Boss - cut1 - cut2 - cut3;
            textBox1.Text = tempCutBoss.ToString();

            label12.Text = ("Cut 1: " + String.Format("{0:C0}", PlayerTake * (tempCutBoss * 0.01)));
            label13.Text = ("Cut 2: " + String.Format("{0:C0}", PlayerTake * (cut1 * 0.01)));
            label14.Text = ("Cut 3: " + String.Format("{0:C0}", PlayerTake * (cut2 * 0.01)));
            label15.Text = ("Cut 4: " + String.Format("{0:C0}", PlayerTake * (cut3 * 0.01)));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}