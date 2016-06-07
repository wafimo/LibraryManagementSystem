using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    public class BookReaderManager
    {
        private BookReaderGateway aBookReaderGateway = new BookReaderGateway();

        public string SaveThisBookReader(BookReader aBookReader)
        {
            if (aBookReaderGateway.CheckIfExist(aBookReader))
            {
                return "This ID is already exist";
            }
            else
            {
                if (aBookReaderGateway.SaveThisBookReader(aBookReader))
                {
                    return "Saved";
                }
                return "not saved";
            }
        }

        public List<BookReader> LoadBookreaderGridview()
        {
            return aBookReaderGateway.LoadBookreaderGridview();
        }

        public bool BookReaderLogin(BookReader aBookReader)
        {
            BookReader bBookReader = new BookReader();
            bBookReader = aBookReaderGateway.BookReaderLogin(aBookReader.ReaderID);

            if (aBookReader.ReaderID == bBookReader.ReaderID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public BookReader GetReaderInfo(BookReader bookReader)
        {
            return aBookReaderGateway.GetReaderInfo(bookReader);
        }

        public string UpdateThisBookReader(BookReader updtReader)
        {
            if (aBookReaderGateway.UpdateThisBookReader(updtReader))
            {
                return "Update Successful";
            }
            return "Error found";
        }
    }
}
