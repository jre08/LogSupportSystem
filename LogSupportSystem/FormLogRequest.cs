using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net.Mime;

namespace LogSupportSystem
{
    public partial class FormLogRequest : Form
    {
        public FormLogRequest()
        {
            InitializeComponent();

            txtBoxContactPhone.Text = ConfigurationManager.AppSettings["ContactNumberPhone"];
            txtBoxContactEmail.Text = ConfigurationManager.AppSettings["ContactNumberEmail"];
        }

        private void btnLogit_Click(object sender, EventArgs e)
        {
            if (validateControls() == false)
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                string receiverMailId = ConfigurationManager.AppSettings["ReceiverMailID"];
                string senderMailId = ConfigurationManager.AppSettings["SenderMailID"];
                string password = ConfigurationManager.AppSettings["Password"];

                MailMessage mail = new MailMessage(senderMailId, receiverMailId);
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                client.Credentials = new NetworkCredential(senderMailId, password);
                mail.Subject = txtBoxTitle.Text.Trim();
                mail.Body = txtBoxProblemDec.Text.Trim();

                mail.Body += Environment.NewLine;
                mail.Body += Environment.NewLine;

                mail.Body += "::: User details :::";
                mail.Body += Environment.NewLine;
                mail.Body += Environment.NewLine;

                mail.Body += ("Username: " + UserInfo.Name);
                mail.Body += Environment.NewLine;

                mail.Body += ("Computer Name: " + UserInfo.MachineName);
                mail.Body += Environment.NewLine;

                mail.Body += ("Teamviewer ID: " + UserInfo.GetTeamviewerID());
                mail.Body += Environment.NewLine;

                mail.Body += ("Phone Number: " + txtBoxContactPhone.Text.Trim());
                mail.Body += Environment.NewLine;

                mail.Body += ("Email address: " + txtBoxContactEmail.Text.Trim());


                if (lblFileAttachment.Tag != null)
                {
                    string fileList = lblFileAttachment.Tag as string;

                    string[] stringSeparators = new string[] { ";" };

                    string[] fileCollection = fileList.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string file in fileCollection)
                    {
                        Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);

                        // Add time stamp information for the file.
                        ContentDisposition disposition = data.ContentDisposition;
                        disposition.CreationDate = System.IO.File.GetCreationTime(file);
                        disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                        disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

                        mail.Attachments.Add(data);
                    }
                }

                client.Send(mail);
                saveBestContactInfo();
                Cursor = Cursors.Default;

                MessageBox.Show("Thanks for submitting your request, one of our team members will be in touch with you shortly.");
                Close();
            }
            catch(Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private void saveBestContactInfo()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["ContactNumberPhone"].Value = txtBoxContactPhone.Text.Trim();
            config.AppSettings.Settings["ContactNumberEmail"].Value = txtBoxContactEmail.Text.Trim();

            config.Save(ConfigurationSaveMode.Minimal);
        }

        private bool validateControls()
        {
            if (txtBoxTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Subject can not be empty.");
                txtBoxTitle.Focus();
                return false;
            }

            if (txtBoxProblemDec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Problem Description can not be empty.");
                txtBoxProblemDec.Focus();
                return false;
            }

            if (txtBoxContactPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phone  number can not be empty.");
                txtBoxContactPhone.Focus();
                return false;
            }

            if (txtBoxContactEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email can not be empty.");
                txtBoxContactEmail.Focus();
                return false;
            }

            string contactNumberPhone = txtBoxContactPhone.Text.Trim();
            string contactNumberEmail = txtBoxContactEmail.Text.Trim();

            bool isPhone = Regex.IsMatch(contactNumberPhone, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", RegexOptions.IgnoreCase);
            if (contactNumberEmail.Length < 6 || isPhone == false)
            {
                MessageBox.Show("The Phone number is not valid.");
                txtBoxContactPhone.Focus();
                return false;
            }

            bool isEmail = Regex.IsMatch(contactNumberEmail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail == false)
            {
                MessageBox.Show("The Email id is not valid.");
                txtBoxContactEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnAttachSomething_Click(object sender, EventArgs e)
        {
            if (openMailAttachment.ShowDialog() == DialogResult.OK)
            {
                if (lblFileAttachment.Tag == null)
                {
                    lblFileAttachment.Tag = openMailAttachment.FileName;
                    lblFileAttachment.Text = openMailAttachment.FileName;
                    lblFileAttachment.Visible = true;
                }
                else
                {
                    lblFileAttachment.Text += ("; " + openMailAttachment.FileName);
                    lblFileAttachment.Tag = lblFileAttachment.Text;
                }
            }
        }

        private void FormLogRequest_Shown(object sender, EventArgs e)
        {
            txtBoxTitle.Focus();
        }
    }

    //enum BestContactMethod
    //{
    //    EMAIL,
    //    PHONE
    //}
}
