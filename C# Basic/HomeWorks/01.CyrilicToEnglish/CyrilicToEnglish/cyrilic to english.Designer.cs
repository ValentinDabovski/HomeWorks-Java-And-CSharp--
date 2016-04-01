namespace ConsoleApplication3
{
    partial class cyrilic_to_english
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
            this.engLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bulLabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // engLabel
            // 
            this.engLabel.AutoSize = true;
            this.engLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engLabel.Location = new System.Drawing.Point(577, 40);
            this.engLabel.Name = "engLabel";
            this.engLabel.Size = new System.Drawing.Size(103, 31);
            this.engLabel.TabIndex = 0;
            this.engLabel.Text = "English";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(583, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 280);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // bulLabel
            // 
            this.bulLabel.AutoSize = true;
            this.bulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulLabel.Location = new System.Drawing.Point(12, 40);
            this.bulLabel.Name = "bulLabel";
            this.bulLabel.Size = new System.Drawing.Size(96, 31);
            this.bulLabel.TabIndex = 2;
            this.bulLabel.Text = "Cyrilic ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(18, 104);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(229, 280);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // cyrilic_to_english
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 655);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.bulLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.engLabel);
            this.Name = "cyrilic_to_english";
            this.Text = "cyrilic_to_english";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label engLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label bulLabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}