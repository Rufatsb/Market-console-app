
using Market_console_app.Enums;
using Market_console_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_console_app.Interface
{
    interface IMarketable
    {
        List<Order> Orders { get; set; }
        List<OrderItem> OrderItem{ get; set; }

        void AddOrder(int orderitemno, int orderitemcount);
        OrderItem ReturnOrderItem(int orderitemno);
        Order ReturnOrder(string orderno, OrderItem orderitem);
        List<Order> ReturnAllOrders (string ordertime,string ordertime2);
        List<Order> ReturnOrders(string ordertime);
        List<Order> ReturnValueOrders(double value);
        Order ReturnNoOrder(string orderno);
        void AddProduct(string productname, double productvalue, Category productcategory, int productcount);
        void EditProduct(string productcode);
        List<Product> ReturnProducts(Category category);
        List<Product> ReturnValueProducts(double value1, double value2);
        List<Product> SearchProducts(string productname);

    }
}
