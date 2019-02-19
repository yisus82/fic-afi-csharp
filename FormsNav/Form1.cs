using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace FormsNav
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;

		public Form1()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}
		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			// 
			// menuItem1
			// 
			this.menuItem1.Text = "Form 2";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 136);
			this.button1.Text = "Form 3";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 88);
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.Text = "Navigation Sample 1";
			// 
			// Form1
			// 
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Menu = this.mainMenu1;
			this.Text = "Form1";
			//this.Load += new System.EventHandler(this.Form1_Load);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>

		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Form3 frm3 = new Form3();
			frm3.Show();
		}

	}
}
