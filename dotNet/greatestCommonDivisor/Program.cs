using System;

namespace greatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Greatest common divisor or Euclidean algorithm
            test tumbers (1071,462)==21
            1071 = 2 × 462 + 147
            462 = 3 × 147 + 21
            147 = 7 × 21 + 0
            1071 > 462 > 147 > 21*/
            
            int firstNum,secondNum;
            Program p = new Program();
            Console.Write("Enter first number: ");
            firstNum = p.GetInput();
            Console.Write("Enter second number: ");
            secondNum = p.GetInput();
            Console.Write("GCD("+firstNum+", "+secondNum+") = ");
            p.EuclideanAlgorithm(firstNum,secondNum);

        }
        void EuclideanAlgorithm(int f1,int f2){
            int times =0;
            if(f1<0){
                f1 = f1 * -1;
            }
            if(f2<0){
                f2 = f2 * -1;
            }
            do{
                times = 0;
                do{
                    f1 = f1 - f2;
                    times++;
                }while(f1 > 0);
                times--;
                f1 = f1 + f2;
                f2 = f2 - f1;
            }while(f2!=0);
            Console.Write(f1);
        }
        int GetInput(){
            int checkInput;
            try{
                checkInput = Convert.ToInt32(Console.ReadLine());
                return checkInput;
            }catch(Exception e){
                Console.WriteLine("Error 0: "+e.Message);
                Environment.Exit(0);
                return -1;//never
            }
        }
    }
}
