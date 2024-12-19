namespace DynamicDictionary
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
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
           
            richTextBox1.Location = new Point(36, 15);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(637, 402);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Hover over a word to get its definition!";
            richTextBox1.MouseUp += richTextBox1_MouseUp;
           
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(679, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(640, 526);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
           
            label1.AutoSize = true;
            label1.Location = new Point(52, 468);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 3;
            label1.Text = "Word Meaning:";
            
            richTextBox2.Location = new Point(52, 507);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(304, 144);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
           
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(richTextBox2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Dynamic Dictionary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private RichTextBox richTextBox2;
    }
}
