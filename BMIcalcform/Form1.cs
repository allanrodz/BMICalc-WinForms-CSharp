using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIcalcform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblinfo.Text = "Enter Weight in KG and Height in Meters";
            weight.Clear();
            height.Clear();
            lbldisplay.Text = "";
        }

        private void radImperial_CheckedChanged(object sender, EventArgs e)
        {
            lblinfo.Text = "Enter Weight in Pounds and Height in Inches";
            weight.Clear();
            height.Clear();
            lbldisplay.Text = "";
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            double weight = double.Parse(this.weight.Text);
            double height = double.Parse(this.height.Text);
            double bmi = 0;

            if (radmetric.Checked)
            {
                
                bmi = weight / (height * height);
                lbldisplay.Text = string.Format($"Your BMI is {bmi}");
            }
            else if (radImperial.Checked)
            {

                
                bmi = weight * 703 / (height * height);
                lbldisplay.Text = string.Format($"Your BMI is {bmi}");
            }

            if (bmi > 30)
            {
                MessageBox.Show("You are overweight", "Your Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bmi > 23)
            {
                MessageBox.Show("You are the correct weight", "Your Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (bmi <= 23)
            {

                MessageBox.Show("You are underweight", "Your Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
