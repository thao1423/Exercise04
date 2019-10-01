using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            InputInt(array);

        } 
        public static void InputInt(int [] Arr)
        {
            for (int i =0; i<Arr.Length; i++)
            {
                Console.Write("A [{0}]=" ,i)  
                string str = Console.ReadLine(); 
                Arr[i] = int.Parse(str);
            }
        } 
        public static bool IsContain5(int[] Arr)
        {
            return false; 
        } 
        public static bool IsContain5or6(int[] Arr)
        {
            return false;
        } 
        public static bool IsContain5and6(int[] Arr)
        {
            return false;
        }
            
    }
}
