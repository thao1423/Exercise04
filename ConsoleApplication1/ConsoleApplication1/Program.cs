using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
        //

        public static bool IsOdd(int n)
        {
            return true;
        }
        public static bool IsOdd1(int n)
        {
            return false; 
        } 
        // bai2 
        public static bool IsEven(int n)
        {
            return true;
        }   
        //Ceil  
        //input: float x 
        //output: a int that smallest but not smaller than X 
        //idea: first change float x into interger then ++1 
        //      if x is a negative than unchanged 
        //      if x == kq then return x
        public static int Ceil(float x)
        {
            int kq = (int)x; 
            if (x >= kq) return kq += 1;
            else return kq;
        } 
        //floor  
        //input: float x 
        //output: a int the largest but not greater than x 
        //idea: first change float x into integer 
        //      if x is a negative then --1 
        public static int Floor(float x)
        {
            int kq = (int)x;
            if (x >= kq) return kq;
            else return kq - 1;
        }
    }
} 
     
    