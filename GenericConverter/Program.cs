using System;

namespace GenericConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter<string, int> converter1 = new Converter<string, int>(sToI);
            Converter<int, string> converter2 = new Converter<int, string>(iToS);
            Converter<double, int> converter3 = new Converter<double, int>(dToI);

            string[] strings = { "Hello", "aaaaa", "bb" };
            int[] numbers = { 1, 2, 3 };
            double[] doubles = { 3.7, 1.3, 9.8 };

            int[] outputs1 = new int[strings.Length];
            string[] outputs2 = new string[numbers.Length];
            int[] outputs3 = new int[doubles.Length];

            outputs1 = converter1.ConvertAll(strings);
            outputs2 = converter2.ConvertAll(numbers);
            outputs3 = converter3.ConvertAll(doubles);

            Console.WriteLine("=== 문자열 -> 길이 변환 ===");
            Console.WriteLine($"{strings[0]} -> {converter1.Convert(strings[0])}");
            Console.Write($"전체 변환 : ");

            for(int i = 0; i < outputs1.Length; i++)
            {
                if(i == 0)
                {
                    Console.Write(outputs1[i]);

                }
                else
                {
                    Console.Write($", {outputs1[i]}");

                }
            }
            Console.WriteLine();

            Console.WriteLine("=== 정수 -> 문자열 변환 ===");
            Console.WriteLine($"{numbers[0]} -> {converter2.Convert(numbers[0])}");
            Console.Write($"전체 변환 : ");

            for (int i = 0; i < outputs2.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(outputs2[i]);

                }
                else
                {
                    Console.Write($", {outputs2[i]}");

                }
            }
            Console.WriteLine();

            Console.WriteLine("=== 문자열 -> 길이 변환 ===");
            Console.WriteLine($"{doubles[0]} -> {converter3.Convert(doubles[0])}");
            Console.Write($"전체 변환 : ");

            for (int i = 0; i < outputs3.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(outputs3[i]);

                }
                else
                {
                    Console.Write($", {outputs3[i]}");

                }
            }
            Console.WriteLine();
        }
        static int sToI(string s)
        {
            return s.Length;
        }

        static string iToS(int i)
        {
            return i.ToString() + "번";
        }

        static int dToI(double d)
        {
            return (int)d;
        }
    }
}