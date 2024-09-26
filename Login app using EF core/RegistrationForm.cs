using Login_app_using_EF_core.Context;
using Login_app_using_EF_core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_app_using_EF_core
{
    public partial class RegistrationForm : BaseForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private bool SuccessfulSignup()
        {
            string name, email, password, hashedpassword, phonenumber, address;
            DateTime dateofbirth;

            name = SUnameTextBox.Text;
            email = SUemailTextBox.Text;
            password = SUpasswordTextBox.Text;
            hashedpassword = SecurePasswordHasher.Hash(password);
            phonenumber = PhoneNumberTextbox.Text;
            address = AddressTextbox.Text;
            dateofbirth = DateTimePicker.Value;

            if (name == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Signup failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                using MyDbContext context = new MyDbContext();
                User newUser = new User()
                {
                    Name = name,
                    Email = email,
                    Password = hashedpassword,
                    UserInfo = new UserInfo()
                    {
                        PhoneNumber = phonenumber,
                        Address = address,
                        DateOfBirth = dateofbirth,
                    }
                };
                context.Add(newUser);
                context.SaveChanges();
                MessageBox.Show("Successfull sign up.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

        
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (SuccessfulSignup())
            {
                ProfileForm profileForm = new ProfileForm();
                profileForm.Show();
                this.Hide();
            }
        }

        private void ToLoginFormLabel_Click(object sender, EventArgs e)
        {

            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }
        
        
    }
}
