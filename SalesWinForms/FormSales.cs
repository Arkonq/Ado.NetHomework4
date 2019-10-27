using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SalesWinForms
{
	public partial class FormShowData : Form
	{
		public FormShowData()
		{
			InitializeComponent();
		}

		private void buttonShowSellers_Click(object sender, EventArgs e)
		{
			SellerRepository sellerRepository = new SellerRepository();
			ICollection<Seller> sellers = sellerRepository.GetAll();

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Данные из таблицы Продавцов: \n");

			foreach(var seller in sellers)
			{
				stringBuilder.Append($"{seller.Id} {seller.FirstName} {seller.LastName}\n");
			}

			MessageBox.Show(stringBuilder.ToString());
		}

		private void buttonShowCustomers_Click(object sender, EventArgs e)
		{
			CustomerRepository customerRepository = new CustomerRepository();
			ICollection<Customer> customers = customerRepository.GetAll();

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Данные из таблицы Покупателей: \n");

			foreach (var customer in customers)
			{
				stringBuilder.Append($"{customer.Id} {customer.FirstName} {customer.LastName}\n");
			}

			MessageBox.Show(stringBuilder.ToString());
		}

		private void buttonShowPurchases_Click(object sender, EventArgs e)
		{
			PurchaseRepository purchaseRepository = new PurchaseRepository();
			ICollection<Purchase> purchases = purchaseRepository.GetAll();

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Данные из таблицы Покупок: \n");

			foreach (var purchase in purchases)
			{
				stringBuilder.Append($"{purchase.Id} {purchase.SellerId} {purchase.CustomerId} {purchase.Sum} {purchase.CreationDate}\n");
			}

			MessageBox.Show(stringBuilder.ToString());
		}
	}
}
