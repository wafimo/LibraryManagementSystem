using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    class BookManager
    {
        BookGateway aBookGateway = new BookGateway();
        public string SaveThisBook(DAL.DAO.Book aBook)
        {
            if (aBookGateway.CheckIfthisBookExist(aBook))
            {
                return "This Book is already exist";
            }
            else
            {
                if (aBookGateway.SaveThisBook(aBook))
                {
                    return "Saved";
                }
                return "not saved";
            }  
        }

        public List<Book> LoadBookListGridView()
        {
            return aBookGateway.LoadBookListGridView();
        }

        public string DeleteThisBook(string bookID)
        {

            if (aBookGateway.DeleteThisBook(bookID))
            {
                return "Delete Successful";
            }
            return "Something Wrong";

        }

        public string UpdateThisBookQuantity(string bookID, string quantity)
        {
            if (aBookGateway.UpdateThisBookQuantity(bookID,quantity))
            {
                return "Book quantity Updated";
            }
            return "Update failed";
        }
    }
}
