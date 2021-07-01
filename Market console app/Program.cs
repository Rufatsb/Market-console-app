using Market_console_app.Service;
using System;

namespace Market_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Marketable m1 = new Marketable();
            

            string answer;

            do
            {
                Console.WriteLine("\n-------------------------------------------\n");


                Console.WriteLine("1.1 - Departamentlerin siyahisini gostermek");
                Console.WriteLine("1.2 - Yeni Department yaratmaq");
                Console.WriteLine("1.3 - Departament uzerinde deyisiklik etmek");
                Console.WriteLine("2.1 - Iscinin sisteme elave olunmasi. ");
                Console.WriteLine("2.2 - Iscinin sistemden silinmesi.");
                Console.WriteLine("2.3 - Isci uzerinde deyisiklik etmek.");
                Console.WriteLine("2.4 - Butun iscilerin siyahisini gostermek.");
                Console.WriteLine("2.5 - Departamentdeki iscilerin siyahisini gostermek.");
                Console.WriteLine("3   - Cixis");

                Console.WriteLine("\nIcra etmek istediyiniz emeliyyati secin:");
                answer = Console.ReadLine();


                Console.WriteLine("\n-------------------------------------------\n");


                switch (answer)
                {
                    case "1.1":
                        AddOrder(m1);
                        break;
                    case "1.2":
                        AddOrder(m1);
                        break;
                    case "1.3":
                        AddOrder(m1);
                        break;
                    case "2.1":
                        AddOrder(m1);
                        break;
                    case "2.2":
                        AddOrder(m1); 
                        break;
                    case "2.3":
                        AddOrder(m1);
                        break;
                    case "2.4":
                        AddOrder(m1);
                        break;
                    case "2.5":
                        AddOrder(m1);
                        break;
                    default:
                        if (answer != "3")
                        {
                            Console.WriteLine("Zehmet olmasa duzgun deyer daxil edin");
                        }
                        break;

                }

            } while (answer != "3");
        }

        static void AddOrder(Marketable m1)
        {
            Console.WriteLine("Deyerleri sox icine");
            int orderitemno = int.Parse(Console.ReadLine());
            int orderitemcount = int.Parse(Console.ReadLine());
            m1.AddOrder(orderitemno, orderitemcount);
        }
      
        }
    }

