using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL.DAO
{
    public class Request
    {
        public int Id { get; set; }
        public string ReaderID { get; set; }
        public string BookID { get; set; }
        public string Status { get; set; }
        public DateTime DateOfTaken { get; set; }
        public DateTime DateOfreturn { get; set; }
    }
}
