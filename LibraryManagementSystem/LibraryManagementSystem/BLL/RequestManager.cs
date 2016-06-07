using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    class RequestManager
    {
        RequestGateway aRequestGateway = new RequestGateway();

        public string RequestForThisBook(Book book, BookReader reader)
        {
            BookGateway aBookGateway = new BookGateway();
            if (aBookGateway.CheckIfthisBookExist(book))
            {
                if (aBookGateway.CheckBookQuantity(book) > 0)
                {

                    if (aRequestGateway.RequestForThisBook(book, reader))
                    {
                        return "Request Successfull";
                    }
                    else
                    {
                        return "Error found";
                    }
                }
                else
                {
                    return "Not Available now";
                }
            }
            else
            {
                return "This book is not exist in the library";
            }
        }

        public string CheckRequestStauts(string readerId)
        {
            string requestStatus = aRequestGateway.CheckRequestStauts(readerId);
            if (requestStatus == "requested")
            {
                return "1";
            }
            else if (requestStatus == "accepted")
            {
                return "2";
            }
            else
            {
                return "3";
            }
        }

        public string ClearRequestedBook(string readerID)
        {
            if (aRequestGateway.ClearRequestedBook(readerID))
            {
                return "Successfully removed";
            }
            return "Error found";
        }

        public List<Request> LoadRequestedBookGridView(string readerID)
        {
            return aRequestGateway.LoadRequestedBookGridView(readerID);
        }

        public List<Request> LoadRequestGridView()
        {
            return aRequestGateway.LoadRequestGridView();
        }

        public string AcceptThisRequest(string readerID)
        {
            if (aRequestGateway.AcceptThisRequest(readerID))
            {
                return "Accepted";
            }
            return "Error found";
        }

        public string UpdateBookQuantity(string bookID)
        {
            BookGateway aGateway = new BookGateway();
            if (aGateway.UpdateBookQuantity(bookID))
            {
                return "Book list Updated";
            }
            return "Book list update failed";
        }

        public string UpdateBookReader(String readerID, DateTime dateTime)
        {
            BookReaderGateway aBookReaderGateway = new BookReaderGateway();
            if (aBookReaderGateway.UpdateBookReader(readerID) && aRequestGateway.UpdateTakeDate(dateTime,readerID) && aRequestGateway.UpdateReaderTakeBook(readerID,dateTime))
            {
                return "Book reader list updated";
            }
            return "Book reader list update failed";
        }

        public bool ReturnThisBook(string bookID, string readerID)
        {
            BookGateway aBookGateway = new BookGateway();
            BookReaderGateway aBookReaderGateway = new BookReaderGateway();
            RequestGateway aRequestGateway = new RequestGateway();

            if (aBookGateway.UpdateReturnBookQuantity(bookID) && aBookReaderGateway.UpdateBookReaderTakenBook(readerID) &&
                aRequestGateway.ReturnBook(bookID) && aRequestGateway.UpdateReturnDate(readerID))
            {
                return true;
            }
            return false;
        }
    }
}
