using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
       

        // Properties
        public string ItemId { get;  set; } 
        
        public Level Quality { get; set; } = Level.Medium; 
        public string Design { get; set; } = "";

        // Constructors
        public Amulet (string _itemId) 
        {
            ItemId = _itemId;
        }
        
        public Amulet (string _itemId, Level quality) 

        {
            ItemId = _itemId;
            Quality = quality;

            //“Gemmer enum-værdien quality som tekst i property’en Level”.

        }

        public Amulet (string _itemId, Level quality, string _design) 
        {
            ItemId = _itemId;
            Quality = quality;
            Design = _design;
           
        }

        public override string ToString() // Override ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
