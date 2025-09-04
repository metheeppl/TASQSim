using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TASQSim.Common
{
	/// <summary>
	/// Summary description for InputBox.
	///
	public class InputBoxDialog : Form
	{

		#region Windows Contols and Constructor

		private Label lblPrompt;
		private Button btnOK;
		private Button button1;
		private TextBox txtInput;
		/// <summary>
		/// Required designer variable.
		///
		private System.ComponentModel.Container components = null;

		public InputBoxDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#endregion

		#region Dispose

		/// <summary>
		/// Clean up any resources being used.
		///
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		///
		private void InitializeComponent()
		{
			this.lblPrompt = new Label();
			this.btnOK = new Button();
			this.button1 = new Button();
			this.txtInput = new TextBox();
			this.SuspendLayout();
			//
			// lblPrompt
			//
			this.lblPrompt.Anchor =
			  ((AnchorStyles)
			  ((((AnchorStyles.Top |
			  AnchorStyles.Bottom)
			  | AnchorStyles.Left)
			  | AnchorStyles.Right)));
			this.lblPrompt.Location = new System.Drawing.Point(12, 9);
			this.lblPrompt.Name = "lblPrompt";
			this.lblPrompt.Size = new System.Drawing.Size(302, 82);
			this.lblPrompt.TabIndex = 3;
			//
			// btnOK
			//
			this.btnOK.DialogResult = DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(326, 24);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(64, 24);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "&OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			//
			// button1
			//
			this.button1.DialogResult = DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(326, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Cancel";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			//
			// txtInput
			//
			this.txtInput.Location = new System.Drawing.Point(8, 100);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(379, 20);
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "";
            this.txtInput.DoubleClick += new EventHandler(InputBoxDialog_DoubleClick);
			//
			// InputBoxDialog
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(398, 128);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblPrompt);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputBoxDialog";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "InputBox";
			this.AcceptButton = this.btnOK;
			this.Load += new System.EventHandler(this.InputBox_Load);
			this.ResumeLayout(false);

		}

        void InputBoxDialog_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string stmp = Clipboard.GetText();
                this.txtInput.Text = stmp;
            }
            catch { }
        }
		#endregion

		#region Private Variables
		string formCaption = string.Empty;
		string formPrompt = string.Empty;
		string inputResponse = string.Empty;
		string defaultValue = string.Empty;
		#endregion

		#region Public Properties
		public string FormCaption
		{
			get { return formCaption; }
			set { formCaption = value; }
		} // property FormCaption
		public string FormPrompt
		{
			get { return formPrompt; }
			set { formPrompt = value; }
		} // property FormPrompt
		public string InputResponse
		{
			get { return inputResponse; }
			set { inputResponse = value; }
		} // property InputResponse
		public char PasswordChar
		{
			get { return this.txtInput.PasswordChar; }
			set { txtInput.PasswordChar = value; }
		} // property InputMask
		public string DefaultValue
		{
			get { return defaultValue; }
			set { defaultValue = value; }
		} // property DefaultValue

		#endregion

		#region Form and Control Events
		private void InputBox_Load(object sender, System.EventArgs e)
		{
			this.txtInput.Text = defaultValue;
			this.lblPrompt.Text = formPrompt;
			this.Text = formCaption;
			this.txtInput.SelectionStart = 0;
			this.txtInput.SelectionLength = this.txtInput.Text.Length;
			this.txtInput.Focus();
		}


		private void btnOK_Click(object sender, System.EventArgs e)
		{
			InputResponse = this.txtInput.Text;
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion

		public static DialogResult Show ( string prompt, string title, string defaultValue, out string sResult)
		{
			InputBoxDialog ib = new InputBoxDialog();
			ib.FormPrompt = prompt;
			ib.FormCaption = title;
			ib.DefaultValue = defaultValue;
			DialogResult dr = ib.ShowDialog();
			string s = ib.InputResponse;
			ib.Close();
			sResult = s;
			return dr;
		} // method: InputBox

	}
}
