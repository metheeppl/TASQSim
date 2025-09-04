using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TASQSim
{
	public partial class frmMain : Form
	{
        private decimal MTRDEVID;
        private decimal BAYID =1 ;
        private decimal Q_ID;
        private decimal[] SQSTEP;
		private decimal iLogHrs = 12;
		private bool bBypsFocusChk = false;
		private int iBayMax = 10;
        private bool bIOWritable = true;
        private const string ION_WS = "DT04";
        private const string ION_WGH = "WGH";
        private const string ION_CARD = "DT01";
        private const string ION_BS = "DT08";
        private const string ION_RES = "DT16";
        private const string ION_GRS = "DT15";
        private const string ION_QNTY = "DT09";
        public frmMain()
		{
			InitializeComponent();
            this.SQSTEP = new decimal[5];
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'dsSim.T_ORDERS_CACHE' table. You can move, or remove it, as needed.
            this.taORDERSCACHE.Fill(this.dsSim.T_ORDERS_CACHE);
            // TODO: This line of code loads data into the 'dsSim.T_ORDERS_WEB' table. You can move, or remove it, as needed.
            this.bAYIDToolStripTextBox.Text = "1";
            this.bAYIDToolStripTextBox.Focus();
            this.taQUEUE1.Fill(this.dsSim.T_QUEUE1);
            this.taMETER_Q.FillAll(this.dsSim.T_METER_Q);
            iBayMax = (int)this.dsSim.T_METER_Q.Count;
			RefreshLoadSQ();
			RefreshIO();
			RefreshTab();
			this.tstIOFilter.Text = "";
			this.timer1.Enabled = true;
		}

		private void fillToolStripButton_Click(object sender, EventArgs e)
		{
			this.bBypsFocusChk = true;
			try
			{
				RefreshLoadSQ();
				RefreshIO();
				RefreshTab();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			this.bBypsFocusChk = false;

		}
		private void RefreshLoadSQ()
		{
            this.BAYID = int.Parse(this.bAYIDToolStripTextBox.Text);
            bsMeterQ.Filter = "METER_ID=" + this.BAYID.ToString();
            this.taMETER_Q.FillAll(this.dsSim.T_METER_Q);
            bsMeterQAll.Position = (int)this.BAYID-1;
            this.MTRDEVID = this.dsSim.T_METER_Q.FindByMETER_ID(this.BAYID).DEVICEID;
            this.Q_ID = ((DataRowView)this.bsMeterQ.Current).Row.Field<decimal>("Q_ID");
            bsQueue.Filter = "Q_ID=" + this.Q_ID.ToString();
            this.taQUEUE.Fill(this.dsSim.T_QUEUE);
        }
		private void RefreshIO()
		{
			RefreshIOR();
			RefreshIOW();
		}
		private void RefreshIOR()
		{
			if (!this.dgvDevIO_R.Focused || bBypsFocusChk) this.taDevIO_R.Fill(this.dsSim.DEVICEIO_R, this.MTRDEVID);
		}
		private void RefreshIOW()
		{
			if (!this.dgvDevIO_W.Focused || bBypsFocusChk) this.taDevIO_W.Fill(this.dsSim.DEVICEIO_W, this.MTRDEVID, this.MTRDEVID);
		}
		private void RefreshTab()
		{
			switch (this.tabBottom.SelectedIndex)
			{
				case 0:
					if (!this.QUEUE_SQ_LOGDataGridView.Focused || bBypsFocusChk) this.taSQLOG.Fill(this.dsSim.QUEUE_SQ_LOG, this.iLogHrs);
					break;
				case 1:
                    if (!this.dgwLSQLog.Focused || bBypsFocusChk) this.taLSQLog.Fill(this.dsSim.LOADING_SQ_LOG, this.iLogHrs);
                    break;
				case 2:
                    if (!this.dEVICEIO_LOG2DataGridView.Focused || bBypsFocusChk) this.taIOLog2.FillByHrs(this.dsSim.DEVICEIO_LOG2, this.iLogHrs);
                    break;
				case 3:
                    if (!this.dEVICEIO_LOGDataGridView.Focused || bBypsFocusChk) this.taIOLog.FillByHrs(this.dsSim.DEVICEIO_LOG, this.iLogHrs);
                    break;
				case 4:
                    if (!this.dgwQ.Focused || bBypsFocusChk) this.taQUEUE1.Fill(this.dsSim.T_QUEUE1);
                    break;
                case 5:
                    if (!this.dgwO.Focused || bBypsFocusChk) this.taORDERS_WEB.Fill(this.dsSim.T_ORDERS_WEB);
                    break;
                case 6:
                    if (!this.dgwCache.Focused || bBypsFocusChk) this.taORDERSCACHE.Fill(this.dsSim.T_ORDERS_CACHE);
                    break;
            }
        }

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshTab();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.tsSQ.Checked) RefreshLoadSQ();
			if (this.tsIO.Checked) RefreshIO();
			if (this.tsLog.Checked) RefreshTab();
		}

		private void tstIOFilter_TextChanged(object sender, EventArgs e)
		{
			this.bsDEVICEIO_R.RemoveFilter();
		}

		private void tstIOFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)
			{
				this.bsDEVICEIO_R.Filter = this.tstIOFilter.Text;
			}
		}

		private void dgvDevIO_W_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bsDEVICEIO_W.Current != null)
			{
				dsSIM.DEVICEIO_WRow drow = (dsSIM.DEVICEIO_WRow)(((DataRowView)(this.bsDEVICEIO_W.Current)).Row);
				if (this.MTRDEVID > 0)
				{
					if (drow.REQ_W == 0)
					{
						string stmp = drow.IOVALUE.ToString();
						if (Common.InputBoxDialog.Show(drow.IONAME, "Write IO", stmp, out stmp) == DialogResult.OK)
						{
							SetIOW(stmp, this.MTRDEVID, drow.IONAME);
						}
					}
					else
					{
						ClearIOREQW(this.MTRDEVID, drow.IONAME);
					}
				}
			}
		}

		private void dgvDevIO_R_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bsDEVICEIO_R.Current != null)
			{
				dsSIM.DEVICEIO_RRow drow = (dsSIM.DEVICEIO_RRow)(((DataRowView)(this.bsDEVICEIO_R.Current)).Row);
				if (this.MTRDEVID > 0)
				{
					string stmp = drow.IOVALUE.ToString();
					if (Common.InputBoxDialog.Show(drow.IONAME, "Simulate IO", stmp, out stmp) == DialogResult.OK)
					{
						SetIOR(stmp, this.MTRDEVID, drow.IONAME);
					}
				}
			}
		}
		private void bAYIDToolStripTextBox_Click(object sender, EventArgs e)
		{
			int iNextBay = int.Parse(this.bAYIDToolStripTextBox.Text) + 1;
			this.bAYIDToolStripTextBox.Text = ((iNextBay > iBayMax) ? 1 : iNextBay).ToString();
			try
			{
				RefreshLoadSQ();
				RefreshIO();
				RefreshTab();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void tstbLogHrs_Click(object sender, EventArgs e)
		{
			if (this.tstbLogHrs.Text == "144")
				this.tstbLogHrs.Text = "12";
			else
				this.tstbLogHrs.Text = (int.Parse(this.tstbLogHrs.Text) + 12).ToString();

			this.iLogHrs = decimal.Parse(this.tstbLogHrs.Text);
			this.RefreshTab();
		}

		private void tstbLogHrs_DoubleClick(object sender, EventArgs e)
		{
			this.tstbLogHrs.Text = "12";
			this.iLogHrs = 12;
			this.RefreshTab();
		}

		private void LogToLocalFile(string Log1)//, string Log2)
		{
			//using (System.IO.StreamWriter sw = new System.IO.StreamWriter(String.Format("{0}TASSIM{1:MMddhh}{2}", "", DateTime.Now, ".log"), true))
			//{
			//	sw.WriteLine(Log1);
			//	//if (Log2 != string.Empty) sw.Write(Log2);
			//	sw.Close();
			//}
		}

		private void tsbtnSQL_Click(object sender, EventArgs e)
		{
            
            string stmp = "update T_METER_Q set Q_AUTO='y' where METER_ID=1";
            string iofltr = this.tstIOFilter.Text.Trim();
            if (iofltr != "") stmp = iofltr;
            if (Common.InputBoxDialog.Show("Query Text", "Run query", stmp, out stmp) == DialogResult.OK)
            {
                OracleConnection orcn = this.taMETER_Q.Connection;
                OracleCommand orcc = new OracleCommand(stmp);
                orcc.Connection = orcn;
                if (orcn.State!=ConnectionState.Open)orcn.Open();
                int rownum = orcc.ExecuteNonQuery();
                MessageBox.Show($"{rownum} rows effceted.");
            }
            //string sLogFN = String.Format("{0}TASQSIM{1:MMddhh}{2}", "", DateTime.Now, ".log");

            //string sLog = ReadAllText(sLogFN);
            //if (sLog.Length > 0)
            //    ShowSQLTextBox(sLog, sLogFN);

            //System.Diagnostics.Process p1 = new System.Diagnostics.Process();
            //p1.StartInfo = new System.Diagnostics.ProcessStartInfo("Notepad.exe", sLogFN);
            //p1.Start();
            //p1 = null;
        }

		private string ReadAllText(string TextFileName)
		{
			string sText = String.Empty;
			try
			{
				using (System.IO.StreamReader myFile = new System.IO.StreamReader(TextFileName))
				{
					sText = myFile.ReadToEnd();
				}
			}
			catch { }
			return sText;
		}

		private void ShowSQLTextBox(string ShowText, string ShowTitle)
		{
			Form f1 = new Form();
			f1.Text = ShowTitle;
			f1.Width = 800;
			f1.Height = 600;

			TextBox tb1 = new TextBox();
			tb1.Multiline = true;
			tb1.WordWrap = true;
			tb1.ScrollBars = ScrollBars.Both;

			f1.Controls.Add(tb1);
			tb1.Dock = DockStyle.Fill;
			tb1.Text = ShowText;

			f1.ShowDialog();

			f1 = null;
			tb1 = null;
		}

        private void SetIOR(string sValue, decimal DeviceID1, string IOName)
        {
            //if (this.bIOWritable)
            //{
                if (IOName == ION_WS || IOName == ION_WGH)
                {
                    sim_ta.UpdateIOR(sValue, DeviceID1 + 1, DeviceID1, ION_WS);
                    sim_ta.UpdateIOR(sValue, DeviceID1 + 1, DeviceID1, ION_WGH);
                    sim_ta.UpdateIOR(sValue, DeviceID1 + 1, DeviceID1 + 1, ION_WGH);
                }
                else
                    sim_ta.UpdateIOR(sValue, DeviceID1, DeviceID1, IOName);

                LogToLocalFile(string.Format("UPDATE DEVICEIO_R SET IOVALUE='{0}' WHERE GROUPID=0 AND DEVICEID={1} AND IONAME='{2}';", sValue, DeviceID1.ToString(), IOName));
                this.RefreshIOR();
            //}
        }
        private void SetIOW(string sValue, decimal DeviceID1, string IOName)
        {
            if (this.bIOWritable)
            {
                sim_ta.UpdateIOW(sValue, DeviceID1, DeviceID1, IOName);
                LogToLocalFile(string.Format("UPDATE DEVICEIO_W SET IOVALUE='{0}',REQW=1 WHERE GROUPID=0 AND DEVICEID{1} AND IONAME='{2}';", sValue, DeviceID1.ToString(), IOName));
            }
        }
        private void ClearIOREQW(decimal DeviceID1,string IOName)
        {
            if (this.bIOWritable)
            {
                sim_ta.ClearREQ(DeviceID1, DeviceID1, IOName);
                LogToLocalFile(string.Format("UPDATE DEVICEIO_W SET REQW=0 WHERE GROUPID=0 AND DEVICEID={0} AND IONAME='{1}';",DeviceID1.ToString(), IOName));
            }
        }
		private void SimLoadProg(decimal IncrsLoad)
		{
            IncIOVal(ION_WS, (decimal)IncrsLoad);
			RefreshIOR();
		}
        private void SetStep(decimal SQ_STEP)
        {
            if (SQ_STEP == 0)
            {
                SetIOR("0", this.MTRDEVID, "ET01");
                this.SQSTEP[(int)BAYID] = 0;
            }
            else if (SQ_STEP!=this.SQSTEP[(int)BAYID])
            {
                SetIOR((this.BAYID * 100 + SQ_STEP).ToString(), this.MTRDEVID, "ET01");
                SetIOR("0", this.MTRDEVID, "FL01");
                this.SQSTEP[(int)BAYID] = SQ_STEP;
                RefreshIOR();
            }
            else
                this.SQSTEP[(int)BAYID] = 0;

        }
        private void IncIOVal(string IONAME, decimal? IncValue)
		{
			decimal? dc1 = sim_ta.ReadIOR(IONAME, this.MTRDEVID, this.MTRDEVID);
			string stmp = left((dc1 + IncValue).ToString(), 9);
			SetIOR(stmp, this.MTRDEVID, IONAME);
		}

		private string left(string sIn, int iLen)
		{
			int l = sIn.Length;
			if (l <= iLen)
				return sIn;
			else
				return sIn.Substring(0, iLen);
		}

		private void btnL04_Click(object sender, EventArgs e)
		{
			SimLoadProg(50);
		}

		private void btnL100_Click(object sender, EventArgs e)
		{
			SimLoadProg(100);
		}

		private void btnL500_Click(object sender, EventArgs e)
		{
			SimLoadProg(500);
		}

		private void btnRst_Click(object sender, EventArgs e)
		{
            SetIOR("0", this.MTRDEVID, ION_WS);
		}

		private void btnL1000_Click(object sender, EventArgs e)
		{
			SimLoadProg(1000);
		}

        private void btnS0_Click(object sender, EventArgs e)
        {
            sim_ta.BayInit(this.MTRDEVID);
            sim_ta.SyncIO_ClearReq(this.MTRDEVID);
            this.SetStep(0);
        }

        private void btnS1_Click(object sender, EventArgs e)// Card In
        {
            decimal STEP = 1;
            if (this.SQSTEP[(int)BAYID]!=STEP)
            {
                SetIOR(this.tbCard.Text, this.MTRDEVID, ION_CARD);
                this.SetStep(STEP);
            }
            else
            {
                SyncIO();
                SetIOR("5", this.MTRDEVID, ION_BS);//  Verifed
                this.SetStep(STEP);
            }
                
        }

        private void btnS2_Click(object sender, EventArgs e)// Verify
        {
            decimal STEP = 2;
            if (this.SQSTEP[(int)BAYID]!=STEP)
            {
                this.SetStep(STEP);
            }
            else
            {
                SyncIO();
                SetIOR("5", this.MTRDEVID, ION_BS);// Verifed
                this.SetStep(STEP);
            }

        }

        private void btnS3_Click(object sender, EventArgs e) // B.Start
        {
            decimal STEP = 3;
            if (this.SQSTEP[(int)BAYID]!=STEP)
                this.SetStep(STEP);
            else
            {
                SyncIO();
                SetIOR("6", this.MTRDEVID, ION_BS);// Active
                this.SetStep(STEP);
            }
        }

        private void btnS4_Click(object sender, EventArgs e)// B.End
        {
            decimal STEP = 4;
            if (this.SQSTEP[(int)BAYID]!=STEP)
            {
                SetIOR(cARD_TAGIDTextBox.Text, this.MTRDEVID, ION_RES);
                this.SetStep(STEP);
            }
            else
            {
                SyncIO();
                SetIOR("10", this.MTRDEVID, ION_BS);// Bay Fin..
                this.SetStep(STEP);
            }
        }

        private void btnS5_Click(object sender, EventArgs e) // Gross
        {
            decimal STEP = 5;
            if (this.SQSTEP[(int)BAYID]!=STEP)
            {
                this.SetStep(STEP);
            }
            else
            {
                SyncIO();
                SetIOR("10", this.MTRDEVID, ION_BS);// Bay Fin..
                this.SetStep(STEP);
            }
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            decimal STEP = 7;
            if (this.SQSTEP[(int)BAYID]!=STEP)
            {
                this.SetStep(STEP);
                this.SetStep(STEP);
                SyncIO();
            }
            
        }

        private void btnIORF_Click(object sender, EventArgs e)
        {
            RefreshIOR();
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            SetIOR("1", this.MTRDEVID, "FL01");
            RefreshIOR();
        }

        private void btnSyncIO_Click(object sender, EventArgs e)
        {
            SyncIO();
        }

        private void SyncIO()
        {
            this.sim_ta.SyncIO(this.MTRDEVID);
            this.sim_ta.SyncIO_ClearReq(this.MTRDEVID);
            RefreshIO();
        }

        private void dgwMeterQAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.bsMeterQAll.Current != null)
            {
                dsSIM.T_METER_QRow drow = (dsSIM.T_METER_QRow)(((DataRowView)(this.bsMeterQAll.Current)).Row);
                if (drow!=null)
                {
                    decimal dtmp = drow.METER_ID;
                    this.bAYIDToolStripTextBox.Text = dtmp.ToString();
                    try
                    {
                        RefreshLoadSQ();
                        RefreshIO();
                        RefreshTab();

                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSTare_Click(object sender, EventArgs e)
        {
            SetIOR(this.textBox2.Text, this.MTRDEVID, ION_WS);
        }
    }
}