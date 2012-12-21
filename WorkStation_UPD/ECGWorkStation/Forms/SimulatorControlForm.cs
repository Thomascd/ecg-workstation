using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECGWorkStation
{
    partial class SimulatorControlForm : Form
    {
        public event EventHandler<EventArgs> SimulatorEvent;
        public event EventHandler<EventArgs> SimulatorStart;
        public event EventHandler<EventArgs> SimulatorStop;

        public string FileName = null;
        public int Cycle
        {
            get { return (int)numericUpDown1.Value; }
        }

        public bool Loop
        {
            get { return LoopCheckBox.Checked; }
        }

        public SimulatorControlForm()
        {
            InitializeComponent();
        }

        private void ChooseFile(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFileDialog.Title = "Select Data file";

            OpenFileDialog.ShowDialog();

            FileName = FileNameLabel.Text = OpenFileDialog.FileName;

            // set button state
            PlayButton.Enabled = true;
            ChooseFileButton.Enabled = true;
            CancelButton.Enabled = false;
            EvenButton.Enabled = false;
            numericUpDown1.Enabled = true;
        }

        private void Play(object sender, EventArgs e)
        {
            if (FileName == null) ChooseFile(null, null);

            // call select handle
            SimulatorStart(this, null);

            // set button state
            PlayButton.Enabled = false;
            ChooseFileButton.Enabled = false;
            CancelButton.Enabled = true;
            EvenButton.Enabled = true;
            numericUpDown1.Enabled = false;
        }

        private void StopSimulator(object sender, EventArgs e)
        {
            StopSimulator();
        }

        private void StopSimulator(object sender, FormClosedEventArgs e)
        {
            if (!PlayButton.Enabled) StopSimulator();
        }

        private void StopSimulator()
        {
            SimulatorStop(this, null);

            // set button state
            PlayButton.Enabled = true;
            ChooseFileButton.Enabled = true;
            CancelButton.Enabled = false;
            EvenButton.Enabled = false;
            numericUpDown1.Enabled = true;
        }

        private void MakeEven(object sender, EventArgs e)
        {
            SimulatorEvent(this, null);
        }
    }
}
