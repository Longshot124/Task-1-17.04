using System;

namespace Classwork_14._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("reqem elave edin");
            int number = Convert.ToInt32(Console.ReadLine()); // console elave edilen birinci reqem


            Console.WriteLine("Evveline elave olunacaq reqemi daxil edin");
            //int addedNumber = Convert.ToInt32(Console.ReadLine());
            addNumber(number);//addNumber metodu
            
        }

        public static void addNumber(int number)
        {
            int finalNumber = number; // finalNumber bizim yekun reqemimizdir
            int count = 0;
            int addedNumber = Convert.ToInt32(Console.ReadLine());// reqemin evveline elave olunacaq reqem

            while (finalNumber!=0)
            {
                finalNumber = finalNumber / 10; // int tipi tam eded oldugu ucun bize qaliqli reqem vermeyecek!!!
                count++; // reqemin nece ededli oldugunu bildirecek
            }

            int coof = 1; // Bize lazim olan reqemiminz nece ededli oldugunu verecek, coof  = 0 vere bilmerik cunki 0*10 sonsuz dovr verecek
            int i = 0 ;

            for (i = 0; i < count; i++) // i ve count beraber olana qeder dovr gedecek
            {
                coof *= 10; // 
            }
            finalNumber = number + addedNumber * coof;

            Console.WriteLine(finalNumber);
        }
        
    }
}
