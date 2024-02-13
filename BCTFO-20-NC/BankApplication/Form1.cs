using BankApplication.Models;
using BankApplication.Repository;
using BankApplication.Repository.Interfaces;

namespace BankApplication
{
    public partial class Form1 : Form
    {
        //Dependency injection
        private readonly IRepository _repository;
        public Form1(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var result = _repository.GetAllCustomers();
                dataList.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var item = dataList.SelectedItem as Customer;

                if (item != null)
                {
                    FillForm(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            var newCustomer = GetCustomer();

            if (newCustomer != null)
            {
                _repository.AddNewCustomer(newCustomer);
            }
        }



        private void FillForm(Customer item)
        {
            nameValue.Text = item.Name;
            pinValue.Text = item.IdentityNumber;
            emailValue.Text = item.Email;
            phoneValue.Text = item.PhoneNumber;
            accountTypeValue.Text = item.Type.ToString();
        }

        private Customer GetCustomer()
        {
            Customer customer = new();

            customer.Name = nameValue.Text;
            customer.IdentityNumber = pinValue.Text;
            customer.Email = emailValue.Text;
            customer.PhoneNumber = phoneValue.Text;
            customer.Type = int.Parse(accountTypeValue.Text);

            return customer;
        }

        private void ClearForm()
        {
            nameValue.Text = string.Empty;
            pinValue.Text = string.Empty;
            emailValue.Text = string.Empty;
            phoneValue.Text = string.Empty;
            accountTypeValue.Text = string.Empty;
        }


    }
}
