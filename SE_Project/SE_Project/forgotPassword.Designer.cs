namespace SE_Project
{
    partial class forgotPassword
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
            txt_forgotemail = new TextBox();
            btn_forgotverificationcode = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 75);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Email";
            // 
            // txt_forgotemail
            // 
            txt_forgotemail.Location = new Point(186, 72);
            txt_forgotemail.Name = "txt_forgotemail";
            txt_forgotemail.Size = new Size(100, 23);
            txt_forgotemail.TabIndex = 1;
            // 
            // btn_forgotverificationcode
            // 
            btn_forgotverificationcode.AccessibleRole = AccessibleRole.Alert;
            btn_forgotverificationcode.Location = new Point(114, 164);
            btn_forgotverificationcode.Name = "btn_forgotverificationcode";
            btn_forgotverificationcode.Size = new Size(172, 23);
            btn_forgotverificationcode.TabIndex = 2;
            btn_forgotverificationcode.Text = "validate Email";
            btn_forgotverificationcode.UseVisualStyleBackColor = true;
            btn_forgotverificationcode.Click += btn_forgotverificationcode_Click;
            // 
            // forgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 450);
            Controls.Add(btn_forgotverificationcode);
            Controls.Add(txt_forgotemail);
            Controls.Add(label1);
            Name = "forgotPassword";
            Text = "forgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_forgotemail;
        private Button btn_forgotverificationcode;
    }
}