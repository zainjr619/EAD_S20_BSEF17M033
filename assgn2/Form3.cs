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
    public partial class Form3 : Form
    {
        String login = "";
        String _name = "";
        public Form3( String name,String login1)
        {
            login = login1;
            _name = name;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            message.Text = "Welcome" + _name;

            var imageName = UsersBO.loadData(login);


            String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            String filePath = applicationBasePath + @"\image\" + imageName;
            pictureBox1.Image = Image.FromFile(filePath);
        }
    }
}
