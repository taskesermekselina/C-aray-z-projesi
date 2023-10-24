using ogrenci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_click(object sender, EventArgs e)
        {
            Personal prs1 = new Personal();



            prs1.Ad = prs1Ad.Text;
            prs1.Yas = Convert.ToInt32(prs1Yas.Text);
            prs1.Adres = prs1Adres.Text;
            prs1.No = Convert.ToInt32(prs1No.Text);

            MessageBox.Show("Ad =" + prs1.Ad + "\nYas =" + prs1.Yas +
                "\nAdres =" + prs1.Adres +
                "\nOgrenci No =" + prs1.No);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal prs1 = new Personal();



            prs1.Ad = prs1Ad.Text;
            prs1.Yas = Convert.ToInt32(yasTxt.Text);
            prs1.Adres = prs1Adres.Text;
            prs1.No = Convert.ToInt32(prs1No.Text);

            MessageBox.Show("Ad =" + prs1.Ad + "\nYas =" + prs1.Yas +
                "\nAdres =" + prs1.Adres +
                "\nOgrenci No =" + prs1.No);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
