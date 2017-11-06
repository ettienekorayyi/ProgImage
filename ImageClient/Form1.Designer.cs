namespace ImageClient
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.BrowseTxt = new System.Windows.Forms.TextBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.LeftRotation = new System.Windows.Forms.Button();
            this.RightRotation = new System.Windows.Forms.Button();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.ConverttoPNG = new System.Windows.Forms.Button();
            this.ConverttoJPG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(41, 232);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 22);
            this.BrowseBtn.TabIndex = 0;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // BrowseTxt
            // 
            this.BrowseTxt.Location = new System.Drawing.Point(114, 233);
            this.BrowseTxt.Name = "BrowseTxt";
            this.BrowseTxt.Size = new System.Drawing.Size(157, 20);
            this.BrowseTxt.TabIndex = 1;
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(615, 69);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewBtn.TabIndex = 2;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(536, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 3;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(41, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(456, 213);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // LeftRotation
            // 
            this.LeftRotation.Location = new System.Drawing.Point(341, 259);
            this.LeftRotation.Name = "LeftRotation";
            this.LeftRotation.Size = new System.Drawing.Size(75, 23);
            this.LeftRotation.TabIndex = 5;
            this.LeftRotation.Text = "LEFT";
            this.LeftRotation.UseVisualStyleBackColor = true;
            this.LeftRotation.Click += new System.EventHandler(this.LeftRotation_Click);
            // 
            // RightRotation
            // 
            this.RightRotation.Location = new System.Drawing.Point(422, 259);
            this.RightRotation.Name = "RightRotation";
            this.RightRotation.Size = new System.Drawing.Size(75, 23);
            this.RightRotation.TabIndex = 6;
            this.RightRotation.Text = "RIGHT";
            this.RightRotation.UseVisualStyleBackColor = true;
            this.RightRotation.Click += new System.EventHandler(this.RightRotation_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(92, 259);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 9;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // ConverttoPNG
            // 
            this.ConverttoPNG.Location = new System.Drawing.Point(519, 130);
            this.ConverttoPNG.Name = "ConverttoPNG";
            this.ConverttoPNG.Size = new System.Drawing.Size(101, 23);
            this.ConverttoPNG.TabIndex = 10;
            this.ConverttoPNG.Text = "Convert to PNG";
            this.ConverttoPNG.UseVisualStyleBackColor = true;
            this.ConverttoPNG.Click += new System.EventHandler(this.ConverttoPNG_Click);
            // 
            // ConverttoJPG
            // 
            this.ConverttoJPG.Location = new System.Drawing.Point(645, 130);
            this.ConverttoJPG.Name = "ConverttoJPG";
            this.ConverttoJPG.Size = new System.Drawing.Size(101, 23);
            this.ConverttoJPG.TabIndex = 11;
            this.ConverttoJPG.Text = "Convert to JPG";
            this.ConverttoJPG.UseVisualStyleBackColor = true;
            this.ConverttoJPG.Click += new System.EventHandler(this.ConverttoJPG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 294);
            this.Controls.Add(this.ConverttoJPG);
            this.Controls.Add(this.ConverttoPNG);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.RightRotation);
            this.Controls.Add(this.LeftRotation);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.BrowseTxt);
            this.Controls.Add(this.BrowseBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox BrowseTxt;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button LeftRotation;
        private System.Windows.Forms.Button RightRotation;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Button ConverttoPNG;
        private System.Windows.Forms.Button ConverttoJPG;
    }
}

