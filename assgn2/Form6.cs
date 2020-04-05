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
    public partial class Form6 : Form
    {
        String email1 = null;
        public Form6(String email)
        {
            email1 = email;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var password = textBox1.Text.Trim();
            var result2 = UsersBO.UpdatePassword(password, email1);

            MessageBox.Show("Password changed");
            this.Hide();
            Form1 obj3 = new Form1();
            obj3.ShowDialog();

        }
    }
}
