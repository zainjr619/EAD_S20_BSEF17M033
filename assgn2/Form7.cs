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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Login = textBox1.Text.Trim();
            var Password = textBox2.Text.Trim();

            var result = UsersBO.ValidateAdmin(Login, Password);
            if (result == true)
            {

                Form8 obj = new Form8();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl.Visible = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
