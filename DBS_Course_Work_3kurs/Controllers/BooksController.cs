using DBS_Course_Work_3kurs.Entities;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Controllers
{
    public class BooksController
    {
        MainForm mainForm;
        int BooksPageNumber = 0;
        int pageSize;
        bool searched = false;
        Func<Book, bool> searchPredicate;
        IBooksRepository booksRepository = RepositoryFactory.GetBooksRepository();
        public BooksController(MainForm main) 
        { 
            mainForm = main;
            pageSize = mainForm.pageSize;
        }

        public void Search() 
        {
            BooksPageNumber = 0;
            ChangePageLabel(mainForm.BooksPageLabel, BooksPageNumber);
            string searchedText = mainForm.BookSearchText.Text.Trim();

            switch (mainForm.BooksSearchType.SelectedIndex) 
            { 
                case 0: 
                    {
                        int searchedBookId = 0;
                        if (int.TryParse(searchedText, out searchedBookId))
                        {
                            searchPredicate = b => b.Book_Id == searchedBookId;
                            searched = true;
                            LoadBooksTable();
                        }
                        else 
                        {
                            MessageBox.Show("Для пошуку за ID введіть ціле число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }

                case 1: 
                    {
                        searchPredicate = b => b.Title.ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadBooksTable();
                        break;
                    }

                case 2:
                    {
                        searchPredicate = b => b.Author.ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadBooksTable();
                        break;
                    }

                case 3:
                    {
                        searchPredicate = b => b.Genre.ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadBooksTable();
                        break;
                    }

                case 4:
                    {
                        searchPredicate = b => b.Collateral_value.ToString().ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadBooksTable();
                        break;
                    }

                case 5:
                    {
                        int searchedBookQuantity = 0;
                        if (int.TryParse(searchedText, out searchedBookQuantity))
                        {
                            searchPredicate = b => b.Quantity == searchedBookQuantity;
                            searched = true;
                            LoadBooksTable();
                        }
                        else
                        {
                            MessageBox.Show("Для пошуку за Кількості введіть ціле число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
            }
        }

        public void ShowAll() 
        {
            BooksPageNumber = 0;
            ChangePageLabel(mainForm.BooksPageLabel, BooksPageNumber);
            searched = false;
            LoadBooksTable();
            mainForm.BookSearchText.Clear();
        }

        public void LoadBooksTable()
        {
            mainForm.BooksTable.Rows.Clear();

            if (searched)
            {
                foreach (Book b in booksRepository.Find(searchPredicate, pageSize, BooksPageNumber))
                {
                    mainForm.BooksTable.Rows.Add(b.Book_Id, b.Title, b.Author, b.Genre, b.Collateral_value, b.Quantity);
                }
            }
            else 
            {
                foreach (Book b in booksRepository.GetPage(pageSize, BooksPageNumber))
                {
                    mainForm.BooksTable.Rows.Add(b.Book_Id, b.Title, b.Author, b.Genre, b.Collateral_value, b.Quantity);
                }
            }
        }

        public void LastPage() 
        {
            BooksPageNumber = booksRepository.CountPages(pageSize);
            ChangePageLabel(mainForm.BooksPageLabel, BooksPageNumber);
            LoadBooksTable();
        }

        public void NextPage() 
        {
            if (BooksPageNumber + 1 <= booksRepository.CountPages(pageSize))
            {
                BooksPageNumber += 1;
                ChangePageLabel(mainForm.BooksPageLabel, BooksPageNumber);
                LoadBooksTable();
            }
            else
            {
                MessageBox.Show("Це остання сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstPage() 
        {
            BooksPageNumber = 0;
            ChangePageLabel(mainForm.BooksPageLabel, BooksPageNumber);
            LoadBooksTable();
        }

        public void PrevPage() 
        {
            if (BooksPageNumber - 1 != -1)
            {
                BooksPageNumber -= 1;
                ChangePageLabel(mainForm.BooksPageLabel, BooksPageNumber);
                LoadBooksTable();
            }
            else
            {
                MessageBox.Show("Це перша сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ChangePageLabel(Label label, int pageNum)
        {
            label.Text = "Page: " + pageNum;
        }
    }
}
