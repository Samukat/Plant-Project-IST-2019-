using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp2
{
    public partial class HydroPod : Form
    {
        public SerialPort port;
        public string portCOM = "COM3";
        public bool isConnected = false;
        public bool isOn = true;

        public float TempRead = 0;
        public float HumidRead = 0;


        public HydroPod()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            able(true);
            string[] ports = SerialPort.GetPortNames();
            try { COMPORT.Text = ports[0]; } catch { COMPORT.Text = "COM1"; }
        }

        void sendPort(string value)
        {
            string portCOM = COMPORT.Text;
            port = new SerialPort();
            port.BaudRate = 9600;
            try
            {
                errorLabel.Text = "";
                port.PortName = portCOM;
                port.Open();
                port.WriteLine(value);
                port.Close();
                PortListener.PortName = portCOM;
                if (value == "Test" && isConnected == false)
                {
                    isConnected = true;
                    Console.WriteLine("isConnected = true");
                    able(true);
                }
            }
            catch
            {
                Console.WriteLine("This port does not work: " + portCOM);
                errorLabel.Text = portCOM + " is not operational";
                isConnected = false;
            }
        }

        void able(bool value) {
            if (!value)
            {
                UVBar.Enabled = false;
                WaterBar.Enabled = false;
                TempBar.Enabled = false;
                HumidBar.Enabled = false;
                onoff.Enabled = false;
            }
            else {
                UVBar.Enabled = true;
                WaterBar.Enabled = true;
                TempBar.Enabled = true;
                HumidBar.Enabled = true;
                onoff.Enabled = true;

                float tmpTemp = TempBar.Value / 20f;
                sendPort(":T" + tmpTemp.ToString() + ":");
                float tmpWater = WaterBar.Value / 20f;
                sendPort(":M" + tmpWater.ToString() + ":");
                float tmpUV = UVBar.Value / 20f;
                if (tmpUV == 0) { tmpUV = 0.0000000000001f; }
                sendPort(":L" + tmpUV.ToString() + ":");
                float tmpHumid = HumidBar.Value / 20f;
                sendPort(":L" + tmpHumid.ToString() + ":");
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                able(true);
            }
        }
        private void TestTimer_Tick(object sender, EventArgs e)
        {
            sendPort("Test");
        }
        
        private void COMPORT_TextChanged(object sender, EventArgs e)
        {
            sendPort("Test");
        }

        private void UVBar_ValueChanged(object sender, EventArgs e)
        {
            float tmpUV = (UVBar.Value / 20f);
            if (tmpUV == 0) { tmpUV = 0.0000000000001f; }
            sendPort(":L" + tmpUV.ToString() + ":");
        }
        private void WaterBar_ValueChanged(object sender, EventArgs e)
        {
            float tmpWater = WaterBar.Value / 20f;
            sendPort(":M" + tmpWater.ToString() + ":");
        }
        private void TempBar_ValueChanged(object sender, EventArgs e)
        {
            float tmpTemp = TempBar.Value / 20f;
            sendPort(":T" + tmpTemp.ToString() + ":");
        }
        private void HumidBar_ValueChanged(object sender, EventArgs e)
        {
            float tmpHumid = WaterBar.Value / 20f;
            sendPort(":H" + tmpHumid.ToString() + ":");
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string s = port.ReadExisting();
            Console.WriteLine(s.ToString());
            Console.WriteLine("Test");
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine(indata + " Data");
            Console.WriteLine(e + " Data E");
            Console.WriteLine(sender + " Sender");

        }

        private void onoff_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                isOn = false;
                onoff.BackgroundImage = WindowsFormsApp2.Properties.Resources.SwitchOff;
                sendPort(":L0.0000000000001:");
                sendPort(":H0.0000000000001:");
                sendPort(":M0.0000000000001:");
                sendPort(":T0.0000000000001:");
                able(false);
                onoff.Enabled = true;
            }
            else
            {
                isOn = true;
                onoff.BackgroundImage = WindowsFormsApp2.Properties.Resources.SwitchOn;
                able(true);
            }
        }
    }
}
