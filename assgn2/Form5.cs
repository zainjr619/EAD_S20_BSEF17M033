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
    public partial class Form5 : Form
    {
        String email;
        String body1;
        public Form5( String Email,String body)
        {
            body1 = body;
            email = Email;
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            var code = textBox1.Text.Trim();
            if (body1 == code)
            {
                this.Hide();
                Form6 obj = new Form6(email);
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Number");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
