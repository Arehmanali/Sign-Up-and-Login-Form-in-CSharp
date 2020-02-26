using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.DarkBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Transparent;
        }

        private void label4_MouseCaptureChanged(object sender, EventArgs e)
        {
            forgetPasswordLabel.BackColor = Color.DarkBlue;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            forgetPasswordLabel.BackColor = Color.DarkBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            forgetPasswordLabel.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.DarkBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.Transparent;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_Page login = new Welcome_Page();
            login.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
           ForgetPassword f = new ForgetPassword();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signup = new Form1();
            signup.ShowDialog();
        }
    }
}
