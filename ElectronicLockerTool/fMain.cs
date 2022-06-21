using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerongLockerTool
{
    public partial class fMain : Form
    {
        Cu48b cu48b;
        CheckBox[] _cbLockers;
        CheckBox[] _cbSensors;

        List<uint> _boardNumbers;

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            _boardNumbers = new List<uint>();  

            uint[] baudRates = { 110, 150, 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200, 230400, 460800, 921600 };
            cbBaudRate.Items.Clear();
            foreach (uint baudRate in baudRates)
            {
                cbBaudRate.Items.Add(baudRate.ToString());
            }
            if (cbBaudRate.Items.Count > 0) cbBaudRate.SelectedIndex = 7;

            Form fMain = (Form)sender;
            fMain.Text = Assembly.GetEntryAssembly().GetName().Name;
        }

        private void _bLocker_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (cu48b == null) return;

            try
            {
                uint lockerNumber = uint.Parse(button.Text);
                uint boardNumber = uint.Parse(button.Tag.ToString());
                cu48b.send(boardNumber, lockerNumber, Cu48b.LOCKER_UNLOCK);
                String data = BitConverter.ToString(cu48b.dataOut);
                rtbPrint(data, Color.Black);
            }
            catch (Exception ex)
            {
                rtbPrint(ex.Message, Color.Red);
            }

        }

        private void Cu48b_onDataReceived(object sender, EventArgs e)
        {
            Cu48b cU48B = (Cu48b)sender;

            String data = BitConverter.ToString(cU48B.dataIn);

            rtbPrint(data, Color.Green);

            try
            {
                TabPage tabPage = null;

                foreach (TabPage tp in tpStatus.TabPages)
                {
                    if (tp.Name == "Board_" + cu48b.boardNumber.ToString())
                    {
                        tabPage = tp; break;
                    }
                }

                if (tabPage == null)
                {

                    tabPage = new TabPage();
                    tabPage.Name = "Board_" + cu48b.boardNumber.ToString();
                    tabPage.Text = "Board_" + cu48b.boardNumber.ToString();

                    TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                    tableLayoutPanel.Dock = DockStyle.Fill;
                    tableLayoutPanel.ColumnCount = 2;
                    tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));
                    tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));
                    tableLayoutPanel.RowCount = 1;

                    GroupBox gbLockers = new GroupBox();
                    gbLockers.Text = "Lockers";
                    gbLockers.Dock = DockStyle.Fill;

                    // lockers start
                    TableLayoutPanel tlpLockers = new TableLayoutPanel();
                    tlpLockers.Dock = DockStyle.Fill;
                    tlpLockers.ColumnCount = 4;
                    tlpLockers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpLockers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpLockers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpLockers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpLockers.RowCount = 1;

                    TableLayoutPanel tlpLockerGroup = new TableLayoutPanel();

                    for (int index = 0; index < cU48B.lockers.Length; index++)
                    {
                        Button button = new Button();
                        button.Text = index.ToString();
                        button.Tag = cU48B.boardNumber;

                        if (cU48B.lockers[index]) button.BackColor = Color.Lime;
                        button.Dock = System.Windows.Forms.DockStyle.Fill;
                        button.Click += new EventHandler(_bLocker_Clicked);

                        tlpLockerGroup.Controls.Add(button);

                        if (index == 11 || index == 23 || index == 35 || index == 47)
                        {
                            tlpLockerGroup.Dock = DockStyle.Fill;
                            tlpLockerGroup.ColumnCount = 1;
                            tlpLockerGroup.RowCount = 13;
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpLockerGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100));
                            tlpLockers.Controls.Add(tlpLockerGroup);
                            tlpLockerGroup = new TableLayoutPanel();
                        }
                    }

                    gbLockers.Controls.Add(tlpLockers);

                    tableLayoutPanel.Controls.Add(gbLockers);
                    // lockers end

                    // Sensor Starts
                    TableLayoutPanel tlpSensors = new TableLayoutPanel();
                    tlpSensors.Dock = DockStyle.Fill;
                    tlpSensors.ColumnCount = 4;
                    tlpSensors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpSensors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpSensors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpSensors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
                    tlpSensors.RowCount = 1;

                    GroupBox gbSensors = new GroupBox();
                    gbSensors.Text = "Sensors";
                    gbSensors.Dock = DockStyle.Fill;

                    TableLayoutPanel tlpSensorsGroup = new TableLayoutPanel();

                    for (int index = 0; index < cU48B.sensors.Length; index++)
                    {
                        Button button = new Button();
                        button.Text = index.ToString();
                        if (cU48B.sensors[index]) button.BackColor = Color.Yellow;

                        button.Dock = System.Windows.Forms.DockStyle.Fill;
                        tlpSensorsGroup.Controls.Add(button);

                        if (index == 11 || index == 23 || index == 35 || index == 47)
                        {
                            tlpSensorsGroup.Dock = DockStyle.Fill;
                            tlpSensorsGroup.ColumnCount = 1;
                            tlpSensorsGroup.RowCount = 13;
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                            tlpSensorsGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100));
                            tlpSensors.Controls.Add(tlpSensorsGroup);
                            tlpSensorsGroup = new TableLayoutPanel();
                        }
                    }
                    gbSensors.Controls.Add(tlpSensors);

                    tableLayoutPanel.Controls.Add(gbSensors);

                    tabPage.Controls.Add(tableLayoutPanel);


                    tpStatus.Invoke(new Action(() =>
                    {
                        tpStatus.TabPages.Add(tabPage);
                    }));

                }
                else
                {
                    tpStatus.Invoke(new Action(() =>
                    {

                        TableLayoutPanel tableLayoutPanel = (TableLayoutPanel)tabPage.Controls[0];

                        GroupBox gbLockers = (GroupBox)tableLayoutPanel.Controls[0];
                        TableLayoutPanel tlpLockers = (TableLayoutPanel)gbLockers.Controls[0];
                        foreach (TableLayoutPanel tlpLockersGroup in tlpLockers.Controls)
                        {
                            foreach (Button b in tlpLockersGroup.Controls)
                            {
                                for (int index = 0; index < cU48B.lockers.Length; index++)
                                {
                                    if (b.Text == index.ToString())
                                    {
                                        if (cU48B.lockers[index]) b.BackColor = Color.Lime;
                                        else b.BackColor = Color.Transparent;
                                    }
                                }

                            }
                        }

                        GroupBox gbSensors = (GroupBox)tableLayoutPanel.Controls[1];
                        TableLayoutPanel tlpSensors = (TableLayoutPanel)gbSensors.Controls[0];
                        foreach (TableLayoutPanel tlpSensorsGroup in tlpSensors.Controls)
                        {
                            foreach (Button b in tlpSensorsGroup.Controls)
                            {
                                for (int index = 0; index < cU48B.sensors.Length; index++)
                                {
                                    if (b.Text == index.ToString())
                                    {
                                        if (cU48B.sensors[index]) b.BackColor = Color.Yellow;
                                        else b.BackColor = Color.Transparent;
                                    }
                                }

                            }
                        }
                    }));
                }

            }
            catch (Exception exception)
            {
                rtbPrint(exception.Message, Color.Red);
            }

        }


        private void bScanPortNames_Click(object sender, EventArgs e)
        {
            string[] portNames = Cu48b.getPortNames();
            cbPortName.Items.Clear();
            foreach (string portName in portNames)
            {
                cbPortName.Items.Add(portName);
            }
            if (cbPortName.Items.Count > 0) cbPortName.SelectedIndex = 0;
        }


        private void bGetStatus_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    foreach (uint cb in _boardNumbers)
                    {
                        if (cu48b == null) return;
                        cu48b.send(cb, 0, Cu48b.GET_STATUS);
                        cu48b.read();

                        String data = BitConverter.ToString(cu48b.dataOut);
                        rtbPrint(data, Color.Black);

                        Thread.Sleep(100);
                    }
                }
                catch (Exception ex)
                {
                    rtbPrint(ex.Message, Color.Red);
                }
            });
        }

        void tpStatusAdd(TabPage tabPage)
        {
            tpStatus.Invoke(new Action(() =>
            {
                tpStatus.TabPages.Add(tabPage);
            }));
        }
        void rtbPrint(String text, Color color)
        {
            rtbOutput.Invoke(new Action(() =>
            {
                rtbOutput.SelectionColor = color;
                rtbOutput.SelectionFont = new Font("Courier", 11, FontStyle.Regular);
                rtbOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") + " | " + text + '\n');
                rtbOutput.ScrollToCaret();
            }));
        }

        private void bUnlockAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (uint cb in _boardNumbers)
                {
                    if (cu48b == null) return;
                    cu48b.send(cb, Cu48b.LOCKER_ALL, Cu48b.LOCKER_UNLOCK);

                    String data = BitConverter.ToString(cu48b.dataOut);
                    rtbPrint(data, Color.Black);
                }
            }
            catch (Exception ex)
            {
                rtbPrint(ex.Message, Color.Red);
            }
        }


        private void bClearOutput_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cu48b == null && bConnect.Text.Equals("Connect"))
                {
                    cu48b = new Cu48b(cbPortName.Text, uint.Parse(cbBaudRate.Text));
                    cu48b.onDataReceived += Cu48b_onDataReceived;
                    cu48b.open();
                    bConnect.Text = "Disconnect";
                    rtbPrint(String.Concat("Connected to ", cbPortName.Text), Color.Blue);
                }
                else if (cu48b != null && bConnect.Text.Equals("Disconnect"))
                {
                    cu48b.close();
                    cu48b = null;
                    bConnect.Text = "Connect";
                    rtbPrint(String.Concat("Disconnected to ", cbPortName.Text), Color.Blue);
                }
            }
            catch (Exception ex)
            {
                rtbPrint(ex.Message, Color.Red);
            }
        }



        private void cbBoard_CheckedChanged(object sender, EventArgs e)
        {
            _boardNumbers.Clear();

            if (cbBoardA.Checked)
            {
                cbBoard0.Checked = false;
                cbBoard1.Checked = false;
                cbBoard2.Checked = false;
                cbBoard3.Checked = false;
                cbBoard4.Checked = false;
                cbBoard5.Checked = false;
                cbBoard6.Checked = false;
                cbBoard7.Checked = false;
                cbBoard8.Checked = false;
                cbBoard9.Checked = false;

                cbBoard0.Enabled = false;
                cbBoard1.Enabled = false;
                cbBoard2.Enabled = false;
                cbBoard3.Enabled = false;
                cbBoard4.Enabled = false;
                cbBoard5.Enabled = false;
                cbBoard6.Enabled = false;
                cbBoard7.Enabled = false;
                cbBoard8.Enabled = false;
                cbBoard9.Enabled = false;

                _boardNumbers.Add(0x0A);
                return;
            }
            else
            {
                cbBoard0.Enabled = true;
                cbBoard1.Enabled = true;
                cbBoard2.Enabled = true;
                cbBoard3.Enabled = true;
                cbBoard4.Enabled = true;
                cbBoard5.Enabled = true;
                cbBoard6.Enabled = true;
                cbBoard7.Enabled = true;
                cbBoard8.Enabled = true;
                cbBoard9.Enabled = true;

                if (cbBoard0.Checked) _boardNumbers.Add(0x00);
                if (cbBoard1.Checked) _boardNumbers.Add(0x01);
                if (cbBoard2.Checked) _boardNumbers.Add(0x02);
                if (cbBoard3.Checked) _boardNumbers.Add(0x03);
                if (cbBoard4.Checked) _boardNumbers.Add(0x04);
                if (cbBoard5.Checked) _boardNumbers.Add(0x05);
                if (cbBoard6.Checked) _boardNumbers.Add(0x06);
                if (cbBoard7.Checked) _boardNumbers.Add(0x07);
                if (cbBoard8.Checked) _boardNumbers.Add(0x08);
                if (cbBoard9.Checked) _boardNumbers.Add(0x09);
            }

            Console.WriteLine(String.Join(",", _boardNumbers));
        }

        private void bClearStatus_Click(object sender, EventArgs e)
        {
            tpStatus.Controls.Clear();
        }
    }
}

