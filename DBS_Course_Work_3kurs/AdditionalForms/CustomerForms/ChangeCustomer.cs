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
    public partial class ChangeCustomer : Form
    {
        MainForm mainForm;
        Customer selectedCustomer;
        ICustomersRepository customers = RepositoryFactory.GetCustomersRepository();
        IDiscountsRepository discounts = RepositoryFactory.GetDiscountsRepository();

        public ChangeCustomer(MainForm mainForm, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            selectedCustomer = customers.Get((int)selectedRow.Cells[0].Value);

            CustomerName.Text = selectedCustomer.Name;
            CustomerSurname.Text = selectedCustomer.Surname;
            CustomerPaternalName.Text = selectedCustomer.Paternal_name;
            CustomerAddress.Text = selectedCustomer.Address;
            CustomerPhone.Text = selectedCustomer.Phone;
            CustomerDiscountId.Text = selectedCustomer.Discount_Id.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int customerNewDiscountId = 0;

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
                if (!int.TryParse(CustomerDiscountId.Text, out customerNewDiscountId))
                {
                    MessageBox.Show("Введене ID знижки не є цілим числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    selectedCustomer.Name = CustomerName.Text.Trim();
                    selectedCustomer.Surname = CustomerSurname.Text.Trim();
                    selectedCustomer.Paternal_name = CustomerPaternalName.Text.Trim();
                    selectedCustomer.Address = CustomerAddress.Text.Trim();

                    if (!IsValidPhoneNumber(CustomerPhone.Text))
                    {
                        MessageBox.Show("Телефон має бути записаний у вигляді (+999-99-999-99-99)!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        selectedCustomer.Phone = CustomerPhone.Text;

                        if (customers.Find(customer => customer.Phone.Equals(selectedCustomer.Phone), 0, 10).Count() == 0)
                        {
                            if (customers.Find(customer =>
                               customer.Name.Equals(selectedCustomer.Name)
                               && customer.Surname.Equals(selectedCustomer.Surname)
                               && customer.Paternal_name.Equals(selectedCustomer.Paternal_name), 0, 10).Count() == 0)
                            {
                                if (discounts.Get(customerNewDiscountId) == null)
                                {
                                    MessageBox.Show("Знижки з обраним ID не існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    selectedCustomer.Discount_Id = customerNewDiscountId;
                                    selectedCustomer.discount = discounts.Get(selectedCustomer.Discount_Id);

                                    customers.Update(selectedCustomer);
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
            int customerDiscountId = 0;
            int.TryParse(CustomerDiscountId.Text, out customerDiscountId);

            Discount discount = discounts.Get(customerDiscountId);

            if (discount == null)
            {
                discount = discounts.Get(0);
            }

            CustomerDiscountDesc.Text = discount.Description;
        }

        private void SeeFullDiscount_Click(object sender, EventArgs e)
        {
            int customerDiscountId = 0;
            int.TryParse(CustomerDiscountId.Text, out customerDiscountId);

            Discount discount = discounts.Get(customerDiscountId);

            if (discount == null)
            {
                discount = discounts.Get(0);
            }

            MessageBox.Show("Повний опис знижки: \n" + discount.Description + " \nРозмір знижки: " + (int)Math.Round(discount.Amount * 100, 0) + "%", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
