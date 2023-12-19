using DBS_Course_Work_3kurs.Entities;
using DBS_Course_Work_3kurs.Repositories.Implementation;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Controllers
{
    public class DiscountsController
    {
        MainForm mainForm;
        int DiscountsPageNumber = 0;
        int pageSize;
        bool searched = false;
        Func<Discount, bool> searchPredicate;
        IDiscountsRepository discountsRepository = RepositoryFactory.GetDiscountsRepository();
        public DiscountsController(MainForm main) 
        {
            mainForm = main;
            pageSize = mainForm.pageSize;
        }


        public void ShowAll()
        {
            DiscountsPageNumber = 0;
            ChangePageLabel(mainForm.BooksPageLabel, DiscountsPageNumber);
            searched = false;
            LoadBooksTable();
            mainForm.BookSearchText.Clear();
        }

        public void LoadBooksTable()
        {
            mainForm.BooksTable.Rows.Clear();

            if (searched)
            {
                foreach (Discount d in discountsRepository.Find(searchPredicate, pageSize, DiscountsPageNumber))
                {
                    mainForm.BooksTable.Rows.Add();
                }
            }
            else
            {
                foreach (Book b in booksRepository.GetPage(pageSize, DiscountsPageNumber))
                {
                    mainForm.BooksTable.Rows.Add(b.Book_Id, b.Title, b.Author, b.Genre, b.Collateral_value, b.Quantity);
                }
            }
        }

        public void LastPage()
        {
            DiscountsPageNumber = booksRepository.CountPages(pageSize);
            ChangePageLabel(mainForm.BooksPageLabel, DiscountsPageNumber);
            LoadBooksTable();
        }

        public void NextPage()
        {
            if (DiscountsPageNumber + 1 <= booksRepository.CountPages(pageSize))
            {
                DiscountsPageNumber += 1;
                ChangePageLabel(mainForm.BooksPageLabel, DiscountsPageNumber);
                LoadBooksTable();
            }
            else
            {
                MessageBox.Show("Це остання сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstPage()
        {
            DiscountsPageNumber = 0;
            ChangePageLabel(mainForm.BooksPageLabel, DiscountsPageNumber);
            LoadBooksTable();
        }

        public void PrevPage()
        {
            if (DiscountsPageNumber - 1 != -1)
            {
                DiscountsPageNumber -= 1;
                ChangePageLabel(mainForm.BooksPageLabel, DiscountsPageNumber);
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
