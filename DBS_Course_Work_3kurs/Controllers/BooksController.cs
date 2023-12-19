using DBS_Course_Work_3kurs.Entities;
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
        public BooksController(MainForm main) 
        { 
            this.mainForm = main;
        }

        public void LoadBooksTable()
        {
            mainForm.BooksTable.Rows.Clear();


            foreach (Book b in mainForm.ef.books.GetPage(mainForm.pageSize, BooksPageNumber))
            {
                mainForm.BooksTable.Rows.Add(b.Book_Id, b.Title, b.Author, b.Genre, b.Collateral_value, b.Quantity);
            }
        }


        public void ChangePageLabel(Label label, int pageNum)
        {
            label.Text = "Page: " + pageNum;
        }
    }
}
