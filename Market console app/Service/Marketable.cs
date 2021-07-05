using Market_console_app.Enums;
using Market_console_app.Interface;
using Market_console_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_console_app.Service
{
    class Marketable : IMarketable
    {
        public List<Order> Orders { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<Product> Products { get; set; }
        public Marketable()
        {
            Orders = new List<Order>();
            Products = new List<Product>();
            OrderItems = new List<OrderItem>();

        }

        //Satis elave etmek ucun olan metod.
        public void AddOrder(string productcode, int productcount)
        {


            Product product = Products.Find(s => s.ProductCode == productcode && productcount<=s.ProductCount );
            if (product!= null)
            {
                Order order = new Order(productcode, productcount);
                Orders.Add(order);
            }
            else
            {
                Console.WriteLine("Duzgun mehsul kodu ve ya sayi  daxil edin.");
            }


        }
        //Satis mehsulunun geri qaytarilmasi
        public  Product  RemoveOrderItem(int orderitemno,int orderitemcount)
        {

             OrderItem Removeitem = OrderItems.Find(s => s.OrderItemNo == orderitemno&& s.OrderItemCount == orderitemcount);
            
                OrderItems.Remove(Removeitem);
                Product product = new Product(Removeitem.OrderItemName);

                Products.Add(product);

                return product;

            




        }
        //Satisin silinmesi.
        public void RemoveOrder(string orderno)
        {
            Order RemoveOrder = Orders.Find(s => s.OrderNo == orderno);
            if (RemoveOrder!=null)
            {
               
                Orders.Remove(RemoveOrder);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        //Iki tarix arasinda bas veren satislar.
        public List<Order> ReturnAllOrdersforTime(string ordertime, string ordertime2)
        {
            int day = 0;
            int month = 0;
            int year = 0;
            int day2 = 0;
            int month2= 0;
            int year2= 0;

            ordertime = (day + month + year).ToString();
            ordertime2 = (day2 + month2 + year2).ToString();
            List<Order> AllOrders = new List<Order>();
            foreach (Order order in Orders)
            {
                if (year <= order.Year && order.Year <= year2 && month <= order.Month && order.Month <= month2 && day < order.Day && order.Day < day2)
                {
                    AllOrders.Add(order);
                }
                else
                {
                    Console.WriteLine("Duzgun satis araligi daxil edin.");
                    
                }
                
            }
            return AllOrders;
        }
        //Bir tarix erzinde bas veren satislar.
        public List<Order> ReturnOrdersforTime(string ordertime)
        {
           
            List<Order> ReturnOrders = Orders.FindAll(s => s.OrderTime == ordertime);
            if (ReturnOrders != null)
            {
                return ReturnOrders;
            }
            else
            {
                Console.WriteLine("Duzgun tarix daxil edin");
            }

            return ReturnOrders;
        }
        //Qiymet araligina gore satislar.
        public List<Order> ReturnValueOrders(double value,double value2)
        {
            List<Order> ReturnValueOrders = Orders.FindAll(s => value <= s.Value && s.Value <= value2);
            if (ReturnValueOrders != null)
            {
                return ReturnValueOrders;
            }
            else
            {
                Console.WriteLine("Duzgun deyer daxil edin");
            }

            return ReturnValueOrders;
        }
        //Satis nomresine gore Satis haqqinda melumatin gosterilmesi.
        public void ReturnNoOrder(string orderno)
        {
            Order ReturnNoOrder = Orders.Find(s => s.OrderNo == orderno);
            if (ReturnNoOrder != null)
            {
                Console.WriteLine($"Satis nomresi:{ReturnNoOrder.OrderNo},Satis meblegi: {ReturnNoOrder.Value}, Mehsul sayi: {ReturnNoOrder.OrderItems.OrderItemCount}, Satis tarixi {ReturnNoOrder.OrderTime},Satis mehsullarinin nomresi:{ReturnNoOrder.OrderItems.OrderItemNo},Satis mehsullarinin adi:{ReturnNoOrder.OrderItems.OrderItemName},Satis mehsullarinin sayi:{ReturnNoOrder.OrderItems.OrderItemCount}");
            }
            else
            {
                Console.WriteLine("Duzgun orderno daxil edin");
            }

            
        }
        //Mehsul elave etmek
        public void AddProduct(string productname, double productvalue, Category productcategory, int productcount)
        {
            Product product = new Product(productname, productvalue, productcategory, productcount);
           
                Products.Add(product);
            
           



        }
        //Mehsul uzerinde duzelis.Mehsulun kodunu deyismek
        public void EditProduct(string productcode, string newproductcode)
        {
            Product product = Products.Find(s => s.ProductCode == productcode);
            if (product.ProductCode == productcode)
            {
                productcode = newproductcode;
            }
            else
            {
                throw new NullReferenceException();
            }


        }
        //Categoriyaya uygun olaraq,hemin categoriyadaki mehsullar haqqinda melumat.
        public void ReturnProducts(Category category)
        {
            List<Product> ReturnProducts =Products.FindAll(s => s.ProductCategory == category);
            if (ReturnProducts.Count>0)
            {
                foreach (Product product in ReturnProducts)
                {
                    Console.WriteLine($"Mehsulun kodu:{product.ProductCode}, Mehsulun adi:{product.ProductName}, Mehsulun kategoriyasi:{product.ProductCategory},Mehsulun sayi:{product.ProductCount},Mehsulun qiymeti:{product.ProductValue}");
                }
            }
           
            else
            {
                throw new NullReferenceException();
            }

        }
        //Iki qiymet arasinda olan mehsullar haqqinda melumat.
        public void ReturnValueProducts(double value1, double value2)
        {
            List<Product> ReturnValueProducts = Products.FindAll(s => s.ProductValue >= value1 && s.ProductValue <= value2);
            if (ReturnValueProducts.Count > 0)
            {
                foreach (Product product in ReturnValueProducts)
                {
                    Console.WriteLine($"Mehsulun kodu:{product.ProductCode}, Mehsulun adi:{product.ProductName}, Mehsulun kategoriyasi:{product.ProductCategory},Mehsulun sayi:{product.ProductCount},Mehsulun qiymeti:{product.ProductValue}");
                }
            }

            else
            {
                throw new NullReferenceException();
            }
        }
        //Mehsulun adina uygun olaraq axtarilmasi.
        public void SearchProducts(string productname)
        {
            List<Product> SearchProducts = Products.FindAll(s => s.ProductName==productname);
           
                foreach (Product product in SearchProducts)
                {
                if (SearchProducts.Count > 0)
                {
                    Console.WriteLine($"Mehsulun kodu:{product.ProductCode}, Mehsulun adi:{product.ProductName}, Mehsulun kategoriyasi:{product.ProductCategory},Mehsulun sayi:{product.ProductCount},Mehsulun qiymeti:{product.ProductValue}");
                }
                else
                {
                    Console.WriteLine("Axtarisa dogru ad daxil edin.");
                }
                }
           

        }

       


        //Additional Methods

        //Mehsulun silinmesi.
        public void RemoveProduct(string productcode)
        {
            Product removeproduct = Products.Find(x => x.ProductCode == productcode);
            if ( removeproduct != null)
            {
                Products.Remove(removeproduct);
                
            }
            else
            {
                throw new NullReferenceException();
            }



        }
       

        //Butun mehsullarin gosterilmesi
        public void ShowAllProducts()
        {
            foreach (Product product in Products)
                if (Products.Count > 0)
                {
                    Console.WriteLine($"Mehsulun nomresi:{product.ProductCode} Mehsulun adi: {product.ProductName} Mehsulun aid oldugu kategoriya:{product.ProductCategory} Mehsulun sayi:  {product.ProductCount}  Mehsulun qiymeti:{product.ProductValue} ");
                }
                else
                {
                    Console.WriteLine("Hec bir mehsul tapilmadi.");
                }
        }


    }
}
