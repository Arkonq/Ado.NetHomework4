namespace SalesWinForms
{
	partial class FormShowData
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonShowSellers = new System.Windows.Forms.Button();
			this.buttonShowCustomers = new System.Windows.Forms.Button();
			this.buttonShowPurchases = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonShowSellers
			// 
			this.buttonShowSellers.BackColor = System.Drawing.Color.Cyan;
			this.buttonShowSellers.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonShowSellers.ForeColor = System.Drawing.SystemColors.Highlight;
			this.buttonShowSellers.Location = new System.Drawing.Point(286, 103);
			this.buttonShowSellers.Name = "buttonShowSellers";
			this.buttonShowSellers.Size = new System.Drawing.Size(205, 54);
			this.buttonShowSellers.TabIndex = 0;
			this.buttonShowSellers.Text = "Показать Продавцов";
			this.buttonShowSellers.UseVisualStyleBackColor = false;
			this.buttonShowSellers.Click += new System.EventHandler(this.buttonShowSellers_Click);
			// 
			// buttonShowCustomers
			// 
			this.buttonShowCustomers.BackColor = System.Drawing.Color.Cyan;
			this.buttonShowCustomers.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonShowCustomers.ForeColor = System.Drawing.SystemColors.Highlight;
			this.buttonShowCustomers.Location = new System.Drawing.Point(286, 180);
			this.buttonShowCustomers.Name = "buttonShowCustomers";
			this.buttonShowCustomers.Size = new System.Drawing.Size(205, 54);
			this.buttonShowCustomers.TabIndex = 1;
			this.buttonShowCustomers.Text = "Показать Покупателей";
			this.buttonShowCustomers.UseVisualStyleBackColor = false;
			this.buttonShowCustomers.Click += new System.EventHandler(this.buttonShowCustomers_Click);
			// 
			// buttonShowPurchases
			// 
			this.buttonShowPurchases.BackColor = System.Drawing.Color.Cyan;
			this.buttonShowPurchases.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonShowPurchases.ForeColor = System.Drawing.SystemColors.Highlight;
			this.buttonShowPurchases.Location = new System.Drawing.Point(286, 256);
			this.buttonShowPurchases.Name = "buttonShowPurchases";
			this.buttonShowPurchases.Size = new System.Drawing.Size(205, 54);
			this.buttonShowPurchases.TabIndex = 2;
			this.buttonShowPurchases.Text = "Показать Покупки";
			this.buttonShowPurchases.UseVisualStyleBackColor = false;
			this.buttonShowPurchases.Click += new System.EventHandler(this.buttonShowPurchases_Click);
			// 
			// FormShowData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonShowPurchases);
			this.Controls.Add(this.buttonShowCustomers);
			this.Controls.Add(this.buttonShowSellers);
			this.Name = "FormShowData";
			this.Text = "FormSales";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonShowSellers;
		private System.Windows.Forms.Button buttonShowCustomers;
		private System.Windows.Forms.Button buttonShowPurchases;
	}
}

