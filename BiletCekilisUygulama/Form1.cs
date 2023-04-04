using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletCekilisUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Db db = new Db();

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            db.AddPerson(txtName.Text, txtSurname.Text, txtCekilis.Text);
            db.GridFill();
        }

        private void btnCekilis_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int cekilisNo = rnd.Next(0, 10);
                txtCekilis.Text += cekilisNo.ToString();
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.GridFill();
        }
    }
}
