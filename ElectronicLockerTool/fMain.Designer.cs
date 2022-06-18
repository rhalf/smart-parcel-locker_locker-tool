namespace KerongLockerTool
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
        private void InitializeComponent()
        {
            this.gbSerial = new System.Windows.Forms.GroupBox();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.bScanPortNames = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.bUnlockAll = new System.Windows.Forms.Button();
            this.bGetStatus = new System.Windows.Forms.Button();
            this.bClearOutput = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbBoard7 = new System.Windows.Forms.CheckBox();
            this.cbBoard6 = new System.Windows.Forms.CheckBox();
            this.cbBoard8 = new System.Windows.Forms.CheckBox();
            this.cbBoardA = new System.Windows.Forms.CheckBox();
            this.cbBoard9 = new System.Windows.Forms.CheckBox();
            this.cbBoard5 = new System.Windows.Forms.CheckBox();
            this.cbBoard1 = new System.Windows.Forms.CheckBox();
            this.cbBoard0 = new System.Windows.Forms.CheckBox();
            this.cbBoard2 = new System.Windows.Forms.CheckBox();
            this.cbBoard4 = new System.Windows.Forms.CheckBox();
            this.cbBoard3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tpStatus = new System.Windows.Forms.TabControl();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.bClearStatus = new System.Windows.Forms.Button();
            this.gbSerial.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSerial
            // 
            this.gbSerial.Controls.Add(this.tlpLeft);
            this.gbSerial.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSerial.Location = new System.Drawing.Point(3, 3);
            this.gbSerial.Name = "gbSerial";
            this.gbSerial.Size = new System.Drawing.Size(1002, 55);
            this.gbSerial.TabIndex = 0;
            this.gbSerial.TabStop = false;
            this.gbSerial.Text = "Serial";
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 6;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLeft.Controls.Add(this.label1, 0, 0);
            this.tlpLeft.Controls.Add(this.cbPortName, 1, 0);
            this.tlpLeft.Controls.Add(this.bScanPortNames, 2, 0);
            this.tlpLeft.Controls.Add(this.bConnect, 5, 0);
            this.tlpLeft.Controls.Add(this.label2, 3, 0);
            this.tlpLeft.Controls.Add(this.cbBaudRate, 4, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 16);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.Padding = new System.Windows.Forms.Padding(3);
            this.tlpLeft.RowCount = 1;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLeft.Size = new System.Drawing.Size(996, 36);
            this.tlpLeft.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPortName
            // 
            this.cbPortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(106, 6);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(289, 21);
            this.cbPortName.TabIndex = 1;
            // 
            // bScanPortNames
            // 
            this.bScanPortNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bScanPortNames.Location = new System.Drawing.Point(401, 6);
            this.bScanPortNames.Name = "bScanPortNames";
            this.bScanPortNames.Size = new System.Drawing.Size(94, 24);
            this.bScanPortNames.TabIndex = 2;
            this.bScanPortNames.Text = "Scan";
            this.bScanPortNames.UseVisualStyleBackColor = true;
            this.bScanPortNames.Click += new System.EventHandler(this.bScanPortNames_Click);
            // 
            // bConnect
            // 
            this.bConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bConnect.Location = new System.Drawing.Point(896, 6);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(94, 24);
            this.bConnect.TabIndex = 5;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(501, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baudrate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(601, 6);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(289, 21);
            this.cbBaudRate.TabIndex = 4;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.tableLayoutPanel3);
            this.gbControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbControls.Location = new System.Drawing.Point(3, 58);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(1002, 100);
            this.gbControls.TabIndex = 1;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tlpControls, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(996, 81);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 5;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpControls.Controls.Add(this.bUnlockAll, 0, 0);
            this.tlpControls.Controls.Add(this.bGetStatus, 0, 0);
            this.tlpControls.Controls.Add(this.bClearOutput, 4, 0);
            this.tlpControls.Controls.Add(this.bClearStatus, 3, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(3, 43);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Size = new System.Drawing.Size(990, 35);
            this.tlpControls.TabIndex = 1;
            // 
            // bUnlockAll
            // 
            this.bUnlockAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bUnlockAll.Location = new System.Drawing.Point(201, 3);
            this.bUnlockAll.Name = "bUnlockAll";
            this.bUnlockAll.Size = new System.Drawing.Size(192, 29);
            this.bUnlockAll.TabIndex = 4;
            this.bUnlockAll.Text = "Unlock All";
            this.bUnlockAll.UseVisualStyleBackColor = true;
            this.bUnlockAll.Click += new System.EventHandler(this.bUnlockAll_Click);
            // 
            // bGetStatus
            // 
            this.bGetStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGetStatus.Location = new System.Drawing.Point(3, 3);
            this.bGetStatus.Name = "bGetStatus";
            this.bGetStatus.Size = new System.Drawing.Size(192, 29);
            this.bGetStatus.TabIndex = 3;
            this.bGetStatus.Text = "GetStatus";
            this.bGetStatus.UseVisualStyleBackColor = true;
            this.bGetStatus.Click += new System.EventHandler(this.bGetStatus_Click);
            // 
            // bClearOutput
            // 
            this.bClearOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bClearOutput.Location = new System.Drawing.Point(795, 3);
            this.bClearOutput.Name = "bClearOutput";
            this.bClearOutput.Size = new System.Drawing.Size(192, 29);
            this.bClearOutput.TabIndex = 5;
            this.bClearOutput.Text = "Clear Output";
            this.bClearOutput.UseVisualStyleBackColor = true;
            this.bClearOutput.Click += new System.EventHandler(this.bClearOutput_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(990, 34);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Board Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 11;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.Controls.Add(this.cbBoard7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoardA, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard0, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBoard3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(153, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(834, 28);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // cbBoard7
            // 
            this.cbBoard7.AutoSize = true;
            this.cbBoard7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard7.Location = new System.Drawing.Point(528, 3);
            this.cbBoard7.Name = "cbBoard7";
            this.cbBoard7.Size = new System.Drawing.Size(69, 22);
            this.cbBoard7.TabIndex = 41;
            this.cbBoard7.Text = "x07";
            this.cbBoard7.UseVisualStyleBackColor = true;
            this.cbBoard7.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard6
            // 
            this.cbBoard6.AutoSize = true;
            this.cbBoard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard6.Location = new System.Drawing.Point(453, 3);
            this.cbBoard6.Name = "cbBoard6";
            this.cbBoard6.Size = new System.Drawing.Size(69, 22);
            this.cbBoard6.TabIndex = 40;
            this.cbBoard6.Text = "x06";
            this.cbBoard6.UseVisualStyleBackColor = true;
            this.cbBoard6.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard8
            // 
            this.cbBoard8.AutoSize = true;
            this.cbBoard8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard8.Location = new System.Drawing.Point(603, 3);
            this.cbBoard8.Name = "cbBoard8";
            this.cbBoard8.Size = new System.Drawing.Size(69, 22);
            this.cbBoard8.TabIndex = 39;
            this.cbBoard8.Text = "x08";
            this.cbBoard8.UseVisualStyleBackColor = true;
            this.cbBoard8.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoardA
            // 
            this.cbBoardA.AutoSize = true;
            this.cbBoardA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoardA.Location = new System.Drawing.Point(753, 3);
            this.cbBoardA.Name = "cbBoardA";
            this.cbBoardA.Size = new System.Drawing.Size(78, 22);
            this.cbBoardA.TabIndex = 38;
            this.cbBoardA.Text = "x0A";
            this.cbBoardA.UseVisualStyleBackColor = true;
            this.cbBoardA.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard9
            // 
            this.cbBoard9.AutoSize = true;
            this.cbBoard9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard9.Location = new System.Drawing.Point(678, 3);
            this.cbBoard9.Name = "cbBoard9";
            this.cbBoard9.Size = new System.Drawing.Size(69, 22);
            this.cbBoard9.TabIndex = 37;
            this.cbBoard9.Text = "x09";
            this.cbBoard9.UseVisualStyleBackColor = true;
            this.cbBoard9.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard5
            // 
            this.cbBoard5.AutoSize = true;
            this.cbBoard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard5.Location = new System.Drawing.Point(378, 3);
            this.cbBoard5.Name = "cbBoard5";
            this.cbBoard5.Size = new System.Drawing.Size(69, 22);
            this.cbBoard5.TabIndex = 36;
            this.cbBoard5.Text = "x05";
            this.cbBoard5.UseVisualStyleBackColor = true;
            this.cbBoard5.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard1
            // 
            this.cbBoard1.AutoSize = true;
            this.cbBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard1.Location = new System.Drawing.Point(78, 3);
            this.cbBoard1.Name = "cbBoard1";
            this.cbBoard1.Size = new System.Drawing.Size(69, 22);
            this.cbBoard1.TabIndex = 35;
            this.cbBoard1.Text = "x01";
            this.cbBoard1.UseVisualStyleBackColor = true;
            this.cbBoard1.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard0
            // 
            this.cbBoard0.AutoSize = true;
            this.cbBoard0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard0.Location = new System.Drawing.Point(3, 3);
            this.cbBoard0.Name = "cbBoard0";
            this.cbBoard0.Size = new System.Drawing.Size(69, 22);
            this.cbBoard0.TabIndex = 34;
            this.cbBoard0.Text = "x00";
            this.cbBoard0.UseVisualStyleBackColor = true;
            this.cbBoard0.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard2
            // 
            this.cbBoard2.AutoSize = true;
            this.cbBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard2.Location = new System.Drawing.Point(153, 3);
            this.cbBoard2.Name = "cbBoard2";
            this.cbBoard2.Size = new System.Drawing.Size(69, 22);
            this.cbBoard2.TabIndex = 33;
            this.cbBoard2.Text = "x02";
            this.cbBoard2.UseVisualStyleBackColor = true;
            this.cbBoard2.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard4
            // 
            this.cbBoard4.AutoSize = true;
            this.cbBoard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard4.Location = new System.Drawing.Point(303, 3);
            this.cbBoard4.Name = "cbBoard4";
            this.cbBoard4.Size = new System.Drawing.Size(69, 22);
            this.cbBoard4.TabIndex = 32;
            this.cbBoard4.Text = "x04";
            this.cbBoard4.UseVisualStyleBackColor = true;
            this.cbBoard4.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // cbBoard3
            // 
            this.cbBoard3.AutoSize = true;
            this.cbBoard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoard3.Location = new System.Drawing.Point(228, 3);
            this.cbBoard3.Name = "cbBoard3";
            this.cbBoard3.Size = new System.Drawing.Size(69, 22);
            this.cbBoard3.TabIndex = 31;
            this.cbBoard3.Text = "x03";
            this.cbBoard3.UseVisualStyleBackColor = true;
            this.cbBoard3.CheckedChanged += new System.EventHandler(this.cbBoard_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tpStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 440);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // tpStatus
            // 
            this.tpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpStatus.Location = new System.Drawing.Point(3, 16);
            this.tpStatus.Name = "tpStatus";
            this.tpStatus.SelectedIndex = 0;
            this.tpStatus.Size = new System.Drawing.Size(996, 421);
            this.tpStatus.TabIndex = 0;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.rtbOutput);
            this.gbOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbOutput.Location = new System.Drawing.Point(3, 478);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(1002, 120);
            this.gbOutput.TabIndex = 6;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Location = new System.Drawing.Point(3, 16);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOutput.Size = new System.Drawing.Size(996, 101);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // bClearStatus
            // 
            this.bClearStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bClearStatus.Location = new System.Drawing.Point(597, 3);
            this.bClearStatus.Name = "bClearStatus";
            this.bClearStatus.Size = new System.Drawing.Size(192, 29);
            this.bClearStatus.TabIndex = 6;
            this.bClearStatus.Text = "Clear Status";
            this.bClearStatus.UseVisualStyleBackColor = true;
            this.bClearStatus.Click += new System.EventHandler(this.bClearStatus_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbSerial);
            this.Name = "fMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.gbSerial.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSerial;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.Button bScanPortNames;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.Button bUnlockAll;
        private System.Windows.Forms.Button bGetStatus;
        private System.Windows.Forms.Button bClearOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox cbBoard7;
        private System.Windows.Forms.CheckBox cbBoard6;
        private System.Windows.Forms.CheckBox cbBoard8;
        private System.Windows.Forms.CheckBox cbBoardA;
        private System.Windows.Forms.CheckBox cbBoard9;
        private System.Windows.Forms.CheckBox cbBoard5;
        private System.Windows.Forms.CheckBox cbBoard1;
        private System.Windows.Forms.CheckBox cbBoard0;
        private System.Windows.Forms.CheckBox cbBoard2;
        private System.Windows.Forms.CheckBox cbBoard4;
        private System.Windows.Forms.CheckBox cbBoard3;
        private System.Windows.Forms.TabControl tpStatus;
        private System.Windows.Forms.Button bClearStatus;
    }
}

