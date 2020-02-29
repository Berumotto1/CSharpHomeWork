using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello,world!");

            Program.Calculator();
            


        }

        public static void Calculator()
        {
            Console.WriteLine("A simple calculator!");


            while(true)
            {

                string s = "";
                int a = 0, b = 0;
                char ope;
                //double d = 0;

                Console.Write("Please input the first integer number:");
                a=input(1);
                Console.Write("Please input the second integer number:");
                b=input(1);
                

                Console.Write("Please input the operator:");

                ope = (char)input(2);

                switch (ope)
                {
                    case '+':
                        Console.WriteLine($"a+b={a + b}");
                        break;
                    case '-':
                        Console.WriteLine($"a-b={a - b}");
                        break;
                    case '*':
                        
                        Console.WriteLine($"a*b={a * b}");
                        break;
                    case '/':
                        double c = (double)a;
                        Console.WriteLine($"a/b={c / b}");
                        break;
                    default:
                        break;

                }
            }
            

            
        }

        public static int input(int ab)
        {
            string s = "";
            int a = 0, b = 0;
            char ope;


            
            bool flag1=false;
            while(!false)
            {
                if(ab==1)
                {
                    try
                    {
                        s = Console.ReadLine();
                        a = Int32.Parse(s);
                        return a;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("请输入正确的数字:");
                        flag1 = false;
                    }
                }
                else
                {
                    
                    
                        ope = Convert.ToChar(Console.ReadLine());
                        if(ope!='+'&& ope!='-' && ope != '*' && ope != '/')
                        {

                        Console.WriteLine("请输入正确的操作符:");
                        flag1 = false;
                        }
                    else
                    {
                        return (int)ope;
                    }

                }
               
            }
            
                
                
        }
    }

}
