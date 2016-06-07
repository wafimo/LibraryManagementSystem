using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.Gateway
{
    public class RequestGateway : BaseGateway
    {
        public bool RequestForThisBook(Book book, BookReader reader)
        {
            Connection.Open();
            string query = "INSERT INTO t_temporary_table (reader_id,book_id,status) VALUES ('" + reader.ReaderID + "','" + book.BookID + "','requested')";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public string CheckRequestStauts(string readerId)
        {
            Connection.Open();
            string query = "SELECT status FROM t_temporary_table WHERE reader_id = '" + readerId + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            string status = "";
            while (aReader.Read())
            {
                status = aReader["status"].ToString();
            }
            Connection.Close();
            return status;
        }

        public bool ClearRequestedBook(string readerID)
        {
            Connection.Open();
            string query = "DELETE FROM t_temporary_table WHERE reader_id = '" + readerID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public List<Request> LoadRequestedBookGridView(string readerID)
        {
            Connection.Open();
            string query = "SELECT * FROM t_temporary_table WHERE reader_id = '" + readerID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<Request> reqList = new List<Request>();
            //DateTime dt;
            while (aReader.Read())
            {
                Request aRequest = new Request();

                aRequest.Id = (int)aReader["id"];
                aRequest.ReaderID = aReader["reader_id"].ToString();
                aRequest.BookID = aReader["book_id"].ToString();
                aRequest.Status = aReader["status"].ToString();
                //if (DateTime.TryParseExact("date_of_take_book",
                //           "yy/mm/dd", null, DateTimeStyles.None, out dt))
                //{
                //    aRequest.DateOfTaken = dt;
                //}
                //aRequest.DateOfTaken = Convert.ToDateTime(aReader["date_of_take_book"]);
                reqList.Add(aRequest);
            }
            Connection.Close();
            return reqList;
        }

        public List<Request> LoadRequestGridView()
        {
            Connection.Open();
            string query = "SELECT * FROM t_temporary_table ";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<Request> reqList = new List<Request>();
            //DateTime date = new DateTime();
            while (aReader.Read())
            {
                Request aRequest = new Request();

                aRequest.Id = (int)aReader["id"];
                aRequest.ReaderID = aReader["reader_id"].ToString();
                aRequest.BookID = aReader["book_id"].ToString();
                aRequest.Status = aReader["status"].ToString();
                if (aReader["date_of_take_book"].ToString() == "")
                {
                    aRequest.DateOfTaken = DateTime.MinValue;
                }
                else
                {
                    aRequest.DateOfTaken = Convert.ToDateTime(aReader["date_of_take_book"]);
                }

                reqList.Add(aRequest);
            }
            Connection.Close();
            return reqList;
        }

        public bool AcceptThisRequest(string readerID)
        {
            Connection.Open();
            string query = "UPDATE t_temporary_table SET status = 'accepted' WHERE reader_id = '" + readerID + "' ";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool ReturnBook(string bookID)
        {
            Connection.Open();
            string query = "DELETE FROM t_temporary_table WHERE book_id = '" + bookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateTakeDate(DateTime dateTime, string readerID)
        {
            Connection.Open();
            string query = "UPDATE t_temporary_table SET date_of_take_book = '" + dateTime.ToShortDateString() + "' WHERE reader_id = '" + readerID + "' ";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateReaderTakeBook(string readerID, DateTime dateTime)
        {
            Connection.Open();
            string query = "UPDATE t_reader SET date_of_taken = '" + dateTime.ToShortDateString() + "' , date_of_return = '"+DateTime.MinValue+"' WHERE reader_id = '" + readerID + "' ";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateReturnDate(string readerID)
        {
            Connection.Open();
            string query = "UPDATE t_reader SET date_of_return = '" + DateTime.Today.ToShortDateString() + "' WHERE reader_id = '" + readerID + "' ";
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
