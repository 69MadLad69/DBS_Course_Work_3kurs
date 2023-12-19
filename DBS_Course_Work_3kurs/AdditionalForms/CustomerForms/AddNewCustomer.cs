using DBS_Course_Work_3kurs.Entities;
using DBS_Course_Work_3kurs.Repositories.Implementation;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Course_Work_3kurs.AdditionalForms.CustomerForms
{
    public partial class AddNewCustomer : Form
    {
        MainForm mainForm;
        ICustomersRepository customers = RepositoryFactory.GetCustomersRepository();
        IDiscountsRepository discounts = RepositoryFactory.GetDiscountsRepository();
        public AddNewCustomer(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int newCustomerId = 1;

            if (customers.GetPage(mainForm.pageSize, 0).Count() != 0)
            {
                newCustomerId = customers.GetPage(
                    mainForm.pageSize, customers.CountPages(mainForm.pageSize)
                    ).Last().Customer_Id + 1;
            }

            int newCustomerDiscountId = 0;

            if (CustomerName.Text.Trim() == ""
                || CustomerSurname.Text.Trim() == ""
                || CustomerPaternalName.Text.Trim() == ""
                || CustomerAddress.Text.Trim() == ""
                || CustomerPhone.Text.Trim() == "")
            {
                MessageBox.Show("Будь ласка заповніть усі поля! (Поле знижки не обов`язково)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(CustomerDiscountId.Text, out newCustomerDiscountId))
                {
                    MessageBox.Show("Введене ID знижки не є цілим числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Customer newCustomer = new Customer();

                    newCustomer.Customer_Id = newCustomerId;
                    newCustomer.Name = CustomerName.Text.Trim();
                    newCustomer.Surname = CustomerSurname.Text.Trim();
                    newCustomer.Paternal_name = CustomerPaternalName.Text.Trim();
                    newCustomer.Address = CustomerAddress.Text.Trim();

                    if (!IsValidPhoneNumber(CustomerPhone.Text))
                    {
                        MessageBox.Show("Телефон має бути записаний у вигляді (+999-99-999-99-99)!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        newCustomer.Phone = CustomerPhone.Text;

                        if (customers.Find(customer => customer.Phone.Equals(newCustomer.Phone), 0, 10).Count() == 0)
                        {
                            if (customers.Find(customer =>
                               customer.Name.Equals(newCustomer.Name)
                               && customer.Surname.Equals(newCustomer.Surname)
                               && customer.Paternal_name.Equals(newCustomer.Paternal_name), 0, 10).Count() == 0)
                            {
                                if (discounts.Get(newCustomerDiscountId) == null)
                                {
                                    MessageBox.Show("Знижки з обраним ID не існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    newCustomer.Discount_Id = newCustomerDiscountId;
                                    newCustomer.discount = discounts.Get(newCustomer.Discount_Id);

                                    customers.Create(newCustomer);
                                    mainForm.CC.LoadCustomersTable();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Користувач з таким повним ім`ям вже існує в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Користувач з таким номером телефону вже існує в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+\d{3}-\d{2}-\d{3}-\d{2}-\d{2}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void CustomerDiscountId_TextChanged(object sender, EventArgs e)
        {
            int newCustomerDiscountId = 0;
            int.TryParse(CustomerDiscountId.Text, out newCustomerDiscountId);

            Discount discount = discounts.Get(newCustomerDiscountId);

            if (discount == null)
            {
                discount = discounts.Get(0);
            }

            CustomerDiscountDesc.Text = discount.Description;
        }

        private void SeeFullDiscount_Click(object sender, EventArgs e)
        {
            int newCustomerDiscountId = 0;
            int.TryParse(CustomerDiscountId.Text, out newCustomerDiscountId);

            Discount discount = discounts.Get(newCustomerDiscountId);

            if (discount == null)
            {
                discount = discounts.Get(0);
            }

            MessageBox.Show("Повний опис знижки: \n" + discount.Description + " \nРозмір знижки: " + (int)Math.Round(discount.Amount * 100, 0) + "%", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
