using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book) // Method to get the value of a book
        {
            return book.Price;
            // Returns the price of the book

        }
        public double GetValueOfAmulet(Amulet amulet) // Method to get the value of an amulet
        {
            double value = 0.0; // Default value
            switch (amulet.Quality) // Switch based on the level of the amulet 
            {
                case Level.Low: // Check the level
                    value = 12.5;  // Assign value based on level
                    break;  
                case Level.Medium: 
                    value = 20.0; 
                    break;
                case Level.High: 
                    value = 27.5;
                    break;

                default: // Default case // should not occur, but included for safety
                    value = 0.0; 
                    break;
            }
            return value; // Return the calculated value

        }
        public double GetValueOfCourse(Course course) // Method to get the value of a course
            //Et kursus på 0 minutter → værdi = 0
            //Et kursus på 59 minutter → værdi = 875
            //Et kursus på 120 minutter → værdi = 1750
        {
            double pricePerHour = 875.0; // Price per hour

            int startedHours = (course.DurationInMinutes + 59) / 60; // Calculate started hours
            // 60 = omregner minutter til timer
            // +59 = sørger for at “runde op” til den næste påbegyndte time
            

            double value = startedHours * pricePerHour; // Calculate total value

            return value; 
        }




    }
}
