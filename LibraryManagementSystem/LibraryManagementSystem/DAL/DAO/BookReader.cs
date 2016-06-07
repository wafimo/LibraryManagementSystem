using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL.DAO
{
    public class BookReader
    {
        public string ReaderID { get; set; }
        public string ReaderName { get; set; }
        public string Email { get; set; }
        public int Booktaken { get; set; }
        public string RequestStatus { get; set; }
        public DateTime DateOfTakeBook { get; set; }
        public DateTime DateOfReturnBook { get; set; } 
    }
}
