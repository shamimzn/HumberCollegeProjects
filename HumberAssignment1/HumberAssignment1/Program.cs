using System;
using System.Linq;

namespace Humber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the series of numbers and separate them with + then press Enter to calculate the sum ");
            string strInput = Console.ReadLine();
            string[] arrInput=strInput.Split('+');
            int[] arrSum=new int[arrInput.Length];
            int i= 0;
            int j = 0;
            string strCorrectInput="";

            foreach (var s in arrInput)
            {
                if (int.TryParse(s, out int result))
                {
                    arrSum[i] = result;
                    strCorrectInput += result + "+";
                    i++;

                }
                else
                    j++;                                                     
            }

            if (strCorrectInput != "")
            {
                strCorrectInput = strCorrectInput.Remove(strCorrectInput.Length - 1, 1);
                Console.WriteLine(strCorrectInput + " = " + arrSum.Sum());
            }
            if (j>0)  
                Console.WriteLine("You have entered "+j +" wrong character" );
           
        }
    }
}
