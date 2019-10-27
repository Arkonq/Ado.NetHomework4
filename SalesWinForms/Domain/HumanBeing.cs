using System;

namespace SalesWinForms
{
	public abstract class HumanBeing
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}