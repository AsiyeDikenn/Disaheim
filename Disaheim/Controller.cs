using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        // Properties (samlinger)
        public List<Book> Books { get; set; } // Liste af bøger
        public List<Amulet> Amulets { get; set; } // Liste af amuletter
        public List<Course> Courses { get; set; } // Liste af kurser

        // Constructor – husk at INITIALISERE listerne
        public Controller() 
        {
            Books = new List<Book>(); // Initialiserer listen af bøger
            Amulets = new List<Amulet>(); // Initialiserer listen af amuletter
            Courses = new List<Course>(); // Initialiserer listen af kurser
        }

        // Overload #1: tilføj en bog
        public void AddToList(Book book) // Metode til at tilføje en bog til listen
        {
            if (book != null) Books.Add(book); // Tilføjer bogen til listen, hvis den ikke er null
        }

        // Overload #2: tilføj en amulet
        public void AddToList(Amulet amulet) 
        {
            if (amulet != null) Amulets.Add(amulet); 
        }
        // Overload #3: tilføj et kursus
        public void AddToList(Course course) 
        {
            if (course != null) Courses.Add(course);
        }
    }

}
