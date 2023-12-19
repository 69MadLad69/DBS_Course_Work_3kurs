using DBS_Course_Work_3kurs.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Course_Work_3kurs.AdditionalForms.BookForms
{
    public partial class ChangeBook : Form
    {
        MainForm mainForm;
        Book selectedBook;
        public ChangeBook(MainForm main, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            mainForm = main;

            selectedBook = mainForm.ef.books.Get((int)selectedRow.Cells[0].Value);

            BookTitle.Text = selectedBook.Title;
            BookAuthor.Text = selectedBook.Author;
            BookGenre.Text = selectedBook.Genre;
            BookValue.Text = selectedBook.Collateral_value.ToString();
            BookQuantity.Text = selectedBook.Quantity.ToString();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int selectedBookQuantity = 0;
            double selectedBookValue = 0;

            if (BookTitle.Text == "")
            {
                MessageBox.Show("Книга має мати назву!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(BookQuantity.Text, out selectedBookQuantity) && double.TryParse(BookValue.Text, out selectedBookValue))
                {
                    selectedBook.Title = BookTitle.Text;
                    selectedBook.Author = BookAuthor.Text;
                    selectedBook.Genre = BookGenre.Text;
                    selectedBook.Collateral_value = Math.Round(selectedBookValue, 2);
                    selectedBook.Quantity = selectedBookQuantity;


                    if (mainForm.ef.books.Find(book => book.Title == selectedBook.Title, 0, 10).Count() == 0)
                    {
                        mainForm.ef.books.Update(selectedBook);
                        mainForm.LoadBooksTable();
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
