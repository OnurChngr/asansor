using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a1, a2, s1, s2,random;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random(); // rastgele sayı üretecek olan nesne
            a1 = rastgele.Next(1, 5);
             a2 = rastgele.Next(1, 5);
            random = rastgele.Next(0, 2);

            lblAsansor1.Text = a1.ToString();
            lblAsansor2.Text = a2.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblGeliyor_Click(object sender, EventArgs e)
        {

        }

        private void btnCagir_Click(object sender, EventArgs e)
        {
           
            int kat = int.Parse(txtBulKat.Text);
            s1 = kat - a1;
            s2 = kat - a2;
            if (s1 > s2)
            {
                a1 = kat;
                lblGeliyor.Text = "Asansör Geliyor Lütfen Bekleyiniz";
            }
            else if (s2 > s1)
            {
                a2 = kat;
                lblGeliyor.Text = "Asansör Geliyor Lütfen Bekleyiniz";
            }
            else
            {
                a1 = kat;
            }
            //lblGosterAsansor2.Text = kat.ToString();
            //asansor eklendi




        }
    }
}
