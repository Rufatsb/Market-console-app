using Market_console_app.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_console_app.Model
{
    class Product
    {
       public string ProductName { get; set; }
       public double ProductValue { get; set; }
       public Category ProductCategory { get; set; }
       public int ProductCount { get; set; }
       public string ProductCode { get; set; }
       private static int _Count =1000;

       
       


        public Product(string productname,double productvalue,Category productcategory,int productcount)
        {
            ProductName = productname;
            ProductValue = productvalue;
            ProductCategory = productcategory;
            ProductCount = productcount;
           


            ProductCode = productname.Substring(0, 2).Trim() + _Count.ToString();

           



        }

        public override string ToString()
        {
            return $"{ ProductName} { ProductValue } {ProductCategory} {ProductCount}";
        }

    }
}
