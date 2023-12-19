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
    public class CustomerController
    {
        MainForm mainForm;
        int CustomersPageNumber = 0;
        int pageSize;
        bool searched = false;
        Func<Customer, bool> searchPredicate;
        ICustomersRepository customersRepository = RepositoryFactory.GetCustomersRepository();
        public CustomerController(MainForm mainForm)
        {
            this.mainForm = mainForm;
            pageSize = mainForm.pageSize;
        }

        public void Search()
        {
            CustomersPageNumber = 0;
            ChangePageLabel(mainForm.CustomerPageLabel, CustomersPageNumber);
            string searchedText = mainForm.CustomerSearchText.Text.Trim();

            switch (mainForm.CustomerSearchType.SelectedIndex)
            {
                case 0:
                    {
                        int searchedCustomerId = 0;
                        if (int.TryParse(searchedText, out searchedCustomerId))
                        {
                            searchPredicate = c => c.Customer_Id == searchedCustomerId;
                            searched = true;
                            LoadCustomersTable();
                        }
                        else
                        {
                            MessageBox.Show("Для пошуку за ID введіть ціле число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }

                case 1:
                    {
                        searchPredicate = c => c.Name.ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadCustomersTable();
                        break;
                    }

                case 2:
                    {
                        searchPredicate = c => c.Surname.ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadCustomersTable();
                        break;
                    }

                case 3:
                    {
                        searchPredicate = c => c.Paternal_name.ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadCustomersTable();
                        break;
                    }

                case 4:
                    {
                        searchPredicate = c => c.Address.ToString().ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadCustomersTable();
                        break;
                    }

                case 5:
                    {
                        searchPredicate = c => c.Phone.ToString().ToLower().Contains(searchedText.ToLower());
                        searched = true;
                        LoadCustomersTable();
                        break;
                    }

                case 6:
                    {
                        int searchedCustomerDiscountId = 0;
                        if (int.TryParse(searchedText, out searchedCustomerDiscountId))
                        {
                            searchPredicate = c => c.Discount_Id == searchedCustomerDiscountId;
                            searched = true;
                            LoadCustomersTable();
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
            CustomersPageNumber = 0;
            ChangePageLabel(mainForm.CustomerPageLabel, CustomersPageNumber);
            searched = false;
            LoadCustomersTable();
            mainForm.CustomerSearchText.Clear();
        }

        public void LoadCustomersTable()
        {
            mainForm.CustomersTable.Rows.Clear();

            if (searched)
            {
                foreach (Customer c in customersRepository.Find(searchPredicate, pageSize, CustomersPageNumber))
                {
                    string fullName = string.Concat(c.Surname + " ", c.Name + " ", c.Paternal_name);
                    mainForm.CustomersTable.Rows.Add(c.Customer_Id, fullName, c.Address, c.Phone, c.Discount_Id);
                }
            }
            else
            {
                foreach (Customer c in customersRepository.GetPage(pageSize, CustomersPageNumber))
                {
                    string fullName = string.Concat(c.Surname + " ", c.Name+" ", c.Paternal_name);
                    mainForm.CustomersTable.Rows.Add(c.Customer_Id, fullName, c.Address, c.Phone, c.Discount_Id);
                }
            }
        }

        public void LastPage()
        {
            CustomersPageNumber = customersRepository.CountPages(pageSize);
            ChangePageLabel(mainForm.CustomerPageLabel, CustomersPageNumber);
            LoadCustomersTable();
        }

        public void NextPage()
        {
            if (CustomersPageNumber + 1 <= customersRepository.CountPages(pageSize))
            {
                CustomersPageNumber += 1;
                ChangePageLabel(mainForm.CustomerPageLabel, CustomersPageNumber);
                LoadCustomersTable();
            }
            else
            {
                MessageBox.Show("Це остання сторінка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FirstPage()
        {
            CustomersPageNumber = 0;
            ChangePageLabel(mainForm.CustomerPageLabel, CustomersPageNumber);
            LoadCustomersTable();
        }

        public void PrevPage()
        {
            if (CustomersPageNumber - 1 != -1)
            {
                CustomersPageNumber -= 1;
                ChangePageLabel(mainForm.CustomerPageLabel, CustomersPageNumber);
                LoadCustomersTable();
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
