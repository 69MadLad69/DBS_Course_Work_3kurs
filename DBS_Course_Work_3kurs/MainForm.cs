using Microsoft.Extensions.DependencyInjection;
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
using DBS_Course_Work_3kurs.Controllers;
using DBS_Course_Work_3kurs.AdditionalForms.CustomerForms;

namespace DBS_Course_Work_3kurs
{
    public partial class MainForm : Form
    {
        public EFUnitOfWork ef;
        public BooksController BC;
        public CustomerController CC;

        public int pageSize = 10;
        public MainForm()
        {
            string connectionString = "Server = 127.0.0.1; Database = Library; User Id = root; Password = bober2467;";

            var dbContextOptions = new DbContextOptionsBuilder<LibraryDBContext>();

            dbContextOptions.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            RepositoryFactory.Initialize(new LibraryDBContext(dbContextOptions.Options));

            //ef = RepositoryFactory.GetEFUnitOfWork();

            InitializeComponent();

            BC = new BooksController(this);
            CC = new CustomerController(this);

            BooksSearchType.SelectedIndex = 0;
            CustomerSearchType.SelectedIndex = 0;

            BC.LoadBooksTable();
            CC.LoadCustomersTable();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Books Tab

        /*
        public void LoadBooksTable()
        {
            BooksTable.Rows.Clear();
            foreach (Book b in RepositoryFactory.GetBooksRepository().GetPage(pageSize, BooksPageNumber))
            {
                BooksTable.Rows.Add(b.Book_Id, b.Title, b.Author, b.Genre, b.Collateral_value, b.Quantity);
            }
        }


        public void ChangePageLabel(Label label, int pageNum)
        {
            label.Text = "Page: " + pageNum;
        }
        */

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddNewBook adder = new AddNewBook(this);
            adder.Show();
        }

        private void BooksNextPageButton_Click(object sender, EventArgs e)
        {
            BC.NextPage();
        }

        private void BooksFirstPageButton_Click(object sender, EventArgs e)
        {
            BC.FirstPage();
        }

        private void BooksPrevPageButton_Click(object sender, EventArgs e)
        {
            BC.PrevPage();
        }

        private void BooksLastPageButton_Click(object sender, EventArgs e)
        {
            BC.LastPage();
        }

        private void ChangeBookButton_Click(object sender, EventArgs e)
        {
            ChangeBook changer = new ChangeBook(this, BooksTable.SelectedRows[0]);
            changer.Show();
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            int Book_Id = (int)BooksTable.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("Чи ви впевнені в видаленні рядка #" + Book_Id + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RepositoryFactory.GetBooksRepository().Delete(Book_Id);
                BC.LoadBooksTable();
            }
        }

        private void BooksSearchButton_Click(object sender, EventArgs e)
        {
            BC.Search();
        }

        private void BooksShowAllButton_Click(object sender, EventArgs e)
        {
            BC.ShowAll();
        }

        // Customers Tab

        private void CustomersNextPageButton_Click(object sender, EventArgs e)
        {
            CC.NextPage();
        }

        private void CustomersPrevPageButton_Click(object sender, EventArgs e)
        {
            CC.PrevPage();
        }

        private void CustomersFirstPageButton_Click(object sender, EventArgs e)
        {
            CC.FirstPage();
        }

        private void CustomersLastPageButton_Click(object sender, EventArgs e)
        {
            CC.LastPage();
        }

        private void CustomerSearchButton_Click(object sender, EventArgs e)
        {
            CC.Search();
        }

        private void CustomerShowAllButton_Click(object sender, EventArgs e)
        {
            CC.ShowAll();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer adder = new AddNewCustomer(this);
            adder.Show();
        }

        private void ChangeCustomerButton_Click(object sender, EventArgs e)
        {
            ChangeCustomer changer = new ChangeCustomer(this, CustomersTable.SelectedRows[0]);
            changer.Show();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            int Customer_Id = (int)CustomersTable.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("Чи ви впевнені в видаленні рядка #" + Customer_Id + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RepositoryFactory.GetCustomersRepository().Delete(Customer_Id);
                CC.LoadCustomersTable();
            }
        }
    }
}
