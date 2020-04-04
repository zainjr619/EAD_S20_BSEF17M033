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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            DataTable dt = UsersBO.LoadAllUsers();
            dataGridView1.DataSource = dt;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj1 = new Form1();
            obj1.ShowDialog();
        }
    }
}
