using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI.Reader
{
    public partial class ReaderUI : Form
    {
        public ReaderUI(BookReader aBookReader)
        {
            InitializeComponent();
            readerIDTextBox.Text = aBookReader.ReaderID;
            readerNameTextBox.Text = aBookReader.ReaderName;
            bookTakenTextBox.Text = Convert.ToString(aBookReader.Booktaken);
            LoadBookListGridView();
            LoadRequestedBookGridView();
            CheckRequestStauts();
           
        }

        public void LoadRequestedBookGridView()
        {
            RequestManager aRequestManager = new RequestManager();
            List<Request> requesetList = new List<Request>();
            requesetList = aRequestManager.LoadRequestedBookGridView(readerIDTextBox.Text);
            int serialNumber = 1;
            requestedBookDataGridView.Rows.Clear();
            string requestStatus = "";
            foreach (var requestedBook in requesetList)
            {
                requestedBookDataGridView.Rows.Add(serialNumber, requestedBook.BookID, requestedBook.Status );
                serialNumber++;
                requestStatus = requestedBook.Status;
            }

            if (requestStatus == "requested")
            {
                returnButton.Enabled = false;
            }
            else if(requestStatus == "accepted")
            {
                returnButton.Enabled = true;
            }
            else
            {
                returnButton.Enabled = false;
            }
        }

        public void CheckRequestStauts()
        {

            RequestManager aRequestManager = new RequestManager();

            string requestStatus = aRequestManager.CheckRequestStauts(readerIDTextBox.Text);

            if (requestStatus =="1")
            {
                addButton.Enabled = false;
            }
            else if(requestStatus == "2")
            {
                
                addButton.Enabled = false;
                clearButton.Enabled = false;
                addBookIDTextBox.Enabled = false;
            }
            else
            {
                addButton.Enabled = true;
                clearButton.Enabled = true;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            RequestManager aRequestManager = new RequestManager();
            Book book = new Book();
            book.BookID = addBookIDTextBox.Text;
            BookReader cReader = new BookReader();
            cReader.ReaderID = readerIDTextBox.Text;
            MessageBox.Show(aRequestManager.RequestForThisBook(book,cReader));
            addButton.Enabled = false;
            addBookIDTextBox.Clear();
            CheckRequestStauts();
            LoadRequestedBookGridView();
        }

        private void ReaderUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            LoginForm aForm = new LoginForm();
            aForm.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            RequestManager aRequestManager = new RequestManager();
            MessageBox.Show(aRequestManager.ClearRequestedBook(readerIDTextBox.Text));
            LoadRequestedBookGridView();
            addButton.Enabled = true;
        }

        private void bookListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = bookListGridView.Rows[e.RowIndex];
            addBookIDTextBox.Text = row.Cells[1].Value.ToString();
        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            RequestManager aRequestManager = new RequestManager();

            if (aRequestManager.ReturnThisBook(returnBookIDTextBox.Text, readerIDTextBox.Text))
            {
                MessageBox.Show("Return Successful");
                LoadRequestedBookGridView();
                LoadBookListGridView();
                returnBookIDTextBox.Clear();
                addButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Something wrong");
            }
        }

        private void requestedBookDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = requestedBookDataGridView.Rows[e.RowIndex];
            returnBookIDTextBox.Text = row.Cells[1].Value.ToString();
        }
    }
}
