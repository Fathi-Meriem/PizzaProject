using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        string x = "";

        // 🔴 Added to store the base price of one pizza
        int basePrice = 0; // 🔴 New variable

        // 🔴 Changed to start at 1 because quantity should not be zero
        decimal oldValue = 1; // 🔴 Updated initial value

        public Form1()
        {
            InitializeComponent();

            groupBox3.Tag = 0;
            label11.Text = "";
            label3.Text = "No Toppings";
            label2.Text = "";
            label4.Text = "";
            label5.Text = "";
            label11.Text = "0";
            label11.Tag = 0;

            // 🔴 Set initial quantity to 1
            numericUpDown1.Value = 1; // 🔴 New line
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton1.Text;
            if (radioButton1.Checked == true)
            {
                label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(radioButton1.Tag);
            }
            else
            {
                label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(radioButton1.Tag);
            }

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New: store base price
            PrintPrice();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton2.Text;
            if (radioButton2.Checked == true)
            {
                label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(radioButton2.Tag);
            }
            else
            {
                label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(radioButton2.Tag);
            }

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New
            PrintPrice();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = radioButton3.Text;
            if (radioButton3.Checked == true)
            {
                label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(radioButton3.Tag);
            }
            else
            {
                label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(radioButton3.Tag);
            }

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New
            PrintPrice();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = radioButton4.Text;
            if (radioButton4.Checked == true)
            {
                label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(radioButton4.Tag);
            }
            else
            {
                label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(radioButton4.Tag);
            }

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New
            PrintPrice();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = radioButton5.Text;
            if (radioButton5.Checked == true)
            {
                label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(radioButton5.Tag);
            }
            else
            {
                label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(radioButton5.Tag);
            }

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New
            PrintPrice();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = radioButton7.Text;
            if (radioButton7.Checked == true) // 🔴 Fixed: was checking radioButton3 by mistake
            {
                label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(radioButton7.Tag);
            }
            else
            {
                label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(radioButton7.Tag);
            }

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New
            PrintPrice();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = radioButton6.Text;
            if (radioButton6.Checked == true) // 🔴 Fixed: was checking radioButton3 by mistake
            {
                label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(radioButton6.Tag);
            }
            else
            {
                label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(radioButton6.Tag);
            }

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New
            PrintPrice();
        }

        private void UpdateTagSum(CheckBox checkBox, bool isChecked)
        {
            label11.Tag = Convert.ToInt32(label11.Tag) - Convert.ToInt32(groupBox3.Tag);

            int currentSum = (int)groupBox3.Tag;
            int checkBoxValue = Convert.ToInt32(checkBox.Tag);

            groupBox3.Tag = isChecked ? currentSum + checkBoxValue : currentSum - checkBoxValue;

            if (isChecked)
            {
                if (string.IsNullOrEmpty(x))
                    x = checkBox.Text;
                else
                    x += ", " + checkBox.Text;
            }
            else
            {
                x = x.Replace(", " + checkBox.Text, "");
                x = x.Replace(checkBox.Text + ", ", "");
                x = x.Replace(checkBox.Text, "");
            }

            label3.Text = string.IsNullOrEmpty(x) ? "No Toppings" : x;

            label11.Tag = Convert.ToInt32(label11.Tag) + Convert.ToInt32(groupBox3.Tag);

            basePrice = Convert.ToInt32(label11.Tag); // 🔴 New: update base price after toppings
            PrintPrice();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTagSum(checkBox1, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTagSum(checkBox2, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTagSum(checkBox3, checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTagSum(checkBox4, checkBox4.Checked);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTagSum(checkBox5, checkBox5.Checked);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTagSum(checkBox6, checkBox6.Checked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            numericUpDown1.Value = 1; // 🔴 New: Reset quantity to 1
        }

        private void PrintPrice()
        {
            label11.Text = label11.Tag.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                button1.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;

            }
            else
            {
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                numericUpDown1.Value = 1; // 🔴 New: Prevent quantity from being zero
                return;
            }

            // 🔴 New: Calculate final price based on base price * quantity
            int finalPrice = basePrice * (int)numericUpDown1.Value;
            label11.Tag = finalPrice;

            PrintPrice();

            oldValue = numericUpDown1.Value; // 🔴 Keep for potential future use
        }
    }
}
