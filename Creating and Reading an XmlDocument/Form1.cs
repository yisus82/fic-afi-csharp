using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace XMLPractice_2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label InstructionsLabel;
		private System.Windows.Forms.TextBox Reminder1TextBox;
		private System.Windows.Forms.TextBox Reminder2TextBox;
		private System.Windows.Forms.TextBox XMLViewTextBox;
		private System.Windows.Forms.Button ReadXMLButton;
		private System.Windows.Forms.Button ShowXMLButton;
		private System.Windows.Forms.MainMenu mainMenu1;

		private XmlDocument _XmlDoc = new XmlDocument();

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
			this.InstructionsLabel = new System.Windows.Forms.Label();
			this.Reminder1TextBox = new System.Windows.Forms.TextBox();
			this.Reminder2TextBox = new System.Windows.Forms.TextBox();
			this.XMLViewTextBox = new System.Windows.Forms.TextBox();
			this.ReadXMLButton = new System.Windows.Forms.Button();
			this.ShowXMLButton = new System.Windows.Forms.Button();
			// 
			// InstructionsLabel
			// 
			this.InstructionsLabel.Location = new System.Drawing.Point(8, 8);
			this.InstructionsLabel.Size = new System.Drawing.Size(224, 24);
			this.InstructionsLabel.Text = "Enter Reminders in textbox\'s below:";
			// 
			// Reminder1TextBox
			// 
			this.Reminder1TextBox.Location = new System.Drawing.Point(16, 48);
			this.Reminder1TextBox.Size = new System.Drawing.Size(208, 20);
			this.Reminder1TextBox.Text = "";
			// 
			// Reminder2TextBox
			// 
			this.Reminder2TextBox.Location = new System.Drawing.Point(16, 80);
			this.Reminder2TextBox.Size = new System.Drawing.Size(208, 20);
			this.Reminder2TextBox.Text = "";
			// 
			// XMLViewTextBox
			// 
			this.XMLViewTextBox.BackColor = System.Drawing.Color.White;
			this.XMLViewTextBox.Location = new System.Drawing.Point(16, 120);
			this.XMLViewTextBox.Multiline = true;
			this.XMLViewTextBox.ReadOnly = true;
			this.XMLViewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.XMLViewTextBox.Size = new System.Drawing.Size(208, 72);
			this.XMLViewTextBox.Text = "";
			// 
			// ReadXMLButton
			// 
			this.ReadXMLButton.Location = new System.Drawing.Point(16, 232);
			this.ReadXMLButton.Size = new System.Drawing.Size(104, 24);
			this.ReadXMLButton.Text = "Read XML";
			this.ReadXMLButton.Click += new System.EventHandler(this.ReadXMLButton_Click);
			// 
			// ShowXMLButton
			// 
			this.ShowXMLButton.Location = new System.Drawing.Point(136, 232);
			this.ShowXMLButton.Size = new System.Drawing.Size(88, 24);
			this.ShowXMLButton.Text = "Show XML";
			this.ShowXMLButton.Click += new System.EventHandler(this.ShowXMLButton_Click);
			// 
			// Form1
			// 
			this.Controls.Add(this.ShowXMLButton);
			this.Controls.Add(this.ReadXMLButton);
			this.Controls.Add(this.XMLViewTextBox);
			this.Controls.Add(this.Reminder2TextBox);
			this.Controls.Add(this.Reminder1TextBox);
			this.Controls.Add(this.InstructionsLabel);
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

		private void ReadXMLButton_Click(object sender, System.EventArgs e)
		{
			BuildXMLDoc();

			//Variable that will contain the data read from the XMLDocument.
			System.Text.StringBuilder DisplayStringBuilder = new System.Text.StringBuilder();

			foreach(XmlNode reminderXmlNode in _XmlDoc.DocumentElement.ChildNodes) //Looping through the all the child nodes
			{
				DisplayStringBuilder.Append(reminderXmlNode.Name + ":" + reminderXmlNode.InnerText + " ");
			}

			XMLViewTextBox.Text = DisplayStringBuilder.ToString();
		}

		private void ShowXMLButton_Click(object sender, System.EventArgs e)
		{
			BuildXMLDoc();
			XMLViewTextBox.Text = _XmlDoc.InnerXml;
		}

		private void BuildXMLDoc()
		{
			XmlNode rootXmlNode;

			_XmlDoc.RemoveAll(); //Removing all nodes, that way we make sure newly added data gets added to the document.

			rootXmlNode = _XmlDoc.CreateElement("ThingsToDo"); //Creating the root node.
			_XmlDoc.AppendChild(rootXmlNode);

			rootXmlNode = _XmlDoc.CreateElement("Reminders"); //Creating the child nodes.
			rootXmlNode.InnerText = Reminder1TextBox.Text; //Inserting the text from a textbox between the node.
			_XmlDoc.DocumentElement.AppendChild(rootXmlNode); //Adding the newly created node and it's innerText to the root node.
			rootXmlNode = _XmlDoc.CreateElement("Reminders"); 
			rootXmlNode.InnerText = Reminder2TextBox.Text; 
			_XmlDoc.DocumentElement.AppendChild(rootXmlNode); 

		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
