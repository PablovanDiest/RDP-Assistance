using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using System.Diagnostics;

namespace RDPAssistance
{
    public partial class RDPAssistance : Form
    {
        private Hashtable RDConfigurations = (Hashtable)ConfigurationManager.GetSection("Customers/RemoteDesktops");

        public RDPAssistance()
        {
            InitializeComponent();
        }

        private void RDPAssistance_Load(object sender, EventArgs e)
        {
            LoadCompanies();
            chkSavePosition.Checked = Properties.Settings.Default.SavePosition;
            if (Properties.Settings.Default.SavePosition)
            {
                this.Top  = (Properties.Settings.Default.FormTop < 0 ? 0 : Properties.Settings.Default.FormTop);
                this.Left = (Properties.Settings.Default.FormLeft < 0 ? 0 : Properties.Settings.Default.FormLeft);
            }
        }

        #region Private Methods
        private void lstCompaniesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCompanyUsers(lstCompaniesList.SelectedItem.ToString());
        }

        private void cboCompanyUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCompanyUser(lstCompaniesList.SelectedItem.ToString(), cboCompanyUsers.SelectedItem.ToString());
        }

        private void picTopImage_Click(object sender, EventArgs e)
        {
            if (this.Height == (picTopImage.Height + 35))
                this.Height = 330;
            else
                this.Height = (picTopImage.Height + 35);
        }

        #region Buttons
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToRDP(lstCompaniesList.SelectedItem.ToString(), cboCompanyUsers.SelectedItem.ToString());
        }
        #endregion

        private void LoadCompanies()
        {
            string Companies = ";";
            string[] RDConfigList;
            string[] CompaniesList;
            foreach (String RDConfiguration in RDConfigurations.Values.Cast<String>().OrderBy(x => x))
            {
                if (!String.IsNullOrEmpty(RDConfiguration))
                {
                    RDConfigList = RDConfiguration.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (!Companies.Contains(String.Format(";{0};", RDConfigList.First())))
                    {
                        Companies += String.Format("{0};", RDConfigList.First());
                    }
                }
            }
            if (Companies.Length > 0)
            {
                CompaniesList = Companies.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (String CompanyName in CompaniesList)
                {
                    lstCompaniesList.Items.Add(CompanyName);
                }
            }
            //Select the first element in the company list
            if (lstCompaniesList.Items.Count > 0)
            {
                lstCompaniesList.SelectedIndex = 0;
            }
        }

        private void LoadCompanyUsers(String CompanyName)
        {
            string[] RDConfigList;
            cboCompanyUsers.Items.Clear();
            foreach (String RDConfiguration in RDConfigurations.Values.Cast<String>().OrderBy(x => x))
            {
                if (!String.IsNullOrEmpty(RDConfiguration))
                {
                    RDConfigList = RDConfiguration.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (RDConfigList.First() == CompanyName)
                    {
                        cboCompanyUsers.Items.Add(GetValue(RDConfigList[1]));
                    }
                }
            }
            //Select the first element in the user list
            if (cboCompanyUsers.Items.Count > 0)
            {
                cboCompanyUsers.SelectedIndex = 0;
            }
        }

        private void LoadCompanyUser(String CompanyName, String UserName)
        {
            String[] RDConfigLine = GetConfigLine(CompanyName, UserName);
            if (RDConfigLine.Length > 0)
            {
                txtHost.Text     = GetValue(RDConfigLine[2]);
                txtDomain.Text   = GetValue(RDConfigLine[3]);
                txtUser.Text     = GetValue(RDConfigLine[4]);
                txtPassword.Text = GetValue(RDConfigLine[5]);
            }
        }

        private bool ConnectToRDP(String CompanyName, String UserName)
        {
            Boolean isOk = false;
            try
            {
                String[] RDConfigLine = GetConfigLine(CompanyName, UserName);
                String Host   = GetValue(RDConfigLine[2]);
                String Domain = GetValue(RDConfigLine[3]);
                String User   = GetValue(RDConfigLine[4]);
                String Pass   = GetValue(RDConfigLine[5]);
                if (Domain.Length > 0)
                {
                    User = String.Format(@"{0}\{1}", Domain, User);
                }

                Process rdcProcess = new Process();
                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                rdcProcess.StartInfo.Arguments = String.Format( "/generic:TERMSRV/{0} /user:{1} /pass:{2}", Host, User, Pass);
                rdcProcess.Start();

                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
                rdcProcess.StartInfo.Arguments = String.Format("/v {0}", Host); // ip or name of computer to connect
                rdcProcess.Start();
                isOk = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return (isOk);
        }

        private String[] GetConfigLine(String CompanyName, String UserName)
        {
            String[] RDConfigLine = new String[] { };
            foreach (String RDConfiguration in RDConfigurations.Values)
            {
                if (!String.IsNullOrEmpty(RDConfiguration))
                {
                    RDConfigLine = RDConfiguration.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if ((RDConfigLine.First() == CompanyName) && (GetValue(RDConfigLine[1]) == UserName))
                    {
                        break;
                    }
                }
            }
            return (RDConfigLine);
        }

        private String GetValue(String Text)
        {
            String value = "";
            try
            {
                if (Text.Contains("="))
                {
                    value = Text.Split("=".ToArray(), StringSplitOptions.RemoveEmptyEntries)[1];
                }
            }
            catch
            {
                value = "";
            }
            return (value);
        }
        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Properties.Settings.Default["SavePosition"] = chkSavePosition.Checked;
            if (chkSavePosition.Checked)
            {
                Properties.Settings.Default["FormTop"] = this.Location.Y;
                Properties.Settings.Default["FormLeft"] = this.Location.X;
            }
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            base.OnFormClosing(e);
        }

    }
}
