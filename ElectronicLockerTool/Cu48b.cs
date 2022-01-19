using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLockerTool
{
    internal class Cu48b
    {
        SerialPort _serialPort;
        byte[] _dataOut;
        byte[] _dataIn;
        BitArray _lockers;
        BitArray _sensors;

        public static int ADDRESS_ALL = 0x0A;
        public static int LOCKER_ALL = 0x30;
        public static int GET_STATUS = 0x60;
        public static int LOCKER_UNLOCK = 0x61;
        public static int LOCKER_STATUS = 0x75;


        public delegate void OnDataReceivedHandler(object sender, EventArgs e);
        public event OnDataReceivedHandler onDataReceived;

        public Cu48b(String portName, int baudrate)
        {
            try
            {
                _serialPort = new SerialPort();
                _serialPort.PortName = portName;
                _serialPort.BaudRate = baudrate;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Handshake = Handshake.None;
                _serialPort.Parity = Parity.None;
                _serialPort.DataBits = 8;
                _serialPort.DtrEnable = false;
                _serialPort.RtsEnable = false;

                _serialPort.ReadTimeout = 3000;
                _serialPort.WriteTimeout = 3000;

                _serialPort.ReadBufferSize = 18;
                _serialPort.WriteBufferSize = 6;

                _serialPort.DataReceived += this.dataReceived;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void open()
        {
            if (_serialPort != null)
                if (!_serialPort.IsOpen)
                    _serialPort.Open();
        }

        public void close()
        {
            if (_serialPort != null)
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                    _serialPort = null;
                }
        }

        public void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = _serialPort.BytesToRead;
            if (bytesToRead == 18)
            {
                _dataIn = new byte[bytesToRead];
                _serialPort.Read(_dataIn, 0, bytesToRead);
                parse(_dataIn);

                if (onDataReceived != null)
                {
                    onDataReceived(this, new EventArgs());
                }
            }
        }


        public void send(int address, int lockerNumber, int command)
        {
            _dataOut = new byte[6];
            _dataOut[0] = 0x02;
            _dataOut[1] = (byte)address;
            _dataOut[2] = (byte)lockerNumber;
            _dataOut[3] = (byte)command;
            _dataOut[4] = 0x03;
            _dataOut[5] = checkSum(_dataOut);

            if (_serialPort != null)
                if (_serialPort.IsOpen)
                    _serialPort.Write(_dataOut, 0, _dataOut.Length);

        }

        public byte checkSum(byte[] datas)
        {
            int sum = 0;
            foreach (byte data in datas)
            {
                sum = sum + (int)data;
            }
            return (byte)(sum & 0xFF);
        }

        public byte[] dataOut
        {
            get { return _dataOut; }
        }

        public byte[] dataIn
        {
            get { return _dataIn; }
        }

        public BitArray lockers
        {
            get { return _lockers; }
        }
        public BitArray sensors
        {
            get { return _sensors; }
        }
        public void parse(byte[] datas)
        {
            if (datas == null) throw new Exception("Data is null");
            if (datas.Length < 18) throw new Exception("Data is short");

            byte[] cloned = (byte[])datas.Clone();
            int prevCheckSum = cloned[17];
            cloned[17] = 0;

            int currentCheckSum = checkSum(cloned);
            if (prevCheckSum != currentCheckSum) throw new Exception("CheckSum is wrong");

            if (datas[3] != 0x75) throw new Exception("Wrong command");

            _lockers = new BitArray(new byte[] {
                datas[4],
                datas[5],
                datas[6],
                datas[7],
                datas[8],
                datas[9],
            });

            _sensors = new BitArray(new byte[] {
                datas[10],
                datas[11],
                datas[12],
                datas[13],
                datas[14],
                datas[15],
            });
        }

        public void read()
        {
            this.dataReceived(this, null);
        }
        public static string[] getPortNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
