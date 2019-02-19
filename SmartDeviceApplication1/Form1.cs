using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace AutoMaintenance
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class frmService : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panTop;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Panel panCustomerInfo;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabUser;
		private System.Windows.Forms.TabPage tabCar;
		private System.Windows.Forms.Label lblFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblAdd;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.TextBox txtLName;
		private System.Windows.Forms.TextBox txtAdd;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cboMake;
		private System.Windows.Forms.ComboBox cboModel;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.Panel panDesc;
		private System.Windows.Forms.CheckBox chkRoutineMaint;
		private System.Windows.Forms.CheckBox chkProblem;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.MainMenu mainMenu1;

		public frmService()
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
			this.panTop = new System.Windows.Forms.Panel();
			this.lblDate = new System.Windows.Forms.Label();
			this.panCustomerInfo = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabUser = new System.Windows.Forms.TabPage();
			this.tabCar = new System.Windows.Forms.TabPage();
			this.lblFName = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.lblAdd = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.txtFName = new System.Windows.Forms.TextBox();
			this.txtLName = new System.Windows.Forms.TextBox();
			this.txtAdd = new System.Windows.Forms.TextBox();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.cboMake = new System.Windows.Forms.ComboBox();
			this.cboModel = new System.Windows.Forms.ComboBox();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.panDesc = new System.Windows.Forms.Panel();
			this.chkRoutineMaint = new System.Windows.Forms.CheckBox();
			this.chkProblem = new System.Windows.Forms.CheckBox();
			this.btnOK = new System.Windows.Forms.Button();
			// 
			// panTop
			// 
			this.panTop.BackColor = System.Drawing.Color.IndianRed;
			this.panTop.Controls.Add(this.lblDate);
			this.panTop.Size = new System.Drawing.Size(246, 24);
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(112, 8);
			this.lblDate.Size = new System.Drawing.Size(120, 16);
			this.lblDate.Text = "label1";
			// 
			// panCustomerInfo
			// 
			this.panCustomerInfo.Controls.Add(this.tabControl1);
			this.panCustomerInfo.Location = new System.Drawing.Point(0, 24);
			this.panCustomerInfo.Size = new System.Drawing.Size(248, 192);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabUser);
			this.tabControl1.Controls.Add(this.tabCar);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(258, 192);
			// 
			// tabUser
			// 
			this.tabUser.Controls.Add(this.txtNum);
			this.tabUser.Controls.Add(this.txtArea);
			this.tabUser.Controls.Add(this.txtAdd);
			this.tabUser.Controls.Add(this.txtLName);
			this.tabUser.Controls.Add(this.txtFName);
			this.tabUser.Controls.Add(this.lblPhone);
			this.tabUser.Controls.Add(this.lblAdd);
			this.tabUser.Controls.Add(this.lblLName);
			this.tabUser.Controls.Add(this.lblFName);
			this.tabUser.Location = new System.Drawing.Point(4, 4);
			this.tabUser.Size = new System.Drawing.Size(250, 166);
			this.tabUser.Text = "Customer Info";
			// 
			// tabCar
			// 
			this.tabCar.Controls.Add(this.panDesc);
			this.tabCar.Controls.Add(this.cboYear);
			this.tabCar.Controls.Add(this.cboModel);
			this.tabCar.Controls.Add(this.cboMake);
			this.tabCar.Location = new System.Drawing.Point(4, 4);
			this.tabCar.Size = new System.Drawing.Size(250, 166);
			this.tabCar.Text = "Car Info";
			// 
			// lblFName
			// 
			this.lblFName.Location = new System.Drawing.Point(8, 8);
			this.lblFName.Size = new System.Drawing.Size(64, 20);
			this.lblFName.Text = "First Name:";
			// 
			// lblLName
			// 
			this.lblLName.Location = new System.Drawing.Point(8, 40);
			this.lblLName.Size = new System.Drawing.Size(64, 20);
			this.lblLName.Text = "Last Name:";
			// 
			// lblAdd
			// 
			this.lblAdd.Location = new System.Drawing.Point(8, 81);
			this.lblAdd.Size = new System.Drawing.Size(64, 20);
			this.lblAdd.Text = "Address:";
			// 
			// lblPhone
			// 
			this.lblPhone.Location = new System.Drawing.Point(8, 128);
			this.lblPhone.Size = new System.Drawing.Size(64, 20);
			this.lblPhone.Text = "Phone #:";
			// 
			// txtFName
			// 
			this.txtFName.Location = new System.Drawing.Point(80, 8);
			this.txtFName.Size = new System.Drawing.Size(144, 20);
			this.txtFName.Text = "";
			// 
			// txtLName
			// 
			this.txtLName.Location = new System.Drawing.Point(80, 40);
			this.txtLName.Size = new System.Drawing.Size(144, 20);
			this.txtLName.Text = "";
			// 
			// txtAdd
			// 
			this.txtAdd.Location = new System.Drawing.Point(80, 72);
			this.txtAdd.Multiline = true;
			this.txtAdd.Size = new System.Drawing.Size(144, 40);
			this.txtAdd.Text = "";
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(80, 128);
			this.txtArea.Size = new System.Drawing.Size(32, 20);
			this.txtArea.Text = "";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(120, 128);
			this.txtNum.Size = new System.Drawing.Size(104, 20);
			this.txtNum.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(160, 232);
			this.btnSave.Text = "&Save";
			// 
			// cboMake
			// 
			this.cboMake.Location = new System.Drawing.Point(16, 16);
			this.cboMake.Size = new System.Drawing.Size(100, 21);
			// 
			// cboModel
			// 
			this.cboModel.Location = new System.Drawing.Point(128, 16);
			this.cboModel.Size = new System.Drawing.Size(100, 21);
			// 
			// cboYear
			// 
			this.cboYear.Location = new System.Drawing.Point(16, 56);
			this.cboYear.Size = new System.Drawing.Size(100, 21);
			// 
			// panDesc
			// 
			this.panDesc.BackColor = System.Drawing.Color.Tan;
			this.panDesc.Controls.Add(this.btnOK);
			this.panDesc.Controls.Add(this.chkProblem);
			this.panDesc.Controls.Add(this.chkRoutineMaint);
			this.panDesc.Location = new System.Drawing.Point(8, 88);
			this.panDesc.Size = new System.Drawing.Size(216, 56);
			// 
			// chkRoutineMaint
			// 
			this.chkRoutineMaint.Location = new System.Drawing.Point(8, 8);
			this.chkRoutineMaint.Size = new System.Drawing.Size(136, 20);
			this.chkRoutineMaint.Text = "Routine Maintenance";
			// 
			// chkProblem
			// 
			this.chkProblem.Location = new System.Drawing.Point(8, 32);
			this.chkProblem.Size = new System.Drawing.Size(136, 20);
			this.chkProblem.Text = "Problem";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(160, 32);
			this.btnOK.Size = new System.Drawing.Size(50, 20);
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmService
			// 
			this.ClientSize = new System.Drawing.Size(258, 312);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.panCustomerInfo);
			this.Controls.Add(this.panTop);
			this.Menu = this.mainMenu1;
			this.Text = "Service Form";
			this.Load += new System.EventHandler(this.fmService_Load);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>

		static void Main() 
		{
			Application.Run(new frmService());
		}

		private void fmService_Load(object sender, System.EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			Form frmDescr = new Description();
			frmDescr.Show();
		}
	}
}
