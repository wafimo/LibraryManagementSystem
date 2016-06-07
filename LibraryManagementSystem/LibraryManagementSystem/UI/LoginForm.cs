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
using LibraryManagementSystem.UI.Reader;
using MetroFramework.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            if (adminPasswordTextBox.Text == "admin")
            {
                Hide();
                AdminInterface aAdminInterface = new AdminInterface();
                aAdminInterface.Show();
            }
            else
            {
                MessageBox.Show("wrong password");
            }
        }

        private void readerLoginButton_Click(object sender, EventArgs e)
        {
            if (readerIDTextBox.Text != "")
            {
                BookReader aBookReader = new BookReader();
                aBookReader.ReaderID = readerIDTextBox.Text;
                
                BookReaderManager aBookReaderManager = new BookReaderManager();
                if (aBookReaderManager.BookReaderLogin(aBookReader))
                {
                    BookReader bookReader = new BookReader();
                    bookReader = aBookReaderManager.GetReaderInfo(aBookReader);

                    Hide();
                    ReaderUI aReaderUi = new ReaderUI(bookReader);
                    aReaderUi.Show();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }     
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void readerIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                readerLoginButton_Click(sender, e);
            }
        }

        private void adminPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adminLoginButton_Click(sender, e);
            }
        }

    }
}
