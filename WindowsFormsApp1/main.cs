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
    public partial class main : MetroFramework.Forms.MetroForm
    {

        public main()
        {
            InitializeComponent();

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form2 = new Form4();
            form2.Show();//9
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm1 = new login();
            frm1.ShowDialog();//8
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Visible = false;

          Form21 form2 = new Form21();

            form2.Show();//9
        }
    }
}
