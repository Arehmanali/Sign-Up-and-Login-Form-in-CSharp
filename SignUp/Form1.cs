using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            backButton.BackColor = Color.DarkBlue;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string userName = txtUserName.Text;
            string pass = txtPassword.Text;
            string email = txtEmail.Text;
            string cnic = txtCnic.Text;
            string confirmPass = txtConfirmPassword.Text;
            string address = txtAddress.Text;
            string date = txtDate.Text;
            string contact = txtContact.Text;

            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\SQLEXPRESS;Initial Catalog=UserSignUp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into myAppUsers(fullName,cnic,email,dateOfBirth,contact,address,userName,password) values(@fname,@uCnic,@uEmail,@uDate,@uContact,@uAddress,@uUserName,@uPassword)");
            cmd.Parameters.AddWithValue("@fName", fullName);
            cmd.Parameters.AddWithValue("@uCnic", cnic);
            cmd.Parameters.AddWithValue("@uEmail", email);
            cmd.Parameters.AddWithValue("@uDate", date);
            cmd.Parameters.AddWithValue("@uContact", contact);
            cmd.Parameters.AddWithValue("@uAddress",address );
            cmd.Parameters.AddWithValue("@uUserName", userName);
            cmd.Parameters.AddWithValue("@uPassword", pass);
            cmd.ExecuteNonQuery();

            MessageBox.Show("You have sign-up Successfully");

            this.Hide();
            Welcome_Page signup = new Welcome_Page();
            signup.ShowDialog();
        }

        private void submitButton_MouseHover(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.DarkBlue;
        }

        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.Transparent;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.ShowDialog();
        }
    }
}
