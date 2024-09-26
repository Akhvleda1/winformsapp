using Login_app_using_EF_core.Context;
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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            LIpasswordTextBox.PasswordChar = '*';
        }
        
        private bool SuccessfulLogin()
        {
            string email, password;

            email = LIemailTextBox.Text;
            password = LIpasswordTextBox.Text;

            using MyDbContext context = new MyDbContext();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            var user = context.Users.SingleOrDefault(i => i.Email == email);
            if (user != null)
            {
                if (user.Email.ToLower() == email.ToLower() && SecurePasswordHasher.Verify(password, user.Password)){
                    return true;
                }
                else
                {
                    MessageBox.Show("Please check your credentials.", "Incorrect credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("User does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (SuccessfulLogin())
            {
                ProfileForm profileform = new ProfileForm();
                profileform.Show();
                this.Hide();
            }
        }
        private void ToRegistrationFormLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationform = new RegistrationForm();
            registrationform.Show();
            this.Hide();
        }

    }
}
