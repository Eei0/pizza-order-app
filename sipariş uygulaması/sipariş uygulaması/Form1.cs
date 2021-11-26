using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sipariş_uygulaması
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

        private void btnsprş_Click(object sender, EventArgs e)
        {
            int i = 5;
            int t = 30;
            lstad.Items.Add(txtad.Text);
            lstno.Items.Add(txtno.Text);
            lstadr.Items.Add(txtadr.Text);
            lstpsz.Items.Add(byt.Text + " " + pizza.Value);
            lstick.Items.Add(icecek.Value + " " + ick.Text);
            if (chkmnt.Checked == true)
            {
                lstext.Items.Add(chkmnt.Text);
                t = t + 3;
            }
            if (chkmsr.Checked == true) 
            {
                lstext.Items.Add(chkmsr.Text);
                t = t + 3;
            }

            if (chkpyn.Checked == true) 
            { 
                lstext.Items.Add(chkpyn.Text);
                t = t + 3;
            }
            if (chksck.Checked == true) 
            {
                lstext.Items.Add(chksck.Text);
                t = t + 3;
            }
            if (chkx.Checked == true)
            {
                lstext.Items.Add(chkx.Text);
                t = t + 3;
            }
            if (chkzytn.Checked == true)
            {
                lstext.Items.Add(chkzytn.Text);
                t = t + 3;
            }
            if (byt.Text == "Medium 35$")
            {
                t = (t + 5)*Convert.ToInt32(pizza.Value);
            }
            if (byt.Text == "Large 40$")
            {
                t = (t + 10) * Convert.ToInt32(pizza.Value);
            }
            if (byt.Text == "XLarge 45$")
            {
                t = (t + 15) * Convert.ToInt32(pizza.Value);
            }
            i = Convert.ToInt32(icecek.Value) * i;
            lstücrt.Items.Add("Total: " + (t+i).ToString()+"$");




        }

        private void btnsprştmz_Click(object sender, EventArgs e)
        {
            lstad.Items.Clear();
            lstadr.Items.Clear();
            lstext.Items.Clear();
            lstick.Items.Clear();
            lstno.Items.Clear();
            lstpsz.Items.Clear();
            lstücrt.Items.Clear();
        }

        private void btntmz_Click(object sender, EventArgs e)
        {
            lstad.Items.Clear();
            lstadr.Items.Clear();
            lstext.Items.Clear();
            lstick.Items.Clear();
            lstno.Items.Clear();
            lstpsz.Items.Clear();
            lstücrt.Items.Clear();
            txtad.Text = null;
            txtno.Text = null;
            txtadr.Text = null;
            byt.Text = null;
            ick.Text = null;
            pizza.Value = 0;
            icecek.Value = 0;
            chkmnt.Checked = false;
            chkmsr.Checked = false;
            chkpyn.Checked = false;
            chksck.Checked = false;
            chkx.Checked = false;
            chkzytn.Checked = false;
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
