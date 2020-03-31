using assign2.bal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assgn2
{
    public partial class Form4 : Form
    {
        private object txtPassword;
        private object txtLogin;

        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Login = textBox1.Text.Trim();
            var Password = textBox2.Text.Trim();

            var result = UsersBO.ValidateUser(Login, Password);
            if(result==true)
            {
                
                Form1 obj = new Form1();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl.Visible=true;
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
