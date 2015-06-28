using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace LogSupportSystem
{
    public partial class formMainScreen : Form
    {
        public formMainScreen()
        {
            InitializeComponent();

            lblWelcome.Text = lblWelcome.Text + UserInfo.Name.ToUpper();
            lblMachineId.Text = lblMachineId.Text + UserInfo.MachineName;
            lblTeamViewerID.Text = lblTeamViewerID.Text + UserInfo.GetTeamviewerID();
        }

        private void btnLogSupportRequest_Click(object sender, EventArgs e)
        {
            FormLogRequest frmLogRequest = new FormLogRequest();
            frmLogRequest.ShowDialog();
        }

        private void formMainScreen_Shown(object sender, EventArgs e)
        {
            try
            {
                string rssFeedUrl = ConfigurationManager.AppSettings["RSSfeedUrl"];
                if (string.IsNullOrWhiteSpace(rssFeedUrl) == false)
                {
                    List<RssFeedItem> feedItems = RSSManager.ReadFeed(rssFeedUrl.Trim());

                    foreach (RssFeedItem item in feedItems)
                    {
                        txtRSSFeed.Text += item.Title + " - " + item.Description + Environment.NewLine;
                    }
                }
            }
            catch(Exception ex)
            {
                txtRSSFeed.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://help.ctgroup.com.au:9000");
        }

        private void btnLiveSupport_Click(object sender, EventArgs e)
        {
            Process.Start("CTGroupSupport.exe");
        }
    }
}
