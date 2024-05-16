using System;

namespace myFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                string operatorName;
                int size;
                string color;
                string brandName;
                string category;
                decimal price;
                int count;

                #region Operator name validaiton

                while (true)
                {
                    Console.Write("Operator's name : ");
                    operatorName = Console.ReadLine();

                    if (operatorName.Length >= 3 && operatorName.Length <= 15)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Color validation

                while (true)
                {
                    Console.Write("Color : ");
                    color = Console.ReadLine();

                    if (color == "Red" || color == "Black" || color == "Blue")
                        break;
                    else
                        Console.WriteLine("Color dugun daxil edilmeyib");
                }

                #endregion

                #region Brand validation
                while (true)
                {
                    Console.Write("Brand name : ");
                    brandName = Console.ReadLine();

                    if (brandName == "Nike" || brandName == "Sketchers" || brandName == "Addidas")
                        break;
                    else
                        Console.WriteLine("Brand dugun daxil edilmeyib");
                }
                #endregion

                #region Category validation
                while (true)
                {
                    Console.Write("Category : ");
                    category = Console.ReadLine(); //Short cut to replace all : Ctrl + RR

                    if (category.Length < 25)
                        break;
                    else
                        Console.WriteLine("Category dugun daxil edilmeyib");
                }
                #endregion

                #region Price validation
                while (true)
                {
                    Console.Write("Price : ");
                    price = decimal.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR

                    if (price > 0)
                        break;
                    else
                        Console.WriteLine("Price dugun daxil edilmeyib");
                }
                #endregion

                #region Count validation
                while (true)
                {
                    Console.Write("Count : ");
                    count = int.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR

                    if (count > 0 && count <= 100)
                        break;
                    else Console.WriteLine("Count dugun daxil edilmeyib");

                }
                #endregion

                decimal individualTotal = count * price;
                resultTotal = resultTotal + individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                Console.WriteLine("Yeni ayaqqabi elave olunsumu? (Yes, No) (Y, N) ");
                string loopTerminationResult = Console.ReadLine();

                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                {
                    //break based loop control
                    break;

                }
            }


            Console.WriteLine("Result Total : " + resultTotal);

        }
    }
}