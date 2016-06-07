using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.Gateway
{
    class BookReaderGateway : BaseGateway
    {
        public bool SaveThisBookReader(BookReader aBookReader)
        {
            Connection.Open();
            string query = "INSERT INTO t_reader (reader_id,reader_name,email) VALUES ('" + aBookReader.ReaderID + "','" + aBookReader.ReaderName + "','" + aBookReader.Email + "')";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckIfExist(BookReader aBookReader)
        {
            Connection.Open();
            string query = "SELECT * FROM t_reader WHERE reader_id = '" + aBookReader.ReaderID + "'";
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

        public List<BookReader> LoadBookreaderGridview()
        {
            Connection.Open();
            string query = "SELECT * FROM t_reader";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<BookReader> readerList = new List<BookReader>();
            while (aReader.Read())
            {
                BookReader bBookReader = new BookReader();
                bBookReader.ReaderID = aReader["reader_id"].ToString();
                bBookReader.ReaderName = aReader["reader_name"].ToString();
                bBookReader.Email = aReader["email"].ToString();
                if (aReader["book_taken"].ToString() == "")
                {
                    bBookReader.Booktaken = 0;
                }
                else
                {
                    bBookReader.Booktaken = (int)aReader["book_taken"];
                }

                if (aReader["date_of_taken"].ToString() == "")
                {
                    bBookReader.DateOfTakeBook = Convert.ToDateTime(null);
                }
                else
                {
                    bBookReader.DateOfTakeBook = Convert.ToDateTime(aReader["date_of_taken"]);
                }


                if (aReader["date_of_return"].ToString() == "")
                {
                    bBookReader.DateOfReturnBook = Convert.ToDateTime(null);
                }
                else
                {
                    bBookReader.DateOfReturnBook = Convert.ToDateTime(aReader["date_of_return"]);
                }


                readerList.Add(bBookReader);
            }
            Connection.Close();
            return readerList;
        }

        public BookReader BookReaderLogin(string bookReaderID)
        {
            Connection.Open();
            string query = "SELECT * FROM t_reader WHERE reader_id = '" + bookReaderID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();

            BookReader bookReader = new BookReader();

            while (aReader.Read())
            {
                bookReader.ReaderID = aReader["reader_id"].ToString();
            }
            Connection.Close();
            return bookReader;
        }


        public BookReader GetReaderInfo(BookReader bookReader)
        {
            Connection.Open();
            string query = "SELECT * FROM t_reader WHERE reader_id = '" + bookReader.ReaderID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            BookReader abreader = new BookReader();
            while (aReader.Read())
            {
                abreader.ReaderID = aReader["reader_id"].ToString();
                abreader.ReaderName = aReader["reader_name"].ToString();
                if (aReader["book_taken"].ToString() == "")
                {
                    abreader.Booktaken = 0;
                }
                else
                {
                    abreader.Booktaken = (int)aReader["book_taken"];
                }
            }
            Connection.Close();
            return abreader;
        }

        public bool UpdateBookReader(string readerID)
        {
            Connection.Open();
            string query = "UPDATE t_reader SET book_taken = '1' WHERE reader_id = '"+readerID+"' ";
            SqlCommand command = new SqlCommand(query,Connection);
            int affectedRow = command.ExecuteNonQuery();

            if (affectedRow>0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateBookReaderTakenBook(string readerID)
        {
            Connection.Open();
            string query = "UPDATE t_reader SET book_taken = '0' WHERE reader_id = '" + readerID + "' ";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateThisBookReader(BookReader updtReader)
        {
            Connection.Open();
            string query = "UPDATE t_reader SET reader_name = '"+updtReader.ReaderName+"' , email = '"+updtReader.Email+"' WHERE reader_id = '" + updtReader.ReaderID + "' ";
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
