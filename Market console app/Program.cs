using Market_console_app.Enums;
using Market_console_app.Model;
using Market_console_app.Service;
using System;

namespace Market_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodlari istifade etmek ucun Marketable classindan yaradilmis m1 obyekti.
            Marketable m1 = new Marketable();


            string answer;
            string answer1;
            //Ic ice olan do while donguleri ve switch caselerle prosesin ise salinmasi.
            do
            {
                Console.WriteLine("\n-------------------------------------------\n");


                Console.WriteLine("1   - Mehsullar uzre emeliyyatlar:");
                Console.WriteLine("2   - Satis emeliyyatlari:");
                Console.WriteLine("3   - Sistemden cixis");

                Console.WriteLine("\n--------------------------------------------\n");
                answer = Console.ReadLine();

                do
                {
                    switch (answer)
                    {

                        case "1":
                            Console.WriteLine("\n--------------------------------------------\n");
                            Console.WriteLine("1.1-Yeni mehsul elave et:");
                            Console.WriteLine("1.2-Mehsul uzerinde duzelis et:");
                            Console.WriteLine("1.3-Mehsulu sil:");
                            Console.WriteLine("1.4-Butun mehsullari goster:");
                            Console.WriteLine("1.5-Categoriyasina gore mehsullari goster:");
                            Console.WriteLine("1.6-Qiymet araligina gore mehsullari goster: ");
                            Console.WriteLine("1.7-Mehsullar arasinda ada gore axtaris et: ");
                            Console.WriteLine("\n--------------------------------------------\n");
                            answer1 = Console.ReadLine();
                            switch (answer1)
                            {

                                case "1.1":
                                    AddProduct(m1);
                                    break;
                                case "1.2":
                                    EditProduct(m1);
                                    break;
                                case "1.3":
                                    RemoveProduct(m1);
                                    break;
                                case "1.4":
                                    ShowAllProducts(m1);
                                    break;
                                case "1.5":
                                    ReturnProductsforCategory(m1);
                                    break;
                                case "1.6":
                                    ReturnValueProducts(m1);
                                    break;
                                case "1.7":
                                    SearchProduct(m1);
                                    break;

                            }
                            break;
                        case "2":
                            Console.WriteLine("\n--------------------------------------------\n");
                            Console.WriteLine("2.1-Yeni satis elave etmek:");
                            Console.WriteLine("2.2-Satisdaki hansisa mehsulun geri qaytarilmasi:");
                            Console.WriteLine("2.3-Satisin silinmesi:");
                            Console.WriteLine("2.4-Butun satislarin ekrana cixarilmasi:");
                            Console.WriteLine("2.5-Verilen tarix araligina gore satislarin gosterilmesi :");
                            Console.WriteLine("2.6-Verilen mebleg araligina gore satislarin gosterilmesi: ");
                            Console.WriteLine("2.7-Verilmis bir tarixde olan satislarin gosterilmesi: ");
                            Console.WriteLine("2.8-Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi: ");
                            Console.WriteLine("\n--------------------------------------------\n");
                            answer1 = Console.ReadLine();
                            switch (answer1)
                            {

                                case "2.1":
                                    AddOrder(m1);
                                    break;
                                case "2.2":
                                    RemoveOrderItem(m1);
                                    break;
                                case "2.3":
                                    RemoveOrder(m1);
                                    break;
                                case "2.4":
                                    ShowOrders(m1);
                                    break;
                                case "2.5":
                                    ReturnAllOrdersforTime(m1);
                                    break;
                                case "2.6":
                                    ReturnValueOrders(m1);
                                    break;
                                case "2.7":
                                    ReturnOrdersforTime(m1);
                                    break;
                                case "2.8":
                                    ReturnNoOrder(m1);
                                    break;

                            }
                            break;
                    }



                } while (answer != "1");

            } while (answer != "3");


        }

        //Userden alinan mehsul nomresi ve sayina uygun olaraq satisin yaradilmasi.
        static void AddOrder(Marketable m1)
        {
            try
            {
                Console.WriteLine("Mehsulunun nomresin daxil et.");
                string orderitemno = Console.ReadLine();
                Console.WriteLine("Satis mehsulunun sayini daxil edin.");
                int orderitemcount = int.Parse(Console.ReadLine());
                m1.AddOrder(orderitemno, orderitemcount);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException();
            }
           
        }

        //Userden alinan mehsul kodu ve userin daxil etdiyi yeni koda uygun olaraq mehsulun kodunun deyisdirilmesi.
        static void EditProduct(Marketable m1)
        {
            Console.WriteLine("Mehsulunun kodunu daxil edin.");
            string productcode = Console.ReadLine();
            Console.WriteLine("Mehsulunun yeni kodunu daxil edin.");
            string newproductcode = Console.ReadLine();
            m1.EditProduct(productcode, newproductcode);
        }
        //User uygun mehsulun kodunu daxil ederek,istediyi mehsulu sile biler.
        static void RemoveProduct(Marketable m1)
        {
            Console.WriteLine("Silmek istediyiniz mehsulun kodunu daxil edin.");
            string productcode = Console.ReadLine();

            m1.RemoveProduct(productcode);


        }
        //Butun mehsullarin gosterilmesi.
        static void ShowAllProducts(Marketable m1)
        {
            Console.WriteLine("Sistemdeki butun mehsullar:");
            m1.ShowAllProducts();

        }

        //Userin daxil etdiyi kategoriyaya uygun olaraq mehsullarin gosterilmesi.
        static void ReturnProductsforCategory(Marketable m1)
        {
            Console.WriteLine("Gormek istediyiniz mehsullarin kategoriyasini daxil edin.");

            string C = Console.ReadLine();
            
           
            switch (C)
            {
                case "Whiskey":
                    m1.ReturnProducts(Category.Whiskey);
                    break;
                case "Beer":
                    m1.ReturnProducts(Category.Beer);
                    break;
                case "Vine":
                    m1.ReturnProducts(Category.Vine);
                    break;
                case "Champaigne":
                    m1.ReturnProducts(Category.Champaigne);
                    break;
                case "Vodka":
                    m1.ReturnProducts(Category.Vodka);
                    break;
                case "Cigarette":
                    m1.ReturnProducts(Category.Cigarette);
                    break;
                case "Energeticdrink":
                    m1.ReturnProducts(Category.Energeticdrink);
                    break;
                case "Water":
                    m1.ReturnProducts(Category.Water);
                    break;
                case "Chips":
                    m1.ReturnProducts(Category.Chips);
                    break;
               
            }
            



        }
        //User mehsulun adini,deyerini ve sayini daxil ederek sisteme yeni mehsul elave edir.
        static void AddProduct(Marketable m1)
        {
            try
            {
                Console.WriteLine("Productun adini daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("Productun qiymetini daxil edin");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("Productun sayini daxil edin");
                int productcount = int.Parse(Console.ReadLine());
              
                Console.WriteLine("Mehsulun kategoriyasini daxil edin.");



                string C = Console.ReadLine();


                switch (C)
                {
                    case "Whiskey":
                        m1.AddProduct(name, value, Category.Whiskey, productcount);
                        break;
                    case "Beer":
                        m1.AddProduct(name, value, Category.Beer, productcount);
                        break;
                    case "Vine":
                        m1.AddProduct(name, value, Category.Vine, productcount);
                        break;
                    case "Champaigne":
                        m1.AddProduct(name, value, Category.Champaigne, productcount);
                        break;
                    case "Vodka":
                        m1.AddProduct(name, value, Category.Vodka, productcount);
                        break;
                    case "Cigarette":
                        m1.AddProduct(name, value, Category.Cigarette, productcount);
                        break;
                    case "Energeticdrink":
                        m1.AddProduct(name, value, Category.Energeticdrink, productcount);
                        break;
                    case "Water":
                        m1.AddProduct(name, value, Category.Water, productcount);
                        break;
                    case "Chips":
                        m1.AddProduct(name, value, Category.Chips, productcount);
                        break;
                }
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Value double,productcount int olmalidir.");
            }
          

            }
        //Ada uygun olaraq mehsulun axtarilmasi.
            static void SearchProduct(Marketable m1)
             {
             Console.WriteLine("Axtardiginiz mehsulun adini qeyd edin.");
             string productname = Console.ReadLine();
              m1.SearchProducts(productname);
             }
        //Satis mehsulunun silinmesi.
        static void RemoveOrderItem(Marketable m1)
        {
  
            try
            {
               
                Console.WriteLine("Satisdan cixarmaq istediyiniz mehsulun nomresini qeyd edin. ");
                int orderitemno = int.Parse(Console.ReadLine());
                Console.WriteLine("Satisdan cixarmaq istediyiniz mehsulun sayini daxil edin. ");
                int orderitemcount = int.Parse(Console.ReadLine());
                m1.RemoveOrderItem(orderitemno, orderitemcount);

            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Xahis olunur int deyer yollayin.");
            }

            
        }
        //Satisin silinmesi.
        static void RemoveOrder(Marketable m1)
        {
            Console.WriteLine("Silmek istediyiniz satisin  nomresini qeyd edin. ");
            string orderno = (Console.ReadLine());
            m1.RemoveOrder(orderno);

        }
        //Satislarin gosterilmesi.
        static void ShowOrders(Marketable m1)
        {
            foreach (Order order in m1.Orders)
            {
                Console.WriteLine($"Satis nomresi:{order.OrderNo},Satis deyeri:{order.Value},Satis mehsulunun sayi:{order.OrderItems.OrderItemCount},Satis vaxti:{order.OrderTime}");
            }
                



            
        }
        //Verilmis zaman araliginda mehsullarin list formasinda gosterilmesi.
        static void ReturnAllOrdersforTime(Marketable m1)
        {
            Console.WriteLine("Axtardiginiz satislarin baslangic tarixini qeyd edin.Gun,ay,il formatinda misal ucun: (13.12.2012)");
            string ordertime = Console.ReadLine();
            Console.WriteLine("Axtardiginiz satislarin bitis tarixini qeyd edin.Gun,ay,il formatinda misal ucun: (13.12.2020)");
            string ordertime2 = Console.ReadLine();

            m1.ReturnAllOrdersforTime(ordertime, ordertime2);
        }

        //Verilmis qiymet araligina uygun olaraq mehsullarin list formasinda gosterilmesi.
        static void ReturnValueOrders(Marketable m1)
        {
            try
            {
                Console.WriteLine("Qiymet araliginin baslangicini qeyd edin.");
                double value1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Qiymet araliginin sonunu qeyd edin.");
                double value2 = double.Parse(Console.ReadLine());
                m1.ReturnValueOrders(value1, value2);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Xahis olunur double deyer yollayin.");
            }
          
        }
        //Daxil edilmis bir tarixe gore satislarin list formasinda qaytarilmasi.
        static void ReturnOrdersforTime(Marketable m1)
        {
            Console.WriteLine("Axtardiginiz satislarin tarixini qeyd edin.");
           string ordertime = Console.ReadLine();
            m1.ReturnOrdersforTime(ordertime);
        }

        //Satis nomresine gore mehsul haqqinda melumatin gosterilmesi.
        static void ReturnNoOrder(Marketable m1)
        {
            Console.WriteLine("Satis melumatlarini gormek ucun satis nomresini qeyd edin.");
            string orderno = Console.ReadLine();
            m1.ReturnNoOrder(orderno);
        }
        //Qiymet araligina uygun olaraq satislar haqqinda melumatin gosterilmesi.
        static void ReturnValueProducts(Marketable m1)
        {
            try
            {
                Console.WriteLine("Baslangic araligini daxil edin.");
                double start = double.Parse(Console.ReadLine());
                Console.WriteLine("Bitis araligini daxil edin.");
                double end = double.Parse(Console.ReadLine());
                m1.ReturnValueProducts(start, end);

            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Daxil edilen deyer double typeinda olmalidir>");
            }
           
        }


    }




    } 
    
 


            

        

