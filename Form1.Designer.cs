
namespace image_sheet_2
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
            this.sobel_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prewitt_button = new System.Windows.Forms.Button();
            this.laplacian_button = new System.Windows.Forms.Button();
            this.sharpen_button = new System.Windows.Forms.Button();
            this.mean_button = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sobel_button
            // 
            this.sobel_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sobel_button.Location = new System.Drawing.Point(350, 91);
            this.sobel_button.Name = "sobel_button";
            this.sobel_button.Size = new System.Drawing.Size(100, 23);
            this.sobel_button.TabIndex = 10;
            this.sobel_button.Text = "Sobel Filter 3x3";
            this.sobel_button.UseVisualStyleBackColor = true;
            this.sobel_button.Click += new System.EventHandler(this.sobel_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(122, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(553, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image After Processing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(108, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Original Image";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(472, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 267);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 267);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // prewitt_button
            // 
            this.prewitt_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prewitt_button.Location = new System.Drawing.Point(350, 134);
            this.prewitt_button.Name = "prewitt_button";
            this.prewitt_button.Size = new System.Drawing.Size(100, 23);
            this.prewitt_button.TabIndex = 11;
            this.prewitt_button.Text = "Prewitt Filter 3x3";
            this.prewitt_button.UseVisualStyleBackColor = true;
            this.prewitt_button.Click += new System.EventHandler(this.prewitt_button_Click);
            // 
            // laplacian_button
            // 
            this.laplacian_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.laplacian_button.Location = new System.Drawing.Point(350, 182);
            this.laplacian_button.Name = "laplacian_button";
            this.laplacian_button.Size = new System.Drawing.Size(100, 23);
            this.laplacian_button.TabIndex = 12;
            this.laplacian_button.Text = "Laplacian Filter";
            this.laplacian_button.UseVisualStyleBackColor = true;
            this.laplacian_button.Click += new System.EventHandler(this.laplacian_button_Click);
            // 
            // sharpen_button
            // 
            this.sharpen_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sharpen_button.Location = new System.Drawing.Point(350, 223);
            this.sharpen_button.Name = "sharpen_button";
            this.sharpen_button.Size = new System.Drawing.Size(100, 23);
            this.sharpen_button.TabIndex = 13;
            this.sharpen_button.Text = "Sharpen Filter";
            this.sharpen_button.UseVisualStyleBackColor = true;
            this.sharpen_button.Click += new System.EventHandler(this.sharpen_button_Click);
            // 
            // mean_button
            // 
            this.mean_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mean_button.Location = new System.Drawing.Point(350, 51);
            this.mean_button.Name = "mean_button";
            this.mean_button.Size = new System.Drawing.Size(100, 23);
            this.mean_button.TabIndex = 14;
            this.mean_button.Text = "Mean Filter 3x3";
            this.mean_button.UseVisualStyleBackColor = true;
            this.mean_button.Click += new System.EventHandler(this.mean_button_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(394, 259);
            this.hScrollBar1.Maximum = 70;
            this.hScrollBar1.Minimum = -70;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(56, 17);
            this.hScrollBar1.TabIndex = 16;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button2.Location = new System.Drawing.Point(350, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Brightness";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button3.Location = new System.Drawing.Point(350, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Contrast";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "0";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(394, 326);
            this.hScrollBar2.Maximum = 70;
            this.hScrollBar2.Minimum = -70;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(56, 17);
            this.hScrollBar2.TabIndex = 19;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.mean_button);
            this.Controls.Add(this.sharpen_button);
            this.Controls.Add(this.laplacian_button);
            this.Controls.Add(this.prewitt_button);
            this.Controls.Add(this.sobel_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sobel_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button prewitt_button;
        private System.Windows.Forms.Button laplacian_button;
        private System.Windows.Forms.Button sharpen_button;
        private System.Windows.Forms.Button mean_button;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.HScrollBar hScrollBar2;
    }
}

