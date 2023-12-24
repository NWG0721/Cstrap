using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;

namespace C_Booter
{
    internal class Formoles
    {
        //---------The Factorial function---------//
        public int Fact()
        {
            Console.Write("Enter: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int output = 1;
            for (int i = 1; i <= input; i++)
            {
                output = output * i;
            }
            return output;
        }
        //---------The Factorial function---------//



        //---------The Min and Max function---------//
        public string xamin()
        {

            Console.Write("Enter: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;
            int Number = 0;
            for (int i = 0; i < input; i++)
            {
                Console.Write($"Enter number{i + 1}: ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number < min)
                {
                    min = Number;

                }
                else
                if (Number > max)
                {
                    max = Number;
                }
            }
            string Min = min.ToString();
            string Max = max.ToString();
            return "Min :" + Min + "\nmax :" + Max;
        }
        //---------The Min and Max function---------//



        //---------The Binary Searching function---------//
        public string BinarySearch(bool TF)
        {
            Console.WriteLine("Enter Dataes: ");

            List<int> list = new List<int>();

            int i = 0;

            while (true)
            {
                i++;
                Console.Write($"Enter Number{i}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Is that enough?");
                Char IFer = Convert.ToChar(Console.ReadLine());
                if (IFer == 'y')
                {
                    break;
                }
                else if (IFer == 'n') { }

            }

            Console.Write("Enter what you want to find:-) -->");
            int Index = Convert.ToInt32(Console.ReadLine());

            int End, First, Mid;
            End = (list.Count()) - 1;
            First = 0;
            list.Sort();


            while (First <= End)
            {
                Mid = First + (End - First) / 2;
                if (Index == list[Mid])
                {
                    return $"Target found at index: {Mid}";
                    break;
                }
                else if (Index > list[Mid])
                {
                    First = Mid + 1;
                }
                else
                if (Index < list[Mid])
                {
                    End = Mid - 1;
                }
            }
            return "Target not found in the array.";
        }
        //---------The Binary Searching function---------//

        //---------The Linery Searching function---------//
        public string LinearSearch(bool TF)
        {
            Console.WriteLine("Enter Dataes: ");

            List<int> list = new List<int>();

            int j = 0;

            while (true)
            {
                j++;
                Console.Write($"Enter Number{j}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Is that enough?");
                Char IFer = Convert.ToChar(Console.ReadLine());
                if (IFer == 'y')
                {
                    break;
                }
                else if (IFer == 'n') { }

            }

            Console.Write("Enter what you want to find:-) -->");
            int Index = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == Index)
                {
                    return $"Target found at index: {i}";  // Return the index where the target is found
                }
            }
            return "Target not found in the array";  // Return -1 if the target is not found
        }
        //---------The Linery Searching function---------//

        //---------The Summer function---------//
        public string summer(bool TF)
        {
            Console.WriteLine("Enter Dataes: ");

            List<int> list = new List<int>();

            int j = 0;

            while (true)
            {
                j++;
                Console.Write($"Enter Number{j}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Is that enough?");
                Char IFer = Convert.ToChar(Console.ReadLine());
                if (IFer == 'y')
                {
                    break;
                }
                else if (IFer == 'n') { }

            }


            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return ($"The sum of the {list.Count} scores is: {sum}");
        }
        //---------The Summer function---------//


        //---------The Multiplication table function---------//
        public string MultTable(bool TF)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine("\n");
            }
            return "Finished...";
        }
        //---------The Multiplication table function---------//


        //---------The Int To Char To Int function---------//

        public string CTITC(bool TF)
        {
            Console.Write("Whats your type Bro? \n <CTI> OR <ITC> \n");
            String What = Console.ReadLine();
            string Output = "";
            char A;
            if (What == "CTI")
            {
                Console.Write("Enter String: ");
                string Input = Console.ReadLine();
                for (int i = 0; i < Input.Length; i++)
                {
                    Output += Convert.ToInt32(Input[i]);
                }
            }
            if (What == "ITC")
            {
                Console.Write("Enter int: ");
                int Input = Convert.ToInt32(Console.ReadLine());
                A = Convert.ToChar(Input);
                Output = A.ToString();
            }
            return $"The out put is : {Output}";
        }

