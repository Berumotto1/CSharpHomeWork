using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


    
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "-";
        }


        
        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "+";
        }

        private void button5_Click(object sender, EventArgs e)  //计算按钮
        {
            string str1 = richTextBox1.Text;
            string str2 = richTextBox2.Text;
            int i1, i2;
            

            if (!int.TryParse(str1, out i1))//将第一个文本框内容字符串转换成整型数据
            {
                MessageBox.Show("第一个数不是合法的整数");//弹出消息对话框
                return;//仅仅退出所在的函数
            }
            if (int.TryParse(str2, out i2) == false)//将第二个文本框内容字符串转换成整型数据
            {
                MessageBox.Show("第二个数字不是合法的整数");//弹出消息对话框
                return;
            }

            
            switch (label1.Text)
            {
                
                case "+":
                    
                    richTextBox3.Text = Convert.ToString(i1 + i2);// 等价于textBox3 = i3.ToString();
                    break;
                case "-":
                    
                    richTextBox3.Text = Convert.ToString(i1-i2);
                    break;
                case "*":

                    
                    richTextBox3.Text = Convert.ToString(i1*i2);// 
                    break;
                case "/":
                    double i3 = (double)i1;
                    if(i2==0)
                    {
                        MessageBox.Show("除数不能为0！请重新输入！");
                        break;
                    }
                    richTextBox3.Text = Convert.ToString(i3/i2);// 等价于textBox3 = i3.ToString();
                    break;
                default:
                    MessageBox.Show("运算符不合法，请重新输入！");//不会出现这种情况！
                    break;
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
