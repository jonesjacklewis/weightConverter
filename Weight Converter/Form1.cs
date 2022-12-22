using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weight_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal from;
            string fromUnit = cmbFrom.Text;
            string toUnit = cmbTo.Text; 

            if (Decimal.TryParse(txtFrom.Text, out from))
            {
                if (fromUnit.Equals(toUnit)) {
                    txtTo.Text = from.ToString();
                }if(fromUnit.Equals("Kilograms") && toUnit.Equals("Grams"))
                {
                    txtTo.Text = kgToG(from).ToString();
                }
                if (toUnit.Equals("Kilograms") && fromUnit.Equals("Grams"))
                {
                    txtTo.Text = gToKG(from).ToString();
                }
                if (toUnit.Equals("Kilograms") && fromUnit.Equals("Pounds"))
                {
                    txtTo.Text = kgToLbs(from).ToString();
                }
                if (fromUnit.Equals("Kilograms") && toUnit.Equals("Pounds"))
                {
                    txtTo.Text = lbsTokg(from).ToString();
                }
                if (fromUnit.Equals("Kilograms") && toUnit.Equals("Stones"))
                {
                    txtTo.Text = kgToStone(from).ToString();
                }
                if (toUnit.Equals("Kilograms") && fromUnit.Equals("Stones"))
                {
                    txtTo.Text = stoneToKG(from).ToString();
                }
                if (fromUnit.Equals("Grams") && toUnit.Equals("Pounds"))
                {
                    txtTo.Text = txtTo.Text = lbsTokg(gToKG(from)).ToString();
                }
                if (toUnit.Equals("Grams") && fromUnit.Equals("Pounds"))
                {
                    txtTo.Text = txtTo.Text = lbsToG(from).ToString();
                }
                if (fromUnit.Equals("Grams") && toUnit.Equals("Stones"))
                {
                    txtTo.Text = txtTo.Text = kgToStone(gToKG(from)).ToString();
                }
                if (toUnit.Equals("Grams") && fromUnit.Equals("Stones"))
                {
                    txtTo.Text = txtTo.Text = stoneToG(from).ToString();
                }
                if (fromUnit.Equals("Pounds") && toUnit.Equals("Stones"))
                {
                    txtTo.Text = txtTo.Text = lbsToStone(from).ToString();
                }
                if (toUnit.Equals("Pounds") && fromUnit.Equals("Stones"))
                {
                    txtTo.Text =  stoneToLbs(from).ToString();
                }
            }
            else
            {
                txtTo.Text = "Invalid From Value";
            }
        }

        private decimal kgToG(decimal kg)
        {
            return kg * 1000;
        }

        private decimal gToKG(decimal g)
        {
            return g / 1000;
        }

        private decimal kgToLbs(decimal kg)
        {
            return kg / decimal.Parse(2.205.ToString());

        }

        private decimal lbsTokg(decimal lbs)
        {
            return lbs * decimal.Parse(2.205.ToString());

        }

        private decimal kgToStone(decimal kg)
        {
            return kg / decimal.Parse(6.35.ToString());
        }

        private decimal stoneToKG(decimal stone)
        {
            return stone * decimal.Parse(6.35.ToString());
        }

        private decimal lbsToG(decimal lbs)
        {
            return lbs * decimal.Parse(454.ToString());
        }

        private decimal stoneToG(decimal stone)
        {
            return stone * decimal.Parse(6350.ToString());
        }

        private decimal lbsToStone(decimal lbs)
        {
            return lbs / decimal.Parse(14.ToString());
        }

        private decimal stoneToLbs(decimal stone)
        {
            return stone * decimal.Parse(14.ToString());
        }
    }
}
