using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
	public partial class ActiveForm : Form
	{

		LaundryEntities db = new LaundryEntities();

		public ActiveForm()
		{
			InitializeComponent();
		}

		private void UpdateTable()
		{
			var active = from activserv in db.Services
						 join un1 in db.Washers on activserv.Washer equals un1.ID
						 join un2 in db.Рowders on activserv.Powder equals un2.ID
						 join un3 in db.Drying on activserv.Drying equals un3.ID
						 join un4 in db.ProcessingStatus on activserv.Status equals un4.ID 
						 join un5 in db.Staff on activserv.Staff equals un5.ID
						 select new
						 { 
							 ID = activserv.ID,
							 Washer = un1.Name,
							 Powder = un2.Name,
							 Drying = un3.Name,
							 Status = un4.Name,
							 Staff = un5.LastName
						 };

			ActiveTable.DataSource = active.ToList();
			ActiveTable.Columns[0].HeaderText = "№";
			ActiveTable.Columns[1].HeaderText = "Номер стиральной машины";
			ActiveTable.Columns[2].HeaderText = "Порошок";
			ActiveTable.Columns[3].HeaderText = "Сушка";
			ActiveTable.Columns[4].Visible = false;
			ActiveTable.Columns[5].HeaderText = "Сотрудник";

		}

		private void Finish_btn_Click(object sender, EventArgs e)
		{

		}

		private void ActiveForm_Load(object sender, EventArgs e)
		{
			UpdateTable();
		}
	}
}
