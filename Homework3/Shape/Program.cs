using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle(10, 3);
            re.display();

            Square sq = new Square(-5);
            sq.display();

            Triangle tr = new Triangle(-10, 2);
            tr.display();
            
        }
    }


    public interface Shape
    {
        //方法隐含为public
        float Area();
        bool IsLeagl();
        void display();
    }


    
    public class Rectangle : Shape
    {
        private int width;
        private int length;

        public Rectangle(int length,int width)
        {
            Width = width;
            Length = length;
        }
        public int Width
        {
            get => width;

            set
            {
                if(value>0)
                {
                    width = value;
                }
                else 
                {
                    Console.WriteLine("输入不合法！请重新输入矩形的宽:");
                    int va = Convert.ToInt32(Console.ReadLine());
                    Width = va;
                }
                
            }
            
        }

        public int Length
        {
            get => length;
            set
            {
                if(value>0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("输入不合法！请重新输入矩形的长:");
                    int va = Convert.ToInt32(Console.ReadLine());
                    Length = va;
                }
            }
        }
       
        public float Area()
        {
            if(IsLeagl())
            {
                return this.Width * this.Length;
            }
            return -1;
            
        }

        public virtual void display()
        {
            Console.WriteLine("矩形！");
            Console.WriteLine($"长为:{Length},宽为:{Width},面积为:" + this.Area());
        }

        public bool IsLeagl()
        {
            return (length > 0) && (width > 0);
        }

        
    }

    public class Square:Rectangle
    {
        
        public Square(int side):base(Math.Abs(side), Math.Abs(side))
        {
            
        }
         
        public override void display()
        {
            Console.WriteLine("正方形！");
            Console.WriteLine($"边长为{Width},面积为:" + this.Area());
        }

    }


    public class Triangle : Shape
    {
        private int height;
        private int bottom;

        public int Height
        {
            get => height;
            set
            {
                if(value>0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("输入不合法！请重新输入三角形的高:");
                    int va = Convert.ToInt32(Console.ReadLine());
                    Height = va;
                }
            }
        }

        public int Bottom
        {
            get => bottom;
            set
            {
                if (value > 0)
                {
                    bottom = value;
                }
                else
                {
                    Console.WriteLine("输入不合法！请重新输入三角形的底:");
                    int va = Convert.ToInt32(Console.ReadLine());
                    Bottom = va;
                }
            }
        }

        public Triangle(int bottom,int height)
        {
            Height = height;
            Bottom = bottom;
        }
        public float Area()
        {
            if(IsLeagl())
            {
                return (float)Height * Bottom / 2;
            }
            return -1;
            

        }

        public bool IsLeagl()
        {
            return (height > 0) && (bottom > 0);
        }

        public void display()
        {
            Console.WriteLine("三角形！");
            Console.WriteLine($"底为:{Bottom},高为:{Height},面积为:" + this.Area());
        }
    }



}
