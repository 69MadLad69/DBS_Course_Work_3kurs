using DBS_Course_Work_3kurs.EF;
using DBS_Course_Work_3kurs.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Course_Work_3kurs.AdditionalForms.BookForms
{
    public partial class AddNewBook : Form
    {
        MainForm mainForm;
        public AddNewBook(MainForm main)
        {
            InitializeComponent();

            mainForm = main;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int newBookId = 1;

            if (mainForm.ef.books.GetPage(mainForm.pageSize, 0).Count() != 0)
            {
                newBookId = mainForm.ef.books.GetPage(
                    mainForm.pageSize, mainForm.ef.books.CountPages(mainForm.pageSize)
                    ).Last().Book_Id + 1;
            }

            int newBookQuantity = 0;
            double newBookValue = 0;

            if (int.TryParse(BookQuantity.Text, out newBookQuantity) && double.TryParse(BookValue.Text, out newBookValue)) 
            {
                Book newBook = new Book();

                int.TryParse(BookValue.Text, out newBookId);

                newBook.Book_Id = newBookId;
                newBook.Title = BookTitle.Text;
                newBook.Author = BookAuthor.Text;
                newBook.Genre = BookGenre.Text;
                newBook.Collateral_value = newBookValue;
                newBook.Quantity = newBookQuantity;


                if (mainForm.ef.books.Find(book => book.Title == newBook.Title, 0, 10).Count() == 0) 
                {
                    mainForm.ef.books.Create(newBook);
                }
            }
        }
    }
}
