
namespace Laundry
{
	partial class ActiveForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveForm));
			this.ActiveTable = new System.Windows.Forms.DataGridView();
			this.Active_btn = new System.Windows.Forms.Button();
			this.Finish_btn = new System.Windows.Forms.Button();
			this.Report_btn = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ActiveTable)).BeginInit();
			this.SuspendLayout();
			// 
			// ActiveTable
			// 
			this.ActiveTable.AllowUserToAddRows = false;
			this.ActiveTable.AllowUserToDeleteRows = false;
			this.ActiveTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ActiveTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ActiveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ActiveTable.Location = new System.Drawing.Point(12, 69);
			this.ActiveTable.MultiSelect = false;
			this.ActiveTable.Name = "ActiveTable";
			this.ActiveTable.ReadOnly = true;
			this.ActiveTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ActiveTable.Size = new System.Drawing.Size(776, 369);
			this.ActiveTable.TabIndex = 0;
			// 
			// Active_btn
			// 
			this.Active_btn.Location = new System.Drawing.Point(12, 40);
			this.Active_btn.Name = "Active_btn";
			this.Active_btn.Size = new System.Drawing.Size(120, 23);
			this.Active_btn.TabIndex = 1;
			this.Active_btn.Text = "Активные стирки";
			this.Active_btn.UseVisualStyleBackColor = true;
			// 
			// Finish_btn
			// 
			this.Finish_btn.Location = new System.Drawing.Point(138, 40);
			this.Finish_btn.Name = "Finish_btn";
			this.Finish_btn.Size = new System.Drawing.Size(130, 23);
			this.Finish_btn.TabIndex = 2;
			this.Finish_btn.Text = "Завершенные стирки";
			this.Finish_btn.UseVisualStyleBackColor = true;
			this.Finish_btn.Click += new System.EventHandler(this.Finish_btn_Click);
			// 
			// Report_btn
			// 
			this.Report_btn.Location = new System.Drawing.Point(274, 40);
			this.Report_btn.Name = "Report_btn";
			this.Report_btn.Size = new System.Drawing.Size(120, 23);
			this.Report_btn.TabIndex = 3;
			this.Report_btn.Text = "Кассовый отчет";
			this.Report_btn.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(678, 40);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(110, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Добавить стирку";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// ActiveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.Report_btn);
			this.Controls.Add(this.Finish_btn);
			this.Controls.Add(this.Active_btn);
			this.Controls.Add(this.ActiveTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ActiveForm";
			this.Text = "Активные стирки - \"Постирушки\"";
			this.Load += new System.EventHandler(this.ActiveForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ActiveTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ActiveTable;
		private System.Windows.Forms.Button Active_btn;
		private System.Windows.Forms.Button Finish_btn;
		private System.Windows.Forms.Button Report_btn;
		private System.Windows.Forms.Button button4;
	}
}