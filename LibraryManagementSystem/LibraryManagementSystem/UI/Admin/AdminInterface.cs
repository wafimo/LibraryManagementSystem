using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
            LoadReaderListGridView();
            LoadBookListGridView();
            LoadRequestGridView();
        }

        private void LoadRequestGridView()
        {
            RequestManager aRequestManager = new RequestManager();
            List<Request> requesetList = new List<Request>();
            requesetList = aRequestManager.LoadRequestGridView();
            int serialNumber = 1;
            requestGridView.Rows.Clear();
            foreach (var requestedBook in requesetList)
            {
                requestGridView.Rows.Add(serialNumber, requestedBook.ReaderID, requestedBook.BookID, requestedBook.Status, requestedBook.DateOfTaken.ToShortDateString());
                serialNumber++;
            }
        }

        private void saveReaderButton_Click(object sender, EventArgs e)
        {
            BookReaderManager aReaderManager = new BookReaderManager();
            if (readerIDTextBox.Text != "" && readerNameTextBox.Text != "" && readerEmailTextBox.Text != "")
            {
                BookReader aBookReader = new BookReader();
                aBookReader.ReaderID = readerIDTextBox.Text;
                aBookReader.ReaderName = readerNameTextBox.Text;
                aBookReader.Email = readerEmailTextBox.Text;
                MessageBox.Show(aReaderManager.SaveThisBookReader(aBookReader));
                LoadReaderListGridView();
                readerIDTextBox.Clear();
                readerNameTextBox.Clear();
                readerEmailTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please fill up the fields");
            }
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {

            Book aBook = new Book();
            BookManager aBookManager = new BookManager();

            if (bookIDTextBox.Text != "" && bookNameTextBox.Text != "" && authorTextBox.Text != "" && quantityTextBox.Text != "")
            {
                int a;
                if (int.TryParse(quantityTextBox.Text, out a))
                {
                    aBook.BookID = bookIDTextBox.Text;
                    aBook.BookName = bookNameTextBox.Text;
                    aBook.Author = authorTextBox.Text;
                    aBook.Quantity = Convert.ToInt32(quantityTextBox.Text);

                    MessageBox.Show(aBookManager.SaveThisBook(aBook));
                    LoadBookListGridView();

                    bookIDTextBox.Clear();
                    bookNameTextBox.Clear();
                    authorTextBox.Clear();
                    quantityTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please Insert correct type");
                }
            }
            else
            {
                MessageBox.Show("Please fill up the fields");
            }
        }

        private void LoadReaderListGridView()
        {
            BookReaderManager aBookReaderManager = new BookReaderManager();
            List<BookReader> bookReaderList = new List<BookReader>();
            bookReaderList = aBookReaderManager.LoadBookreaderGridview();
            int serialNumber = 1;
            readerListGridView.Rows.Clear();
            foreach (var reader in bookReaderList)
            {
                readerListGridView.Rows.Add(serialNumber, reader.ReaderID, reader.ReaderName, reader.Email, reader.Booktaken, reader.DateOfTakeBook.ToShortDateString(), reader.DateOfReturnBook.ToShortDateString());
                serialNumber++;
            }
        }

        private void LoadBookListGridView()
        {
            BookManager aBookManager = new BookManager();
            List<Book> bookList = new List<Book>();
            bookList = aBookManager.LoadBookListGridView();
            int serialNumber = 1;
            bookListGridView.Rows.Clear();
            foreach (var book in bookList)
            {
                bookListGridView.Rows.Add(serialNumber, book.BookID, book.BookName, book.Author, book.Quantity);
                serialNumber++;
            }
        }


        private void requestGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = requestGridView.Rows[e.RowIndex];
                requestedReaderTextBox.Text = row.Cells[1].Value.ToString();
                requestedBookIDTextBox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            RequestManager aRequestManager = new RequestManager();
            if (requestedBookIDTextBox.Text != "" && requestedReaderTextBox.Text != "")
            {
                MessageBox.Show(aRequestManager.AcceptThisRequest(requestedReaderTextBox.Text) + "\n\n" + aRequestManager.UpdateBookQuantity(requestedBookIDTextBox.Text) + "\n\n" + aRequestManager.UpdateBookReader(requestedReaderTextBox.Text, DateTime.Today));
                LoadBookListGridView();
                requestedReaderTextBox.Clear();
                requestedBookIDTextBox.Clear();
                LoadRequestGridView();
                LoadReaderListGridView();
            }
            else
            {
                MessageBox.Show("Fill up the required field");
            }
        }

        private void AdminInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            LoginForm aForm = new LoginForm();
            aForm.Show();
        }

        private void updateBookReaderButton_Click(object sender, EventArgs e)
        {
            BookReader updtReader = new BookReader();
            BookReaderManager aBookReaderManager = new BookReaderManager();

            updtReader.ReaderID = updateBookReaderIDtextBox.Text;
            updtReader.ReaderName = updateBookReaderNameTextBox.Text;
            updtReader.Email = UpdateEmailTextBox.Text;

            MessageBox.Show(aBookReaderManager.UpdateThisBookReader(updtReader));
            updateBookReaderIDtextBox.Clear();
            UpdateEmailTextBox.Clear();
            updateBookReaderNameTextBox.Clear();
            LoadReaderListGridView();
        }

        private void readerListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = readerListGridView.Rows[e.RowIndex];
                updateBookReaderIDtextBox.Text = row.Cells[1].Value.ToString();
                updateBookReaderNameTextBox.Text = row.Cells[2].Value.ToString();
                UpdateEmailTextBox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            BookManager aBookManager = new BookManager();

            MessageBox.Show(aBookManager.DeleteThisBook(deleteBookIDTextBox.Text));
            LoadBookListGridView();
        }

        private void bookListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = bookListGridView.Rows[e.RowIndex];
            updateBookIDTextBox.Text = row.Cells[1].Value.ToString();
            updateBookQuantityTextBox.Text = row.Cells[4].Value.ToString();
        }

        private void updateBookQuantityButton_Click(object sender, EventArgs e)
        {
            BookManager aBookManager = new BookManager();

            MessageBox.Show(aBookManager.UpdateThisBookQuantity(updateBookIDTextBox.Text, addQuantityTextBox.Text));
            updateBookIDTextBox.Clear();
            updateBookQuantityTextBox.Clear();
            addQuantityTextBox.Clear();
            LoadBookListGridView();
        }
    }
}