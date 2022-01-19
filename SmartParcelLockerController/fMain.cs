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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicLockerTool
{
    public partial class fMain : Form
    {
        Cu48b cu48b;
        CheckBox[] _cbLockers;
        CheckBox[] _cbSensors;

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            _cbLockers = new CheckBox[48] {
                cbLocker00, cbLocker01, cbLocker02, cbLocker03, cbLocker04, cbLocker05, cbLocker06, cbLocker07,
                cbLocker08, cbLocker09, cbLocker10, cbLocker11, cbLocker12, cbLocker13, cbLocker14, cbLocker15,
                cbLocker16, cbLocker17, cbLocker18, cbLocker19, cbLocker20, cbLocker21, cbLocker22, cbLocker23,
                cbLocker24, cbLocker25, cbLocker26, cbLocker27, cbLocker28, cbLocker29, cbLocker30, cbLocker31,
                cbLocker32, cbLocker33, cbLocker34, cbLocker35, cbLocker36, cbLocker37, cbLocker38, cbLocker39,
                cbLocker40, cbLocker41, cbLocker42, cbLocker43, cbLocker44, cbLocker45, cbLocker46, cbLocker47
            };

            foreach (var checkBox in _cbLockers)
            {
                checkBox.Click += new EventHandler(_cbLockers_Clicked);
                checkBox.CheckedChanged += new EventHandler(_cbLockers_CheckedChanged);
            }

            _cbSensors = new CheckBox[48]
            {
                cbSensor00, cbSensor01, cbSensor02, cbSensor03, cbSensor04, cbSensor05, cbSensor06, cbSensor07,
                cbSensor08, cbSensor09, cbSensor10, cbSensor11, cbSensor12, cbSensor13, cbSensor14, cbSensor15,
                cbSensor16, cbSensor17, cbSensor18, cbSensor19, cbSensor20, cbSensor21, cbSensor22, cbSensor23,
                cbSensor24, cbSensor25, cbSensor26, cbSensor27, cbSensor28, cbSensor29, cbSensor30, cbSensor31,
                cbSensor32, cbSensor33, cbSensor34, cbSensor35, cbSensor36, cbSensor37, cbSensor38, cbSensor39,
                cbSensor40, cbSensor41, cbSensor42, cbSensor43, cbSensor44, cbSensor45, cbSensor46, cbSensor47,
            };

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

        private void _cbLockers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

        }

        private void _cbLockers_Clicked(object sender, EventArgs e)
        {
            for (int index = 0; index < _cbLockers.Length; index++)
            {
                CheckBox cb = (CheckBox)sender;
                if (cb.Name == _cbLockers[index].Name)
                {
                    try
                    {
                        if (cb.Checked) continue;
                        cu48b.send(0, index, Cu48b.LOCKER_UNLOCK);
                        String data = BitConverter.ToString(cu48b.dataOut);

                        rtbPrint(data, Color.Black);

                    }
                    catch (Exception ex)
                    {
                        rtbPrint(ex.Message, Color.Red);
                    }

                }
            }
        }

        private void Cu48b_onDataReceived(object sender, EventArgs e)
        {
            Cu48b cU48B = (Cu48b)sender;
            try
            {
                for (int index = 0; index < cU48B.lockers.Length; index++)
                {
                    _cbLockers[index].Invoke(new Action(() =>
                    {
                        _cbLockers[index].Checked = cU48B.lockers[index];
                    }));
                }
                for (int index = 0; index < cU48B.sensors.Length; index++)
                {
                    _cbSensors[index].Invoke(new Action(() =>
                    {
                        _cbSensors[index].Checked = cU48B.sensors[index];
                    }));
                }

            }
            catch (Exception exception)
            {
                rtbOutput.Invoke(new Action(() =>
                {
                    rtbPrint(exception.Message, Color.Red);
                }));
            }
            finally
            {
                String data = BitConverter.ToString(cU48B.dataIn);
                rtbOutput.Invoke(new Action(() =>
                {
                    rtbPrint(data, Color.Green);
                }));
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
            try
            {
                if (cu48b == null) return;
                cu48b.send(0, 0, Cu48b.GET_STATUS);
                cu48b.read();

                String data = BitConverter.ToString(cu48b.dataOut);
                rtbPrint(data, Color.Black);
            }
            catch (Exception ex)
            {
                rtbPrint(ex.Message, Color.Red);
            }
        }

        void rtbPrint(String text, Color color)
        {
            rtbOutput.SelectionColor = color;
            rtbOutput.SelectionFont = new Font("Courier", 11, FontStyle.Regular);
            rtbOutput.AppendText(DateTime.Now.ToString("HH:mm:ss") + " | " + text + '\n');
            rtbOutput.ScrollToCaret();
        }

        private void bUnlockAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (cu48b == null) return;
                cu48b.send(0, Cu48b.LOCKER_ALL, Cu48b.LOCKER_UNLOCK);

                String data = BitConverter.ToString(cu48b.dataOut);
                rtbPrint(data, Color.Black);
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
                    cu48b = new Cu48b(cbPortName.Text, int.Parse(cbBaudRate.Text));
                    cu48b.onDataReceived += Cu48b_onDataReceived;
                    cu48b.open();
                    bConnect.Text = "Disconnect";
                    rtbPrint(String.Concat("Connected to ", cbPortName.Text), Color.Blue);
                }
                else if (cu48b != null && bConnect.Text.Equals("Disconnect"))
                {
                    cu48b.close();
                    bConnect.Text = "Connect";
                    rtbPrint(String.Concat("Disconnected to ", cbPortName.Text), Color.Blue);
                }
            }
            catch (Exception ex)
            {
                rtbPrint(ex.Message, Color.Red);
            }
        }
    }
}

