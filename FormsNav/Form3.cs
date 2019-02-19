using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FormsNav
{
	/// <summary>
	/// Descripción breve de Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	
		public Form3()
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(72, 96);
			this.radioButton1.Text = "Form 1";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(72, 136);
			this.radioButton2.Text = "Form 2";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 192);
			this.button1.Text = "Go";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 40);
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.Text = "Navigation Sample 3";
			// 
			// Form3
			// 
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Text = "Form3";

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (radioButton1.Checked)
			{
				this.Close();
				return;
			}
			
			if (radioButton2.Checked)
			{
				Form frm2 = new Form2();
				frm2.Show();
				this.Close();
			}
		}
	}
}
