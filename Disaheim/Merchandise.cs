using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    //En abstrakt klasse kan godt have en constructor, fordi subklasser (fx Book og Amulet) kan kalde den med base(...).
    //Altså: Book bruger Merchandise’s constructor, selvom man ikke kan lave Merchandise selv.
    public abstract class Merchandise
    {
        private string _itemId; // Backing field

        public string ItemId // Property
        { 
            get { return _itemId; } 
            set { _itemId = value;}
        }

       

        public override string ToString() // Override ToString() // Abstract class kan godt have en ToString() metode
        {
            return $"ItemId: {ItemId}"; 
        }


    }
}
