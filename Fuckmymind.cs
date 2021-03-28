using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int box1, box2, box3, number, amount;
            int left1, left2, left3;


            box1 = int.Parse(Console.ReadLine());
            box2 = int.Parse(Console.ReadLine());
            box3 = int.Parse(Console.ReadLine());
            for (int x = 1; ;)
            {
                left1 = box1;
                left2 = box2;
                left3 = box3;
                if (x % 2 == 1)
                {

                    Console.WriteLine("Mr.A turn");
                    Console.WriteLine("Choose Box1,2,3");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine("amount to pick");
                    amount = int.Parse(Console.ReadLine());
                    if (amount > 0 && amount < 3)
                    {
                        if (number == 1 )
                        {
                            box1 = box1 - amount;
                        
                        }
                      else if(number == 2)
                        {
                            box2 = box2 - amount;
                        }
                        else if(number == 3)
                        {
                            box3 = box3 - amount;
                        }

                    }
                    left1 = box1;
                    left2 = box2;
                    left3 = box3;
                    if (left1 == 0 && left2 == 0 && left3 == 0)
                    {
                        Console.WriteLine("Mr.B win");
                        break;
                    }
                    Console.WriteLine("{0},{1},{2}", box1, box2, box3);
                    x++;

                }
                else if (x % 2 == 0)
                {

                    Console.WriteLine("Mr.B turn");
                    Console.WriteLine("Choose Box1,2,3");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine("amount to pick");
                    amount = int.Parse(Console.ReadLine());
                    if (amount > 0 && amount < 3)
                    {
                        if (number == 1)
                        {
                            box1 = box1 - amount;

                        }
                         else if (number == 2)
                        {
                            box2 = box2 - amount;
                        }
                        else if (number == 3)
                        {
                            box3 = box3 - amount;
                        }

                    }
                    left1 = box1;
                    left2 = box2;
                    left3 = box3;
                    if (left1 == 0 && left2 == 0 && left3 == 0)
                    {
                        Console.WriteLine("Mr.A win");
                        break;
                    }
                    Console.WriteLine("{0},{1},{2}", box1, box2, box3);
                    x++;
                }
                



            }
        }
    }
}
