using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECGWorkStation
{
    partial class LoginForm : Form
    {
        public Doctor Doctor = null;
        private WebService.ECGServiceClient Service = new ECGWorkStation.WebService.ECGServiceClient();
        private WebService.User LoginUser;

        public LoginForm()
        {
            InitializeComponent();
            InitializeFullScreen();
        }

        void InitializeFullScreen()
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            int Width   = Screen.PrimaryScreen.Bounds.Width;
            int Height  = Screen.PrimaryScreen.Bounds.Height;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point((Width - 155) / 2, (Height - 130) / 2 + 25);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point((Width - 155) / 2, (Height - 130) / 2 + 94);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point((Width - 155) / 2, (Height - 130) / 2 + 143);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point((Width - 155) / 2, (Height - 130) / 2);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point((Width - 155) / 2, (Height - 130) / 2 + 74);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point((Width + 383) / 2, (Height - 130) / 2 + 93);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(Width - 55, 25);
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            // 
            // AvatarBox
            // 
            this.AvatarBox.Image = global::ECGWorkStation.Properties.Resources.User_icon;
            this.AvatarBox.Location = new System.Drawing.Point((Width - 445) / 2, (Height - 130) / 2);
            this.AvatarBox.Size = new System.Drawing.Size(120, 120);
        }

        private void Login(object sender, EventArgs e)
        {
            try
            {
                LoginUser = Service.getUserByUsernamePassword(NameTextBox.Text, PasswordTextBox.Text);

                if (LoginUser == null || LoginUser.permission >= 3)
                {
                    StatusLabel.Text = "Login faild";
                    PasswordTextBox.Text = "";
                    NameTextBox.Text = "";
                    NameTextBox.SelectAll();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    Doctor = new Doctor(LoginUser);
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show(
                    "Cannot conect to server. Do you want to start with offline mode?",
                    "Connet error",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MonitorForm ViewECG = new MonitorForm();
                    ViewECG.Show();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }            
        }
    }
}
