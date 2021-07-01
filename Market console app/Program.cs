using Market_console_app.Model;
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
            string answer1;

            do
            {
                Console.WriteLine("\n-------------------------------------------\n");


                Console.WriteLine("1   - Use Products Operations");
                Console.WriteLine("2   - Use Order Oper=ations");
                Console.WriteLine("3   - Exit");

                Console.WriteLine("\n Use appropriate choice. :");
                answer = Console.ReadLine();

                do
                {
                    switch (answer)
                    {
                        case "1":
                            Console.WriteLine("1.1-Yeni mehsul elave et - userden yeni mehsul yaradilmasi ucun lazim olan melumatlari daxil edilmelidir");
                            Console.WriteLine("1.2-Mehsul uzerinde duzelis et -  duzelis edilecek mehsulun code-u ve duzelis melumatlari daxil edilmelidir");
                            Console.WriteLine("1.3- Mehsulu sil - mehsulu kodu daxil edilmelidir");
                            Console.WriteLine("1.4-Butun mehsullari goster - butun mehsullar gosterilecek (kodu,adi,categoriyasi,sayi,qiymeti)");
                            Console.WriteLine("1.5-Categoriyasina gore mehsullari goster - usere var olan kateqoriyalar gosteilecek ve onlar arasinda bir secim etmelidir ve secilmis kateqoriyadan olan butun mehsullar gosterilir (kodu,adi,categoriyasi,sayi,qiymeti)");
                            Console.WriteLine("1.6-Qiymet araligina gore mehsullari goster - userden minmum ve maximum qiymetleri daxil etmesi istenilir ve hemin qiymet araliginda olan mehsullar gosterilir (kodu, adi,categoriyasi,sayi,qiymeti)");
                            Console.WriteLine("1.7-Mehsullar arasinda ada gore axtaris et - useden text daxil etmesi istenilir ve adinda hemin text olan butun mehsullar gosterilir (kodu, adi,categoriyasi,sayi,qiymeti)");
                            answer1 = Console.ReadLine();
                            switch (answer1)
                            {

                                case "1.1":
                                    AddOrder(m1);
                                    break;
                                case "1.2":
                                    EditProduct(m1);
                                    break;
                                case "1.3":
                                    RemoveProduct(m1);
                                    break;
                            }
                            break;
                    }



                } while (answer != "1");

            } while (answer != "3");

           
        }
        static void AddOrder(Marketable m1)
        {
            Console.WriteLine("Satis mehsulunun nomresin daxil et.");
           int  orderitemno = int.Parse(Console.ReadLine());
            Console.WriteLine("Satis mehsulunun sayini daxil edin.");
            int orderitemcount = int.Parse(Console.ReadLine());
            m1.AddOrder(orderitemno, orderitemcount);
        }
        static void EditProduct(Marketable m1)
        {
            Console.WriteLine("Mehsulunun kodunu daxil edin.");
            string  productcode = Console.ReadLine();
            Console.WriteLine("Mehsulunun yeni kodunu daxil edin.");
            string newproductcode = Console.ReadLine();
            m1.EditProduct( productcode,  newproductcode);
        }

        static void RemoveProduct(Marketable m1)
        {
            Console.WriteLine("Silmek istediyiniz mehsulun adini daxil edin.");
           string productcode = Console.ReadLine();

            m1.RemoveProduct(productcode);


        }
        static void ShowAllProducts()
        {

        }
    }
}
              


            

        

