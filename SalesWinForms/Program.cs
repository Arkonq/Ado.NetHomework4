using System;
using System.Windows.Forms;

namespace SalesWinForms
{
	/*
	 * Создайте базу данных «Продажи» (в качестве формата базы данных можно использовать Microsoft Access). 
	 * Создайте внутри базы данных три таблицы:  
	 *		1) Таблица Покупатели. Столбцы: идентификатор, имя, фамилия;  
	 *		2) Таблица Продавцы. Столбцы: идентификатор, имя, фамилия;  
	 *		3) Таблица Продажи. Столбцы: идентификатор сделки, идентификатор покупателя, 
	 *			 идентификатор продавца, сумма сделки, дата сделки.
	 * Наполните таблицы данными, задайте правила ссылочной целостности.  
	 * Реализуйте WinForms приложение, позволяющее пользователю выбрать название таблицы из базы данных 
	 *		sample.mdb (например, с помощью выпадающего списка), в результате выбора таблицы приложение должно 
	 *		отображать содержимое данной таблицы на форму. 
	*/
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AddData();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormShowData());
		}
		static void AddData()
		{
			Customer customer = new Customer
			{
				FirstName = "Василий",
				LastName = "Печкин",
			};

			Seller seller = new Seller
			{
				FirstName = "Владислав",
				LastName = "Соколов",
			};

			Purchase purchase = new Purchase
			{
				CustomerId = customer.Id,
				SellerId = seller.Id,
				Sum = 100
			};

			CustomerRepository customerRepository = new CustomerRepository();
			customerRepository.Add(customer);

			SellerRepository sellerRepository = new SellerRepository();
			sellerRepository.Add(seller);

			PurchaseRepository purchaseRepository = new PurchaseRepository();
			purchaseRepository.Add(purchase);
		}
	}
}
