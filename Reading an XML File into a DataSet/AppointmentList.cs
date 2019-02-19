using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml;
using System.Data.SqlServerCe;   // Add the System.Data.SqlServerCe and System.Data.Common refrence to the project

namespace LabLocalData
{
	/// <summary>
	/// Summary description for AppointmentList.
	/// </summary>
	public class AppointmentList : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Label TypeValueDisplayLabel;
		private System.Windows.Forms.Label NameToScheduleLabel;
		private System.Windows.Forms.Label TypeSetLabel;
		private System.Windows.Forms.Label ScheduledLabel;
		private System.Windows.Forms.Label TypeDisplayLabel;
		private System.Windows.Forms.ComboBox TypeComboBox;
		private System.Windows.Forms.ComboBox TimeComboBox;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.ListBox ScheduledListBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox PatientTextBox;
		private System.Windows.Forms.Button SaveToXMLButton;

		private static string _xmlDataFile = @"Program Files\LabLocalData\appointment.xml";

		private DataTable _confirmedDataTable;

		private string[] _timeStringArray = {"06:00 AM","07:00 AM","08:00 AM","09:00 AM","10:00 AM","11:00 AM","12:00 PM"};

		public AppointmentList()
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
			this.TitleLabel = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.ScheduledListBox = new System.Windows.Forms.ListBox();
			this.SaveToXMLButton = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.PatientTextBox = new System.Windows.Forms.TextBox();
			this.TypeSetLabel = new System.Windows.Forms.Label();
			this.TypeComboBox = new System.Windows.Forms.ComboBox();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.ScheduledLabel = new System.Windows.Forms.Label();
			this.TimeComboBox = new System.Windows.Forms.ComboBox();
			this.TypeValueDisplayLabel = new System.Windows.Forms.Label();
			this.TypeDisplayLabel = new System.Windows.Forms.Label();
			this.NameToScheduleLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			//
			// TitleLabel
			//
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.TitleLabel.Size = new System.Drawing.Size(88, 16);
			this.TitleLabel.Text = "Appointments";
			//
			// DateLabel
			//
			this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.DateLabel.Location = new System.Drawing.Point(136, 0);
			this.DateLabel.Size = new System.Drawing.Size(104, 16);
			this.DateLabel.Text = "Date:";
			this.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			// ScheduledListBox
			//
			this.ScheduledListBox.Location = new System.Drawing.Point(8, 136);
			this.ScheduledListBox.Size = new System.Drawing.Size(72, 114);
			//
			// SaveToXMLButton
			//
			this.SaveToXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.SaveToXMLButton.Location = new System.Drawing.Point(136, 80);
			this.SaveToXMLButton.Size = new System.Drawing.Size(96, 24);
			this.SaveToXMLButton.Text = "Save to XML File";
			this.SaveToXMLButton.Click += new System.EventHandler(this.SaveToXMLButton_Click);
			//
			// NameLabel
			//
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.NameLabel.Location = new System.Drawing.Point(8, 24);
			this.NameLabel.Size = new System.Drawing.Size(40, 16);
			this.NameLabel.Text = "Name:";
			//
			// PatientTextBox
			//
			this.PatientTextBox.Location = new System.Drawing.Point(48, 24);
			this.PatientTextBox.Size = new System.Drawing.Size(184, 22);
			this.PatientTextBox.Text = "";
			//
			// TypeSetLabel
			//
			this.TypeSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.TypeSetLabel.Location = new System.Drawing.Point(8, 48);
			this.TypeSetLabel.Size = new System.Drawing.Size(32, 16);
			this.TypeSetLabel.Text = "Type:";
			//
			// TypeComboBox
			//
			this.TypeComboBox.Items.Add("Ear");
			this.TypeComboBox.Items.Add("Eyes");
			this.TypeComboBox.Items.Add("Throat");
			this.TypeComboBox.Items.Add("Other");
			this.TypeComboBox.Location = new System.Drawing.Point(48, 48);
			this.TypeComboBox.Size = new System.Drawing.Size(72, 22);
			//
			// TimeLabel
			//
			this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.TimeLabel.Location = new System.Drawing.Point(128, 48);
			this.TimeLabel.Size = new System.Drawing.Size(40, 16);
			this.TimeLabel.Text = "Time:";
			//
			// ScheduledLabel
			//
			this.ScheduledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.ScheduledLabel.Location = new System.Drawing.Point(8, 120);
			this.ScheduledLabel.Size = new System.Drawing.Size(64, 16);
			this.ScheduledLabel.Text = "Scheduled:";
			//
			// TimeComboBox
			//
			this.TimeComboBox.Location = new System.Drawing.Point(160, 48);
			this.TimeComboBox.Size = new System.Drawing.Size(72, 22);
			//
			// TypeValueDisplayLabel
			//
			this.TypeValueDisplayLabel.Location = new System.Drawing.Point(96, 184);
			this.TypeValueDisplayLabel.Size = new System.Drawing.Size(40, 16);
			this.TypeValueDisplayLabel.Text = "Type";
			//
			// TypeDisplayLabel
			//
			this.TypeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.TypeDisplayLabel.Location = new System.Drawing.Point(96, 168);
			this.TypeDisplayLabel.Size = new System.Drawing.Size(32, 16);
			this.TypeDisplayLabel.Text = "Type:";
			//
			// NameToScheduleLabel
			//
			this.NameToScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.NameToScheduleLabel.Location = new System.Drawing.Point(96, 120);
			this.NameToScheduleLabel.Size = new System.Drawing.Size(40, 16);
			this.NameToScheduleLabel.Text = "Name:";
			//
			// NameTextBox
			//
			this.NameTextBox.Location = new System.Drawing.Point(96, 136);
			this.NameTextBox.ReadOnly = true;
			this.NameTextBox.Size = new System.Drawing.Size(136, 22);
			this.NameTextBox.Text = "";
			//
			// AppointmentList
			//
			this.BackColor = System.Drawing.Color.Silver;
			this.Controls.Add(this.TimeComboBox);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.TypeComboBox);
			this.Controls.Add(this.TypeSetLabel);
			this.Controls.Add(this.PatientTextBox);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.SaveToXMLButton);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.ScheduledListBox);
			this.Controls.Add(this.ScheduledLabel);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameToScheduleLabel);
			this.Controls.Add(this.TypeDisplayLabel);
			this.Controls.Add(this.TypeValueDisplayLabel);
			this.Menu = this.mainMenu1;
			this.Text = "AppointmentList";
			this.Load += new System.EventHandler(this.AppointmentList_Load);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main()
		{
			Application.Run(new AppointmentList());
		}

		private void AppointmentList_Load(object sender, System.EventArgs e)
		{
			DateLabel.Text = DateTime.Now.DayOfWeek.ToString();	//Formatting to show current day.

			GetDataFromXML();

			// Setup the controls
			SetControls();
		}

		private void GetDataFromXML()
		{

			DataSet ds = new DataSet(); 
			ds.ReadXml(_xmlDataFile); 


			//This is the DataTable that we are getting our scheduled appointments from
			DataTable tempDataTable = ds.Tables["confirmed"];

			// Sort the data
			_confirmedDataTable = SortDataTable(tempDataTable, "time");

		}

		private void SetControls()
		{

			//Populate the times comboBox
			TimeComboBox.DataSource = _timeStringArray;

			ScheduledListBox.DataSource = _confirmedDataTable;

			ScheduledListBox.DisplayMember = "time";

			NameTextBox.DataBindings.Add( 
				"Text", _confirmedDataTable, "name"); 
			TypeValueDisplayLabel.DataBindings.Add( 
				"Text", _confirmedDataTable, "type");

		}

		private void SaveToXMLButton_Click(object sender, System.EventArgs e)
		{
			BuildXMLDoc();
		}

		private void BuildXMLDoc()
		{

			XmlDocument xmlDoc = new XmlDocument();
			XmlNode confirmedNode;
			XmlNode timeNode;
			XmlNode nameNode;
			XmlNode typeNode;

			try
			{
				xmlDoc.Load(_xmlDataFile); 
 
				confirmedNode = xmlDoc.CreateElement("confirmed"); 
				xmlDoc.DocumentElement.AppendChild(confirmedNode); 
 
				timeNode = xmlDoc.CreateElement("time"); 
				timeNode.InnerText = TimeComboBox.SelectedValue.ToString(); 
				confirmedNode.AppendChild(timeNode); 
 
				nameNode = xmlDoc.CreateElement("name"); 
				nameNode.InnerText = PatientTextBox.Text; 
				confirmedNode.AppendChild(nameNode); 
 
				typeNode = xmlDoc.CreateElement("type"); 
				typeNode.InnerText = TypeComboBox.SelectedItem.ToString(); 
				confirmedNode.AppendChild(typeNode); 
				
				//Create a FileStream obj so we can save the XML file.
				FileStream strmSaveToFile;

				strmSaveToFile = new FileStream(_xmlDataFile, FileMode.OpenOrCreate, FileAccess.Write);

				//Instantiating a Datawriter obj so we can write the XML file to disk.
				StreamWriter wrDatawriter = new StreamWriter(strmSaveToFile);

				wrDatawriter.Write(xmlDoc.InnerXml);
				wrDatawriter.Close();

				MessageBox.Show("XML file saved!");

				ScheduledListBox.DataBindings.Clear(); //Clearing Bindings
				TypeValueDisplayLabel.DataBindings.Clear(); //Clearing Bindings
				NameTextBox.DataBindings.Clear(); //Clearing Bindings

				PatientTextBox.Text = "";
				TypeComboBox.SelectedIndex = 0;
				TimeComboBox.SelectedIndex = 0;

				//Refreshing the form with the newly added appointment.
				GetDataFromXML();
				SetControls();
			}
			catch
			{
				MessageBox.Show("There was a problem saving your XML file!");
			}
		}

		private  System.Data.DataTable SortDataTable(System.Data.DataTable DataTableToSort, string ColumnNameToSort)
		{
			// Make the DataView we will use and apply the table to be sorted
			System.Data.DataView dvTemp = new System.Data.DataView(DataTableToSort);

			// Set the Column to be sorted by
			dvTemp.Sort = ColumnNameToSort;

			// Create and setup the table we will use to return the data
			System.Data.DataTable NewDataTable = DataTableToSort.Clone();

			// Loop through all the rows in the data view and add each to the new table
			for (int i = 0; dvTemp.Count > i; i++)
			{
				NewDataTable.Rows.Add(dvTemp[i].Row.ItemArray);
			}

			// Return the new table
			return NewDataTable;
		}

	}
}
