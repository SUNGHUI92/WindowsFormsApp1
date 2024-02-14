using System;
using WindowsFormsApp1.INPUTOUTPUT;

namespace WindowsFormsApp1
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) //dsdfs
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

             form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Form4 = new Form4();

            Formk1 Formk1 = new Formk1();

            Formk1.Show();
        }
    }
}
