using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ProductProject
{
    class Product
    {
        private string _name = "";
        private double _price;
        private DateTime _orginalexpirationDate;
       
        public Product(string name, int numday, double price = 100)//defult 100 
        {
            
            SetName(name);
            SetPrice(price);
            SetWarrantyExpirationDate(numday);
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName(string name)
        {
            return _name;
        }
        public void SetPrice(double price)
        {
            if (price > 0)
            {
                _price = price;
            }
        }
        public double GetPrice()
        {
            return _price;
        }
       
        public void SetWarrantyExpirationDate(int numDays)
        {
            if (numDays >= 0)
            {
                _orginalexpirationDate = DateTime.Now.AddDays(numDays);
            }
        }
        public string GetFormattedWarrantyExpirationDate()
        {
            return $"Warranty expiration date: {_orginalexpirationDate.ToString("dd/MM/yyyy")}";
        }
        public DateTime GetWarrantyExpirationDate()
        {
            return _orginalexpirationDate;
        }      
        public override string ToString( )
        {
            double numDays = (int)(_orginalexpirationDate - DateTime.Now).TotalDays;// the exp date- the date time now 
            DateTime updatedDate = DateTime.Now.AddDays(numDays);// update the date to the update days 
            int daysLeft = (int)(_orginalexpirationDate - updatedDate).TotalDays;
            DateTime dt = DateTime.Now;// Globalization
            string theDate = $"{dt:F}";
            int days = (int)(_orginalexpirationDate - DateTime.Now).TotalDays;// the days left like the date left 
            return $"product : {_name}\nprice : {_price}\nthe day today: {(theDate)}\nthe exp date is {(updatedDate)} (left {days} days)";
        }              
    }
}
