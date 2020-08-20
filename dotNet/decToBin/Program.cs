using System;

namespace decToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            int remainder = 0,num,inputNumber = 0;

            try{
                Console.Write("Enter a Number : ");
                inputNumber = Convert.ToInt32(Console.ReadLine());
                num = Convert.ToInt32(inputNumber);
            result = "";
            while (num > 1)
            {
                remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                Console.WriteLine(num+"%"+2+"="+remainder+"\t|"+result);
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine(num+"%"+2+"="+remainder+"\t|"+result);
            Console.WriteLine("Answer"+"\t|"+result);
            }catch(Exception e){
                Console.Write("Error 0: "+e.Message);
            }
        }
    }
}
