using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryandIo
{
    class Book
    {
        public int Id { get; set; }
        public Guid ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public short NumberOfCopies { get; set; }
        public short NumberOfBorrowedOut { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
