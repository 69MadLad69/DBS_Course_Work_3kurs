using DBS_Course_Work_3kurs.EF;
using DBS_Course_Work_3kurs.Entities;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
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
        IBooksRepository booksRepository = RepositoryFactory.GetBooksRepository();
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

            if (booksRepository.GetPage(mainForm.pageSize, 0).Count() != 0)
            {
                newBookId = booksRepository.GetPage(
                    mainForm.pageSize, booksRepository.CountPages(mainForm.pageSize)
                    ).Last().Book_Id + 1;
            }

            int newBookQuantity = 0;
            double newBookValue = 0;

            if (BookTitle.Text.Trim() == "")
            {
                MessageBox.Show("Книга має мати назву!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(BookQuantity.Text, out newBookQuantity) && double.TryParse(BookValue.Text, out newBookValue))
                {
                    Book newBook = new Book();

                    newBook.Book_Id = newBookId;
                    newBook.Title = BookTitle.Text.Trim();

                    if (BookAuthor.Text.Trim() == "" && BookGenre.Text.Trim() == "")
                    {
                        newBook.Author = "Невідомо";
                        newBook.Genre = "Невідомо";
                    }
                    else
                    {
                        newBook.Author = BookAuthor.Text.Trim();
                        newBook.Genre = BookGenre.Text.Trim();
                    }

                    newBook.Collateral_value = Math.Round(newBookValue, 2);
                    newBook.Quantity = newBookQuantity;


                    if (booksRepository.Find(book => book.Title == newBook.Title, 0, 10).Count() == 0)
                    {
                        booksRepository.Create(newBook);
                        mainForm.BC.LoadBooksTable();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Книга з такою назвою вже існує в БД!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Кількість екземплярів має бути цілим числом і Заставна вартість має бути числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
