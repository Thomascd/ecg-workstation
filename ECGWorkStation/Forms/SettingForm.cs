using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ECGWorkStation
{
    enum InputDevice { COM, USB, FILE , SIMULATOR}

    partial class SettingForm : Form
    {        
        private InputDevice InputDeviceValue;   // default Input device
        public string FileName = "";

        public string IDString { get; set; }
        public string SMSPort 
        {
            get
            {
                if (SMScheckBox.Checked) return (string) PortName2.SelectedItem;
                //if (SMScheckBox.Checked) return SerialPort.GetPortNames();
                return null;
            } 
        }

        public SettingForm()
        {
            InitializeComponent();
            //Load(null, null);

            // add serial port to list
            string[] ListPort = System.IO.Ports.SerialPort.GetPortNames();
            PortName1.Items.AddRange(ListPort);
            PortName2.Items.AddRange(ListPort);

            //if (PortName.Items.Count > 0) PortName.SelectedIndex = 0;

            InputDevice = InputDevice.USB;
        }

        private void ChangeInputDevice(object sender, EventArgs e)
        {
            if (USBButton.Checked && InputDevice != InputDevice.USB)
            {
                InputDevice = InputDevice.USB;
            }
            else if (COMButton.Checked && InputDevice != InputDevice.COM)
            {
                InputDevice = InputDevice.COM;
            }
            else if (FileButton.Checked && InputDevice != InputDevice.FILE)
            {
                InputDevice = InputDevice.FILE;
            }
            else if (SimulatorButton.Checked && InputDevice != InputDevice.SIMULATOR)
            {
                InputDevice = InputDevice.SIMULATOR;
            }
        }

        private void ChooseFile(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFileDialog.Title  = "Select Data file";

            OpenFileDialog.ShowDialog();

            FileName = FileNameLabel.Text = OpenFileDialog.FileName;
        }

        public InputDevice InputDevice
        {
            get
            {
                return InputDeviceValue;
            }
            set
            {
                InputDeviceValue = value;
                if(InputDeviceValue == InputDevice.USB)
                {
                    PortName1.Enabled         = false;
                    ChooseFileButton.Enabled = false;
                }
                else if(InputDeviceValue == InputDevice.COM)
                {
                    PortName1.Enabled         = true;
                    ChooseFileButton.Enabled = false;
                }
                else if (InputDeviceValue == InputDevice.FILE)
                {
                    PortName1.Enabled         = false;
                    ChooseFileButton.Enabled = true;

                    ChooseFile(null, null);
                }
                else if (InputDeviceValue == InputDevice.SIMULATOR)
                {
                    PortName1.Enabled         = false;
                    ChooseFileButton.Enabled = false;
                }
            }
        }

        private void SetID(object sender, EventArgs e)
        {
            IDString = IDTextBox.Text;
        }

    }
}
