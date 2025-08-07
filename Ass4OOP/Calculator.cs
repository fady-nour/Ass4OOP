using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4OOP
{
    internal class Calculator
    {
        #region part 1 Q1 
        public static int Add(int x, int y) {  return x + y; }
        public static int Add(int x, int y,int z) {  return x + y+z; }
        public static double Add(double x, double y) { return x + y; }
        #endregion

    }
    #region Q2
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Width=0; Height=0;
        }
        public Rectangle(int S)
        {
            Width=S; Height=S;
        }
        public Rectangle(int width, int height) {
            Width = width;
            Height = height; }
    }
    #endregion
    #region Q3
    class Complex
    {
        public int Real { get; set; }
        public int Imginary { get; set; }

      
        public static Complex operator +(Complex left, Complex right)
        {
            Complex C = new Complex()
            {
                Real = left.Real + right.Real,
                Imginary = left.Imginary + right.Imginary

            };
            return C;
        }
        public override string ToString()
        {
            return $"{Real} + {Imginary}i";
        }
    }
    #endregion
    #region Q4
    class Employee
    {
         public virtual void Work()
         {
            Console.WriteLine("Employee is  working");
         }
    }
    class Manager :Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing");
        }

    }
    #endregion
    #region Q5
    class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }

    }
    class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }
    class DerivedClass2 : BaseClass
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }
    #endregion
  
}
