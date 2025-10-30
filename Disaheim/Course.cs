using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        // Backing fields
        private string _name;
        private int _durationInMinutes;

        // Properties
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set { _durationInMinutes = value; }
        }

        // Constructors
        public Course(string _name)
        {
            Name = _name;
            DurationInMinutes = 0; // Default duration
            // When only name is provided, duration is set to 0 
        }
        public Course(string _name, int _durationInMinutes)
            : this(_name)
        {
            DurationInMinutes = _durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
            
        }

    }
}
