﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using DBS_Course_Work_3kurs.Repositories.Implementation;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using DBS_Course_Work_3kurs.EF;
using DBS_Course_Work_3kurs.Entities;
using DBS_Course_Work_3kurs.AdditionalForms.BookForms;
using System.Globalization;

namespace DBS_Course_Work_3kurs
{
    public partial class MainForm : Form
    {
        public EFUnitOfWork ef;

        public int pageSize = 10;
        int BooksPageNumber = 0;
        public MainForm()
        {
            string connectionString = "Server = 127.0.0.1; Database = Library; User Id = root; Password = bober2467;";

            var dbContextOptions = new DbContextOptionsBuilder<LibraryDBContext>();

            dbContextOptions.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            ef = new EFUnitOfWork(dbContextOptions.Options);

            InitializeComponent();

            LoadBooksTable();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public bool isIntParsable(String val)
        {
            try
            {
                int num = int.Parse(val);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool isDoubleParsable(String val)
        {
            try
            {
                double num = double.Parse(val, NumberStyles.Any);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        // Books
        public void LoadBooksTable()
        {
            BooksTable.Rows.Clear();
            foreach (Book b in ef.books.GetPage(pageSize, BooksPageNumber))
            {
                BooksTable.Rows.Add(b.Book_Id, b.Title, b.Author, b.Genre, b.Collateral_value, b.Quantity);
            }
        }


        public void ChangePageLabel(Label label, int pageNum)
        {
            label.Text = "Page: " + pageNum;
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddNewBook adder = new AddNewBook(this);
            adder.Show();
        }

        private void BooksNextPageButton_Click(object sender, EventArgs e)
        {
            if (BooksPageNumber + 1 <= ef.books.CountPages(pageSize))
            {
                BooksPageNumber += 1;
                ChangePageLabel(BooksPageLabel, BooksPageNumber);
                LoadBooksTable();
            }
            else
            {
                MessageBox.Show("Це остання сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BooksFirstPageButton_Click(object sender, EventArgs e)
        {
            BooksPageNumber = 0;
            ChangePageLabel(BooksPageLabel, BooksPageNumber);
            LoadBooksTable();
        }

        private void BooksPrevPageButton_Click(object sender, EventArgs e)
        {
            if (BooksPageNumber - 1 != -1)
            {
                BooksPageNumber -= 1;
                ChangePageLabel(BooksPageLabel, BooksPageNumber);
                LoadBooksTable();
            }
            else
            {
                MessageBox.Show("Це перша сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BooksLastPageButton_Click(object sender, EventArgs e)
        {
            BooksPageNumber = ef.books.CountPages(pageSize);
            ChangePageLabel(BooksPageLabel, BooksPageNumber);
            LoadBooksTable();
        }
    }
}