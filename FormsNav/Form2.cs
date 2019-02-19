using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FormsNav
{
	/// <summary>
	/// Descripción breve de Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	
		public Form2()
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			// 
			// listBox1
			// 
			this.listBox1.Items.Add("Form 1");
			this.listBox1.Items.Add("Form 3");
			this.listBox1.Location = new System.Drawing.Point(72, 56);
			this.listBox1.Size = new System.Drawing.Size(100, 93);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 176);
			this.button1.Text = "Go";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 16);
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.Text = "Navigation Sample 2";
			// 
			// Form2
			// 
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Text = "Form2";

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			switch(listBox1.SelectedIndex)
			{
				case 0:
					this.Close();
					break;
				case 1:
					Form frm3 = new Form3();
					frm3.Show();
					this.Close();
					break;
			}

		}
	}
}
