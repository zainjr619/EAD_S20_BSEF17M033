using assign2.bal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

                MessageBox.Show("SUCCESSFULL");
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
        public static Boolean sendMail(String toEmailAddress, String subject, String body)
        {
            String fromDisplayEmail = "EAD.SEMorning@gmail.com";
            String fromPassword = "SEMorning2017";
            String fromDisplayName = "JuTT Admin";
            MailAddress fromAddress = new MailAddress(fromDisplayEmail,fromDisplayName);
            MailAddress toAddress = new MailAddress(toEmailAddress);
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body

            })
            {
                smtp.Send(message);
            }
            return true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            String subject = "UpdatePassword";
            String body = "Please enter this number to reset code:786";
            var login = textBox1.Text.Trim();
            String toEmailAddress = textBox3.Text.Trim();
            var Email = UsersBO.GetEmail(login);
            if (Email != toEmailAddress)
            {
                MessageBox.Show("invalid email");
            }
            else
            {
                sendMail(toEmailAddress, subject, body);

                this.Hide();
                Form5 obj = new Form5(Email,body);
                obj.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
