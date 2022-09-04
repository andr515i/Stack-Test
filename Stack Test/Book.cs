using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Test
{
    class Book
    {  // book class, as we dont usually rip pages off or change the contents of the book ,we cant set the properties after it has been created
        private string _name;

        public string name
        {
            get { return _name; }
        }
        private int _pageCount;

        public int pageCount
        {
            get { return _pageCount; }
        }
        private string _bio;

        public string bio
        {
            get { return _bio; }
        }



        public Book(string name, int pageCount, string bio)
        {
            _name = name;
            _pageCount = pageCount;
            _bio = bio;
        }
    }
}
