using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_sheet_2
{
    public partial class Form1 : Form
    {
        Bitmap src_img, dest_img;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("D:\\Beems.bmp");
            src_img = new Bitmap(pictureBox1.Image);
            dest_img = new Bitmap(pictureBox1.Image);
        }

        private void prewitt_button_Click(object sender, EventArgs e)
        {
            int[,] kernelX = new int[3, 3];
            int[,] kernelY = new int[3, 3];

            kernelX[0, 0] = -1; kernelX[0, 1] = 0; kernelX[0, 2] = 1;
            kernelX[1, 0] = -1; kernelX[1, 1] = 0; kernelX[1, 2] = 1;
            kernelX[2, 0] = -1; kernelX[2, 1] = 0; kernelX[2, 2] = 1;

            kernelY[0, 0] = 1; kernelY[0, 1] = 1; kernelY[0, 2] = 1;
            kernelY[1, 0] = 0; kernelY[1, 1] = 0; kernelY[1, 2] = 0;
            kernelY[2, 0] = -1; kernelY[2, 1] = -1; kernelY[2, 2] = -1;


            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result;
                    int resultX = 0;
                    int resultY = 0;

                    // convolution
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                        }

                    result = Convert.ToInt32(Math.Sqrt((resultX * resultX) + (resultY * resultY)));

                    if (result > 255)
                        result = 255;

                    // assign to new image
                    dest_img.SetPixel(x, y, Color.FromArgb(result, result, result));
                }

            pictureBox2.Image = dest_img;

        }

        private void laplacian_button_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3];
            
            kernel[0, 0] = -1; kernel[0, 1] = -1; kernel[0, 2] = -1;
            kernel[1, 0] = -1; kernel[1, 1] = 8; kernel[1, 2] = -1;
            kernel[2, 0] = -1; kernel[2, 1] = -1; kernel[2, 2] = -1;


            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result =0;

                    // convolution
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            result += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                        }

                    if (result > 255)
                        result = 255;

                    if (result < 0)
                        result = 0;

                    // assign to new image
                    dest_img.SetPixel(x, y, Color.FromArgb(result, result, result));
                }

            pictureBox2.Image = dest_img;

        }

        private void sharpen_button_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3];
            
            kernel[0, 0] = -1; kernel[0, 1] = -1; kernel[0, 2] = -1;
            kernel[1, 0] = -1; kernel[1, 1] = 9; kernel[1, 2] = -1;
            kernel[2, 0] = -1; kernel[2, 1] = -1; kernel[2, 2] = -1;


            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result = 0;

                    // convolution
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            result += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                        }

                    if (result > 255)
                        result = 255;

                    if (result < 0)
                        result = 0;

                    // assign to new image
                    dest_img.SetPixel(x, y, Color.FromArgb(result, result, result));
                }

            pictureBox2.Image = dest_img;
        }

        private void mean_button_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3];

            kernel[0, 0] = 1; kernel[0, 1] = 1; kernel[0, 2] = 1;
            kernel[1, 0] = 1; kernel[1, 1] = 3; kernel[1, 2] = 1;
            kernel[2, 0] = 1; kernel[2, 1] = 1; kernel[2, 2] = 1;


            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result = 0;
                    // convolution
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            result += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                        }

                    result = result / 11;

                    // assign to new image
                    dest_img.SetPixel(x, y, Color.FromArgb(result, result, result));
                }

            pictureBox2.Image = dest_img;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = hScrollBar2.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int C = hScrollBar2.Value;
            double F = (259 * (C + 255)) / (255 * (259 - C));
            for (int x = 0; x < pictureBox1.Image.Width ; x++)
                for (int y = 0; y < pictureBox1.Image.Height ; y++)
                {
                    double result;
                    result = F * (src_img.GetPixel(x, y).G - 128) + 128;


                    if (result > 255)
                        result = 255;

                    if (result < 0)
                        result = 0;

                    // assign to new image
                    dest_img.SetPixel(x, y, Color.FromArgb((int)result, (int)result, (int)result));
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3];

            kernel[0, 0] = 1; kernel[0, 1] = 1; kernel[0, 2] = 1;
            kernel[1, 0] = 1; kernel[1, 1] = 3; kernel[1, 2] = 1;
            kernel[2, 0] = 1; kernel[2, 1] = 1; kernel[2, 2] = 1;


            for (int x = 1; x < pictureBox1.Image.Width; x++)
                for (int y = 1; y < pictureBox1.Image.Height; y++)
                {
                    int result = 0;
                    // convolution

                    result = hScrollBar1.Value + src_img.GetPixel(x, y).G;

                    if (result > 255)
                        result = 255;
                    if (result < 0)
                        result = 0;


                    // assign to new image
                    dest_img.SetPixel(x, y, Color.FromArgb(result, result, result));
                }

            pictureBox2.Image = dest_img;
        }

        private void sobel_button_Click(object sender, EventArgs e)
        {
            int[,] kernelX = new int[3, 3];
            int[,] kernelY = new int[3, 3];

            kernelX[0, 0] = -1; kernelX[0, 1] = 0; kernelX[0, 2] = 1;
            kernelX[1, 0] = -2; kernelX[1, 1] = 0; kernelX[1, 2] = 2;
            kernelX[2, 0] = -1; kernelX[2, 1] = 0; kernelX[2, 2] = 1;

            kernelY[0, 0] = 1; kernelY[0, 1] = 2; kernelY[0, 2] = 1;
            kernelY[1, 0] = 0; kernelY[1, 1] = 0; kernelY[1, 2] = 0;
            kernelY[2, 0] =-1; kernelY[2, 1] = -2; kernelY[2, 2] = -1;


            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result;
                    int resultX = 0;
                    int resultY = 0;

                    // convolution
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                        }
                    
                    result = Convert.ToInt32(Math.Sqrt((resultX * resultX) + (resultY * resultY)));

                    if (result > 255)
                        result = 255;
                    
                    // assign to new image
                    dest_img.SetPixel(x, y, Color.FromArgb(result,result, result));
                }

            pictureBox2.Image = dest_img;

        }
    }
}
