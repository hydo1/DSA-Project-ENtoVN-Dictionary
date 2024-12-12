namespace dictionaryprj
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputword = new System.Windows.Forms.TextBox();
            this.meaning = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.phienam = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.whiteheart = new System.Windows.Forms.PictureBox();
            this.redheart = new System.Windows.Forms.PictureBox();
            this.ovalPictureBox1 = new dictionaryprj.OvalPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.whiteheart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redheart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(317, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ điển";
            // 
            // inputword
            // 
            this.inputword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputword.Location = new System.Drawing.Point(279, 271);
            this.inputword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputword.Name = "inputword";
            this.inputword.Size = new System.Drawing.Size(191, 20);
            this.inputword.TabIndex = 1;
            this.inputword.Click += new System.EventHandler(this.inputword_Click);
            this.inputword.TextChanged += new System.EventHandler(this.inputword_TextChanged);
            // 
            // meaning
            // 
            this.meaning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meaning.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaning.Location = new System.Drawing.Point(279, 300);
            this.meaning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.meaning.Multiline = true;
            this.meaning.Name = "meaning";
            this.meaning.Size = new System.Drawing.Size(191, 46);
            this.meaning.TabIndex = 2;
            this.meaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // type
            // 
            this.type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type.Location = new System.Drawing.Point(483, 285);
            this.type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.type.Multiline = true;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(78, 19);
            this.type.TabIndex = 3;
            // 
            // phienam
            // 
            this.phienam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phienam.Location = new System.Drawing.Point(483, 328);
            this.phienam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phienam.Name = "phienam";
            this.phienam.Size = new System.Drawing.Size(78, 20);
            this.phienam.TabIndex = 4;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.Bisque;
            this.cancel.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel.Location = new System.Drawing.Point(627, 34);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 19);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Đóng";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbtn.BackColor = System.Drawing.Color.Bisque;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(345, 350);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(74, 44);
            this.searchbtn.TabIndex = 10;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(494, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại từ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(487, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phiên âm";
            // 
            // whiteheart
            // 
            this.whiteheart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whiteheart.BackColor = System.Drawing.Color.Transparent;
            this.whiteheart.BackgroundImage = global::dictionaryprj.Properties.Resources.whiteheartsmall;
            this.whiteheart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whiteheart.Location = new System.Drawing.Point(497, 194);
            this.whiteheart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.whiteheart.Name = "whiteheart";
            this.whiteheart.Size = new System.Drawing.Size(49, 48);
            this.whiteheart.TabIndex = 13;
            this.whiteheart.TabStop = false;
            this.whiteheart.Click += new System.EventHandler(this.whiteheart_Click);
            // 
            // redheart
            // 
            this.redheart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redheart.BackColor = System.Drawing.Color.Transparent;
            this.redheart.BackgroundImage = global::dictionaryprj.Properties.Resources.redheartsmall;
            this.redheart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redheart.Location = new System.Drawing.Point(493, 194);
            this.redheart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redheart.Name = "redheart";
            this.redheart.Size = new System.Drawing.Size(62, 54);
            this.redheart.TabIndex = 14;
            this.redheart.TabStop = false;
            this.redheart.Visible = false;
            this.redheart.Click += new System.EventHandler(this.redheart_Click);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::dictionaryprj.Properties.Resources.debut;
            this.ovalPictureBox1.Location = new System.Drawing.Point(289, 75);
            this.ovalPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(180, 185);
            this.ovalPictureBox1.TabIndex = 9;
            this.ovalPictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(156, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Favorite List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(213, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::dictionaryprj.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.redheart);
            this.Controls.Add(this.whiteheart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.phienam);
            this.Controls.Add(this.type);
            this.Controls.Add(this.meaning);
            this.Controls.Add(this.inputword);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.whiteheart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redheart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputword;
        private System.Windows.Forms.TextBox meaning;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox phienam;
        private System.Windows.Forms.Button cancel;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox whiteheart;
        private System.Windows.Forms.PictureBox redheart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

