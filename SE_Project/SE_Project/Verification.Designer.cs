namespace SE_Project
{
    partial class Verification
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
            txt_code = new TextBox();
            label1 = new Label();
            btn_verify = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_code
            // 
            txt_code.Location = new Point(175, 73);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(100, 23);
            txt_code.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 76);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Code";
            // 
            // btn_verify
            // 
            btn_verify.Location = new Point(128, 163);
            btn_verify.Name = "btn_verify";
            btn_verify.Size = new Size(75, 23);
            btn_verify.TabIndex = 2;
            btn_verify.Text = "Verify";
            btn_verify.UseVisualStyleBackColor = true;
            btn_verify.Click += btn_verify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 29);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 3;
            label2.Text = "Let's Verify First that it's you";
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(label2);
            Controls.Add(btn_verify);
            Controls.Add(label1);
            Controls.Add(txt_code);
            Name = "Verification";
            Text = "Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_code;
        private Label label1;
        private Button btn_verify;
        private Label label2;
    }
}