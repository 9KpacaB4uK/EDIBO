using System;

namespace fibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows=0;
            int koef = 1;
            try{
                Console.Write("Enter number of rows: ");
                rows = Convert.ToInt32(Console.ReadLine());
            }catch(Exception e){
                Console.WriteLine("Error 0: "+e.Message);
            }
            for(int i=0;i<rows;i++){
                for(int j=0;j<=i;j++){
                    if(j == 0 || i == 0){
                        koef = 1;
                        Console.WriteLine();
                    }else{
                        koef=koef*(i-j+1)/j;
                        Console.Write("_");
                    }
                    Console.Write(koef);
                }
            }

        }
    }
}
