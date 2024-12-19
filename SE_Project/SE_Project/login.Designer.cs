namespace SE_Project
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_loginemail = new TextBox();
            txt_loginpass = new TextBox();
            btn_login = new Button();
            btn_registerhere = new Button();
            label4 = new Label();
            label5 = new Label();
            btn_clickhere = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 93);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 140);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 233);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 2;
            label3.Text = "Dont Have an Account?";
            // 
            // txt_loginemail
            // 
            txt_loginemail.Location = new Point(155, 85);
            txt_loginemail.Name = "txt_loginemail";
            txt_loginemail.Size = new Size(100, 23);
            txt_loginemail.TabIndex = 3;
            // 
            // txt_loginpass
            // 
            txt_loginpass.Location = new Point(155, 137);
            txt_loginpass.Name = "txt_loginpass";
            txt_loginpass.Size = new Size(100, 23);
            txt_loginpass.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(155, 187);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "LogIn";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_registerhere
            // 
            btn_registerhere.Location = new Point(238, 229);
            btn_registerhere.Name = "btn_registerhere";
            btn_registerhere.Size = new Size(122, 23);
            btn_registerhere.TabIndex = 6;
            btn_registerhere.Text = "Register Here";
            btn_registerhere.UseVisualStyleBackColor = true;
            btn_registerhere.Click += btn_registerhere_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 9);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "LogIn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 275);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 8;
            label5.Text = "Forgot Password?";
            // 
            // btn_clickhere
            // 
            btn_clickhere.Location = new Point(217, 271);
            btn_clickhere.Name = "btn_clickhere";
            btn_clickhere.Size = new Size(96, 23);
            btn_clickhere.TabIndex = 9;
            btn_clickhere.Text = "Click Here";
            btn_clickhere.UseVisualStyleBackColor = true;
            btn_clickhere.Click += btn_clickhere_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(btn_clickhere);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_registerhere);
            Controls.Add(btn_login);
            Controls.Add(txt_loginpass);
            Controls.Add(txt_loginemail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_loginemail;
        private TextBox txt_loginpass;
        private Button btn_login;
        private Button btn_registerhere;
        private Label label4;
        private Label label5;
        private Button btn_clickhere;
    }
}