using System;

namespace HomeTask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Daxil edilmiş string dəyərinin içində rəqəm olub olmadığını tapan proqram

            //Console.WriteLine("Input Value : ");
            //string str = Console.ReadLine();
            //char m = '0';
            //foreach (char item in str)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        //char ch = (char)j;
            //        m = Convert.ToChar(j);
            //        //m = (char)j;
            //        if (item == m )
            //            Console.WriteLine("Var");
            //    }
            //}
            //Console.WriteLine("Yoxdur");

            //Console.WriteLine("Input Value : ");
            //string str = Console.ReadLine();
            //foreach (char item in str)
            //{
            //    if(item=='0'|| item == '1' || item == '2' || item == '3' || item == '4' || item == '5' || item == '6' || item == '7' || item == '8' || item == '9')
            //    {
            //        Console.WriteLine("Var");                 
            //    }
            //}

            Console.WriteLine("Input Value : ");
            string str = Console.ReadLine();
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
            int counter = 0;
            foreach (char item in str)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (item == numbers[j])
                    {
                        //Console.WriteLine("var");
                        counter++;
                        
                    }
                }
            }
            if (counter>0)
                Console.WriteLine("Vardir");
            else
                Console.WriteLine("Yoxdur");
            //Console.WriteLine("Yoxdur");




            //2. Daxil edilmiş string  dəyərində  ardıcıl a ve l char-larının olub olmadığını tapan proqram.
            //Misalçün alma, salam və s. kimi sözlərdə "vardir" yazdırmalıdır geriyə.

            //Console.WriteLine("Input the name : ");
            //string name = Console.ReadLine();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == 'a' && name[i+1]=='l')
            //    {
            //        Console.WriteLine("Vardir");
            //    }
            //}
            //Console.WriteLine("Yoxdur");



            //3. Verilmiş ədədin rəqəmlərinin ədədi ortasını tapan proqram
            //Console.WriteLine("Input number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int counter = 0;
            //while (number >= 1)
            //{
            //    int k = number % 10;
            //    sum += k;
            //    counter++;
            //    number = number / 10;
            //}
            //Console.WriteLine(sum / counter);


            //4.Daxil edilmiş yazı siyahısında(string array) neçə sözdə rəqəm olduğunu tapan proqram

            //string[] array = { "sasdg", "df4twd", "dt5as" };
            //char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
            //int counter = 0;
            //foreach (string item in array)
            //{
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        for (int j = 0; j < numbers.Length; j++)
            //        {
            //            if (item[i]==numbers[j])
            //            {
            //                counter++;
            //            }

            //        }
            //    }

            //}
            //Console.WriteLine(counter);

        }
    }
}
