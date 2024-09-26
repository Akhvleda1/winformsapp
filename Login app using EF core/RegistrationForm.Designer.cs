namespace Login_app_using_EF_core
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToLoginFormLabel = new Label();
            SignUpButton = new Button();
            SUpasswordTextBox = new TextBox();
            SUemailTextBox = new TextBox();
            SignUpLabel = new Label();
            SUnameTextBox = new TextBox();
            SUPasswordLabel = new Label();
            SUEmailLabel = new Label();
            SUNameLabel = new Label();
            AddressTextbox = new TextBox();
            PhoneNumberTextbox = new TextBox();
            DateOfBirthLabel = new Label();
            AddressLabel = new Label();
            PhoneNumberLabel = new Label();
            DateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // ToLoginFormLabel
            // 
            ToLoginFormLabel.AutoSize = true;
            ToLoginFormLabel.Cursor = Cursors.Hand;
            ToLoginFormLabel.Font = new Font("Segoe UI", 7.20000029F);
            ToLoginFormLabel.ForeColor = Color.Blue;
            ToLoginFormLabel.Location = new Point(301, 387);
            ToLoginFormLabel.Name = "ToLoginFormLabel";
            ToLoginFormLabel.Size = new Size(189, 17);
            ToLoginFormLabel.TabIndex = 8;
            ToLoginFormLabel.Text = "Already have an accoun? log in";
            ToLoginFormLabel.Click += ToLoginFormLabel_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Cursor = Cursors.Hand;
            SignUpButton.Location = new Point(303, 325);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(185, 45);
            SignUpButton.TabIndex = 7;
            SignUpButton.Text = "Sign up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SUpasswordTextBox
            // 
            SUpasswordTextBox.Location = new Point(189, 255);
            SUpasswordTextBox.Name = "SUpasswordTextBox";
            SUpasswordTextBox.Size = new Size(152, 27);
            SUpasswordTextBox.TabIndex = 3;
            SUpasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SUemailTextBox
            // 
            SUemailTextBox.Location = new Point(189, 198);
            SUemailTextBox.Name = "SUemailTextBox";
            SUemailTextBox.Size = new Size(152, 27);
            SUemailTextBox.TabIndex = 2;
            SUemailTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SignUpLabel
            // 
            SignUpLabel.Dock = DockStyle.Top;
            SignUpLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SignUpLabel.Location = new Point(0, 0);
            SignUpLabel.Margin = new Padding(0);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(782, 116);
            SignUpLabel.TabIndex = 5;
            SignUpLabel.Text = "Sign Up";
            SignUpLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SUnameTextBox
            // 
            SUnameTextBox.Location = new Point(189, 141);
            SUnameTextBox.Name = "SUnameTextBox";
            SUnameTextBox.Size = new Size(152, 27);
            SUnameTextBox.TabIndex = 1;
            SUnameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SUPasswordLabel
            // 
            SUPasswordLabel.AutoSize = true;
            SUPasswordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SUPasswordLabel.Location = new Point(96, 254);
            SUPasswordLabel.Name = "SUPasswordLabel";
            SUPasswordLabel.Size = new Size(87, 25);
            SUPasswordLabel.TabIndex = 12;
            SUPasswordLabel.Text = "Password";
            // 
            // SUEmailLabel
            // 
            SUEmailLabel.AutoSize = true;
            SUEmailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SUEmailLabel.Location = new Point(96, 197);
            SUEmailLabel.Name = "SUEmailLabel";
            SUEmailLabel.Size = new Size(54, 25);
            SUEmailLabel.TabIndex = 11;
            SUEmailLabel.Text = "Email";
            // 
            // SUNameLabel
            // 
            SUNameLabel.AutoSize = true;
            SUNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SUNameLabel.Location = new Point(96, 140);
            SUNameLabel.Name = "SUNameLabel";
            SUNameLabel.Size = new Size(59, 25);
            SUNameLabel.TabIndex = 13;
            SUNameLabel.Text = "Name";
            // 
            // AddressTextbox
            // 
            AddressTextbox.Location = new Point(516, 255);
            AddressTextbox.Name = "AddressTextbox";
            AddressTextbox.Size = new Size(152, 27);
            AddressTextbox.TabIndex = 6;
            AddressTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Location = new Point(516, 198);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.Size = new Size(152, 27);
            PhoneNumberTextbox.TabIndex = 5;
            PhoneNumberTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DateOfBirthLabel.Location = new Point(375, 143);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(113, 25);
            DateOfBirthLabel.TabIndex = 19;
            DateOfBirthLabel.Text = "Date of birth";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(375, 257);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(77, 25);
            AddressLabel.TabIndex = 18;
            AddressLabel.Text = "Address";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneNumberLabel.Location = new Point(375, 200);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(132, 25);
            PhoneNumberLabel.TabIndex = 17;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(516, 143);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(250, 27);
            DateTimePicker.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(DateTimePicker);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(AddressLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(AddressTextbox);
            Controls.Add(PhoneNumberTextbox);
            Controls.Add(SUNameLabel);
            Controls.Add(SUPasswordLabel);
            Controls.Add(SUEmailLabel);
            Controls.Add(SUnameTextBox);
            Controls.Add(ToLoginFormLabel);
            Controls.Add(SignUpButton);
            Controls.Add(SUpasswordTextBox);
            Controls.Add(SUemailTextBox);
            Controls.Add(SignUpLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ToLoginFormLabel;
        private Button SignUpButton;
        private TextBox SUpasswordTextBox;
        private TextBox SUemailTextBox;
        private Label SignUpLabel;
        private TextBox SUnameTextBox;
        private Label SUPasswordLabel;
        private Label SUEmailLabel;
        private Label SUNameLabel;
        private TextBox AddressTextbox;
        private TextBox PhoneNumberTextbox;
        private Label DateOfBirthLabel;
        private Label AddressLabel;
        private Label PhoneNumberLabel;
        private DateTimePicker DateTimePicker;
    }
}