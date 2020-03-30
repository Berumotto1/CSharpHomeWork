using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Move(object sender, EventArgs e)
        {

        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            progressBar1.Value = 0;
            if (graphics == null) graphics = this.panel1.CreateGraphics();


            int n = 10;
            double leng=100;


            if(textBox1.Text!="")
            {
                n = Convert.ToInt32(textBox1.Text.Trim());
            }
            layer = n;
            /*if (textBox2.Text != "")
            {
                leng = Convert.ToInt32(textBox2.Text.Trim());
            }*/
            leng = trackBar1.Value;
            label8.Text = trackBar1.Value.ToString();
            progressBar1.Maximum = (int)Math.Pow(2, layer)-1;
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);


        }
        int layer;
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen color = Pens.Blue;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;
           

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            if (textBox3.Text != "")
            {
                per1 = Convert.ToDouble(textBox3.Text.Trim());
            }
            if (textBox4.Text != "")
            {
                per2 = Convert.ToDouble(textBox4.Text.Trim());
            }

            if (textBox5.Text != "")
            {
                th1 = Convert.ToInt32(textBox5.Text.Trim())
                    * Math.PI / 180;
            }

            if (textBox6.Text != "")
            {
                th2 = Convert.ToInt32(textBox6.Text.Trim())
                    * Math.PI / 180;
            }

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            

            /*if (textBox7.Text != "")
            {
               //string str=textBox7.Text.First().ToString().ToUpper() 
                //    + textBox7.Text.Substring(1);
                switch(textBox7.Text)
                {
                    case "red":
                        color = Pens.Red;
                        break;
                    case "orange":
                        color = Pens.Orange;
                        break;
                    case "yellow":
                        color = Pens.Yellow;
                        break;
                    case "green":
                        color = Pens.Green;
                        break;
                    case "indigo":
                        color = Pens.Indigo;
                        break;
                    case "blue":
                        color = Pens.Blue;
                        break;
                    case "violet":
                        color = Pens.Violet;
                        break;
                }     
            }*/
            //n层
            //进度条
            progressBar1.Value += 1;

            graphics.DrawLine(color, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color; 
                color = new Pen(colorChoosed);
                button2.BackColor = colorChoosed;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar1.Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
