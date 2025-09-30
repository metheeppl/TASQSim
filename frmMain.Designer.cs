namespace TASQSim
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bAYIDLabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label lOADINGMODELabel;
            System.Windows.Forms.Label oRDER_IDLabel;
            System.Windows.Forms.Label bATCH_IDLabel;
            System.Windows.Forms.Label bATCH_QNTYLabel;
            System.Windows.Forms.Label cARD_LABELLabel;
            System.Windows.Forms.Label tM_CHECKINLabel;
            System.Windows.Forms.Label lICPLATELabel;
            System.Windows.Forms.Label sTIMERLabel;
            System.Windows.Forms.Label mSG1Label;
            System.Windows.Forms.Label mSG2Label;
            System.Windows.Forms.Label aLERTLabel;
            System.Windows.Forms.Label oRDER_QNTYLabel;
            System.Windows.Forms.Label dEBUG_MSGLabel;
            System.Windows.Forms.Label uSTR4Label;
            System.Windows.Forms.Label pRVBATCHIDLabel;
            System.Windows.Forms.Label cARD_TAGIDLabel;
            System.Windows.Forms.Label oCARD_LABELLabel;
            System.Windows.Forms.Label oCARD_TAGIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label sQERRORLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.chk2KLPM = new System.Windows.Forms.CheckBox();
            this.chk500LPM = new System.Windows.Forms.CheckBox();
            this.chk1KLPM = new System.Windows.Forms.CheckBox();
            this.dgwMeterQAll = new System.Windows.Forms.DataGridView();
            this.mETERIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAINTENANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRYRUNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROG_Q1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROG_Q2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMeterQAll = new System.Windows.Forms.BindingSource(this.components);
            this.dsSim = new TASQSim.dsSIM();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.bsMeterQ = new System.Windows.Forms.BindingSource(this.components);
            this.tbRegW = new System.Windows.Forms.TextBox();
            this.bsQueue = new System.Windows.Forms.BindingSource(this.components);
            this.tbMaxW = new System.Windows.Forms.TextBox();
            this.oCARD_TAGIDTextBox = new System.Windows.Forms.TextBox();
            this.sTIMERTextBox = new System.Windows.Forms.TextBox();
            this.aLERTTextBox = new System.Windows.Forms.TextBox();
            this.tbTareW = new System.Windows.Forms.TextBox();
            this.uSTR4TextBox = new System.Windows.Forms.TextBox();
            this.cARD_TAGIDTextBox = new System.Windows.Forms.TextBox();
            this.mSG1TextBox = new System.Windows.Forms.TextBox();
            this.mSG2TextBox = new System.Windows.Forms.TextBox();
            this.sQERRORTextBox = new System.Windows.Forms.TextBox();
            this.dEBUG_MSGTextBox = new System.Windows.Forms.TextBox();
            this.btnSTare = new System.Windows.Forms.Button();
            this.btnL1000 = new System.Windows.Forms.Button();
            this.btnS7 = new System.Windows.Forms.Button();
            this.btnS5 = new System.Windows.Forms.Button();
            this.btnS4 = new System.Windows.Forms.Button();
            this.btnS3 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.btnSyncIO = new System.Windows.Forms.Button();
            this.btnIORF = new System.Windows.Forms.Button();
            this.btnSwDry = new System.Windows.Forms.Button();
            this.btnSwAuto = new System.Windows.Forms.Button();
            this.btnSwMain = new System.Windows.Forms.Button();
            this.btnS1 = new System.Windows.Forms.Button();
            this.btnL500 = new System.Windows.Forms.Button();
            this.btnRst = new System.Windows.Forms.Button();
            this.btnL100 = new System.Windows.Forms.Button();
            this.btnL04 = new System.Windows.Forms.Button();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bAYIDTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbAuto = new System.Windows.Forms.TextBox();
            this.bATCH_IDTextBox = new System.Windows.Forms.TextBox();
            this.bATCH_QNTYTextBox = new System.Windows.Forms.TextBox();
            this.cARD_LABELTextBox = new System.Windows.Forms.TextBox();
            this.tM_CHECKINTextBox = new System.Windows.Forms.TextBox();
            this.tbDry = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.pRVBATCHIDTextBox = new System.Windows.Forms.TextBox();
            this.oCARD_LABELTextBox = new System.Windows.Forms.TextBox();
            this.dgvDevIO_W = new System.Windows.Forms.DataGridView();
            this.iONAMEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOVALUEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDEVICEIO_W = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.bAYIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bAYIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsSQ = new System.Windows.Forms.ToolStripButton();
            this.tsLog = new System.Windows.Forms.ToolStripButton();
            this.tstbLogHrs = new System.Windows.Forms.ToolStripTextBox();
            this.tsIO = new System.Windows.Forms.ToolStripButton();
            this.tstIOFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSQL = new System.Windows.Forms.ToolStripButton();
            this.tabBottom = new System.Windows.Forms.TabControl();
            this.tpgSQLog = new System.Windows.Forms.TabPage();
            this.QUEUE_SQ_LOGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSQLOG = new System.Windows.Forms.BindingSource(this.components);
            this.tpgCache = new System.Windows.Forms.TabPage();
            this.dgwCache = new System.Windows.Forms.DataGridView();
            this.bsORDERSCACHE = new System.Windows.Forms.BindingSource(this.components);
            this.tpgQ = new System.Windows.Forms.TabPage();
            this.dgwQ = new System.Windows.Forms.DataGridView();
            this.qIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRYRUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STDTAREWEIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXWEIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGULATIONWEIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wAITTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRONTLICENSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEARLICENSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLTANKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSPARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSEXITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsQUEUE1 = new System.Windows.Forms.BindingSource(this.components);
            this.tpgORDER = new System.Windows.Forms.TabPage();
            this.dgwO = new System.Windows.Forms.DataGridView();
            this.bsORDERS_WEB = new System.Windows.Forms.BindingSource(this.components);
            this.tpgLSQLog = new System.Windows.Forms.TabPage();
            this.dgwLSQLog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLSQLog = new System.Windows.Forms.BindingSource(this.components);
            this.tpgIOLog2 = new System.Windows.Forms.TabPage();
            this.dEVICEIO_LOG2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIOLog2 = new System.Windows.Forms.BindingSource(this.components);
            this.tpgIOLog = new System.Windows.Forms.TabPage();
            this.dEVICEIO_LOGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIOLog = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDevIO_R = new System.Windows.Forms.DataGridView();
            this.iONAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOVALUEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEADONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDEVICEIO_R = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelRgh = new System.Windows.Forms.Panel();
            this.taSQLOG = new TASQSim.dsSIMTableAdapters.QUEUE_SQ_LOGTableAdapter();
            this.taIOLog = new TASQSim.dsSIMTableAdapters.DEVICEIO_LOGTableAdapter();
            this.taDevIO_R = new TASQSim.dsSIMTableAdapters.DEVICEIO_RTableAdapter();
            this.taDevIO_W = new TASQSim.dsSIMTableAdapters.DEVICEIO_WTableAdapter();
            this.sim_ta = new TASQSim.dsSIMTableAdapters.SimTableAdapter();
            this.taIOLog2 = new TASQSim.dsSIMTableAdapters.DEVICEIO_LOG2TableAdapter();
            this.taMETER_Q = new TASQSim.dsSIMTableAdapters.T_METER_QTableAdapter();
            this.taQUEUE = new TASQSim.dsSIMTableAdapters.T_QUEUETableAdapter();
            this.taQUEUE1 = new TASQSim.dsSIMTableAdapters.T_QUEUE1TableAdapter();
            this.taORDERS_WEB = new TASQSim.dsSIMTableAdapters.T_ORDERS_WEBTableAdapter();
            this.taLSQLog = new TASQSim.dsSIMTableAdapters.LOADING_SQ_LOGTableAdapter();
            this.taORDERSCACHE = new TASQSim.dsSIMTableAdapters.T_ORDERS_CACHETableAdapter();
            this.qSTATUSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCODEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEARRIVEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARRIERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRONTLICENSEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEARLICENSEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRIVER1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNTYDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAREWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAXWEIGHTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLTANKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEARRIVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mETERIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRONTLICENSEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEARLICENSEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNTYDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDTAREWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAXWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROSSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOADEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSTAREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSBSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSBENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSFINISHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSBOLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEIGHTSCALEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALCQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bAYIDLabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            lOADINGMODELabel = new System.Windows.Forms.Label();
            oRDER_IDLabel = new System.Windows.Forms.Label();
            bATCH_IDLabel = new System.Windows.Forms.Label();
            bATCH_QNTYLabel = new System.Windows.Forms.Label();
            cARD_LABELLabel = new System.Windows.Forms.Label();
            tM_CHECKINLabel = new System.Windows.Forms.Label();
            lICPLATELabel = new System.Windows.Forms.Label();
            sTIMERLabel = new System.Windows.Forms.Label();
            mSG1Label = new System.Windows.Forms.Label();
            mSG2Label = new System.Windows.Forms.Label();
            aLERTLabel = new System.Windows.Forms.Label();
            oRDER_QNTYLabel = new System.Windows.Forms.Label();
            dEBUG_MSGLabel = new System.Windows.Forms.Label();
            uSTR4Label = new System.Windows.Forms.Label();
            pRVBATCHIDLabel = new System.Windows.Forms.Label();
            cARD_TAGIDLabel = new System.Windows.Forms.Label();
            oCARD_LABELLabel = new System.Windows.Forms.Label();
            oCARD_TAGIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            sQERRORLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeterQAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeterQAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeterQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevIO_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDEVICEIO_W)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.tabBottom.SuspendLayout();
            this.tpgSQLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QUEUE_SQ_LOGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSQLOG)).BeginInit();
            this.tpgCache.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsORDERSCACHE)).BeginInit();
            this.tpgQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQUEUE1)).BeginInit();
            this.tpgORDER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsORDERS_WEB)).BeginInit();
            this.tpgLSQLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLSQLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLSQLog)).BeginInit();
            this.tpgIOLog2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEIO_LOG2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIOLog2)).BeginInit();
            this.tpgIOLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEIO_LOGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIOLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevIO_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDEVICEIO_R)).BeginInit();
            this.panelRgh.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAYIDLabel
            // 
            bAYIDLabel.AutoSize = true;
            bAYIDLabel.Location = new System.Drawing.Point(3, 4);
            bAYIDLabel.Name = "bAYIDLabel";
            bAYIDLabel.Size = new System.Drawing.Size(42, 13);
            bAYIDLabel.TabIndex = 0;
            bAYIDLabel.Text = "BAYID:";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(116, 4);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(83, 13);
            dESCRIPTIONLabel.TabIndex = 2;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // lOADINGMODELabel
            // 
            lOADINGMODELabel.AutoSize = true;
            lOADINGMODELabel.Location = new System.Drawing.Point(3, 21);
            lOADINGMODELabel.Name = "lOADINGMODELabel";
            lOADINGMODELabel.Size = new System.Drawing.Size(88, 13);
            lOADINGMODELabel.TabIndex = 4;
            lOADINGMODELabel.Text = "MAINTENANCE:";
            // 
            // oRDER_IDLabel
            // 
            oRDER_IDLabel.AutoSize = true;
            oRDER_IDLabel.Location = new System.Drawing.Point(3, 38);
            oRDER_IDLabel.Name = "oRDER_IDLabel";
            oRDER_IDLabel.Size = new System.Drawing.Size(54, 13);
            oRDER_IDLabel.TabIndex = 6;
            oRDER_IDLabel.Text = "Q_AUTO:";
            // 
            // bATCH_IDLabel
            // 
            bATCH_IDLabel.AutoSize = true;
            bATCH_IDLabel.Location = new System.Drawing.Point(3, 89);
            bATCH_IDLabel.Name = "bATCH_IDLabel";
            bATCH_IDLabel.Size = new System.Drawing.Size(62, 13);
            bATCH_IDLabel.TabIndex = 8;
            bATCH_IDLabel.Text = "QUEUE ID:";
            // 
            // bATCH_QNTYLabel
            // 
            bATCH_QNTYLabel.AutoSize = true;
            bATCH_QNTYLabel.Location = new System.Drawing.Point(157, 72);
            bATCH_QNTYLabel.Name = "bATCH_QNTYLabel";
            bATCH_QNTYLabel.Size = new System.Drawing.Size(54, 13);
            bATCH_QNTYLabel.TabIndex = 10;
            bATCH_QNTYLabel.Text = "Q. QNTY:";
            // 
            // cARD_LABELLabel
            // 
            cARD_LABELLabel.AutoSize = true;
            cARD_LABELLabel.Location = new System.Drawing.Point(160, 124);
            cARD_LABELLabel.Name = "cARD_LABELLabel";
            cARD_LABELLabel.Size = new System.Drawing.Size(58, 13);
            cARD_LABELLabel.TabIndex = 12;
            cARD_LABELLabel.Text = "PROG Q1:";
            // 
            // tM_CHECKINLabel
            // 
            tM_CHECKINLabel.AutoSize = true;
            tM_CHECKINLabel.Location = new System.Drawing.Point(3, 108);
            tM_CHECKINLabel.Name = "tM_CHECKINLabel";
            tM_CHECKINLabel.Size = new System.Drawing.Size(64, 13);
            tM_CHECKINLabel.TabIndex = 14;
            tM_CHECKINLabel.Text = "SQ.START:";
            // 
            // lICPLATELabel
            // 
            lICPLATELabel.AutoSize = true;
            lICPLATELabel.Location = new System.Drawing.Point(3, 55);
            lICPLATELabel.Name = "lICPLATELabel";
            lICPLATELabel.Size = new System.Drawing.Size(57, 13);
            lICPLATELabel.TabIndex = 28;
            lICPLATELabel.Text = "DRYRUN:";
            // 
            // sTIMERLabel
            // 
            sTIMERLabel.AutoSize = true;
            sTIMERLabel.Location = new System.Drawing.Point(2, 141);
            sTIMERLabel.Name = "sTIMERLabel";
            sTIMERLabel.Size = new System.Drawing.Size(54, 13);
            sTIMERLabel.TabIndex = 30;
            sTIMERLabel.Text = "SQ.TIME:";
            // 
            // mSG1Label
            // 
            mSG1Label.AutoSize = true;
            mSG1Label.Location = new System.Drawing.Point(200, 38);
            mSG1Label.Name = "mSG1Label";
            mSG1Label.Size = new System.Drawing.Size(40, 13);
            mSG1Label.TabIndex = 32;
            mSG1Label.Text = "MSG1:";
            // 
            // mSG2Label
            // 
            mSG2Label.AutoSize = true;
            mSG2Label.Location = new System.Drawing.Point(200, 55);
            mSG2Label.Name = "mSG2Label";
            mSG2Label.Size = new System.Drawing.Size(40, 13);
            mSG2Label.TabIndex = 34;
            mSG2Label.Text = "MSG2:";
            // 
            // aLERTLabel
            // 
            aLERTLabel.AutoSize = true;
            aLERTLabel.Location = new System.Drawing.Point(2, 158);
            aLERTLabel.Name = "aLERTLabel";
            aLERTLabel.Size = new System.Drawing.Size(53, 13);
            aLERTLabel.TabIndex = 38;
            aLERTLabel.Text = "SQ.NUM:";
            // 
            // oRDER_QNTYLabel
            // 
            oRDER_QNTYLabel.AutoSize = true;
            oRDER_QNTYLabel.Location = new System.Drawing.Point(3, 72);
            oRDER_QNTYLabel.Name = "oRDER_QNTYLabel";
            oRDER_QNTYLabel.Size = new System.Drawing.Size(53, 13);
            oRDER_QNTYLabel.TabIndex = 40;
            oRDER_QNTYLabel.Text = "STATUS:";
            // 
            // dEBUG_MSGLabel
            // 
            dEBUG_MSGLabel.AutoSize = true;
            dEBUG_MSGLabel.Location = new System.Drawing.Point(192, 21);
            dEBUG_MSGLabel.Name = "dEBUG_MSGLabel";
            dEBUG_MSGLabel.Size = new System.Drawing.Size(48, 13);
            dEBUG_MSGLabel.TabIndex = 48;
            dEBUG_MSGLabel.Text = "DEBUG:";
            // 
            // uSTR4Label
            // 
            uSTR4Label.AutoSize = true;
            uSTR4Label.Location = new System.Drawing.Point(3, 124);
            uSTR4Label.Name = "uSTR4Label";
            uSTR4Label.Size = new System.Drawing.Size(57, 13);
            uSTR4Label.TabIndex = 66;
            uSTR4Label.Text = "SQ.TARE:";
            // 
            // pRVBATCHIDLabel
            // 
            pRVBATCHIDLabel.AutoSize = true;
            pRVBATCHIDLabel.Location = new System.Drawing.Point(283, 4);
            pRVBATCHIDLabel.Name = "pRVBATCHIDLabel";
            pRVBATCHIDLabel.Size = new System.Drawing.Size(60, 13);
            pRVBATCHIDLabel.TabIndex = 70;
            pRVBATCHIDLabel.Text = "PRV Q. ID:";
            // 
            // cARD_TAGIDLabel
            // 
            cARD_TAGIDLabel.AutoSize = true;
            cARD_TAGIDLabel.Location = new System.Drawing.Point(160, 141);
            cARD_TAGIDLabel.Name = "cARD_TAGIDLabel";
            cARD_TAGIDLabel.Size = new System.Drawing.Size(58, 13);
            cARD_TAGIDLabel.TabIndex = 72;
            cARD_TAGIDLabel.Text = "PROG Q2:";
            // 
            // oCARD_LABELLabel
            // 
            oCARD_LABELLabel.AutoSize = true;
            oCARD_LABELLabel.Location = new System.Drawing.Point(160, 158);
            oCARD_LABELLabel.Name = "oCARD_LABELLabel";
            oCARD_LABELLabel.Size = new System.Drawing.Size(57, 13);
            oCARD_LABELLabel.TabIndex = 74;
            oCARD_LABELLabel.Text = "PROG T1:";
            // 
            // oCARD_TAGIDLabel
            // 
            oCARD_TAGIDLabel.AutoSize = true;
            oCARD_TAGIDLabel.Location = new System.Drawing.Point(160, 174);
            oCARD_TAGIDLabel.Name = "oCARD_TAGIDLabel";
            oCARD_TAGIDLabel.Size = new System.Drawing.Size(57, 13);
            oCARD_TAGIDLabel.TabIndex = 76;
            oCARD_TAGIDLabel.Text = "PROG T2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(2, 174);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 6;
            label1.Text = "COUNT:";
            // 
            // sQERRORLabel
            // 
            sQERRORLabel.AutoSize = true;
            sQERRORLabel.Location = new System.Drawing.Point(157, 89);
            sQERRORLabel.Name = "sQERRORLabel";
            sQERRORLabel.Size = new System.Drawing.Size(64, 13);
            sQERRORLabel.TabIndex = 36;
            sQERRORLabel.Text = "Q. FULLTK:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(280, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 76;
            label2.Text = "MAX. W.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(280, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 13);
            label3.TabIndex = 72;
            label3.Text = "S.TARE W.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(280, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 13);
            label4.TabIndex = 76;
            label4.Text = "REG. W.:";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.chk2KLPM);
            this.panelTop.Controls.Add(this.chk500LPM);
            this.panelTop.Controls.Add(this.chk1KLPM);
            this.panelTop.Controls.Add(this.dgwMeterQAll);
            this.panelTop.Controls.Add(this.tbMain);
            this.panelTop.Controls.Add(this.tbRegW);
            this.panelTop.Controls.Add(this.tbMaxW);
            this.panelTop.Controls.Add(this.oCARD_TAGIDTextBox);
            this.panelTop.Controls.Add(this.sTIMERTextBox);
            this.panelTop.Controls.Add(this.aLERTTextBox);
            this.panelTop.Controls.Add(this.tbTareW);
            this.panelTop.Controls.Add(this.uSTR4TextBox);
            this.panelTop.Controls.Add(this.cARD_TAGIDTextBox);
            this.panelTop.Controls.Add(this.mSG1TextBox);
            this.panelTop.Controls.Add(this.mSG2TextBox);
            this.panelTop.Controls.Add(this.sQERRORTextBox);
            this.panelTop.Controls.Add(this.dEBUG_MSGTextBox);
            this.panelTop.Controls.Add(this.btnSTare);
            this.panelTop.Controls.Add(this.btnL1000);
            this.panelTop.Controls.Add(this.btnS7);
            this.panelTop.Controls.Add(this.btnS5);
            this.panelTop.Controls.Add(this.btnS4);
            this.panelTop.Controls.Add(this.btnS3);
            this.panelTop.Controls.Add(this.btnS2);
            this.panelTop.Controls.Add(this.btnSyncIO);
            this.panelTop.Controls.Add(this.btnIORF);
            this.panelTop.Controls.Add(this.btnSwDry);
            this.panelTop.Controls.Add(this.btnSwAuto);
            this.panelTop.Controls.Add(this.btnSwMain);
            this.panelTop.Controls.Add(this.btnS1);
            this.panelTop.Controls.Add(this.btnL500);
            this.panelTop.Controls.Add(this.btnRst);
            this.panelTop.Controls.Add(this.btnL100);
            this.panelTop.Controls.Add(this.btnL04);
            this.panelTop.Controls.Add(this.tbStep);
            this.panelTop.Controls.Add(this.tbCard);
            this.panelTop.Controls.Add(bAYIDLabel);
            this.panelTop.Controls.Add(this.textBox2);
            this.panelTop.Controls.Add(this.bAYIDTextBox);
            this.panelTop.Controls.Add(dESCRIPTIONLabel);
            this.panelTop.Controls.Add(this.dESCRIPTIONTextBox);
            this.panelTop.Controls.Add(lOADINGMODELabel);
            this.panelTop.Controls.Add(label1);
            this.panelTop.Controls.Add(oRDER_IDLabel);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.tbAuto);
            this.panelTop.Controls.Add(bATCH_IDLabel);
            this.panelTop.Controls.Add(this.bATCH_IDTextBox);
            this.panelTop.Controls.Add(bATCH_QNTYLabel);
            this.panelTop.Controls.Add(this.bATCH_QNTYTextBox);
            this.panelTop.Controls.Add(cARD_LABELLabel);
            this.panelTop.Controls.Add(this.cARD_LABELTextBox);
            this.panelTop.Controls.Add(tM_CHECKINLabel);
            this.panelTop.Controls.Add(this.tM_CHECKINTextBox);
            this.panelTop.Controls.Add(lICPLATELabel);
            this.panelTop.Controls.Add(this.tbDry);
            this.panelTop.Controls.Add(sTIMERLabel);
            this.panelTop.Controls.Add(mSG1Label);
            this.panelTop.Controls.Add(mSG2Label);
            this.panelTop.Controls.Add(sQERRORLabel);
            this.panelTop.Controls.Add(aLERTLabel);
            this.panelTop.Controls.Add(oRDER_QNTYLabel);
            this.panelTop.Controls.Add(this.tbStatus);
            this.panelTop.Controls.Add(dEBUG_MSGLabel);
            this.panelTop.Controls.Add(uSTR4Label);
            this.panelTop.Controls.Add(pRVBATCHIDLabel);
            this.panelTop.Controls.Add(label3);
            this.panelTop.Controls.Add(this.pRVBATCHIDTextBox);
            this.panelTop.Controls.Add(cARD_TAGIDLabel);
            this.panelTop.Controls.Add(label4);
            this.panelTop.Controls.Add(oCARD_LABELLabel);
            this.panelTop.Controls.Add(label2);
            this.panelTop.Controls.Add(this.oCARD_LABELTextBox);
            this.panelTop.Controls.Add(oCARD_TAGIDLabel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 25);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(744, 190);
            this.panelTop.TabIndex = 0;
            // 
            // chk2KLPM
            // 
            this.chk2KLPM.Location = new System.Drawing.Point(626, 147);
            this.chk2KLPM.Margin = new System.Windows.Forms.Padding(0);
            this.chk2KLPM.Name = "chk2KLPM";
            this.chk2KLPM.Size = new System.Drawing.Size(54, 17);
            this.chk2KLPM.TabIndex = 98;
            this.chk2KLPM.Text = "2klpm";
            this.chk2KLPM.UseVisualStyleBackColor = false;
            this.chk2KLPM.CheckedChanged += new System.EventHandler(this.chk2KLPM_CheckedChanged);
            // 
            // chk500LPM
            // 
            this.chk500LPM.Location = new System.Drawing.Point(505, 147);
            this.chk500LPM.Margin = new System.Windows.Forms.Padding(0);
            this.chk500LPM.Name = "chk500LPM";
            this.chk500LPM.Size = new System.Drawing.Size(60, 17);
            this.chk500LPM.TabIndex = 98;
            this.chk500LPM.Text = "500lpm";
            this.chk500LPM.UseVisualStyleBackColor = false;
            this.chk500LPM.CheckedChanged += new System.EventHandler(this.chk500LPM_CheckedChanged);
            // 
            // chk1KLPM
            // 
            this.chk1KLPM.Location = new System.Drawing.Point(567, 147);
            this.chk1KLPM.Margin = new System.Windows.Forms.Padding(0);
            this.chk1KLPM.Name = "chk1KLPM";
            this.chk1KLPM.Size = new System.Drawing.Size(54, 17);
            this.chk1KLPM.TabIndex = 98;
            this.chk1KLPM.Text = "1klpm";
            this.chk1KLPM.UseVisualStyleBackColor = false;
            this.chk1KLPM.CheckedChanged += new System.EventHandler(this.chk1KLPM_CheckedChanged);
            // 
            // dgwMeterQAll
            // 
            this.dgwMeterQAll.AllowUserToAddRows = false;
            this.dgwMeterQAll.AllowUserToDeleteRows = false;
            this.dgwMeterQAll.AllowUserToOrderColumns = true;
            this.dgwMeterQAll.AutoGenerateColumns = false;
            this.dgwMeterQAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMeterQAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mETERIDDataGridViewTextBoxColumn2,
            this.mTRNAMEDataGridViewTextBoxColumn,
            this.mAINTENANCEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn1,
            this.dRYRUNDataGridViewTextBoxColumn1,
            this.qAUTODataGridViewTextBoxColumn,
            this.qIDDataGridViewTextBoxColumn2,
            this.CNT,
            this.PROG_Q1,
            this.PROG_Q2});
            this.dgwMeterQAll.DataSource = this.bsMeterQAll;
            this.dgwMeterQAll.Location = new System.Drawing.Point(402, 4);
            this.dgwMeterQAll.Name = "dgwMeterQAll";
            this.dgwMeterQAll.ReadOnly = true;
            this.dgwMeterQAll.RowHeadersVisible = false;
            this.dgwMeterQAll.Size = new System.Drawing.Size(335, 117);
            this.dgwMeterQAll.TabIndex = 97;
            this.dgwMeterQAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMeterQAll_CellDoubleClick);
            // 
            // mETERIDDataGridViewTextBoxColumn2
            // 
            this.mETERIDDataGridViewTextBoxColumn2.DataPropertyName = "METER_ID";
            this.mETERIDDataGridViewTextBoxColumn2.HeaderText = "METER_ID";
            this.mETERIDDataGridViewTextBoxColumn2.Name = "mETERIDDataGridViewTextBoxColumn2";
            this.mETERIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.mETERIDDataGridViewTextBoxColumn2.Width = 20;
            // 
            // mTRNAMEDataGridViewTextBoxColumn
            // 
            this.mTRNAMEDataGridViewTextBoxColumn.DataPropertyName = "MTRNAME";
            this.mTRNAMEDataGridViewTextBoxColumn.HeaderText = "MTRNAME";
            this.mTRNAMEDataGridViewTextBoxColumn.Name = "mTRNAMEDataGridViewTextBoxColumn";
            this.mTRNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mTRNAMEDataGridViewTextBoxColumn.Width = 20;
            // 
            // mAINTENANCEDataGridViewTextBoxColumn
            // 
            this.mAINTENANCEDataGridViewTextBoxColumn.DataPropertyName = "MAINTENANCE";
            this.mAINTENANCEDataGridViewTextBoxColumn.HeaderText = "MAINTENANCE";
            this.mAINTENANCEDataGridViewTextBoxColumn.Name = "mAINTENANCEDataGridViewTextBoxColumn";
            this.mAINTENANCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAINTENANCEDataGridViewTextBoxColumn.Width = 25;
            // 
            // sTATUSDataGridViewTextBoxColumn1
            // 
            this.sTATUSDataGridViewTextBoxColumn1.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn1.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn1.Name = "sTATUSDataGridViewTextBoxColumn1";
            this.sTATUSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sTATUSDataGridViewTextBoxColumn1.Width = 60;
            // 
            // dRYRUNDataGridViewTextBoxColumn1
            // 
            this.dRYRUNDataGridViewTextBoxColumn1.DataPropertyName = "DRYRUN";
            this.dRYRUNDataGridViewTextBoxColumn1.HeaderText = "DRYRUN";
            this.dRYRUNDataGridViewTextBoxColumn1.Name = "dRYRUNDataGridViewTextBoxColumn1";
            this.dRYRUNDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dRYRUNDataGridViewTextBoxColumn1.Width = 25;
            // 
            // qAUTODataGridViewTextBoxColumn
            // 
            this.qAUTODataGridViewTextBoxColumn.DataPropertyName = "Q_AUTO";
            this.qAUTODataGridViewTextBoxColumn.HeaderText = "Q_AUTO";
            this.qAUTODataGridViewTextBoxColumn.Name = "qAUTODataGridViewTextBoxColumn";
            this.qAUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.qAUTODataGridViewTextBoxColumn.Width = 25;
            // 
            // qIDDataGridViewTextBoxColumn2
            // 
            this.qIDDataGridViewTextBoxColumn2.DataPropertyName = "Q_ID";
            this.qIDDataGridViewTextBoxColumn2.HeaderText = "Q_ID";
            this.qIDDataGridViewTextBoxColumn2.Name = "qIDDataGridViewTextBoxColumn2";
            this.qIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.qIDDataGridViewTextBoxColumn2.Width = 30;
            // 
            // CNT
            // 
            this.CNT.DataPropertyName = "CNT";
            this.CNT.HeaderText = "CNT";
            this.CNT.Name = "CNT";
            this.CNT.ReadOnly = true;
            this.CNT.Width = 25;
            // 
            // PROG_Q1
            // 
            this.PROG_Q1.DataPropertyName = "PROG_Q1";
            this.PROG_Q1.HeaderText = "PROG_Q1";
            this.PROG_Q1.Name = "PROG_Q1";
            this.PROG_Q1.ReadOnly = true;
            this.PROG_Q1.Width = 45;
            // 
            // PROG_Q2
            // 
            this.PROG_Q2.DataPropertyName = "PROG_Q2";
            this.PROG_Q2.HeaderText = "PROG_Q2";
            this.PROG_Q2.Name = "PROG_Q2";
            this.PROG_Q2.ReadOnly = true;
            this.PROG_Q2.Width = 45;
            // 
            // bsMeterQAll
            // 
            this.bsMeterQAll.AllowNew = false;
            this.bsMeterQAll.DataMember = "T_METER_Q";
            this.bsMeterQAll.DataSource = this.dsSim;
            // 
            // dsSim
            // 
            this.dsSim.DataSetName = "dsSIM";
            this.dsSim.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMain
            // 
            this.tbMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMain.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "MAINTENANCE", true));
            this.tbMain.Location = new System.Drawing.Point(92, 21);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(42, 13);
            this.tbMain.TabIndex = 5;
            // 
            // bsMeterQ
            // 
            this.bsMeterQ.AllowNew = false;
            this.bsMeterQ.DataMember = "T_METER_Q";
            this.bsMeterQ.DataSource = this.dsSim;
            // 
            // tbRegW
            // 
            this.tbRegW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQueue, "REGULATIONWEIGHT", true));
            this.tbRegW.Location = new System.Drawing.Point(346, 109);
            this.tbRegW.Name = "tbRegW";
            this.tbRegW.Size = new System.Drawing.Size(50, 13);
            this.tbRegW.TabIndex = 77;
            // 
            // bsQueue
            // 
            this.bsQueue.AllowNew = false;
            this.bsQueue.DataMember = "T_QUEUE";
            this.bsQueue.DataSource = this.dsSim;
            // 
            // tbMaxW
            // 
            this.tbMaxW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaxW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQueue, "MAXWEIGHT", true));
            this.tbMaxW.Location = new System.Drawing.Point(346, 92);
            this.tbMaxW.Name = "tbMaxW";
            this.tbMaxW.Size = new System.Drawing.Size(50, 13);
            this.tbMaxW.TabIndex = 77;
            // 
            // oCARD_TAGIDTextBox
            // 
            this.oCARD_TAGIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oCARD_TAGIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "PROG_T2", true));
            this.oCARD_TAGIDTextBox.Location = new System.Drawing.Point(237, 174);
            this.oCARD_TAGIDTextBox.Name = "oCARD_TAGIDTextBox";
            this.oCARD_TAGIDTextBox.Size = new System.Drawing.Size(54, 13);
            this.oCARD_TAGIDTextBox.TabIndex = 77;
            // 
            // sTIMERTextBox
            // 
            this.sTIMERTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTIMERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "SQ_TIMER", true));
            this.sTIMERTextBox.Location = new System.Drawing.Point(92, 141);
            this.sTIMERTextBox.Name = "sTIMERTextBox";
            this.sTIMERTextBox.Size = new System.Drawing.Size(62, 13);
            this.sTIMERTextBox.TabIndex = 31;
            // 
            // aLERTTextBox
            // 
            this.aLERTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aLERTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "SQ_NUMBER", true));
            this.aLERTTextBox.Location = new System.Drawing.Point(92, 158);
            this.aLERTTextBox.Name = "aLERTTextBox";
            this.aLERTTextBox.Size = new System.Drawing.Size(62, 13);
            this.aLERTTextBox.TabIndex = 39;
            // 
            // tbTareW
            // 
            this.tbTareW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTareW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQueue, "STDTAREWEIGHT", true));
            this.tbTareW.Location = new System.Drawing.Point(346, 70);
            this.tbTareW.Name = "tbTareW";
            this.tbTareW.Size = new System.Drawing.Size(50, 20);
            this.tbTareW.TabIndex = 73;
            // 
            // uSTR4TextBox
            // 
            this.uSTR4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uSTR4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "SQ_TARE", true));
            this.uSTR4TextBox.Location = new System.Drawing.Point(92, 124);
            this.uSTR4TextBox.Name = "uSTR4TextBox";
            this.uSTR4TextBox.Size = new System.Drawing.Size(62, 13);
            this.uSTR4TextBox.TabIndex = 67;
            // 
            // cARD_TAGIDTextBox
            // 
            this.cARD_TAGIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cARD_TAGIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "PROG_Q2", true));
            this.cARD_TAGIDTextBox.Location = new System.Drawing.Point(237, 141);
            this.cARD_TAGIDTextBox.Name = "cARD_TAGIDTextBox";
            this.cARD_TAGIDTextBox.Size = new System.Drawing.Size(54, 13);
            this.cARD_TAGIDTextBox.TabIndex = 73;
            // 
            // mSG1TextBox
            // 
            this.mSG1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mSG1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "MSG1", true));
            this.mSG1TextBox.Location = new System.Drawing.Point(237, 38);
            this.mSG1TextBox.Name = "mSG1TextBox";
            this.mSG1TextBox.Size = new System.Drawing.Size(159, 13);
            this.mSG1TextBox.TabIndex = 33;
            // 
            // mSG2TextBox
            // 
            this.mSG2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mSG2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "MSG2", true));
            this.mSG2TextBox.Location = new System.Drawing.Point(237, 55);
            this.mSG2TextBox.Name = "mSG2TextBox";
            this.mSG2TextBox.Size = new System.Drawing.Size(159, 13);
            this.mSG2TextBox.TabIndex = 35;
            // 
            // sQERRORTextBox
            // 
            this.sQERRORTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sQERRORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQueue, "FULLTANK", true));
            this.sQERRORTextBox.Location = new System.Drawing.Point(221, 89);
            this.sQERRORTextBox.Name = "sQERRORTextBox";
            this.sQERRORTextBox.Size = new System.Drawing.Size(56, 13);
            this.sQERRORTextBox.TabIndex = 37;
            // 
            // dEBUG_MSGTextBox
            // 
            this.dEBUG_MSGTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dEBUG_MSGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "DEBUG_MSG", true));
            this.dEBUG_MSGTextBox.Location = new System.Drawing.Point(237, 21);
            this.dEBUG_MSGTextBox.Name = "dEBUG_MSGTextBox";
            this.dEBUG_MSGTextBox.Size = new System.Drawing.Size(159, 13);
            this.dEBUG_MSGTextBox.TabIndex = 49;
            // 
            // btnSTare
            // 
            this.btnSTare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSTare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTare.Location = new System.Drawing.Point(401, 123);
            this.btnSTare.Margin = new System.Windows.Forms.Padding(1);
            this.btnSTare.Name = "btnSTare";
            this.btnSTare.Size = new System.Drawing.Size(77, 21);
            this.btnSTare.TabIndex = 96;
            this.btnSTare.Text = "W=S.Tare.Wgh";
            this.btnSTare.UseVisualStyleBackColor = false;
            this.btnSTare.Click += new System.EventHandler(this.btnSTare_Click);
            // 
            // btnL1000
            // 
            this.btnL1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL1000.Location = new System.Drawing.Point(479, 123);
            this.btnL1000.Margin = new System.Windows.Forms.Padding(1);
            this.btnL1000.Name = "btnL1000";
            this.btnL1000.Size = new System.Drawing.Size(50, 21);
            this.btnL1000.TabIndex = 96;
            this.btnL1000.Text = "W+1K";
            this.btnL1000.UseVisualStyleBackColor = true;
            this.btnL1000.Click += new System.EventHandler(this.btnL1000_Click);
            // 
            // btnS7
            // 
            this.btnS7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS7.Location = new System.Drawing.Point(695, 167);
            this.btnS7.Margin = new System.Windows.Forms.Padding(1);
            this.btnS7.Name = "btnS7";
            this.btnS7.Size = new System.Drawing.Size(44, 20);
            this.btnS7.TabIndex = 96;
            this.btnS7.Text = "B.Canc";
            this.btnS7.UseVisualStyleBackColor = true;
            this.btnS7.Click += new System.EventHandler(this.btnS7_Click);
            // 
            // btnS5
            // 
            this.btnS5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS5.Location = new System.Drawing.Point(650, 167);
            this.btnS5.Margin = new System.Windows.Forms.Padding(1);
            this.btnS5.Name = "btnS5";
            this.btnS5.Size = new System.Drawing.Size(44, 20);
            this.btnS5.TabIndex = 96;
            this.btnS5.Text = "Gross";
            this.btnS5.UseVisualStyleBackColor = true;
            this.btnS5.Click += new System.EventHandler(this.btnS5_Click);
            // 
            // btnS4
            // 
            this.btnS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS4.Location = new System.Drawing.Point(605, 167);
            this.btnS4.Margin = new System.Windows.Forms.Padding(1);
            this.btnS4.Name = "btnS4";
            this.btnS4.Size = new System.Drawing.Size(44, 20);
            this.btnS4.TabIndex = 96;
            this.btnS4.Text = "B.End";
            this.btnS4.UseVisualStyleBackColor = true;
            this.btnS4.Click += new System.EventHandler(this.btnS4_Click);
            // 
            // btnS3
            // 
            this.btnS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS3.Location = new System.Drawing.Point(560, 167);
            this.btnS3.Margin = new System.Windows.Forms.Padding(1);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(44, 20);
            this.btnS3.TabIndex = 96;
            this.btnS3.Text = "B.Start";
            this.btnS3.UseVisualStyleBackColor = true;
            this.btnS3.Click += new System.EventHandler(this.btnS3_Click);
            // 
            // btnS2
            // 
            this.btnS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS2.Location = new System.Drawing.Point(515, 167);
            this.btnS2.Margin = new System.Windows.Forms.Padding(1);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(44, 20);
            this.btnS2.TabIndex = 96;
            this.btnS2.Text = "Verify";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // btnSyncIO
            // 
            this.btnSyncIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncIO.Location = new System.Drawing.Point(448, 145);
            this.btnSyncIO.Margin = new System.Windows.Forms.Padding(1);
            this.btnSyncIO.Name = "btnSyncIO";
            this.btnSyncIO.Size = new System.Drawing.Size(49, 21);
            this.btnSyncIO.TabIndex = 96;
            this.btnSyncIO.Text = "IO Syn";
            this.btnSyncIO.UseVisualStyleBackColor = true;
            this.btnSyncIO.Click += new System.EventHandler(this.btnSyncIO_Click);
            // 
            // btnIORF
            // 
            this.btnIORF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIORF.Location = new System.Drawing.Point(681, 145);
            this.btnIORF.Margin = new System.Windows.Forms.Padding(1);
            this.btnIORF.Name = "btnIORF";
            this.btnIORF.Size = new System.Drawing.Size(56, 21);
            this.btnIORF.TabIndex = 96;
            this.btnIORF.Text = "IO Rfsh";
            this.btnIORF.UseVisualStyleBackColor = true;
            this.btnIORF.Click += new System.EventHandler(this.btnIORF_Click);
            // 
            // btnSwDry
            // 
            this.btnSwDry.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwDry.Location = new System.Drawing.Point(138, 52);
            this.btnSwDry.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwDry.Name = "btnSwDry";
            this.btnSwDry.Size = new System.Drawing.Size(52, 16);
            this.btnSwDry.TabIndex = 96;
            this.btnSwDry.Text = "Sw Dry";
            this.btnSwDry.UseVisualStyleBackColor = true;
            this.btnSwDry.Click += new System.EventHandler(this.btnSwDry_Click);
            // 
            // btnSwAuto
            // 
            this.btnSwAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwAuto.Location = new System.Drawing.Point(138, 35);
            this.btnSwAuto.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwAuto.Name = "btnSwAuto";
            this.btnSwAuto.Size = new System.Drawing.Size(52, 16);
            this.btnSwAuto.TabIndex = 96;
            this.btnSwAuto.Text = "Sw Auto";
            this.btnSwAuto.UseVisualStyleBackColor = true;
            this.btnSwAuto.Click += new System.EventHandler(this.btnSwAuto_Click);
            // 
            // btnSwMain
            // 
            this.btnSwMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwMain.Location = new System.Drawing.Point(138, 18);
            this.btnSwMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwMain.Name = "btnSwMain";
            this.btnSwMain.Size = new System.Drawing.Size(52, 16);
            this.btnSwMain.TabIndex = 96;
            this.btnSwMain.Text = "Sw Main";
            this.btnSwMain.UseVisualStyleBackColor = true;
            this.btnSwMain.Click += new System.EventHandler(this.btnSwMain_Click);
            // 
            // btnS1
            // 
            this.btnS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS1.Location = new System.Drawing.Point(448, 167);
            this.btnS1.Margin = new System.Windows.Forms.Padding(1);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(62, 20);
            this.btnS1.TabIndex = 96;
            this.btnS1.Text = "Card";
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnL500
            // 
            this.btnL500.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL500.Location = new System.Drawing.Point(529, 123);
            this.btnL500.Margin = new System.Windows.Forms.Padding(1);
            this.btnL500.Name = "btnL500";
            this.btnL500.Size = new System.Drawing.Size(50, 21);
            this.btnL500.TabIndex = 96;
            this.btnL500.Text = "W+500";
            this.btnL500.UseVisualStyleBackColor = true;
            this.btnL500.Click += new System.EventHandler(this.btnL500_Click);
            // 
            // btnRst
            // 
            this.btnRst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRst.Location = new System.Drawing.Point(681, 123);
            this.btnRst.Margin = new System.Windows.Forms.Padding(1);
            this.btnRst.Name = "btnRst";
            this.btnRst.Size = new System.Drawing.Size(58, 21);
            this.btnRst.TabIndex = 96;
            this.btnRst.Text = "Reset W";
            this.btnRst.UseVisualStyleBackColor = false;
            this.btnRst.Click += new System.EventHandler(this.btnRst_Click);
            // 
            // btnL100
            // 
            this.btnL100.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL100.Location = new System.Drawing.Point(579, 123);
            this.btnL100.Margin = new System.Windows.Forms.Padding(1);
            this.btnL100.Name = "btnL100";
            this.btnL100.Size = new System.Drawing.Size(50, 21);
            this.btnL100.TabIndex = 96;
            this.btnL100.Text = "W+100";
            this.btnL100.UseVisualStyleBackColor = true;
            this.btnL100.Click += new System.EventHandler(this.btnL100_Click);
            // 
            // btnL04
            // 
            this.btnL04.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL04.Location = new System.Drawing.Point(629, 123);
            this.btnL04.Margin = new System.Windows.Forms.Padding(1);
            this.btnL04.Name = "btnL04";
            this.btnL04.Size = new System.Drawing.Size(50, 21);
            this.btnL04.TabIndex = 96;
            this.btnL04.Text = "W+50";
            this.btnL04.UseVisualStyleBackColor = true;
            this.btnL04.Click += new System.EventHandler(this.btnL04_Click);
            // 
            // tbStep
            // 
            this.tbStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStep.Location = new System.Drawing.Point(402, 145);
            this.tbStep.Name = "tbStep";
            this.tbStep.ReadOnly = true;
            this.tbStep.Size = new System.Drawing.Size(41, 20);
            this.tbStep.TabIndex = 95;
            this.tbStep.Text = "0";
            this.tbStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCard
            // 
            this.tbCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCard.Location = new System.Drawing.Point(402, 167);
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(41, 20);
            this.tbCard.TabIndex = 95;
            this.tbCard.Text = "1";
            this.tbCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCard.TextChanged += new System.EventHandler(this.tbCard_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "METER_ID", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(318, 129);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(57, 55);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.WordWrap = false;
            // 
            // bAYIDTextBox
            // 
            this.bAYIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bAYIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "METER_ID", true));
            this.bAYIDTextBox.Location = new System.Drawing.Point(53, 4);
            this.bAYIDTextBox.Name = "bAYIDTextBox";
            this.bAYIDTextBox.Size = new System.Drawing.Size(57, 13);
            this.bAYIDTextBox.TabIndex = 1;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "MTRDESC", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(205, 4);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(76, 13);
            this.dESCRIPTIONTextBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "CNT", true));
            this.textBox1.Location = new System.Drawing.Point(92, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 13);
            this.textBox1.TabIndex = 7;
            // 
            // tbAuto
            // 
            this.tbAuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "Q_AUTO", true));
            this.tbAuto.Location = new System.Drawing.Point(92, 38);
            this.tbAuto.Name = "tbAuto";
            this.tbAuto.Size = new System.Drawing.Size(42, 13);
            this.tbAuto.TabIndex = 7;
            // 
            // bATCH_IDTextBox
            // 
            this.bATCH_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bATCH_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "Q_ID", true));
            this.bATCH_IDTextBox.Location = new System.Drawing.Point(92, 89);
            this.bATCH_IDTextBox.Name = "bATCH_IDTextBox";
            this.bATCH_IDTextBox.Size = new System.Drawing.Size(62, 13);
            this.bATCH_IDTextBox.TabIndex = 9;
            // 
            // bATCH_QNTYTextBox
            // 
            this.bATCH_QNTYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bATCH_QNTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQueue, "QNTY", true));
            this.bATCH_QNTYTextBox.Location = new System.Drawing.Point(221, 72);
            this.bATCH_QNTYTextBox.Name = "bATCH_QNTYTextBox";
            this.bATCH_QNTYTextBox.Size = new System.Drawing.Size(56, 13);
            this.bATCH_QNTYTextBox.TabIndex = 11;
            // 
            // cARD_LABELTextBox
            // 
            this.cARD_LABELTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cARD_LABELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "PROG_Q1", true));
            this.cARD_LABELTextBox.Location = new System.Drawing.Point(237, 124);
            this.cARD_LABELTextBox.Name = "cARD_LABELTextBox";
            this.cARD_LABELTextBox.Size = new System.Drawing.Size(54, 13);
            this.cARD_LABELTextBox.TabIndex = 13;
            // 
            // tM_CHECKINTextBox
            // 
            this.tM_CHECKINTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tM_CHECKINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "SQ_START", true));
            this.tM_CHECKINTextBox.Location = new System.Drawing.Point(92, 108);
            this.tM_CHECKINTextBox.Name = "tM_CHECKINTextBox";
            this.tM_CHECKINTextBox.Size = new System.Drawing.Size(95, 13);
            this.tM_CHECKINTextBox.TabIndex = 15;
            // 
            // tbDry
            // 
            this.tbDry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "DRYRUN", true));
            this.tbDry.Location = new System.Drawing.Point(92, 55);
            this.tbDry.Name = "tbDry";
            this.tbDry.Size = new System.Drawing.Size(42, 13);
            this.tbDry.TabIndex = 29;
            // 
            // tbStatus
            // 
            this.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "STATUS", true));
            this.tbStatus.Location = new System.Drawing.Point(92, 72);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(62, 13);
            this.tbStatus.TabIndex = 41;
            // 
            // pRVBATCHIDTextBox
            // 
            this.pRVBATCHIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pRVBATCHIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "P_Q_ID", true));
            this.pRVBATCHIDTextBox.Location = new System.Drawing.Point(349, 4);
            this.pRVBATCHIDTextBox.Name = "pRVBATCHIDTextBox";
            this.pRVBATCHIDTextBox.Size = new System.Drawing.Size(47, 13);
            this.pRVBATCHIDTextBox.TabIndex = 71;
            // 
            // oCARD_LABELTextBox
            // 
            this.oCARD_LABELTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oCARD_LABELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeterQ, "PROG_T1", true));
            this.oCARD_LABELTextBox.Location = new System.Drawing.Point(237, 158);
            this.oCARD_LABELTextBox.Name = "oCARD_LABELTextBox";
            this.oCARD_LABELTextBox.Size = new System.Drawing.Size(54, 13);
            this.oCARD_LABELTextBox.TabIndex = 75;
            // 
            // dgvDevIO_W
            // 
            this.dgvDevIO_W.AllowUserToAddRows = false;
            this.dgvDevIO_W.AllowUserToDeleteRows = false;
            this.dgvDevIO_W.AutoGenerateColumns = false;
            this.dgvDevIO_W.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iONAMEDataGridViewTextBoxColumn2,
            this.iOVALUEDataGridViewTextBoxColumn2,
            this.rEQWDataGridViewTextBoxColumn});
            this.dgvDevIO_W.DataSource = this.bsDEVICEIO_W;
            this.dgvDevIO_W.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDevIO_W.Location = new System.Drawing.Point(0, 366);
            this.dgvDevIO_W.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDevIO_W.Name = "dgvDevIO_W";
            this.dgvDevIO_W.RowHeadersWidth = 5;
            this.dgvDevIO_W.RowTemplate.Height = 17;
            this.dgvDevIO_W.Size = new System.Drawing.Size(240, 370);
            this.dgvDevIO_W.TabIndex = 83;
            this.dgvDevIO_W.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevIO_W_CellDoubleClick);
            // 
            // iONAMEDataGridViewTextBoxColumn2
            // 
            this.iONAMEDataGridViewTextBoxColumn2.DataPropertyName = "IONAME";
            this.iONAMEDataGridViewTextBoxColumn2.HeaderText = "IONAME";
            this.iONAMEDataGridViewTextBoxColumn2.Name = "iONAMEDataGridViewTextBoxColumn2";
            // 
            // iOVALUEDataGridViewTextBoxColumn2
            // 
            this.iOVALUEDataGridViewTextBoxColumn2.DataPropertyName = "IOVALUE";
            this.iOVALUEDataGridViewTextBoxColumn2.HeaderText = "IOVALUE";
            this.iOVALUEDataGridViewTextBoxColumn2.Name = "iOVALUEDataGridViewTextBoxColumn2";
            this.iOVALUEDataGridViewTextBoxColumn2.Width = 80;
            // 
            // rEQWDataGridViewTextBoxColumn
            // 
            this.rEQWDataGridViewTextBoxColumn.DataPropertyName = "REQ_W";
            this.rEQWDataGridViewTextBoxColumn.HeaderText = "RQW";
            this.rEQWDataGridViewTextBoxColumn.Name = "rEQWDataGridViewTextBoxColumn";
            this.rEQWDataGridViewTextBoxColumn.Width = 35;
            // 
            // bsDEVICEIO_W
            // 
            this.bsDEVICEIO_W.AllowNew = false;
            this.bsDEVICEIO_W.DataMember = "DEVICEIO_W";
            this.bsDEVICEIO_W.DataSource = this.dsSim;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAYIDToolStripLabel,
            this.bAYIDToolStripTextBox,
            this.fillToolStripButton,
            this.tsSQ,
            this.tsLog,
            this.tstbLogHrs,
            this.tsIO,
            this.tstIOFilter,
            this.tsbtnSQL});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(984, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // bAYIDToolStripLabel
            // 
            this.bAYIDToolStripLabel.Name = "bAYIDToolStripLabel";
            this.bAYIDToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.bAYIDToolStripLabel.Text = "BAY:";
            // 
            // bAYIDToolStripTextBox
            // 
            this.bAYIDToolStripTextBox.MaxLength = 2;
            this.bAYIDToolStripTextBox.Name = "bAYIDToolStripTextBox";
            this.bAYIDToolStripTextBox.ReadOnly = true;
            this.bAYIDToolStripTextBox.Size = new System.Drawing.Size(25, 25);
            this.bAYIDToolStripTextBox.Text = "1";
            this.bAYIDToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bAYIDToolStripTextBox.Click += new System.EventHandler(this.bAYIDToolStripTextBox_Click);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(64, 22);
            this.fillToolStripButton.Text = "RefreshAll";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // tsSQ
            // 
            this.tsSQ.CheckOnClick = true;
            this.tsSQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSQ.Image = ((System.Drawing.Image)(resources.GetObject("tsSQ.Image")));
            this.tsSQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSQ.Name = "tsSQ";
            this.tsSQ.Size = new System.Drawing.Size(55, 22);
            this.tsSQ.Text = "SQ Auto";
            // 
            // tsLog
            // 
            this.tsLog.CheckOnClick = true;
            this.tsLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLog.Image = ((System.Drawing.Image)(resources.GetObject("tsLog.Image")));
            this.tsLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLog.Name = "tsLog";
            this.tsLog.Size = new System.Drawing.Size(60, 22);
            this.tsLog.Text = "Log Auto";
            // 
            // tstbLogHrs
            // 
            this.tstbLogHrs.MaxLength = 2;
            this.tstbLogHrs.Name = "tstbLogHrs";
            this.tstbLogHrs.ReadOnly = true;
            this.tstbLogHrs.Size = new System.Drawing.Size(25, 25);
            this.tstbLogHrs.Text = "12";
            this.tstbLogHrs.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstbLogHrs.ToolTipText = "Log Show Hours ";
            this.tstbLogHrs.Click += new System.EventHandler(this.tstbLogHrs_Click);
            this.tstbLogHrs.DoubleClick += new System.EventHandler(this.tstbLogHrs_DoubleClick);
            // 
            // tsIO
            // 
            this.tsIO.CheckOnClick = true;
            this.tsIO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsIO.Image = ((System.Drawing.Image)(resources.GetObject("tsIO.Image")));
            this.tsIO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIO.Name = "tsIO";
            this.tsIO.Size = new System.Drawing.Size(52, 22);
            this.tsIO.Text = "IO Auto";
            // 
            // tstIOFilter
            // 
            this.tstIOFilter.Name = "tstIOFilter";
            this.tstIOFilter.Size = new System.Drawing.Size(360, 25);
            this.tstIOFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstIOFilter_KeyPress);
            this.tstIOFilter.Click += new System.EventHandler(this.tstIOFilter_Click);
            // 
            // tsbtnSQL
            // 
            this.tsbtnSQL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSQL.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSQL.Image")));
            this.tsbtnSQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSQL.Name = "tsbtnSQL";
            this.tsbtnSQL.Size = new System.Drawing.Size(32, 22);
            this.tsbtnSQL.Text = "SQL";
            this.tsbtnSQL.Click += new System.EventHandler(this.tsbtnSQL_Click);
            // 
            // tabBottom
            // 
            this.tabBottom.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabBottom.Controls.Add(this.tpgSQLog);
            this.tabBottom.Controls.Add(this.tpgCache);
            this.tabBottom.Controls.Add(this.tpgQ);
            this.tabBottom.Controls.Add(this.tpgORDER);
            this.tabBottom.Controls.Add(this.tpgLSQLog);
            this.tabBottom.Controls.Add(this.tpgIOLog2);
            this.tabBottom.Controls.Add(this.tpgIOLog);
            this.tabBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBottom.Location = new System.Drawing.Point(0, 215);
            this.tabBottom.Multiline = true;
            this.tabBottom.Name = "tabBottom";
            this.tabBottom.SelectedIndex = 0;
            this.tabBottom.Size = new System.Drawing.Size(744, 546);
            this.tabBottom.TabIndex = 2;
            this.tabBottom.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpgSQLog
            // 
            this.tpgSQLog.AutoScroll = true;
            this.tpgSQLog.Controls.Add(this.QUEUE_SQ_LOGDataGridView);
            this.tpgSQLog.Location = new System.Drawing.Point(23, 4);
            this.tpgSQLog.Name = "tpgSQLog";
            this.tpgSQLog.Padding = new System.Windows.Forms.Padding(1);
            this.tpgSQLog.Size = new System.Drawing.Size(717, 538);
            this.tpgSQLog.TabIndex = 0;
            this.tpgSQLog.Text = "Queue SQ";
            this.tpgSQLog.UseVisualStyleBackColor = true;
            // 
            // QUEUE_SQ_LOGDataGridView
            // 
            this.QUEUE_SQ_LOGDataGridView.AutoGenerateColumns = false;
            this.QUEUE_SQ_LOGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.QUEUE_SQ_LOGDataGridView.DataSource = this.bsSQLOG;
            this.QUEUE_SQ_LOGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QUEUE_SQ_LOGDataGridView.Location = new System.Drawing.Point(1, 1);
            this.QUEUE_SQ_LOGDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.QUEUE_SQ_LOGDataGridView.Name = "QUEUE_SQ_LOGDataGridView";
            this.QUEUE_SQ_LOGDataGridView.ReadOnly = true;
            this.QUEUE_SQ_LOGDataGridView.RowHeadersWidth = 10;
            this.QUEUE_SQ_LOGDataGridView.RowTemplate.Height = 18;
            this.QUEUE_SQ_LOGDataGridView.Size = new System.Drawing.Size(715, 536);
            this.QUEUE_SQ_LOGDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LOGTIME";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "LOGTIME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SEQ";
            this.dataGridViewTextBoxColumn15.HeaderText = "SEQ";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "LOGCAT";
            this.dataGridViewTextBoxColumn19.HeaderText = "LOGCAT";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 50;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "LOGTXT";
            this.dataGridViewTextBoxColumn20.HeaderText = "SEQ LOG";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 460;
            // 
            // bsSQLOG
            // 
            this.bsSQLOG.AllowNew = false;
            this.bsSQLOG.DataMember = "QUEUE_SQ_LOG";
            this.bsSQLOG.DataSource = this.dsSim;
            // 
            // tpgCache
            // 
            this.tpgCache.Controls.Add(this.dgwCache);
            this.tpgCache.Location = new System.Drawing.Point(23, 4);
            this.tpgCache.Name = "tpgCache";
            this.tpgCache.Size = new System.Drawing.Size(717, 538);
            this.tpgCache.TabIndex = 7;
            this.tpgCache.Text = "WebCache";
            this.tpgCache.UseVisualStyleBackColor = true;
            // 
            // dgwCache
            // 
            this.dgwCache.AllowUserToAddRows = false;
            this.dgwCache.AllowUserToDeleteRows = false;
            this.dgwCache.AllowUserToOrderColumns = true;
            this.dgwCache.AutoGenerateColumns = false;
            this.dgwCache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCache.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qSTATUSDataGridViewTextBoxColumn1,
            this.qIDDataGridViewTextBoxColumn3,
            this.oRDERCODEDataGridViewTextBoxColumn2,
            this.cOMPANYDataGridViewTextBoxColumn,
            this.dATEARRIVEDataGridViewTextBoxColumn1,
            this.cARRIERDataGridViewTextBoxColumn,
            this.fRONTLICENSEDataGridViewTextBoxColumn2,
            this.rEARLICENSEDataGridViewTextBoxColumn2,
            this.dRIVER1DataGridViewTextBoxColumn,
            this.qNTYDataGridViewTextBoxColumn2,
            this.dESTINATIONNAMEDataGridViewTextBoxColumn,
            this.tAREWEIGHTDataGridViewTextBoxColumn,
            this.mAXWEIGHTDataGridViewTextBoxColumn1,
            this.vEHICLENAMEDataGridViewTextBoxColumn,
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn1,
            this.fULLTANKDataGridViewTextBoxColumn1});
            this.dgwCache.DataSource = this.bsORDERSCACHE;
            this.dgwCache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCache.Location = new System.Drawing.Point(0, 0);
            this.dgwCache.Name = "dgwCache";
            this.dgwCache.ReadOnly = true;
            this.dgwCache.RowHeadersWidth = 5;
            this.dgwCache.RowTemplate.ReadOnly = true;
            this.dgwCache.Size = new System.Drawing.Size(717, 538);
            this.dgwCache.TabIndex = 0;
            // 
            // bsORDERSCACHE
            // 
            this.bsORDERSCACHE.AllowNew = false;
            this.bsORDERSCACHE.DataMember = "T_ORDERS_CACHE";
            this.bsORDERSCACHE.DataSource = this.dsSim;
            // 
            // tpgQ
            // 
            this.tpgQ.AutoScroll = true;
            this.tpgQ.Controls.Add(this.dgwQ);
            this.tpgQ.Location = new System.Drawing.Point(23, 4);
            this.tpgQ.Name = "tpgQ";
            this.tpgQ.Size = new System.Drawing.Size(717, 538);
            this.tpgQ.TabIndex = 4;
            this.tpgQ.Text = "Queue";
            this.tpgQ.UseVisualStyleBackColor = true;
            // 
            // dgwQ
            // 
            this.dgwQ.AllowUserToAddRows = false;
            this.dgwQ.AllowUserToDeleteRows = false;
            this.dgwQ.AutoGenerateColumns = false;
            this.dgwQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIDDataGridViewTextBoxColumn,
            this.qNODataGridViewTextBoxColumn,
            this.qSTATUSDataGridViewTextBoxColumn,
            this.dRYRUNDataGridViewTextBoxColumn,
            this.STDTAREWEIGHT,
            this.MAXWEIGHT,
            this.REGULATIONWEIGHT,
            this.wAITTMDataGridViewTextBoxColumn,
            this.oRDERCODEDataGridViewTextBoxColumn,
            this.fRONTLICENSEDataGridViewTextBoxColumn,
            this.rEARLICENSEDataGridViewTextBoxColumn,
            this.qNTYDataGridViewTextBoxColumn,
            this.fULLTANKDataGridViewTextBoxColumn,
            this.mETERIDDataGridViewTextBoxColumn,
            this.tSPARKDataGridViewTextBoxColumn,
            this.tSEXITDataGridViewTextBoxColumn,
            this.tYPEDataGridViewTextBoxColumn});
            this.dgwQ.DataSource = this.bsQUEUE1;
            this.dgwQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwQ.Location = new System.Drawing.Point(0, 0);
            this.dgwQ.Name = "dgwQ";
            this.dgwQ.ReadOnly = true;
            this.dgwQ.RowHeadersWidth = 5;
            this.dgwQ.Size = new System.Drawing.Size(717, 538);
            this.dgwQ.TabIndex = 2;
            // 
            // qIDDataGridViewTextBoxColumn
            // 
            this.qIDDataGridViewTextBoxColumn.DataPropertyName = "Q_ID";
            this.qIDDataGridViewTextBoxColumn.HeaderText = "Q_ID";
            this.qIDDataGridViewTextBoxColumn.Name = "qIDDataGridViewTextBoxColumn";
            this.qIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.qIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // qNODataGridViewTextBoxColumn
            // 
            this.qNODataGridViewTextBoxColumn.DataPropertyName = "Q_NO";
            this.qNODataGridViewTextBoxColumn.HeaderText = "Q_NO";
            this.qNODataGridViewTextBoxColumn.Name = "qNODataGridViewTextBoxColumn";
            this.qNODataGridViewTextBoxColumn.ReadOnly = true;
            this.qNODataGridViewTextBoxColumn.Width = 25;
            // 
            // qSTATUSDataGridViewTextBoxColumn
            // 
            this.qSTATUSDataGridViewTextBoxColumn.DataPropertyName = "Q_STATUS";
            this.qSTATUSDataGridViewTextBoxColumn.HeaderText = "Q_STATUS";
            this.qSTATUSDataGridViewTextBoxColumn.Name = "qSTATUSDataGridViewTextBoxColumn";
            this.qSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.qSTATUSDataGridViewTextBoxColumn.Width = 70;
            // 
            // dRYRUNDataGridViewTextBoxColumn
            // 
            this.dRYRUNDataGridViewTextBoxColumn.DataPropertyName = "DRYRUN";
            this.dRYRUNDataGridViewTextBoxColumn.HeaderText = "DRYRUN";
            this.dRYRUNDataGridViewTextBoxColumn.Name = "dRYRUNDataGridViewTextBoxColumn";
            this.dRYRUNDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRYRUNDataGridViewTextBoxColumn.Width = 25;
            // 
            // STDTAREWEIGHT
            // 
            this.STDTAREWEIGHT.DataPropertyName = "STDTAREWEIGHT";
            this.STDTAREWEIGHT.HeaderText = "STDTAREWEIGHT";
            this.STDTAREWEIGHT.Name = "STDTAREWEIGHT";
            this.STDTAREWEIGHT.ReadOnly = true;
            this.STDTAREWEIGHT.Width = 50;
            // 
            // MAXWEIGHT
            // 
            this.MAXWEIGHT.DataPropertyName = "MAXWEIGHT";
            this.MAXWEIGHT.HeaderText = "MAXWEIGHT";
            this.MAXWEIGHT.Name = "MAXWEIGHT";
            this.MAXWEIGHT.ReadOnly = true;
            this.MAXWEIGHT.Width = 50;
            // 
            // REGULATIONWEIGHT
            // 
            this.REGULATIONWEIGHT.DataPropertyName = "REGULATIONWEIGHT";
            this.REGULATIONWEIGHT.HeaderText = "REGULATIONWEIGHT";
            this.REGULATIONWEIGHT.Name = "REGULATIONWEIGHT";
            this.REGULATIONWEIGHT.ReadOnly = true;
            this.REGULATIONWEIGHT.Width = 50;
            // 
            // wAITTMDataGridViewTextBoxColumn
            // 
            this.wAITTMDataGridViewTextBoxColumn.DataPropertyName = "WAIT_TM";
            this.wAITTMDataGridViewTextBoxColumn.HeaderText = "WAIT_TM";
            this.wAITTMDataGridViewTextBoxColumn.Name = "wAITTMDataGridViewTextBoxColumn";
            this.wAITTMDataGridViewTextBoxColumn.ReadOnly = true;
            this.wAITTMDataGridViewTextBoxColumn.Width = 25;
            // 
            // oRDERCODEDataGridViewTextBoxColumn
            // 
            this.oRDERCODEDataGridViewTextBoxColumn.DataPropertyName = "ORDER_CODE";
            this.oRDERCODEDataGridViewTextBoxColumn.HeaderText = "ORDER_CODE";
            this.oRDERCODEDataGridViewTextBoxColumn.Name = "oRDERCODEDataGridViewTextBoxColumn";
            this.oRDERCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERCODEDataGridViewTextBoxColumn.Width = 60;
            // 
            // fRONTLICENSEDataGridViewTextBoxColumn
            // 
            this.fRONTLICENSEDataGridViewTextBoxColumn.DataPropertyName = "FRONT_LICENSE";
            this.fRONTLICENSEDataGridViewTextBoxColumn.HeaderText = "FRONT_LICENSE";
            this.fRONTLICENSEDataGridViewTextBoxColumn.Name = "fRONTLICENSEDataGridViewTextBoxColumn";
            this.fRONTLICENSEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fRONTLICENSEDataGridViewTextBoxColumn.Width = 80;
            // 
            // rEARLICENSEDataGridViewTextBoxColumn
            // 
            this.rEARLICENSEDataGridViewTextBoxColumn.DataPropertyName = "REAR_LICENSE";
            this.rEARLICENSEDataGridViewTextBoxColumn.HeaderText = "REAR_LICENSE";
            this.rEARLICENSEDataGridViewTextBoxColumn.Name = "rEARLICENSEDataGridViewTextBoxColumn";
            this.rEARLICENSEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEARLICENSEDataGridViewTextBoxColumn.Width = 80;
            // 
            // qNTYDataGridViewTextBoxColumn
            // 
            this.qNTYDataGridViewTextBoxColumn.DataPropertyName = "QNTY";
            this.qNTYDataGridViewTextBoxColumn.HeaderText = "QNTY";
            this.qNTYDataGridViewTextBoxColumn.Name = "qNTYDataGridViewTextBoxColumn";
            this.qNTYDataGridViewTextBoxColumn.ReadOnly = true;
            this.qNTYDataGridViewTextBoxColumn.Width = 25;
            // 
            // fULLTANKDataGridViewTextBoxColumn
            // 
            this.fULLTANKDataGridViewTextBoxColumn.DataPropertyName = "FULLTANK";
            this.fULLTANKDataGridViewTextBoxColumn.HeaderText = "FULLTANK";
            this.fULLTANKDataGridViewTextBoxColumn.Name = "fULLTANKDataGridViewTextBoxColumn";
            this.fULLTANKDataGridViewTextBoxColumn.ReadOnly = true;
            this.fULLTANKDataGridViewTextBoxColumn.Width = 20;
            // 
            // mETERIDDataGridViewTextBoxColumn
            // 
            this.mETERIDDataGridViewTextBoxColumn.DataPropertyName = "METER_ID";
            this.mETERIDDataGridViewTextBoxColumn.HeaderText = "METER_ID";
            this.mETERIDDataGridViewTextBoxColumn.Name = "mETERIDDataGridViewTextBoxColumn";
            this.mETERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mETERIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // tSPARKDataGridViewTextBoxColumn
            // 
            this.tSPARKDataGridViewTextBoxColumn.DataPropertyName = "TS_PARK";
            this.tSPARKDataGridViewTextBoxColumn.HeaderText = "TS_PARK";
            this.tSPARKDataGridViewTextBoxColumn.Name = "tSPARKDataGridViewTextBoxColumn";
            this.tSPARKDataGridViewTextBoxColumn.ReadOnly = true;
            this.tSPARKDataGridViewTextBoxColumn.Width = 80;
            // 
            // tSEXITDataGridViewTextBoxColumn
            // 
            this.tSEXITDataGridViewTextBoxColumn.DataPropertyName = "TS_EXIT";
            this.tSEXITDataGridViewTextBoxColumn.HeaderText = "TS_EXIT";
            this.tSEXITDataGridViewTextBoxColumn.Name = "tSEXITDataGridViewTextBoxColumn";
            this.tSEXITDataGridViewTextBoxColumn.ReadOnly = true;
            this.tSEXITDataGridViewTextBoxColumn.Width = 80;
            // 
            // tYPEDataGridViewTextBoxColumn
            // 
            this.tYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.HeaderText = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.Name = "tYPEDataGridViewTextBoxColumn";
            this.tYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tYPEDataGridViewTextBoxColumn.Width = 80;
            // 
            // bsQUEUE1
            // 
            this.bsQUEUE1.AllowNew = false;
            this.bsQUEUE1.DataMember = "T_QUEUE";
            this.bsQUEUE1.DataSource = this.dsSim;
            // 
            // tpgORDER
            // 
            this.tpgORDER.Controls.Add(this.dgwO);
            this.tpgORDER.Location = new System.Drawing.Point(23, 4);
            this.tpgORDER.Name = "tpgORDER";
            this.tpgORDER.Padding = new System.Windows.Forms.Padding(3);
            this.tpgORDER.Size = new System.Drawing.Size(717, 538);
            this.tpgORDER.TabIndex = 5;
            this.tpgORDER.Text = "Order";
            this.tpgORDER.UseVisualStyleBackColor = true;
            // 
            // dgwO
            // 
            this.dgwO.AllowUserToAddRows = false;
            this.dgwO.AllowUserToDeleteRows = false;
            this.dgwO.AllowUserToOrderColumns = true;
            this.dgwO.AutoGenerateColumns = false;
            this.dgwO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIDDataGridViewTextBoxColumn1,
            this.oRDERIDDataGridViewTextBoxColumn,
            this.oRDERCODEDataGridViewTextBoxColumn1,
            this.dATEARRIVEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.mETERIDDataGridViewTextBoxColumn1,
            this.cARDIDDataGridViewTextBoxColumn,
            this.fRONTLICENSEDataGridViewTextBoxColumn1,
            this.rEARLICENSEDataGridViewTextBoxColumn1,
            this.qNTYDataGridViewTextBoxColumn1,
            this.sTDTAREWEIGHTDataGridViewTextBoxColumn,
            this.mAXWEIGHTDataGridViewTextBoxColumn,
            this.oRDERNODataGridViewTextBoxColumn,
            this.gROSSDataGridViewTextBoxColumn,
            this.nETDataGridViewTextBoxColumn,
            this.lOADEDDataGridViewTextBoxColumn,
            this.tAREDataGridViewTextBoxColumn,
            this.tSTAREDataGridViewTextBoxColumn,
            this.tSBSTARTDataGridViewTextBoxColumn,
            this.tSBENDDataGridViewTextBoxColumn,
            this.tSFINISHDataGridViewTextBoxColumn,
            this.tSBOLDataGridViewTextBoxColumn,
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn,
            this.wEIGHTSCALEDataGridViewTextBoxColumn,
            this.cALCQUANTITYDataGridViewTextBoxColumn});
            this.dgwO.DataSource = this.bsORDERS_WEB;
            this.dgwO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwO.Location = new System.Drawing.Point(3, 3);
            this.dgwO.Name = "dgwO";
            this.dgwO.ReadOnly = true;
            this.dgwO.RowHeadersWidth = 5;
            this.dgwO.Size = new System.Drawing.Size(711, 532);
            this.dgwO.TabIndex = 0;
            // 
            // bsORDERS_WEB
            // 
            this.bsORDERS_WEB.AllowNew = false;
            this.bsORDERS_WEB.DataMember = "T_ORDERS_WEB";
            this.bsORDERS_WEB.DataSource = this.dsSim;
            // 
            // tpgLSQLog
            // 
            this.tpgLSQLog.Controls.Add(this.dgwLSQLog);
            this.tpgLSQLog.Location = new System.Drawing.Point(23, 4);
            this.tpgLSQLog.Name = "tpgLSQLog";
            this.tpgLSQLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLSQLog.Size = new System.Drawing.Size(717, 538);
            this.tpgLSQLog.TabIndex = 6;
            this.tpgLSQLog.Text = "Loading SQ";
            this.tpgLSQLog.UseVisualStyleBackColor = true;
            // 
            // dgwLSQLog
            // 
            this.dgwLSQLog.AutoGenerateColumns = false;
            this.dgwLSQLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgwLSQLog.DataSource = this.bsLSQLog;
            this.dgwLSQLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLSQLog.Location = new System.Drawing.Point(3, 3);
            this.dgwLSQLog.Margin = new System.Windows.Forms.Padding(1);
            this.dgwLSQLog.Name = "dgwLSQLog";
            this.dgwLSQLog.ReadOnly = true;
            this.dgwLSQLog.RowHeadersWidth = 10;
            this.dgwLSQLog.RowTemplate.Height = 18;
            this.dgwLSQLog.Size = new System.Drawing.Size(711, 532);
            this.dgwLSQLog.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LOGTIME";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "LOGTIME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SEQ";
            this.dataGridViewTextBoxColumn2.HeaderText = "SEQ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LOGCAT";
            this.dataGridViewTextBoxColumn4.HeaderText = "LOGCAT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LOGTXT";
            this.dataGridViewTextBoxColumn5.HeaderText = "SEQ LOG";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 460;
            // 
            // bsLSQLog
            // 
            this.bsLSQLog.AllowNew = false;
            this.bsLSQLog.DataMember = "LOADING_SQ_LOG";
            this.bsLSQLog.DataSource = this.dsSim;
            // 
            // tpgIOLog2
            // 
            this.tpgIOLog2.Controls.Add(this.dEVICEIO_LOG2DataGridView);
            this.tpgIOLog2.Location = new System.Drawing.Point(23, 4);
            this.tpgIOLog2.Name = "tpgIOLog2";
            this.tpgIOLog2.Padding = new System.Windows.Forms.Padding(1);
            this.tpgIOLog2.Size = new System.Drawing.Size(717, 538);
            this.tpgIOLog2.TabIndex = 3;
            this.tpgIOLog2.Text = "IO Log";
            this.tpgIOLog2.UseVisualStyleBackColor = true;
            // 
            // dEVICEIO_LOG2DataGridView
            // 
            this.dEVICEIO_LOG2DataGridView.AllowUserToAddRows = false;
            this.dEVICEIO_LOG2DataGridView.AllowUserToDeleteRows = false;
            this.dEVICEIO_LOG2DataGridView.AutoGenerateColumns = false;
            this.dEVICEIO_LOG2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dEVICEIO_LOG2DataGridView.DataSource = this.bsIOLog2;
            this.dEVICEIO_LOG2DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dEVICEIO_LOG2DataGridView.Location = new System.Drawing.Point(1, 1);
            this.dEVICEIO_LOG2DataGridView.Name = "dEVICEIO_LOG2DataGridView";
            this.dEVICEIO_LOG2DataGridView.ReadOnly = true;
            this.dEVICEIO_LOG2DataGridView.RowHeadersWidth = 10;
            this.dEVICEIO_LOG2DataGridView.RowTemplate.Height = 18;
            this.dEVICEIO_LOG2DataGridView.Size = new System.Drawing.Size(715, 536);
            this.dEVICEIO_LOG2DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "LOGTIME";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn25.HeaderText = "LOGTIME";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 110;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "SEQ";
            this.dataGridViewTextBoxColumn26.HeaderText = "SEQ";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "LOGCAT";
            this.dataGridViewTextBoxColumn27.HeaderText = "LOGCAT";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 50;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "LOGTXT";
            this.dataGridViewTextBoxColumn28.HeaderText = "IO LOG";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 460;
            // 
            // bsIOLog2
            // 
            this.bsIOLog2.AllowNew = false;
            this.bsIOLog2.DataMember = "DEVICEIO_LOG2";
            this.bsIOLog2.DataSource = this.dsSim;
            // 
            // tpgIOLog
            // 
            this.tpgIOLog.AutoScroll = true;
            this.tpgIOLog.Controls.Add(this.dEVICEIO_LOGDataGridView);
            this.tpgIOLog.Location = new System.Drawing.Point(23, 4);
            this.tpgIOLog.Name = "tpgIOLog";
            this.tpgIOLog.Padding = new System.Windows.Forms.Padding(1);
            this.tpgIOLog.Size = new System.Drawing.Size(717, 538);
            this.tpgIOLog.TabIndex = 1;
            this.tpgIOLog.Text = "OPCLink";
            this.tpgIOLog.UseVisualStyleBackColor = true;
            // 
            // dEVICEIO_LOGDataGridView
            // 
            this.dEVICEIO_LOGDataGridView.AllowUserToAddRows = false;
            this.dEVICEIO_LOGDataGridView.AllowUserToDeleteRows = false;
            this.dEVICEIO_LOGDataGridView.AutoGenerateColumns = false;
            this.dEVICEIO_LOGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dEVICEIO_LOGDataGridView.DataSource = this.bsIOLog;
            this.dEVICEIO_LOGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dEVICEIO_LOGDataGridView.Location = new System.Drawing.Point(1, 1);
            this.dEVICEIO_LOGDataGridView.Name = "dEVICEIO_LOGDataGridView";
            this.dEVICEIO_LOGDataGridView.ReadOnly = true;
            this.dEVICEIO_LOGDataGridView.RowHeadersWidth = 10;
            this.dEVICEIO_LOGDataGridView.RowTemplate.Height = 18;
            this.dEVICEIO_LOGDataGridView.Size = new System.Drawing.Size(715, 536);
            this.dEVICEIO_LOGDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "LOGTIME";
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn21.HeaderText = "LOGTIME";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 110;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "SEQ";
            this.dataGridViewTextBoxColumn22.HeaderText = "SEQ";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 50;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "LOGCAT";
            this.dataGridViewTextBoxColumn23.HeaderText = "LOGCAT";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 50;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "LOGTXT";
            this.dataGridViewTextBoxColumn24.HeaderText = "IO LOG";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 460;
            // 
            // bsIOLog
            // 
            this.bsIOLog.AllowNew = false;
            this.bsIOLog.DataMember = "DEVICEIO_LOG";
            this.bsIOLog.DataSource = this.dsSim;
            // 
            // dgvDevIO_R
            // 
            this.dgvDevIO_R.AllowUserToAddRows = false;
            this.dgvDevIO_R.AllowUserToDeleteRows = false;
            this.dgvDevIO_R.AutoGenerateColumns = false;
            this.dgvDevIO_R.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iONAMEDataGridViewTextBoxColumn1,
            this.iOVALUEDataGridViewTextBoxColumn1,
            this.rEADONDataGridViewTextBoxColumn1});
            this.dgvDevIO_R.DataSource = this.bsDEVICEIO_R;
            this.dgvDevIO_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevIO_R.Location = new System.Drawing.Point(0, 0);
            this.dgvDevIO_R.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDevIO_R.Name = "dgvDevIO_R";
            this.dgvDevIO_R.RowHeadersWidth = 5;
            this.dgvDevIO_R.RowTemplate.Height = 15;
            this.dgvDevIO_R.Size = new System.Drawing.Size(240, 366);
            this.dgvDevIO_R.TabIndex = 81;
            this.dgvDevIO_R.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevIO_R_CellDoubleClick);
            // 
            // iONAMEDataGridViewTextBoxColumn1
            // 
            this.iONAMEDataGridViewTextBoxColumn1.DataPropertyName = "IONAME";
            this.iONAMEDataGridViewTextBoxColumn1.HeaderText = "IONAME";
            this.iONAMEDataGridViewTextBoxColumn1.Name = "iONAMEDataGridViewTextBoxColumn1";
            this.iONAMEDataGridViewTextBoxColumn1.Width = 110;
            // 
            // iOVALUEDataGridViewTextBoxColumn1
            // 
            this.iOVALUEDataGridViewTextBoxColumn1.DataPropertyName = "IOVALUE";
            this.iOVALUEDataGridViewTextBoxColumn1.HeaderText = "IOVALUE";
            this.iOVALUEDataGridViewTextBoxColumn1.Name = "iOVALUEDataGridViewTextBoxColumn1";
            this.iOVALUEDataGridViewTextBoxColumn1.Width = 80;
            // 
            // rEADONDataGridViewTextBoxColumn1
            // 
            this.rEADONDataGridViewTextBoxColumn1.DataPropertyName = "READON";
            this.rEADONDataGridViewTextBoxColumn1.HeaderText = "READON";
            this.rEADONDataGridViewTextBoxColumn1.Name = "rEADONDataGridViewTextBoxColumn1";
            this.rEADONDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bsDEVICEIO_R
            // 
            this.bsDEVICEIO_R.AllowNew = false;
            this.bsDEVICEIO_R.DataMember = "DEVICEIO_R";
            this.bsDEVICEIO_R.DataSource = this.dsSim;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelRgh
            // 
            this.panelRgh.Controls.Add(this.dgvDevIO_R);
            this.panelRgh.Controls.Add(this.dgvDevIO_W);
            this.panelRgh.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRgh.Location = new System.Drawing.Point(744, 25);
            this.panelRgh.Name = "panelRgh";
            this.panelRgh.Size = new System.Drawing.Size(240, 736);
            this.panelRgh.TabIndex = 98;
            // 
            // taSQLOG
            // 
            this.taSQLOG.ClearBeforeFill = true;
            // 
            // taIOLog
            // 
            this.taIOLog.ClearBeforeFill = true;
            // 
            // taDevIO_R
            // 
            this.taDevIO_R.ClearBeforeFill = true;
            // 
            // taDevIO_W
            // 
            this.taDevIO_W.ClearBeforeFill = true;
            // 
            // taIOLog2
            // 
            this.taIOLog2.ClearBeforeFill = true;
            // 
            // taMETER_Q
            // 
            this.taMETER_Q.ClearBeforeFill = true;
            // 
            // taQUEUE
            // 
            this.taQUEUE.ClearBeforeFill = true;
            // 
            // taQUEUE1
            // 
            this.taQUEUE1.ClearBeforeFill = true;
            // 
            // taORDERS_WEB
            // 
            this.taORDERS_WEB.ClearBeforeFill = true;
            // 
            // taLSQLog
            // 
            this.taLSQLog.ClearBeforeFill = true;
            // 
            // taORDERSCACHE
            // 
            this.taORDERSCACHE.ClearBeforeFill = true;
            // 
            // qSTATUSDataGridViewTextBoxColumn1
            // 
            this.qSTATUSDataGridViewTextBoxColumn1.DataPropertyName = "Q_STATUS";
            this.qSTATUSDataGridViewTextBoxColumn1.HeaderText = "Q_STATUS";
            this.qSTATUSDataGridViewTextBoxColumn1.Name = "qSTATUSDataGridViewTextBoxColumn1";
            this.qSTATUSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qSTATUSDataGridViewTextBoxColumn1.Width = 55;
            // 
            // qIDDataGridViewTextBoxColumn3
            // 
            this.qIDDataGridViewTextBoxColumn3.DataPropertyName = "Q_ID";
            this.qIDDataGridViewTextBoxColumn3.HeaderText = "Q_ID";
            this.qIDDataGridViewTextBoxColumn3.Name = "qIDDataGridViewTextBoxColumn3";
            this.qIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.qIDDataGridViewTextBoxColumn3.Width = 35;
            // 
            // oRDERCODEDataGridViewTextBoxColumn2
            // 
            this.oRDERCODEDataGridViewTextBoxColumn2.DataPropertyName = "ORDER_CODE";
            this.oRDERCODEDataGridViewTextBoxColumn2.HeaderText = "ORDER_CODE";
            this.oRDERCODEDataGridViewTextBoxColumn2.Name = "oRDERCODEDataGridViewTextBoxColumn2";
            this.oRDERCODEDataGridViewTextBoxColumn2.ReadOnly = true;
            this.oRDERCODEDataGridViewTextBoxColumn2.Width = 60;
            // 
            // cOMPANYDataGridViewTextBoxColumn
            // 
            this.cOMPANYDataGridViewTextBoxColumn.DataPropertyName = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.HeaderText = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.Name = "cOMPANYDataGridViewTextBoxColumn";
            this.cOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPANYDataGridViewTextBoxColumn.Width = 45;
            // 
            // dATEARRIVEDataGridViewTextBoxColumn1
            // 
            this.dATEARRIVEDataGridViewTextBoxColumn1.DataPropertyName = "DATEARRIVE";
            this.dATEARRIVEDataGridViewTextBoxColumn1.HeaderText = "DATEARRIVE";
            this.dATEARRIVEDataGridViewTextBoxColumn1.Name = "dATEARRIVEDataGridViewTextBoxColumn1";
            this.dATEARRIVEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dATEARRIVEDataGridViewTextBoxColumn1.Width = 90;
            // 
            // cARRIERDataGridViewTextBoxColumn
            // 
            this.cARRIERDataGridViewTextBoxColumn.DataPropertyName = "CARRIER";
            this.cARRIERDataGridViewTextBoxColumn.HeaderText = "CARRIER";
            this.cARRIERDataGridViewTextBoxColumn.Name = "cARRIERDataGridViewTextBoxColumn";
            this.cARRIERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cARRIERDataGridViewTextBoxColumn.Width = 60;
            // 
            // fRONTLICENSEDataGridViewTextBoxColumn2
            // 
            this.fRONTLICENSEDataGridViewTextBoxColumn2.DataPropertyName = "FRONT_LICENSE";
            this.fRONTLICENSEDataGridViewTextBoxColumn2.HeaderText = "FRONT_LICENSE";
            this.fRONTLICENSEDataGridViewTextBoxColumn2.Name = "fRONTLICENSEDataGridViewTextBoxColumn2";
            this.fRONTLICENSEDataGridViewTextBoxColumn2.ReadOnly = true;
            this.fRONTLICENSEDataGridViewTextBoxColumn2.Width = 60;
            // 
            // rEARLICENSEDataGridViewTextBoxColumn2
            // 
            this.rEARLICENSEDataGridViewTextBoxColumn2.DataPropertyName = "REAR_LICENSE";
            this.rEARLICENSEDataGridViewTextBoxColumn2.HeaderText = "REAR_LICENSE";
            this.rEARLICENSEDataGridViewTextBoxColumn2.Name = "rEARLICENSEDataGridViewTextBoxColumn2";
            this.rEARLICENSEDataGridViewTextBoxColumn2.ReadOnly = true;
            this.rEARLICENSEDataGridViewTextBoxColumn2.Width = 60;
            // 
            // dRIVER1DataGridViewTextBoxColumn
            // 
            this.dRIVER1DataGridViewTextBoxColumn.DataPropertyName = "DRIVER1";
            this.dRIVER1DataGridViewTextBoxColumn.HeaderText = "DRIVER1";
            this.dRIVER1DataGridViewTextBoxColumn.Name = "dRIVER1DataGridViewTextBoxColumn";
            this.dRIVER1DataGridViewTextBoxColumn.ReadOnly = true;
            this.dRIVER1DataGridViewTextBoxColumn.Width = 50;
            // 
            // qNTYDataGridViewTextBoxColumn2
            // 
            this.qNTYDataGridViewTextBoxColumn2.DataPropertyName = "QNTY";
            this.qNTYDataGridViewTextBoxColumn2.HeaderText = "QNTY";
            this.qNTYDataGridViewTextBoxColumn2.Name = "qNTYDataGridViewTextBoxColumn2";
            this.qNTYDataGridViewTextBoxColumn2.ReadOnly = true;
            this.qNTYDataGridViewTextBoxColumn2.Width = 40;
            // 
            // dESTINATIONNAMEDataGridViewTextBoxColumn
            // 
            this.dESTINATIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION_NAME";
            this.dESTINATIONNAMEDataGridViewTextBoxColumn.HeaderText = "DESTINATION_NAME";
            this.dESTINATIONNAMEDataGridViewTextBoxColumn.Name = "dESTINATIONNAMEDataGridViewTextBoxColumn";
            this.dESTINATIONNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tAREWEIGHTDataGridViewTextBoxColumn
            // 
            this.tAREWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "TAREWEIGHT";
            this.tAREWEIGHTDataGridViewTextBoxColumn.HeaderText = "TAREWEIGHT";
            this.tAREWEIGHTDataGridViewTextBoxColumn.Name = "tAREWEIGHTDataGridViewTextBoxColumn";
            this.tAREWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAREWEIGHTDataGridViewTextBoxColumn.Width = 50;
            // 
            // mAXWEIGHTDataGridViewTextBoxColumn1
            // 
            this.mAXWEIGHTDataGridViewTextBoxColumn1.DataPropertyName = "MAXWEIGHT";
            this.mAXWEIGHTDataGridViewTextBoxColumn1.HeaderText = "MAXWEIGHT";
            this.mAXWEIGHTDataGridViewTextBoxColumn1.Name = "mAXWEIGHTDataGridViewTextBoxColumn1";
            this.mAXWEIGHTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mAXWEIGHTDataGridViewTextBoxColumn1.Width = 50;
            // 
            // vEHICLENAMEDataGridViewTextBoxColumn
            // 
            this.vEHICLENAMEDataGridViewTextBoxColumn.DataPropertyName = "VEHICLE_NAME";
            this.vEHICLENAMEDataGridViewTextBoxColumn.HeaderText = "VEHICLE_NAME";
            this.vEHICLENAMEDataGridViewTextBoxColumn.Name = "vEHICLENAMEDataGridViewTextBoxColumn";
            this.vEHICLENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vEHICLENAMEDataGridViewTextBoxColumn.Width = 80;
            // 
            // rEGULATIONWEIGHTDataGridViewTextBoxColumn1
            // 
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn1.DataPropertyName = "REGULATIONWEIGHT";
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn1.HeaderText = "REGULATIONWEIGHT";
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn1.Name = "rEGULATIONWEIGHTDataGridViewTextBoxColumn1";
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn1.Width = 50;
            // 
            // fULLTANKDataGridViewTextBoxColumn1
            // 
            this.fULLTANKDataGridViewTextBoxColumn1.DataPropertyName = "FULLTANK";
            this.fULLTANKDataGridViewTextBoxColumn1.HeaderText = "FULLTANK";
            this.fULLTANKDataGridViewTextBoxColumn1.Name = "fULLTANKDataGridViewTextBoxColumn1";
            this.fULLTANKDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fULLTANKDataGridViewTextBoxColumn1.Width = 30;
            // 
            // qIDDataGridViewTextBoxColumn1
            // 
            this.qIDDataGridViewTextBoxColumn1.DataPropertyName = "Q_ID";
            this.qIDDataGridViewTextBoxColumn1.HeaderText = "Q_ID";
            this.qIDDataGridViewTextBoxColumn1.Name = "qIDDataGridViewTextBoxColumn1";
            this.qIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qIDDataGridViewTextBoxColumn1.Width = 40;
            // 
            // oRDERIDDataGridViewTextBoxColumn
            // 
            this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
            this.oRDERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // oRDERCODEDataGridViewTextBoxColumn1
            // 
            this.oRDERCODEDataGridViewTextBoxColumn1.DataPropertyName = "ORDER_CODE";
            this.oRDERCODEDataGridViewTextBoxColumn1.HeaderText = "ORDER_CODE";
            this.oRDERCODEDataGridViewTextBoxColumn1.Name = "oRDERCODEDataGridViewTextBoxColumn1";
            this.oRDERCODEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.oRDERCODEDataGridViewTextBoxColumn1.Width = 50;
            // 
            // dATEARRIVEDataGridViewTextBoxColumn
            // 
            this.dATEARRIVEDataGridViewTextBoxColumn.DataPropertyName = "DATEARRIVE";
            this.dATEARRIVEDataGridViewTextBoxColumn.HeaderText = "DATEARRIVE";
            this.dATEARRIVEDataGridViewTextBoxColumn.Name = "dATEARRIVEDataGridViewTextBoxColumn";
            this.dATEARRIVEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATEARRIVEDataGridViewTextBoxColumn.Width = 90;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSDataGridViewTextBoxColumn.Width = 55;
            // 
            // mETERIDDataGridViewTextBoxColumn1
            // 
            this.mETERIDDataGridViewTextBoxColumn1.DataPropertyName = "METER_ID";
            this.mETERIDDataGridViewTextBoxColumn1.HeaderText = "METER_ID";
            this.mETERIDDataGridViewTextBoxColumn1.Name = "mETERIDDataGridViewTextBoxColumn1";
            this.mETERIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mETERIDDataGridViewTextBoxColumn1.Width = 30;
            // 
            // cARDIDDataGridViewTextBoxColumn
            // 
            this.cARDIDDataGridViewTextBoxColumn.DataPropertyName = "CARD_ID";
            this.cARDIDDataGridViewTextBoxColumn.HeaderText = "CARD_ID";
            this.cARDIDDataGridViewTextBoxColumn.Name = "cARDIDDataGridViewTextBoxColumn";
            this.cARDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cARDIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // fRONTLICENSEDataGridViewTextBoxColumn1
            // 
            this.fRONTLICENSEDataGridViewTextBoxColumn1.DataPropertyName = "FRONT_LICENSE";
            this.fRONTLICENSEDataGridViewTextBoxColumn1.HeaderText = "FRONT_LICENSE";
            this.fRONTLICENSEDataGridViewTextBoxColumn1.Name = "fRONTLICENSEDataGridViewTextBoxColumn1";
            this.fRONTLICENSEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fRONTLICENSEDataGridViewTextBoxColumn1.Width = 50;
            // 
            // rEARLICENSEDataGridViewTextBoxColumn1
            // 
            this.rEARLICENSEDataGridViewTextBoxColumn1.DataPropertyName = "REAR_LICENSE";
            this.rEARLICENSEDataGridViewTextBoxColumn1.HeaderText = "REAR_LICENSE";
            this.rEARLICENSEDataGridViewTextBoxColumn1.Name = "rEARLICENSEDataGridViewTextBoxColumn1";
            this.rEARLICENSEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rEARLICENSEDataGridViewTextBoxColumn1.Width = 50;
            // 
            // qNTYDataGridViewTextBoxColumn1
            // 
            this.qNTYDataGridViewTextBoxColumn1.DataPropertyName = "QNTY";
            this.qNTYDataGridViewTextBoxColumn1.HeaderText = "QNTY";
            this.qNTYDataGridViewTextBoxColumn1.Name = "qNTYDataGridViewTextBoxColumn1";
            this.qNTYDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qNTYDataGridViewTextBoxColumn1.Width = 50;
            // 
            // sTDTAREWEIGHTDataGridViewTextBoxColumn
            // 
            this.sTDTAREWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "STDTAREWEIGHT";
            this.sTDTAREWEIGHTDataGridViewTextBoxColumn.HeaderText = "STDTAREWEIGHT";
            this.sTDTAREWEIGHTDataGridViewTextBoxColumn.Name = "sTDTAREWEIGHTDataGridViewTextBoxColumn";
            this.sTDTAREWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTDTAREWEIGHTDataGridViewTextBoxColumn.Width = 50;
            // 
            // mAXWEIGHTDataGridViewTextBoxColumn
            // 
            this.mAXWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "MAXWEIGHT";
            this.mAXWEIGHTDataGridViewTextBoxColumn.HeaderText = "MAXWEIGHT";
            this.mAXWEIGHTDataGridViewTextBoxColumn.Name = "mAXWEIGHTDataGridViewTextBoxColumn";
            this.mAXWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAXWEIGHTDataGridViewTextBoxColumn.Width = 50;
            // 
            // oRDERNODataGridViewTextBoxColumn
            // 
            this.oRDERNODataGridViewTextBoxColumn.DataPropertyName = "ORDER_NO";
            this.oRDERNODataGridViewTextBoxColumn.HeaderText = "ORDER_NO";
            this.oRDERNODataGridViewTextBoxColumn.Name = "oRDERNODataGridViewTextBoxColumn";
            this.oRDERNODataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERNODataGridViewTextBoxColumn.Width = 50;
            // 
            // gROSSDataGridViewTextBoxColumn
            // 
            this.gROSSDataGridViewTextBoxColumn.DataPropertyName = "GROSS";
            this.gROSSDataGridViewTextBoxColumn.HeaderText = "GROSS";
            this.gROSSDataGridViewTextBoxColumn.Name = "gROSSDataGridViewTextBoxColumn";
            this.gROSSDataGridViewTextBoxColumn.ReadOnly = true;
            this.gROSSDataGridViewTextBoxColumn.Width = 50;
            // 
            // nETDataGridViewTextBoxColumn
            // 
            this.nETDataGridViewTextBoxColumn.DataPropertyName = "NET";
            this.nETDataGridViewTextBoxColumn.HeaderText = "NET";
            this.nETDataGridViewTextBoxColumn.Name = "nETDataGridViewTextBoxColumn";
            this.nETDataGridViewTextBoxColumn.ReadOnly = true;
            this.nETDataGridViewTextBoxColumn.Width = 50;
            // 
            // lOADEDDataGridViewTextBoxColumn
            // 
            this.lOADEDDataGridViewTextBoxColumn.DataPropertyName = "LOADED";
            this.lOADEDDataGridViewTextBoxColumn.HeaderText = "LOADED";
            this.lOADEDDataGridViewTextBoxColumn.Name = "lOADEDDataGridViewTextBoxColumn";
            this.lOADEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOADEDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tAREDataGridViewTextBoxColumn
            // 
            this.tAREDataGridViewTextBoxColumn.DataPropertyName = "TARE";
            this.tAREDataGridViewTextBoxColumn.HeaderText = "TARE";
            this.tAREDataGridViewTextBoxColumn.Name = "tAREDataGridViewTextBoxColumn";
            this.tAREDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAREDataGridViewTextBoxColumn.Width = 50;
            // 
            // tSTAREDataGridViewTextBoxColumn
            // 
            this.tSTAREDataGridViewTextBoxColumn.DataPropertyName = "TS_TARE";
            this.tSTAREDataGridViewTextBoxColumn.HeaderText = "TS_TARE";
            this.tSTAREDataGridViewTextBoxColumn.Name = "tSTAREDataGridViewTextBoxColumn";
            this.tSTAREDataGridViewTextBoxColumn.ReadOnly = true;
            this.tSTAREDataGridViewTextBoxColumn.Width = 50;
            // 
            // tSBSTARTDataGridViewTextBoxColumn
            // 
            this.tSBSTARTDataGridViewTextBoxColumn.DataPropertyName = "TS_BSTART";
            this.tSBSTARTDataGridViewTextBoxColumn.HeaderText = "TS_BSTART";
            this.tSBSTARTDataGridViewTextBoxColumn.Name = "tSBSTARTDataGridViewTextBoxColumn";
            this.tSBSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tSBSTARTDataGridViewTextBoxColumn.Width = 50;
            // 
            // tSBENDDataGridViewTextBoxColumn
            // 
            this.tSBENDDataGridViewTextBoxColumn.DataPropertyName = "TS_BEND";
            this.tSBENDDataGridViewTextBoxColumn.HeaderText = "TS_BEND";
            this.tSBENDDataGridViewTextBoxColumn.Name = "tSBENDDataGridViewTextBoxColumn";
            this.tSBENDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tSBENDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tSFINISHDataGridViewTextBoxColumn
            // 
            this.tSFINISHDataGridViewTextBoxColumn.DataPropertyName = "TS_FINISH";
            this.tSFINISHDataGridViewTextBoxColumn.HeaderText = "TS_FINISH";
            this.tSFINISHDataGridViewTextBoxColumn.Name = "tSFINISHDataGridViewTextBoxColumn";
            this.tSFINISHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tSFINISHDataGridViewTextBoxColumn.Width = 50;
            // 
            // tSBOLDataGridViewTextBoxColumn
            // 
            this.tSBOLDataGridViewTextBoxColumn.DataPropertyName = "TS_BOL";
            this.tSBOLDataGridViewTextBoxColumn.HeaderText = "TS_BOL";
            this.tSBOLDataGridViewTextBoxColumn.Name = "tSBOLDataGridViewTextBoxColumn";
            this.tSBOLDataGridViewTextBoxColumn.ReadOnly = true;
            this.tSBOLDataGridViewTextBoxColumn.Width = 50;
            // 
            // rEGULATIONWEIGHTDataGridViewTextBoxColumn
            // 
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "REGULATIONWEIGHT";
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn.HeaderText = "REGULATIONWEIGHT";
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn.Name = "rEGULATIONWEIGHTDataGridViewTextBoxColumn";
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEGULATIONWEIGHTDataGridViewTextBoxColumn.Width = 50;
            // 
            // wEIGHTSCALEDataGridViewTextBoxColumn
            // 
            this.wEIGHTSCALEDataGridViewTextBoxColumn.DataPropertyName = "WEIGHTSCALE";
            this.wEIGHTSCALEDataGridViewTextBoxColumn.HeaderText = "WEIGHTSCALE";
            this.wEIGHTSCALEDataGridViewTextBoxColumn.Name = "wEIGHTSCALEDataGridViewTextBoxColumn";
            this.wEIGHTSCALEDataGridViewTextBoxColumn.ReadOnly = true;
            this.wEIGHTSCALEDataGridViewTextBoxColumn.Width = 50;
            // 
            // cALCQUANTITYDataGridViewTextBoxColumn
            // 
            this.cALCQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "CALCQUANTITY";
            this.cALCQUANTITYDataGridViewTextBoxColumn.HeaderText = "CALCQUANTITY";
            this.cALCQUANTITYDataGridViewTextBoxColumn.Name = "cALCQUANTITYDataGridViewTextBoxColumn";
            this.cALCQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.cALCQUANTITYDataGridViewTextBoxColumn.Width = 50;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.tabBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelRgh);
            this.Controls.Add(this.fillToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[BAY 1] TAS Simulator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeterQAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeterQAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeterQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevIO_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDEVICEIO_W)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.tabBottom.ResumeLayout(false);
            this.tpgSQLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QUEUE_SQ_LOGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSQLOG)).EndInit();
            this.tpgCache.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsORDERSCACHE)).EndInit();
            this.tpgQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQUEUE1)).EndInit();
            this.tpgORDER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsORDERS_WEB)).EndInit();
            this.tpgLSQLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLSQLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLSQLog)).EndInit();
            this.tpgIOLog2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEIO_LOG2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIOLog2)).EndInit();
            this.tpgIOLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEIO_LOGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIOLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevIO_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDEVICEIO_R)).EndInit();
            this.panelRgh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private dsSIM dsSim;
		private System.Windows.Forms.BindingSource bsMeterQ;

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.TextBox bAYIDTextBox;
		private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
		private System.Windows.Forms.TextBox tbMain;
		private System.Windows.Forms.TextBox tbAuto;
		private System.Windows.Forms.TextBox bATCH_IDTextBox;
		private System.Windows.Forms.TextBox bATCH_QNTYTextBox;
		private System.Windows.Forms.TextBox cARD_LABELTextBox;
		private System.Windows.Forms.TextBox tM_CHECKINTextBox;
		private System.Windows.Forms.TextBox tbDry;
		private System.Windows.Forms.TextBox sTIMERTextBox;
		private System.Windows.Forms.TextBox mSG1TextBox;
		private System.Windows.Forms.TextBox mSG2TextBox;
		private System.Windows.Forms.TextBox aLERTTextBox;
		private System.Windows.Forms.TextBox tbStatus;
		private System.Windows.Forms.TextBox dEBUG_MSGTextBox;
		private System.Windows.Forms.TextBox uSTR4TextBox;
		private System.Windows.Forms.TextBox pRVBATCHIDTextBox;
		private System.Windows.Forms.TextBox cARD_TAGIDTextBox;
		private System.Windows.Forms.TextBox oCARD_LABELTextBox;
		private System.Windows.Forms.TextBox oCARD_TAGIDTextBox;
		private System.Windows.Forms.ToolStrip fillToolStrip;
		private System.Windows.Forms.ToolStripLabel bAYIDToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox bAYIDToolStripTextBox;
		private System.Windows.Forms.ToolStripButton fillToolStripButton;
		private System.Windows.Forms.BindingSource bsSQLOG;
		private TASQSim.dsSIMTableAdapters.QUEUE_SQ_LOGTableAdapter taSQLOG;
		private System.Windows.Forms.TabControl tabBottom;
		private System.Windows.Forms.TabPage tpgSQLog;
		private System.Windows.Forms.TabPage tpgIOLog;
		private System.Windows.Forms.DataGridView QUEUE_SQ_LOGDataGridView;
		private System.Windows.Forms.BindingSource bsIOLog;
		private TASQSim.dsSIMTableAdapters.DEVICEIO_LOGTableAdapter taIOLog;
		private System.Windows.Forms.DataGridView dEVICEIO_LOGDataGridView;
		private System.Windows.Forms.BindingSource bsDEVICEIO_R;
		private TASQSim.dsSIMTableAdapters.DEVICEIO_RTableAdapter taDevIO_R;
		private System.Windows.Forms.DataGridView dgvDevIO_R;
        private System.Windows.Forms.DataGridView dgvDevIO_W;
		private System.Windows.Forms.ToolStripButton tsSQ;
		private System.Windows.Forms.ToolStripButton tsIO;
		private System.Windows.Forms.BindingSource bsDEVICEIO_W;
		private TASQSim.dsSIMTableAdapters.DEVICEIO_WTableAdapter taDevIO_W;
		private System.Windows.Forms.ToolStripButton tsLog;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripTextBox tstIOFilter;
		private TASQSim.dsSIMTableAdapters.SimTableAdapter sim_ta;
		private System.Windows.Forms.TabPage tpgIOLog2;
        private System.Windows.Forms.DataGridView dEVICEIO_LOG2DataGridView;
		private System.Windows.Forms.BindingSource bsIOLog2;
		private TASQSim.dsSIMTableAdapters.DEVICEIO_LOG2TableAdapter taIOLog2;
		private System.Windows.Forms.ToolStripTextBox tstbLogHrs;
        private System.Windows.Forms.ToolStripButton tsbtnSQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn iONAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOVALUEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEADONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iONAMEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOVALUEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.Button btnL1000;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Button btnL500;
        private System.Windows.Forms.Button btnL100;
        private System.Windows.Forms.Button btnL04;
        private System.Windows.Forms.Button btnRst;
        private dsSIMTableAdapters.T_METER_QTableAdapter taMETER_Q;
        private dsSIMTableAdapters.T_QUEUETableAdapter taQUEUE;
        private System.Windows.Forms.BindingSource bsQueue;
        private System.Windows.Forms.Panel panelRgh;
        private System.Windows.Forms.TabPage tpgQ;
        private System.Windows.Forms.DataGridView dgwQ;
        private System.Windows.Forms.BindingSource bsQUEUE1;
        private dsSIMTableAdapters.T_QUEUE1TableAdapter taQUEUE1;
        private System.Windows.Forms.Button btnS7;
        private System.Windows.Forms.Button btnS4;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Button btnSTare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.Button btnIORF;
        private System.Windows.Forms.Button btnS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRYRUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STDTAREWEIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXWEIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGULATIONWEIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn wAITTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRONTLICENSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEARLICENSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLTANKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSPARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSEXITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbRegW;
        private System.Windows.Forms.TextBox tbMaxW;
        private System.Windows.Forms.TextBox tbTareW;
        private System.Windows.Forms.TextBox sQERRORTextBox;
        private System.Windows.Forms.Button btnSyncIO;
        private System.Windows.Forms.TabPage tpgORDER;
        private System.Windows.Forms.DataGridView dgwO;
        private System.Windows.Forms.BindingSource bsORDERS_WEB;
        private dsSIMTableAdapters.T_ORDERS_WEBTableAdapter taORDERS_WEB;
        private System.Windows.Forms.DataGridView dgwMeterQAll;
        private System.Windows.Forms.TabPage tpgLSQLog;
        private System.Windows.Forms.DataGridView dgwLSQLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bsLSQLog;
        private dsSIMTableAdapters.LOADING_SQ_LOGTableAdapter taLSQLog;
        private System.Windows.Forms.BindingSource bsMeterQAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETERIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAINTENANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRYRUNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROG_Q1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROG_Q2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.TabPage tpgCache;
        private System.Windows.Forms.DataGridView dgwCache;
        private System.Windows.Forms.BindingSource bsORDERSCACHE;
        private dsSIMTableAdapters.T_ORDERS_CACHETableAdapter taORDERSCACHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Button btnSwDry;
        private System.Windows.Forms.Button btnSwAuto;
        private System.Windows.Forms.Button btnSwMain;
        private System.Windows.Forms.CheckBox chk1KLPM;
        private System.Windows.Forms.CheckBox chk2KLPM;
        private System.Windows.Forms.CheckBox chk500LPM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qSTATUSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCODEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEARRIVEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARRIERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRONTLICENSEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEARLICENSEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRIVER1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNTYDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAREWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXWEIGHTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vEHICLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGULATIONWEIGHTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLTANKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEARRIVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mETERIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRONTLICENSEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEARLICENSEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNTYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDTAREWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOADEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSTAREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSBSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSBENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSFINISHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSBOLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGULATIONWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTSCALEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALCQUANTITYDataGridViewTextBoxColumn;
    }
}