        //---------The Int To Char To Int function---------//


        //---------The DisplayTriangle function---------//
        public string DisplayTriangle(int size)
        {
            for (int i = 1; i < size; i++)//horizantal sync
            {
                for (int j = (size * 2) - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 - 1; k++)//vertical sync
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            return " ";
        }
        //---------The DisplayTriangle function---------//

        //---------The Bubble Sort function---------//
        public string BubbleSort(bool validation)
        {
            int[] Array = { 7, 1, 2, 10, 3, 4, 5, 9, 8, 6 };
            int ArrayLength = (Array.Length) - 1;
            int cache;
            for (int i = 0; i < ArrayLength; i++)
            {
                for (int j = 0; j < ArrayLength - i; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        cache = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = cache;
                        validation = true;

                    }
                }
                if (!validation)
                {
                    break;
                }
            }
            string Exporter = "";
            foreach (int i in Array)
            {
                Exporter += i + " ";
            }
            return Exporter;
        }
        //---------The Bubble Sort function---------//

        //---------The Fibonacci function---------//
        public int Fibonacci()
        {
            int n1 = 1,
                 n2 = 1,
                    n3;
            Thread.Sleep(1000);
            Console.WriteLine(n1);
            Thread.Sleep(1000);
            Console.WriteLine(n2);
            while (true)
            {
                Thread.Sleep(1000);
                n3 = n1 + n2; Thread.Sleep(1000);
                Console.WriteLine(n3);
                n2 = n1 + n3; Thread.Sleep(1000);
                Console.WriteLine(n2);
                n1 = n3 + n2; Thread.Sleep(1000);
                Console.WriteLine(n1);
            }
        }
        //---------The Fibonacci function---------//


        //---------The MBKM function---------//
        public string MBKM()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int bmm =0;
            int kmm;

            if (a > b)
            {
                bmm = a - b;
                for (; bmm >= b;)
                {

                    bmm -= b;
                }
            }
            else if (a < b)
            {
                bmm = b - a;
                for (; bmm >= a;)
                {

                    bmm -= a;

                }
            }
            kmm = a * b;

            kmm /= bmm;

            return $"Bmm = {bmm} , Kmm = {kmm}";

        }
        //---------The MBKM function---------//


        //---------The Perfect Number function---------//
        public string PerfectNumber()
        {
            Console.Write("Enter a positive integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            int sum = 0;

            if (input > 0)
            {
                for (int i = 1; i <= input / 2; i++)
                {
                    if (input % i == 0)
                    {
                        list.Add(i);
                    }
                }

                foreach (var item in list)
                {
                    sum += item;
                }

                if (sum == input)
                {
                    return $"The {input} is a Perfect Number";
                }
                else
                {
                    return $"The {input} isn't a Perfect Number";
                }
            }
            else
            {
                return "Please enter a positive integer.";
            }
        }
        //---------The Perfect Number function---------// 
    }
}
//      معمولا این روش رو روش کسری میگویند
//      یعنی عدد هایی‌ که قرار ک .م.م آنها را به دست بیاوریم در صورت کسر قرار گرفته و برهم ضرب میشوند و ب.م.م ان دو عدد در مخرج کسر قرار گرفته و بر صورت ان تقسیم میشود
//      ۱۶=(۳۲و۴۸)
//      ۱۵۳۶=۴۸×۳۲
//      ۹۶=۱۶÷۱۵۳۶
//      96=[32و۴۸]
//https://gama.ir/question/detail/17309/%D9%BE%DB%8C%D8%AF%D8%A7-%DA%A9%D8%B1%D8%AF%D9%86-%DA%A9%D9%85%D9%85-%D8%A8%D8%A7-%D8%A7%D8%B3%D8%AA%D9%81%D8%A7%D8%AF%D9%87-%D8%A7%D8%B2-%D8%A8%D9%85%D9%85