using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string makenot(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '0')  res += "1";
                else res += "0";
                return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool isnot=false;

            //if (a.Text.Length != b.Text.Length) throw(Exception);
               if(not.Checked==true)
                isnot=true;

            
            //----AND
            if (rb1.Checked == true)
            {
                short and1 = Convert.ToInt16(a.Text, 2);
                short and2 = Convert.ToInt16(b.Text, 2);




                if (bin.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(and1 & and2), 2);
                    else c.Text = Convert.ToString(and1 & and2, 2);
                }

                if (hex.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(and1 & and2), 16);
                    else c.Text = Convert.ToString(and1 & and2, 16);
                }

                if (dec.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(and1 & and2), 10);
                    else c.Text = Convert.ToString(and1 & and2, 10);
                }
                
            }
            //----AND        

            //----OR
            if (rb2.Checked == true)
            {
                short or1 = Convert.ToInt16(a.Text, 2);
                short or2 = Convert.ToInt16(b.Text, 2);

                if (bin.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(or1 | or2), 2);
                    else c.Text = Convert.ToString(or1 | or2, 2);
                }

                if (hex.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(or1 | or2), 16);
                    else c.Text = Convert.ToString(or1 | or2, 16);
                }

                if (dec.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(or1 | or2), 10);
                    else c.Text = Convert.ToString(or1 | or2, 10);
                }
               
            }
            //----OR

            //----XOR
            if (rb3.Checked == true)
            {
                short xor1 = Convert.ToInt16(a.Text, 2);
                short xor2 = Convert.ToInt16(b.Text, 2);

                if (bin.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(xor1 ^ xor2), 2);
                    else c.Text = Convert.ToString(xor1 ^ xor2, 2);
                }

                if (hex.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~xor1 ^ ~xor2, 16);
                    else c.Text = Convert.ToString(xor1 ^ xor2, 16);
                }

                if (dec.Checked == true)
                {
                    if (isnot == true)
                        c.Text = Convert.ToString(~(xor1 ^ xor2), 10);
                    else c.Text = Convert.ToString(xor1 ^ xor2, 10);
                }
            }
            //----XOR

      
            
            
        }

        private void a_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 50) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 50) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x0D)
                button1_Click(sender, e);
        }
    }
}
