namespace SE_Project
{
    partial class ChangePassword
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
            txt_new = new TextBox();
            txt_connfirm = new TextBox();
            btn_change = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 112);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "NewPassword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 203);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "ConfirmPassword";
            // 
            // txt_new
            // 
            txt_new.Location = new Point(298, 109);
            txt_new.Name = "txt_new";
            txt_new.Size = new Size(100, 23);
            txt_new.TabIndex = 2;
            // 
            // txt_connfirm
            // 
            txt_connfirm.Location = new Point(298, 200);
            txt_connfirm.Name = "txt_connfirm";
            txt_connfirm.Size = new Size(100, 23);
            txt_connfirm.TabIndex = 3;
            // 
            // btn_change
            // 
            btn_change.Location = new Point(262, 286);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(143, 23);
            btn_change.TabIndex = 4;
            btn_change.Text = "Change Password";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Click += btn_change_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_change);
            Controls.Add(txt_connfirm);
            Controls.Add(txt_new);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_new;
        private TextBox txt_connfirm;
        private Button btn_change;
    }
}