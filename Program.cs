/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arr arr = new Arr();
            Console.WriteLine("Введите M");
            Console.Write("M=");
            int M = Convert.ToInt32(Console.ReadLine());
            arr.SetArray(M);
            Result result=new Result();
            result.NumsMoreThan0(arr);
        }
        class Arr
        {
            protected double[] arr;
            public double[] GetArray() { return arr; }
            public void SetArray(int M) {
                double[] tmp_arr=new double[M];
                for(int i = 0; i < M; i++)
                {
                    Console.Write($"{(i + 1)}element:");
                    tmp_arr[i] = Convert.ToDouble(Console.ReadLine());
                }
                arr = tmp_arr;
            }

        }
        class Result
        {
            public
                void NumsMoreThan0(Arr arr)
            {
                int counter = 0;
                double[] array= arr.GetArray();
                foreach (double element in array)
                {
                    if (element > 0) { counter++; };
                }


                Console.Write("Колличество чисел больше 0: ");
                Console.Write(Convert.ToString(counter));
            }
        }
    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите M");
            Console.Write("M=");
            int M = Convert.ToInt32(Console.ReadLine());
          
            Result result=new Result();
            result.NumsMoreThan0(M);
        }
 
        class Result
        {
            public
                void NumsMoreThan0(int M)
            {
                int t = 0;
                string s ="";
             
                do
                {
                    s += Convert.ToString(M%2);
                    M = M / 2;
                 
                } while (M != 0) ;
                int[] arr =new int[s.Length];
                for(int i = 0; i < arr.Length; i++) { arr[i] = Convert.ToInt32(s[(s.Length) - (i+1)]); }
                Console.Write($"Двоичная форма числа{(M)}: ");
                for (int i = 0; i < arr.Length; i++) { Console.Write(Convert.ToChar(arr[i])); }
                   
            }
        }
    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите M");
            Console.Write("k1=");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("k2=");
            double k2 =Convert.ToDouble(Console.ReadLine());
            Console.Write("b1=");
            double b1 =Convert.ToDouble(Console.ReadLine());
            Console.Write("b2=");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Result result=new Result();
            result.NumsMoreThan0(k1,k2,b1,b2);
        }
 
        class Result
        {
            public
                void NumsMoreThan0(double k1, double k2, double b1, double b2)
            {            
                double x = ((b2 - b1)/(k1 - k2));
                double y = k1 * x + b1;
                Console.Write($"Пересечением является точка М:({x},{y})");
            }
        }
    }
}*/