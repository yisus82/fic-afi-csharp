using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace CreateAndFillDataSets
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button CreateDataSetButton;
		private System.Windows.Forms.Button FillDataSetButton;
		private System.Windows.Forms.Button ShowContentsButton;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.TextBox AddDataTextBox;
		private System.Windows.Forms.Button AddDataButton;
		private System.Windows.Forms.Button SaveDatasetButton;
		private System.Windows.Forms.Button BindButton;
		private System.Windows.Forms.ListBox DisplayListBox;

		private DataSet _CustomersDS = new DataSet("Customers");

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.CreateDataSetButton = new System.Windows.Forms.Button();
			this.FillDataSetButton = new System.Windows.Forms.Button();
			this.ShowContentsButton = new System.Windows.Forms.Button();
			this.AddDataTextBox = new System.Windows.Forms.TextBox();
			this.AddDataButton = new System.Windows.Forms.Button();
			this.SaveDatasetButton = new System.Windows.Forms.Button();
			this.BindButton = new System.Windows.Forms.Button();
			this.DisplayListBox = new System.Windows.Forms.ListBox();
			// 
			// CreateDataSetButton
			// 
			this.CreateDataSetButton.Location = new System.Drawing.Point(48, 80);
			this.CreateDataSetButton.Size = new System.Drawing.Size(144, 24);
			this.CreateDataSetButton.Text = "Create DataSet";
			this.CreateDataSetButton.Click += new System.EventHandler(this.CreateDataSetButton_Click);
			// 
			// FillDataSetButton
			// 
			this.FillDataSetButton.Location = new System.Drawing.Point(48, 120);
			this.FillDataSetButton.Size = new System.Drawing.Size(144, 24);
			this.FillDataSetButton.Text = "Fill DataSet";
			this.FillDataSetButton.Click += new System.EventHandler(this.FillDataSetButton_Click);
			// 
			// ShowContentsButton
			// 
			this.ShowContentsButton.Location = new System.Drawing.Point(48, 160);
			this.ShowContentsButton.Size = new System.Drawing.Size(144, 24);
			this.ShowContentsButton.Text = "Show Contents";
			this.ShowContentsButton.Click += new System.EventHandler(this.ShowContentsButton_Click);
			// 
			// AddDataTextBox
			// 
			this.AddDataTextBox.Location = new System.Drawing.Point(32, 200);
			this.AddDataTextBox.Text = "";
			// 
			// AddDataButton
			// 
			this.AddDataButton.Location = new System.Drawing.Point(152, 200);
			this.AddDataButton.Text = "Add Data";
			this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
			// 
			// SaveDatasetButton
			// 
			this.SaveDatasetButton.Location = new System.Drawing.Point(72, 232);
			this.SaveDatasetButton.Size = new System.Drawing.Size(96, 20);
			this.SaveDatasetButton.Text = "Save Dataset";
			this.SaveDatasetButton.Click += new System.EventHandler(this.SaveDatasetButton_Click);
			// 
			// BindButton
			// 
			this.BindButton.Location = new System.Drawing.Point(152, 24);
			this.BindButton.Text = "Bind";
			this.BindButton.Click += new System.EventHandler(this.BindButton_Click);
			// 
			// DisplayListBox
			// 
			this.DisplayListBox.Location = new System.Drawing.Point(48, 16);
			this.DisplayListBox.Size = new System.Drawing.Size(88, 54);
			// 
			// Form1
			// 
			this.Controls.Add(this.DisplayListBox);
			this.Controls.Add(this.BindButton);
			this.Controls.Add(this.SaveDatasetButton);
			this.Controls.Add(this.AddDataButton);
			this.Controls.Add(this.AddDataTextBox);
			this.Controls.Add(this.ShowContentsButton);
			this.Controls.Add(this.FillDataSetButton);
			this.Controls.Add(this.CreateDataSetButton);
			this.Menu = this.mainMenu1;
			this.Text = "Form1";

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main()
		{
			Application.Run(new Form1());
		}

		private void CreateDataSetButton_Click(object sender, System.EventArgs e)
		{

			DataTable infoDataTable = new DataTable("Info"); //Create a DataTable for our DataSet

			DataColumn newCol = new DataColumn(); //Create a DataColumn for our DataTabe
			newCol.DataType= System.Type.GetType("System.String"); //Make the Column type a string
			newCol.ColumnName = "Name"; //Give the Column a name

			infoDataTable.Columns.Add(newCol); //Add the new Column to the DataTable

			_CustomersDS.Tables.Add(infoDataTable); //Add the DataTable to the DataSet

			MessageBox.Show("Done");

		}

		private void FillDataSetButton_Click(object sender, System.EventArgs e)
		{
			DataRow newDataRow = _CustomersDS.Tables["Info"].NewRow(); //Create a DataRow
			newDataRow["Name"] = "Suzan Fine"; //Add a name to the Column
			_CustomersDS.Tables["Info"].Rows.Add(newDataRow); //Add the row to the DataSet

			newDataRow = _CustomersDS.Tables["Info"].NewRow();
			newDataRow["Name"] = "Paul West";
			_CustomersDS.Tables["Info"].Rows.Add(newDataRow);

			newDataRow = _CustomersDS.Tables["Info"].NewRow();
			newDataRow["Name"] = "Anne Paper";
			_CustomersDS.Tables["Info"].Rows.Add(newDataRow);

			MessageBox.Show("Done");
		}

		private void ShowContentsButton_Click(object sender, System.EventArgs e)
		{
			// Loop through each row and display each item in the Name Coulumn
			foreach(DataRow currDR in _CustomersDS.Tables["Info"].Rows)
			{
				MessageBox.Show(currDR["Name"].ToString());
			}
		}

		private void AddDataButton_Click(object sender, System.EventArgs e)
		{
			if (_CustomersDS.Tables["Info"] != null) 
			{ 
				DataRow newDataRow = 
					_CustomersDS.Tables["Info"].NewRow(); 
				newDataRow["Name"] = AddDataTextBox.Text; 
				_CustomersDS.Tables["Info"].Rows.Add(newDataRow); 
				_CustomersDS.AcceptChanges();
				AddDataTextBox.Text = "";
				MessageBox.Show("Done"); 
			} 
		}

		private void SaveDatasetButton_Click(object sender, System.EventArgs e)
		{
			_CustomersDS.WriteXml("ActionStars.xml"); 
			MessageBox.Show("DataSet Saved"); 
		}

		private void BindButton_Click(object sender, System.EventArgs e)
		{
			DataTable infoDataTable = _CustomersDS.Tables["Info"]; 
			DisplayListBox.DataSource = infoDataTable; 
			DisplayListBox.DisplayMember = "Name";
		}

	}
}
