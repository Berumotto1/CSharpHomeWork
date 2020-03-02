using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Homework3;

namespace work2
{

    enum ShapeName
    {
        rec,squ,tri
    }

    class Program
    {
        static void Main(string[] args)
        {
            float SumArea=0;
            Shape[] arr=new Shape[10];
            Random rnd = new Random();
            
            for(int i=0;i<10;i++)
            {

                arr[i] = ShapeFactory.CreateShape(rnd.Next(1, 4));
                Console.Write("第" + (i+1) + "图形为:");
                arr[i].display();
                SumArea += arr[i].Area();
                Console.WriteLine();
            }
            Console.WriteLine("总面积为:"+SumArea);

        }
    }



    public class ShapeFactory
    {
        
        public static Shape CreateShape(int shapeName)
        {
            
            const int max = 100;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            Shape shape = null;
            switch(shapeName)
            {
                case 1://"rec":
                    //Console.WriteLine("请输入矩形的长与宽:");
                    int length = rnd.Next(1, max);//Convert.ToInt32(Console.ReadLine());
                    int width = rnd.Next(1, max);//Convert.ToInt32(Console.ReadLine());

                    shape = new Rectangle(length, width);
                    break;
                case 2:// "squ":
                    //Console.WriteLine("请输入正方形的边长:");
                    int side = rnd.Next(1, max);//Convert.ToInt32(Console.ReadLine());
                    shape = new Square(side);
                    break;

                case 3:// "tri":
                    //Console.WriteLine("请输入三角形的底和高:");
                    int bottom = rnd.Next(1, max);//onvert.ToInt32(Console.ReadLine());
                    int height = rnd.Next(1, max);//Convert.ToInt32(Console.ReadLine());

                    shape = new Triangle(bottom, height);
                    break;

            }
            return shape;
        }

    }
}
