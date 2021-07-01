using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_console_app.Model
{
    class Order
    {
        public string OrderNo { get; set; }
        public double Value { get; set; }
        public OrderItem  OrderItems { get; set; }
        public string OrderTime { get; set; }
        private static int _Count = 1000;



        public Order(double value,OrderItem orderitem,string ordertime)
        {
            OrderItems = orderitem;
            OrderNo = (OrderItems.OrderItemNo + _Count).ToString();
        }

        public Order(OrderItem orderitem)
        {
            OrderItems = orderitem;
        }
     
                  
    }
}
