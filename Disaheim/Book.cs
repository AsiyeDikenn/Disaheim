using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        //backing fields
        private string _itemId;
        private string _title;
        private double _price;

        //properties
        public string ItemId 

        { 
            get { return _itemId; }
            set { _itemId = value;}
        }

        public string Title 
        { 
            get { return _title; }
            set { _title = value;}
        }

        public double Price
        { 
            get { return _price; }
            set { _price = value;}

        }

        // Constructors
        public Book (string _itemId) 
        {
           ItemId = _itemId;
        }

        public Book (string _itemId, string _title) 
        {
           ItemId = _itemId;
           Title = _title;
        }

        public Book(string _itemId, string _title, double _price)

        {
           ItemId = _itemId;
           Title = _title;
           Price = _price; 
        }

        //override ToString()
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }

    
}
