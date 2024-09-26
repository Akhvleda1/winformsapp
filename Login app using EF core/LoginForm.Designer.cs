namespace Login_app_using_EF_core
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogInLabel = new Label();
            LIemailTextBox = new TextBox();
            LIpasswordTextBox = new TextBox();
            LogInButton = new Button();
            ToRegistrationFormLabel = new Label();
            LIEmailLabel = new Label();
            LIPasswordLabel = new Label();
            PasswordCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // LogInLabel
            // 
            LogInLabel.Dock = DockStyle.Top;
            LogInLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogInLabel.Location = new Point(0, 0);
            LogInLabel.Margin = new Padding(0);
            LogInLabel.Name = "LogInLabel";
            LogInLabel.Size = new Size(782, 116);
            LogInLabel.TabIndex = 0;
            LogInLabel.Text = "Log In";
            LogInLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LIemailTextBox
            // 
            LIemailTextBox.Location = new Point(242, 157);
            LIemailTextBox.Name = "LIemailTextBox";
            LIemailTextBox.Size = new Size(305, 27);
            LIemailTextBox.TabIndex = 1;
            LIemailTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LIpasswordTextBox
            // 
            LIpasswordTextBox.Location = new Point(242, 212);
            LIpasswordTextBox.Name = "LIpasswordTextBox";
            LIpasswordTextBox.Size = new Size(305, 27);
            LIpasswordTextBox.TabIndex = 2;
            LIpasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LogInButton
            // 
            LogInButton.Cursor = Cursors.Hand;
            LogInButton.Location = new Point(302, 291);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(185, 45);
            LogInButton.TabIndex = 3;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // ToRegistrationFormLabel
            // 
            ToRegistrationFormLabel.AutoSize = true;
            ToRegistrationFormLabel.Cursor = Cursors.Hand;
            ToRegistrationFormLabel.Font = new Font("Segoe UI", 7.20000029F);
            ToRegistrationFormLabel.ForeColor = Color.Blue;
            ToRegistrationFormLabel.Location = new Point(302, 353);
            ToRegistrationFormLabel.Name = "ToRegistrationFormLabel";
            ToRegistrationFormLabel.Size = new Size(185, 17);
            ToRegistrationFormLabel.TabIndex = 4;
            ToRegistrationFormLabel.Text = "Dont Have an accoun? sign up";
            ToRegistrationFormLabel.Click += ToRegistrationFormLabel_Click;
            // 
            // LIEmailLabel
            // 
            LIEmailLabel.AutoSize = true;
            LIEmailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LIEmailLabel.Location = new Point(151, 156);
            LIEmailLabel.Name = "LIEmailLabel";
            LIEmailLabel.Size = new Size(54, 25);
            LIEmailLabel.TabIndex = 5;
            LIEmailLabel.Text = "Email";
            // 
            // LIPasswordLabel
            // 
            LIPasswordLabel.AutoSize = true;
            LIPasswordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LIPasswordLabel.Location = new Point(135, 211);
            LIPasswordLabel.Name = "LIPasswordLabel";
            LIPasswordLabel.Size = new Size(87, 25);
            LIPasswordLabel.TabIndex = 6;
            LIPasswordLabel.Text = "Password";
            // 
            // PasswordCheckbox
            // 
            PasswordCheckbox.AutoSize = true;
            PasswordCheckbox.Location = new Point(480, 245);
            PasswordCheckbox.Name = "PasswordCheckbox";
            PasswordCheckbox.Size = new Size(67, 24);
            PasswordCheckbox.TabIndex = 8;
            PasswordCheckbox.Text = "Show";
            PasswordCheckbox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(782, 453);
            Controls.Add(PasswordCheckbox);
            Controls.Add(LIPasswordLabel);
            Controls.Add(LIEmailLabel);
            Controls.Add(ToRegistrationFormLabel);
            Controls.Add(LogInButton);
            Controls.Add(LIpasswordTextBox);
            Controls.Add(LIemailTextBox);
            Controls.Add(LogInLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogInLabel;
        private TextBox LIemailTextBox;
        private TextBox LIpasswordTextBox;
        private Button LogInButton;
        private Label ToRegistrationFormLabel;
        private Label LIEmailLabel;
        private Label LIPasswordLabel;
        private CheckBox PasswordCheckbox;
    }
}
