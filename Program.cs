namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mohammed Reda Gaber Farg 
            List<int> numbers = new List<int> { 50, 40, 20, 70, 10, 60, 30, 100, 90, 80 };
            List<int> numberscoype = new List<int>(numbers) { };
            Console.WriteLine("\t\t\tWelcome to Every Body!!Plaese, Choose from the following List\n\n");
            while (true)
            {

                Console.WriteLine("\t ---------------------------");
                Console.WriteLine("\t P - Print numbers");
                Console.WriteLine("\t A - Add a number");
                Console.WriteLine("\t M - Display mean of the numbers");
                Console.WriteLine("\t S - Display the smallest number");
                Console.WriteLine("\t L - Display the largest number");
                Console.WriteLine("\t T - Display Sort List");
                Console.WriteLine("\t F - Display Search number in the List");
                Console.WriteLine("\t C - Copy list in another List");
                Console.WriteLine("\t PC - Print the list is coped");
                Console.WriteLine("\t Q - Quit");
                Console.WriteLine("\t ---------------------------");
                Console.Write("\tEnter your choice: ");
                string choose = Console.ReadLine();
                if (choose == "q" || choose == "Q")
                {
                    Console.WriteLine("\tGoodbye!!");
                    break;
                    // or return;
                }

                if (numbers.Count == 0 && choose != "A" && choose != "a")
                {
                    if (choose == "P" || choose == "p")
                    {
                        Console.WriteLine("  [] - The List is Empty");
                        continue;
                    }
                    else if (choose == "M" || choose == "m")
                    {
                        Console.WriteLine("  Unable to determine the Avarage - The List is Empty");
                        continue;

                    }
                    else if (choose == "S" || choose == "s")
                    {
                        Console.WriteLine("  Unable to determine the Smallest Number - The List is Empty");
                        continue;

                    }
                    else if (choose == "L" || choose == "l")
                    {
                        Console.WriteLine("  Unable to determine the Largest Number - The List is Empty");
                        continue;

                    }
                }

                switch (choose)
                {
                    case "P":
                    case "p":
                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        Console.Write("[");
                        for (int i = 0; i < numbers.Count; i++)
                        {

                            Console.Write(numbers[i]);
                            Console.Write(" ");

                        }
                        Console.WriteLine("]");
                        break;
                    case "A":
                    case "a":

                        Console.Write("  Please Enter num,you want to Add: ");
                        // Duplicated List
                        int add = int.Parse(Console.ReadLine());
                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        int flag = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (!(numbers[i] == add))
                            {
                                flag = 1;
                            }
                            else { flag = 0; }

                        }
                        if (flag == 1)
                        {
                            numbers.Add(add);
                            Console.WriteLine("  The number Added");
                        }
                        else
                        {
                            Console.WriteLine($"  The number '{add}' is arleady in the list");
                        }
                        // طريقه ثانيه
                        //if (!numbers.Contains(add))
                        //{
                        //    numbers.Add(add);
                        //    Console.WriteLine("  The number Added");
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"  The number '{add}' is arleady in the list");
                        //}

                        break;
                    case "M":
                    case "m":
                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {

                            sum += numbers[i];

                        }
                        double Avg = sum / numbers.Count;
                        Console.WriteLine($"   Avarage= {Avg}");
                        break;
                    case "S":
                    case "s":
                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        int min = 655436; //قيمة كبيره علشان اقدر اقارن بيها
                        int Indexmin = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < min)
                            {
                                min = numbers[i];
                                Indexmin = i;

                            }
                        }
                        Console.WriteLine($"  The Smallest number is '{min}' and find in Index '{Indexmin}'");
                        break;
                    case "L":
                    case "l":
                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        int max = 0;
                        int Indexmax = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > max)
                            {
                                max = numbers[i];
                                Indexmax = i;

                            }
                        }
                        Console.WriteLine($"  The Largest number is '{max}' and find in Index '{Indexmax}'");
                        break;
                    case "T":
                    case "t":
                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            int temp = 0;
                            for (int j = 0; j < numbers.Count - 1 - i; j++)
                            {
                                if (numbers[j] > numbers[j + 1])
                                {
                                    temp = numbers[j];
                                    numbers[j] = numbers[j + 1];
                                    numbers[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("  The List Sorted!!!");
                        break;
                    case "F":
                    case "f":
                        int flag1 = 0;
                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        Console.Write("  Please Enter number you want to search for: ");
                        int num = int.Parse(Console.ReadLine());
                        
                        for (int i = 0; i < numbers.Count; i++)
                            
                        {
                            
                            if (num == numbers[i])
                            {
                                Console.WriteLine($"  The number'{num}' find in Index'{i}'");
                                flag1 = 0;
                                break;

                            }
                            else
                            {
                                flag1 = 1;
                            }
                        }


                        if (flag1 == 1)
                        {
                            Console.WriteLine($"  The number'{num}'didn't find in the List");
                            flag = 0;

                        }

                        break;
                    case "C":
                    case "c":

                        Console.Write("    Please wait");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numberscoype[i] = numbers[i];
                        }
                        //طريقه تانيه
                        //numberscoype.AddRange(numbers);
                        break;
                    case "PC":
                    case "pc":
                        Console.Write("    Please wait");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");
                        Console.Write($"  listCopy:[");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write($" {numberscoype[i]}");
                        }
                        Console.WriteLine("]");
                        break;
                    default:
                        Console.Write("    Please wait");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(200);
                        }

                        Console.WriteLine("");

                        Console.WriteLine("  Wrong Choice,Tye Again....");
                        break;

                }



            }
        }
    }
}

  