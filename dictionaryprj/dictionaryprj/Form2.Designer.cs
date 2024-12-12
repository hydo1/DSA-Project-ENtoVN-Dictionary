namespace dictionaryprj
{
    partial class Form2
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
            this.listBoxFAV = new System.Windows.Forms.ListBox();
            this.DeletefromFaV = new System.Windows.Forms.Button();
            this.meaning = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.phienam = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFAV
            // 
            this.listBoxFAV.AllowDrop = true;
            this.listBoxFAV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxFAV.FormattingEnabled = true;
            this.listBoxFAV.Location = new System.Drawing.Point(9, 68);
            this.listBoxFAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFAV.Name = "listBoxFAV";
            this.listBoxFAV.Size = new System.Drawing.Size(175, 212);
            this.listBoxFAV.TabIndex = 0;
            this.listBoxFAV.SelectedValueChanged += new System.EventHandler(this.listBoxFAV_SelectedValueChanged);
            // 
            // DeletefromFaV
            // 
            this.DeletefromFaV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeletefromFaV.BackColor = System.Drawing.Color.Bisque;
            this.DeletefromFaV.ForeColor = System.Drawing.Color.Black;
            this.DeletefromFaV.Location = new System.Drawing.Point(305, 183);
            this.DeletefromFaV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeletefromFaV.Name = "DeletefromFaV";
            this.DeletefromFaV.Size = new System.Drawing.Size(126, 28);
            this.DeletefromFaV.TabIndex = 1;
            this.DeletefromFaV.Text = "Xóa khỏi Favorite";
            this.DeletefromFaV.UseVisualStyleBackColor = false;
            this.DeletefromFaV.Click += new System.EventHandler(this.DeletefromFaV_Click);
            // 
            // meaning
            // 
            this.meaning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meaning.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaning.Location = new System.Drawing.Point(272, 55);
            this.meaning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.meaning.Multiline = true;
            this.meaning.Name = "meaning";
            this.meaning.Size = new System.Drawing.Size(191, 46);
            this.meaning.TabIndex = 3;
            this.meaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // type
            // 
            this.type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type.Location = new System.Drawing.Point(272, 124);
            this.type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.type.Multiline = true;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(78, 19);
            this.type.TabIndex = 4;
            // 
            // phienam
            // 
            this.phienam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phienam.Location = new System.Drawing.Point(386, 125);
            this.phienam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phienam.Name = "phienam";
            this.phienam.Size = new System.Drawing.Size(78, 20);
            this.phienam.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(9, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dictionaryprj.Properties.Resources.backgroundgau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phienam);
            this.Controls.Add(this.type);
            this.Controls.Add(this.meaning);
            this.Controls.Add(this.DeletefromFaV);
            this.Controls.Add(this.listBoxFAV);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeletefromFaV;
        public System.Windows.Forms.ListBox listBoxFAV;
        private System.Windows.Forms.TextBox meaning;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox phienam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}