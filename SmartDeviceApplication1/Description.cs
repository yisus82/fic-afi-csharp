using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoMaintenance
{
	/// <summary>
	/// Descripción breve de Description.
	/// </summary>
	public class Description : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.Panel panDesc;
		private System.Windows.Forms.CheckBox chkTires;
		private System.Windows.Forms.CheckBox chkEngine;
		private System.Windows.Forms.CheckBox chkOther;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.CheckBox chkBrakes;
	
		public Description()
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
			this.lblArea = new System.Windows.Forms.Label();
			this.lblDesc = new System.Windows.Forms.Label();
			this.panDesc = new System.Windows.Forms.Panel();
			this.chkBrakes = new System.Windows.Forms.CheckBox();
			this.chkOther = new System.Windows.Forms.CheckBox();
			this.chkTires = new System.Windows.Forms.CheckBox();
			this.chkEngine = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtDesc = new System.Windows.Forms.TextBox();
			// 
			// lblArea
			// 
			this.lblArea.Location = new System.Drawing.Point(8, 8);
			this.lblArea.Text = "Problem Area";
			// 
			// lblDesc
			// 
			this.lblDesc.Location = new System.Drawing.Point(8, 96);
			this.lblDesc.Text = "Description";
			// 
			// panDesc
			// 
			this.panDesc.BackColor = System.Drawing.Color.NavajoWhite;
			this.panDesc.Controls.Add(this.chkBrakes);
			this.panDesc.Controls.Add(this.chkOther);
			this.panDesc.Controls.Add(this.chkTires);
			this.panDesc.Controls.Add(this.chkEngine);
			this.panDesc.Location = new System.Drawing.Point(8, 32);
			this.panDesc.Size = new System.Drawing.Size(216, 56);
			// 
			// chkBrakes
			// 
			this.chkBrakes.Location = new System.Drawing.Point(112, 8);
			this.chkBrakes.Size = new System.Drawing.Size(80, 20);
			this.chkBrakes.Text = "Brakes";
			// 
			// chkOther
			// 
			this.chkOther.Location = new System.Drawing.Point(112, 32);
			this.chkOther.Size = new System.Drawing.Size(80, 20);
			this.chkOther.Text = "Other";
			// 
			// chkTires
			// 
			this.chkTires.Location = new System.Drawing.Point(8, 32);
			this.chkTires.Size = new System.Drawing.Size(80, 20);
			this.chkTires.Text = "Tires";
			// 
			// chkEngine
			// 
			this.chkEngine.Location = new System.Drawing.Point(8, 8);
			this.chkEngine.Size = new System.Drawing.Size(80, 20);
			this.chkEngine.Text = "Engine";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(152, 240);
			this.btnSave.Text = "&Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(8, 120);
			this.txtDesc.Multiline = true;
			this.txtDesc.Size = new System.Drawing.Size(216, 112);
			this.txtDesc.Text = "";
			// 
			// Description
			// 
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.panDesc);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.lblArea);
			this.Text = "Problem Description";

		}
		#endregion

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
