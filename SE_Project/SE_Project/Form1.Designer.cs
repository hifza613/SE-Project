namespace SE_Project
{
    partial class Form1
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
            label1 = new Label();
            FirstName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_name = new TextBox();
            txt_lname = new TextBox();
            txt_email = new TextBox();
            txt_passwod = new TextBox();
            txt_confirmpass = new TextBox();
            btn_register = new Button();
            label2 = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 21);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "SignUp";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(47, 79);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(61, 15);
            FirstName.TabIndex = 1;
            FirstName.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 124);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 172);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 227);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 272);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 5;
            label6.Text = "ConfirmPassword";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(184, 71);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 6;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(184, 116);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(100, 23);
            txt_lname.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(184, 164);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 8;
            // 
            // txt_passwod
            // 
            txt_passwod.Location = new Point(184, 219);
            txt_passwod.Name = "txt_passwod";
            txt_passwod.Size = new Size(100, 23);
            txt_passwod.TabIndex = 9;
            // 
            // txt_confirmpass
            // 
            txt_confirmpass.Location = new Point(184, 272);
            txt_confirmpass.Name = "txt_confirmpass";
            txt_confirmpass.Size = new Size(100, 23);
            txt_confirmpass.TabIndex = 10;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(162, 326);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(75, 23);
            btn_register.TabIndex = 11;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 372);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 12;
            label2.Text = "Already Have an Account?";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(204, 368);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 13;
            btn_login.Text = "LogIn";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(btn_register);
            Controls.Add(txt_confirmpass);
            Controls.Add(txt_passwod);
            Controls.Add(txt_email);
            Controls.Add(txt_lname);
            Controls.Add(txt_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FirstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label FirstName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_name;
        private TextBox txt_lname;
        private TextBox txt_email;
        private TextBox txt_passwod;
        private TextBox txt_confirmpass;
        private Button btn_register;
        private Label label2;
        private Button btn_login;
    }
}
