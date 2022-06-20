
namespace Laundry
{
	partial class AuthorizationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LoginField = new System.Windows.Forms.TextBox();
			this.PasswordField = new System.Windows.Forms.TextBox();
			this.Autorization_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Laundry.Properties.Resources.logo;
			this.pictureBox1.InitialImage = global::Laundry.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(150, 149);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// LoginField
			// 
			this.LoginField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginField.Location = new System.Drawing.Point(275, 149);
			this.LoginField.Name = "LoginField";
			this.LoginField.Size = new System.Drawing.Size(250, 26);
			this.LoginField.TabIndex = 1;
			// 
			// PasswordField
			// 
			this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PasswordField.Location = new System.Drawing.Point(275, 191);
			this.PasswordField.Name = "PasswordField";
			this.PasswordField.Size = new System.Drawing.Size(250, 26);
			this.PasswordField.TabIndex = 2;
			// 
			// Autorization_btn
			// 
			this.Autorization_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Autorization_btn.Location = new System.Drawing.Point(357, 236);
			this.Autorization_btn.Name = "Autorization_btn";
			this.Autorization_btn.Size = new System.Drawing.Size(86, 31);
			this.Autorization_btn.TabIndex = 3;
			this.Autorization_btn.Text = "Войти";
			this.Autorization_btn.UseVisualStyleBackColor = true;
			this.Autorization_btn.Click += new System.EventHandler(this.Autorization_btn_Click);
			// 
			// AuthorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Autorization_btn);
			this.Controls.Add(this.PasswordField);
			this.Controls.Add(this.LoginField);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AuthorizationForm";
			this.Text = "Авторизация - \"Постирушки\"";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox LoginField;
		private System.Windows.Forms.TextBox PasswordField;
		private System.Windows.Forms.Button Autorization_btn;
	}
}

