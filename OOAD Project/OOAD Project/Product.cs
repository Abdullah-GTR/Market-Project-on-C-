using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project
{
    class Product
    {
        int ProductID;
        string ProductName;
        int ProductQuantity;
        int ProductPrice;

        
        public Product(int productID,string productName,int productQuantity, int productPrice)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductQuantity = productQuantity;
        }
    }
}