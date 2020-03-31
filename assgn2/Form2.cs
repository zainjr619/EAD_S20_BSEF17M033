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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.IO.Directory.CreateDirectory(applicationBasePath + @"\image\");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char gender = 'm';
            switch(cbox1.Text)
            {
                case "Male":
                    gender = 'm';
                    break;

                case "Female":
                    gender = 'f';
                    break;

                case "Others":
                    gender = 'O';
                    break;
            }
            String uniqueName = "";
            if (pictureBox1.Image != null)
            {
                String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                String PathToSaveImage = applicationBasePath + @"\image\";

                uniqueName = Guid.NewGuid().ToString() + ".jpg";
                String ImgPath = PathToSaveImage + uniqueName;

                pictureBox1.Image.Save(ImgPath);

            }


            var name = txt2.Text.Trim();
            var login = txt1.Text.Trim();
            var password = txt3.Text.Trim();
            var email = txt4.Text.Trim();
            var address = txt6.Text.Trim();
            var age =(int)ud1.Value;
            var nic = maskedTextBox1.Text.Trim();
            var dob = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            var isCricket = checkBox2.Checked;
            var hockey = checkBox3.Checked;
            var football = checkBox1.Checked;
            var result1 =UsersBO.UserSave(name, login, password, email, gender,
             address, age, nic, dob, isCricket, hockey, football,uniqueName);
            if(result1>0)
            {
                MessageBox.Show("User Created");
            }
            else
            {
               MessageBox.Show("invalid Entries");
            }

           
            this.Hide();
            Form3 obj3 = new Form3(name,login);
            obj3.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                pictureBox1.Load(file); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
