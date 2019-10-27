using System;

namespace SalesWinForms
{
	public class Purchase
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid CustomerId { get; set; }
		public Guid SellerId { get; set; }
		public int Sum { get; set; }
		public DateTime CreationDate { get; set; } = DateTime.Now;
	}
}
