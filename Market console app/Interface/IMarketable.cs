
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
        List<OrderItem> OrderItems{ get; set; }

        void AddOrder(string productcode, int productcount);
        Product RemoveOrderItem(int orderitemno,int orderitemcount);
        void RemoveOrder(string orderno);
        List<Order> ReturnAllOrdersforTime (string ordertime,string ordertime2);
        List<Order> ReturnOrdersforTime(string ordertime);
        List<Order> ReturnValueOrders(double value1,double value2);
        void ReturnNoOrder(string orderno);
        void AddProduct(string productname, double productvalue, Category productcategory, int productcount);
        void EditProduct(string productcode, string newproductcode);
        void ReturnProducts(Category category);
        void ReturnValueProducts(double value1, double value2);
        void SearchProducts(string productname);

    }
}
