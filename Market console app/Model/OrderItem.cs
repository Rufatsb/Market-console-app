using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_console_app.Model
{
    class OrderItem
    {
        public int OrderItemNo { get; set; }
        public string OrderItemName { get; set; }
        public int OrderItemCount { get; set; }

        public static int Count = 1000;

        public OrderItem(string orderitemname, int orderitemcount)
        {
            Count++;
            OrderItemNo = Count;
            OrderItemName = orderitemname;
            OrderItemCount = orderitemcount;

        }
        public OrderItem(int orderitemno,int orderitemcount)
        {
            OrderItemNo = orderitemno;
            OrderItemCount = orderitemcount;
        }

        public override string ToString()
        {
            return $"{OrderItemNo} {OrderItemName} ";
        }
    }
}
