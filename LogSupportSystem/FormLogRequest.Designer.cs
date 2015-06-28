namespace LogSupportSystem
{
    partial class FormLogRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogRequest));
            this.txtBoxProblemDec = new System.Windows.Forms.TextBox();
            this.btnLogit = new System.Windows.Forms.Button();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxContactPhone = new System.Windows.Forms.TextBox();
            this.btnAttachSomething = new System.Windows.Forms.Button();
            this.lblFileAttachment = new System.Windows.Forms.Label();
            this.openMailAttachment = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxContactEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxProblemDec
            // 
            this.txtBoxProblemDec.Location = new System.Drawing.Point(21, 242);
            this.txtBoxProblemDec.Multiline = true;
            this.txtBoxProblemDec.Name = "txtBoxProblemDec";
            this.txtBoxProblemDec.Size = new System.Drawing.Size(325, 59);
            this.txtBoxProblemDec.TabIndex = 2;
            // 
            // btnLogit
            // 
            this.btnLogit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogit.Image = ((System.Drawing.Image)(resources.GetObject("btnLogit.Image")));
            this.btnLogit.Location = new System.Drawing.Point(173, 475);
            this.btnLogit.Name = "btnLogit";
            this.btnLogit.Size = new System.Drawing.Size(185, 53);
            this.btnLogit.TabIndex = 6;
            this.btnLogit.UseVisualStyleBackColor = true;
            this.btnLogit.Click += new System.EventHandler(this.btnLogit_Click);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(21, 194);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(326, 20);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxContactPhone
            // 
            this.txtBoxContactPhone.Location = new System.Drawing.Point(21, 328);
            this.txtBoxContactPhone.Name = "txtBoxContactPhone";
            this.txtBoxContactPhone.Size = new System.Drawing.Size(326, 20);
            this.txtBoxContactPhone.TabIndex = 3;
            // 
            // btnAttachSomething
            // 
            this.btnAttachSomething.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAttachSomething.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachSomething.Image")));
            this.btnAttachSomething.Location = new System.Drawing.Point(5, 474);
            this.btnAttachSomething.Name = "btnAttachSomething";
            this.btnAttachSomething.Size = new System.Drawing.Size(164, 53);
            this.btnAttachSomething.TabIndex = 5;
            this.btnAttachSomething.UseVisualStyleBackColor = true;
            this.btnAttachSomething.Click += new System.EventHandler(this.btnAttachSomething_Click);
            // 
            // lblFileAttachment
            // 
            this.lblFileAttachment.AutoSize = true;
            this.lblFileAttachment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileAttachment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFileAttachment.Location = new System.Drawing.Point(18, 448);
            this.lblFileAttachment.Name = "lblFileAttachment";
            this.lblFileAttachment.Size = new System.Drawing.Size(77, 13);
            this.lblFileAttachment.TabIndex = 15;
            this.lblFileAttachment.Text = "FileAttachment";
            this.lblFileAttachment.Visible = false;
            // 
            // openMailAttachment
            // 
            this.openMailAttachment.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            this.openMailAttachment.Title = "Select an attachment";
            // 
            // txtBoxContactEmail
            // 
            this.txtBoxContactEmail.Location = new System.Drawing.Point(21, 378);
            this.txtBoxContactEmail.Name = "txtBoxContactEmail";
            this.txtBoxContactEmail.Size = new System.Drawing.Size(326, 20);
            this.txtBoxContactEmail.TabIndex = 4;
            // 
            // FormLogRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(360, 540);
            this.Controls.Add(this.txtBoxContactEmail);
            this.Controls.Add(this.lblFileAttachment);
            this.Controls.Add(this.txtBoxContactPhone);
            this.Controls.Add(this.btnAttachSomething);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.btnLogit);
            this.Controls.Add(this.txtBoxProblemDec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log Request";
            this.Shown += new System.EventHandler(this.FormLogRequest_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxProblemDec;
        private System.Windows.Forms.Button btnLogit;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxContactPhone;
        private System.Windows.Forms.Button btnAttachSomething;
        private System.Windows.Forms.Label lblFileAttachment;
        private System.Windows.Forms.OpenFileDialog openMailAttachment;
        private System.Windows.Forms.TextBox txtBoxContactEmail;
    }
}