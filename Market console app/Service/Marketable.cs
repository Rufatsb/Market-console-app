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
        public List<Order> Orders { get ; set ; }
        public List<OrderItem> OrderItem { get ; set ; }
        List<Product> Products { get; set; }
        public Marketable()
        {
            Orders = new List<Order>();
            Products = new List<Product>();

            
        }


        public void AddOrder(int orderitemno, int orderitemcount)
        {
            

            var orderItem = OrderItem.Find(s => s.OrderItemNo == orderitemno && s.OrderItemCount == orderitemcount);
            if (orderitemno <= 0 || orderitemcount <= 0)
            {
                throw new ArgumentNullException("sellitem not found");
            }
            else
            {
                Order order = new Order(orderItem);
                Orders.Add(order);
            }
               
            
        }

        public OrderItem ReturnOrderItem(int orderitemno)
        {
            throw new NotImplementedException();
        }

        public Order ReturnOrder(string orderno, OrderItem orderitem)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnAllOrders(string ordertime, string ordertime2)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrders(string ordertime)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnValueOrders(double value)
        {
            throw new NotImplementedException();
        }

        public Order ReturnNoOrder(string orderno)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(string productname, double productvalue, Category productcategory, int productcount)
        {
            Product whiskey = new Product(productname, productvalue, productcategory, productcount);
            Products.Add(whiskey);


            
        }

        public void EditProduct(string productcode,string newproductcode)
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

        public List<Product> ReturnProducts(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnValueProducts(double value1, double value2)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProducts(string productname)
        {
            throw new NotImplementedException();
        }

        //Additional Methods

        public void RemoveProduct(string productcode)
        {
             foreach (Product item in Products)
                
                if (item.ProductCode == productcode)
                {
                    Products.Remove(item);
                }

                   
                
            
               
            

          

        }
    }
}
