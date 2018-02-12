﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5_Ques_2
{
    public struct Complex
    {
        public int real;
        public int imaginary;

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }


        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }


        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(2, 3);
            Complex num2 = new Complex(3, 4);
            Complex sum = num1 + num2;
            Console.WriteLine("First Complex Number :  {0}", num1);
            Console.WriteLine("Second Complex Number : {0}", num2);
            Console.WriteLine("The Sum of the Two Numbers : {0}", sum);
            Console.ReadLine();
        }
    }
}
