using System;

namespace BasicPart07_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            //showMessage("Kongpop Kunchanuan");

            Console.Write("Input number : ");
            int.TryParse(Console.ReadLine(), out number);
            while (number != 0)//ค่าที่ไม่เท่ากับ 0 ถึงจะเข้าสู่ loop while
            {

                showMultipleTable(number);

                Console.Write("Input number : ");
                int.TryParse(Console.ReadLine(), out number);
                //เอาค่าที่รับมาใหม่ไปเช็ค
            } 
            
            //Console.ReadKey();
        }

/*        static void showMessage(string str)
        {
            Console.WriteLine("Hello K." + str);
        }*/

        static void showMultipleTable(int number)
        {
            for (int i=1; i <= 12;i++)
            {
                Console.WriteLine("{0} x {1} = {2}",number,i,number*i);
            }
        }


    }
}
