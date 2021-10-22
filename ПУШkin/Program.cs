using System;
namespace ПУШkin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("привет, синий , я зелёный");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("привет, зелёный, как дела?");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("короче, меченый, я тебя спас и вблагородство играть не буду, выполнишь для меня пару заданий и мы врасчёте, заодно посмотрим как быстро у тебя башка после амнезии прояснится, а по твоей теме: постараюсь разузнать, хрен его знает на кой ляг тебе этот стерлок сдался, но я вчужие дела не лезу");
            //int a = 1;
            //Console.WriteLine(a);
            //int b = 8;
            //int umnojenie = a * b;
            //Console.WriteLine(umnojenie);
            //string text = "фильм \"брильянтовая рука\" ";
            //Console.WriteLine(text);
            //string str = "Hello World";
            //char ch = str[7];
            //Console.WriteLine(ch);
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str.IndexOf("o"));
            //double ugol = 0;
            //double ugolDva = 90 - ugol;
            //double konstanta = ugol + ugolDva;
            //Console.WriteLine(Math.Sin(konstanta * Math.PI / 180));


            //находим гипотенузу)))
            
            Console.WriteLine("введиите число 1");
            double longKatetOne = double.Parse(Console.ReadLine());
            Console.WriteLine("введиите число 2");
            double longKatetTwo = double.Parse(Console.ReadLine());
        
            double x = Math.Sqrt(longKatetOne * longKatetOne + longKatetTwo * longKatetTwo);

            Console.WriteLine(x);
            //находим площадь
            Console.WriteLine("Площадь равна:");
            Console.WriteLine((longKatetOne * longKatetTwo) / 2);


        }
      




    }
}
