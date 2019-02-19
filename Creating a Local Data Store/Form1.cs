using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlServerCe;
using System.Data.Common;
using System.Text;


namespace LocalDataStore
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{

		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.SqlServerCe.SqlCeConnection cn;

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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(40, 16);
			this.label1.Size = new System.Drawing.Size(152, 48);
			this.label1.Text = "Accessing SQL Server CE Data";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 72);
			this.button1.Size = new System.Drawing.Size(88, 20);
			this.button1.Text = "Data Reader";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(128, 72);
			this.button2.Size = new System.Drawing.Size(88, 20);
			this.button2.Text = "Data Adapter";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.Location = new System.Drawing.Point(16, 104);
			this.dataGrid1.Size = new System.Drawing.Size(200, 152);
			this.dataGrid1.Text = "dataGrid1";
			// 
			// Form1
			// 
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Menu = this.mainMenu1;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main()
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{

			try
			{
				System.IO.File.Delete("\\My Documents\\prac3.sdf");

				System.Data.SqlServerCe.SqlCeEngine SQLEngine  = new System.Data.SqlServerCe.SqlCeEngine("data source=\\My Documents\\prac3.sdf");
				SQLEngine.CreateDatabase();

				// Next, open the database.
				cn = new System.Data.SqlServerCe.SqlCeConnection("Data Source=\\My Documents\\prac3.sdf");
				cn.Open();

				//Create the structure of the database using SQL statements.
				// Create the Titles table.
				String SQL = "CREATE TABLE Titles (TitleID nchar(5) Primary Key "
					+ "NOT NULL,TitleName nvarchar(40) NOT NULL)";
				System.Data.SqlServerCe.SqlCeCommand cmd = new System.Data.SqlServerCe.SqlCeCommand(SQL, cn);
				cmd.CommandType = CommandType.Text;
				cmd.ExecuteNonQuery();
				SQL = "";

				//Insert Data into the table.
				SQL = "INSERT INTO Titles (TitleID, TitleName) VALUES "
					+ "('MSCF1','Compact Framework')";
				cmd.CommandText = SQL;
				cmd.ExecuteNonQuery();

				SQL = "";
				SQL = "INSERT INTO Titles (TitleID, TitleName) VALUES "
					+ "('MSCE1','SQLCE DB')";
				cmd.CommandText = SQL;
				cmd.ExecuteNonQuery();

			}
			catch(SqlCeException ex)
			{
				ShowErrors(ex);
			}
			finally
			{
				cn.Close();
			}
		}

		public void ShowErrors(SqlCeException e)
		{
			SqlCeErrorCollection errorCollection   = e.Errors;
			StringBuilder bld = new StringBuilder();
			Exception inner   = e.InnerException;

			if(inner != null)
			{
				MessageBox.Show(("Inner Exception: " + inner.ToString()));
			}

			foreach( SqlCeError err  in errorCollection)
			{
				bld.Append("\n" + " Error Code: " + err.HResult.ToString());
				bld.Append("\n" + " Message   : " + err.Message);
				bld.Append("\n" + " Minor Err.: " + err.NativeError);
				bld.Append("\n" + " Source    : " + err.Source);

				foreach(int numPar in err.NumericErrorParameters)
				{
					if (0 != numPar)
					{
						bld.Append("\n" + " Num. Par. : " + numPar);
					}
				}

				foreach(string errPar in err.ErrorParameters)
				{
					if (string.Empty != errPar)
					{
						bld.Append("\n" + " Err. Par. : " + errPar);
					}
				}

				MessageBox.Show(bld.ToString());
				bld.Remove(0, bld.Length);
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			cn = new System.Data.SqlServerCe.SqlCeConnection("Data Source=\\My Documents\\prac3.sdf");
			cn.Open();
			SqlCeCommand cmd = cn.CreateCommand();
			cmd.CommandText = "SELECT TitleName FROM Titles";
			SqlCeDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				MessageBox.Show(reader.GetString(0));
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			cn = new System.Data.SqlServerCe.SqlCeConnection("Data Source=\\My Documents\\prac3.sdf");
			SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Titles",cn);
			cmd.CommandType = CommandType.Text;
			SqlCeDataAdapter adapter = new SqlCeDataAdapter();
			adapter.SelectCommand = cmd;
			DataSet ds = new DataSet();
			adapter.Fill(ds,"Titles");
			//foreach(DataRow dr in ds.Tables["Titles"].Rows)
			//{
			//	MessageBox.Show(dr["TitleName"].ToString());
			//}
			this.dataGrid1.DataSource = ds.Tables["Titles"];
		}

	}
}
