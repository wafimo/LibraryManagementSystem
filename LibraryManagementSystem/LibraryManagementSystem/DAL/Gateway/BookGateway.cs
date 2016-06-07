using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.Gateway
{
    class BookGateway : BaseGateway
    {
        public bool CheckIfthisBookExist(DAO.Book aBook)
        {
            Connection.Open();
            string query = "SELECT * FROM t_book WHERE book_id = '" + aBook.BookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            while (aReader.Read())
            {
                Connection.Close();

                return true;
            }
            Connection.Close();
            return false;
        }

        public bool SaveThisBook(DAO.Book aBook)
        {
            Connection.Open();
            string query = "INSERT INTO t_book (book_id,book_name,author,quantity) VALUES ('" + aBook.BookID + "','" + aBook.BookName + "','" + aBook.Author + "','" + aBook.Quantity + "')";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }


        public List<Book> LoadBookListGridView()
        {
            Connection.Open();
            string query = "SELECT * FROM t_book";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Book> bookList = new List<Book>();
            while (aReader.Read())
            {
                Book bBook = new Book();
                bBook.BookID = aReader["book_id"].ToString();
                bBook.BookName = aReader["book_name"].ToString();
                bBook.Author = aReader["author"].ToString();
                bBook.Quantity = (int)aReader["quantity"];

                bookList.Add(bBook);
            }

            Connection.Close();
            return bookList;
        }

        public int CheckBookQuantity(Book book)
        {
            Connection.Open();
            string query = "SELECT quantity FROM t_book WHERE book_id = '" + book.BookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            int quantity = 0;
            while (aReader.Read())
            {
                quantity = (int)aReader["quantity"];
            }
            Connection.Close();
            return quantity;
        }

        public bool UpdateBookQuantity(string bookID)
        {
            Connection.Open();
            string query = "UPDATE t_book SET quantity=quantity-1  WHERE book_id = '"+bookID+"' ";
            SqlCommand command = new SqlCommand(query,Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow>0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateReturnBookQuantity(string bookID)
        {
            Connection.Open();
            string query = "Update t_book SET quantity = quantity+1 WHERE book_id = '"+bookID+"'";
            SqlCommand command = new SqlCommand(query,Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();

            if (affectedRow>0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteThisBook(string bookID)
        {
            Connection.Open();
            string query = "Delete FROM t_book WHERE book_id = '" + bookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();

            if (affectedRow > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateThisBookQuantity(string bookID, string newQuantity)
        {
            Connection.Open();
            string query = "Update t_book SET quantity = quantity + '"+newQuantity+"' WHERE book_id = '" + bookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();

            if (affectedRow > 0)
            {
                return true;
            }
            return false;

        }
    }
}
