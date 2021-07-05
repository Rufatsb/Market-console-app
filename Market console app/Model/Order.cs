using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Market_console_app.Model
{
    class Order
    {
        public string OrderNo { get; set; }
        public double Value { get; set; }
        public OrderItem  OrderItems { get; set; }
        public string OrderTime { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        private static int _Count = 1000;



        public Order(double value,OrderItem orderitem,string orderno,string ordertime)
        {
            OrderItems = orderitem;
            OrderNo = (OrderItems.OrderItemNo + _Count).ToString();
            OrderTime = ordertime;
            ordertime = (Day + Month + Year).ToString();
            Value = value;
            OrderNo = orderno;


        }
        public Order(string productcode, int productcount)
        {

        }

        public override string ToString()
        {
            return $"{OrderItems} {Value} {OrderTime} {OrderNo}";
        }

    }
}
