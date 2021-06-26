using System;
using System.Collections.Generic;
using System.Text;

namespace Matthew_991524179_Midterm
{
	class Book
	{
        public int ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return "ISBN = " + ISBN + ", Title = " + Title + ", Price = " + Price + ", Genre = " + Genre;
        }
    }
}
