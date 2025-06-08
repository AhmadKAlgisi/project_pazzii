using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pazzii
{
    public partial class Form1 : Form
    {

       
        int totale;
        int totall_add = 0;

        //string [] ar= { "Extra Chees", "Mushrooms", "Tomatoes", "Onion", "olives", "Green Pappers" };
        public Form1()
        {
            InitializeComponent();
        }

    
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
            label12.Text = ra_size_small.Text;


            totale = totall_add + 30;
            label13.Text = totale.ToString();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = ra_size_medium.Text;
            totale = totall_add + 40;
            label13.Text = totale.ToString();
         


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = ra_size_larg.Text;
            totale = totall_add + 50;
            label13.Text = totale.ToString();
        
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void toppings()
        {
           // totale = Convert.ToInt32(label13.Text);
            label14.Text = "";

            if (ch_extra_chees.Checked)
            {
                label14.Text += ch_extra_chees.Text + ", ";
              //  totale = totale + 5;
            }

            if (ch_mushrooms.Checked)
            {
                label14.Text += ch_mushrooms.Text + ", ";
              //  totale = totale + 5;
            }
            if (ch_tomatoes.Checked)

            {
                label14.Text += ch_tomatoes.Text + ", ";
            //    totale = totale + 5;
            }
            if (ch_onion.Checked)
            {
                label14.Text += ch_onion.Text + ", ";
               // totale = totale + 5;
            }
            if (ch_olives.Checked)
            {
                label14.Text += ch_olives.Text + ", ";
              //  totale = totale + 5;
            }

            if (ch_green_pappers.Checked)
            {
                label14.Text += ch_green_pappers.Text + ", ";
          //      totale = totale + 5;
            }

               // label13.Text = totale.ToString();

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            totale =  Convert.ToInt32( label13.Text);
            toppings();
            if (ch_extra_chees.Checked)
            {
                totale = totale + 5;
                totall_add += 5;
            }
            else
                totale = totale - 5;
            label13.Text = totale.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            totale = Convert.ToInt32(label13.Text);
            toppings();
            if (ch_mushrooms.Checked)
            {
                totale = totale + 5;
                totall_add += 5;
            }
            else
                totale = totale - 5;
            label13.Text = totale.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            totale = Convert.ToInt32(label13.Text);
            toppings();
            if (ch_tomatoes.Checked)
            {
                totale = totale + 5;
                totall_add += 5;
            }
            else
                totale = totale - 5;
            label13.Text = totale.ToString();
        }

    
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = ra_thin_crust.Text;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = ra_think_crust.Text;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = radioButton10.Text;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = radioButton13.Text;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            totale = Convert.ToInt32(label13.Text);
            toppings();
            if (ch_onion.Checked)
            {
                totale = totale + 5;
                totall_add += 5;
            }
            else
                totale = totale - 5;
            label13.Text = totale.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            totale = Convert.ToInt32(label13.Text);
            toppings();
            if (ch_olives.Checked)
            {
                totale = totale + 5;
                totall_add += 5;
            }
            else
                totale = totale - 5;
            label13.Text = totale.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            totale = Convert.ToInt32(label13.Text);
            toppings();
            if (ch_green_pappers.Checked)
            {
                totale = totale + 5;
                totall_add += 5;
            }
            else
                totale = totale - 5;
            label13.Text = totale.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ra_size_small.Checked = false;
            ra_size_medium.Checked = false;
            ra_size_larg.Checked = false;
            ra_thin_crust.Checked = false;
            radioButton13.Checked = false;
            radioButton10.Checked = false;
            ra_think_crust.Checked = false;
            ch_extra_chees.Checked = false;
            ch_mushrooms.Checked = false;
            ch_tomatoes.Checked = false;
            ch_onion.Checked = false;
            ch_olives.Checked = false;
            ch_green_pappers.Checked = false;
            label12.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label13.Text = "00";

            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox2.Enabled = true;

            button1.Enabled = true;
            totale = 0;
            totall_add = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totale != 0)
            {

                if (MessageBox.Show("Confirm Order ? ", " Confirm ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    if (MessageBox.Show("Order  Placed Successfully ", "Success") == DialogResult.OK)
                    {
                        groupBox1.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox2.Enabled = false;

                        button1.Enabled = false;
                      


                    }
            }
            else
                  MessageBox.Show("Not Exsit Order !!! ", " Warning ", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) ;


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
