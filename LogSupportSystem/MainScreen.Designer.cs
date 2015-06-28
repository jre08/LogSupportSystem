namespace LogSupportSystem
{
    partial class formMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainScreen));
            this.txtRSSFeed = new System.Windows.Forms.TextBox();
            this.btnLogSupportRequest = new System.Windows.Forms.Button();
            this.CheckOnMyRequest = new System.Windows.Forms.Button();
            this.btnPhoneSupport = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMachineId = new System.Windows.Forms.Label();
            this.lblTeamViewerID = new System.Windows.Forms.Label();
            this.btnLiveSupport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRSSFeed
            // 
            this.txtRSSFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRSSFeed.Font = new System.Drawing.Font("MagistralC", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSSFeed.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtRSSFeed.Location = new System.Drawing.Point(16, 187);
            this.txtRSSFeed.Multiline = true;
            this.txtRSSFeed.Name = "txtRSSFeed";
            this.txtRSSFeed.ReadOnly = true;
            this.txtRSSFeed.Size = new System.Drawing.Size(998, 51);
            this.txtRSSFeed.TabIndex = 6;
            // 
            // btnLogSupportRequest
            // 
            this.btnLogSupportRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnLogSupportRequest.Image")));
            this.btnLogSupportRequest.Location = new System.Drawing.Point(16, 306);
            this.btnLogSupportRequest.Name = "btnLogSupportRequest";
            this.btnLogSupportRequest.Size = new System.Drawing.Size(169, 61);
            this.btnLogSupportRequest.TabIndex = 1;
            this.btnLogSupportRequest.UseVisualStyleBackColor = true;
            this.btnLogSupportRequest.Click += new System.EventHandler(this.btnLogSupportRequest_Click);
            // 
            // CheckOnMyRequest
            // 
            this.CheckOnMyRequest.Image = ((System.Drawing.Image)(resources.GetObject("CheckOnMyRequest.Image")));
            this.CheckOnMyRequest.Location = new System.Drawing.Point(428, 306);
            this.CheckOnMyRequest.Name = "CheckOnMyRequest";
            this.CheckOnMyRequest.Size = new System.Drawing.Size(174, 61);
            this.CheckOnMyRequest.TabIndex = 2;
            this.CheckOnMyRequest.UseVisualStyleBackColor = true;
            this.CheckOnMyRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPhoneSupport
            // 
            this.btnPhoneSupport.Image = ((System.Drawing.Image)(resources.GetObject("btnPhoneSupport.Image")));
            this.btnPhoneSupport.Location = new System.Drawing.Point(828, 306);
            this.btnPhoneSupport.Name = "btnPhoneSupport";
            this.btnPhoneSupport.Size = new System.Drawing.Size(186, 61);
            this.btnPhoneSupport.TabIndex = 3;
            this.btnPhoneSupport.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Font = new System.Drawing.Font("MagistralC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(13, 110);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(75, 15);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "WELCOME ";
            // 
            // lblMachineId
            // 
            this.lblMachineId.AutoSize = true;
            this.lblMachineId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMachineId.Font = new System.Drawing.Font("MagistralC", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMachineId.Location = new System.Drawing.Point(13, 127);
            this.lblMachineId.Name = "lblMachineId";
            this.lblMachineId.Size = new System.Drawing.Size(68, 14);
            this.lblMachineId.TabIndex = 16;
            this.lblMachineId.Text = "Machine ID:";
            // 
            // lblTeamViewerID
            // 
            this.lblTeamViewerID.AutoSize = true;
            this.lblTeamViewerID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTeamViewerID.Font = new System.Drawing.Font("MagistralC", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamViewerID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTeamViewerID.Location = new System.Drawing.Point(13, 145);
            this.lblTeamViewerID.Name = "lblTeamViewerID";
            this.lblTeamViewerID.Size = new System.Drawing.Size(73, 14);
            this.lblTeamViewerID.TabIndex = 17;
            this.lblTeamViewerID.Text = "TeamViewer:";
            // 
            // btnLiveSupport
            // 
            this.btnLiveSupport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLiveSupport.BackgroundImage")));
            this.btnLiveSupport.Location = new System.Drawing.Point(816, 11);
            this.btnLiveSupport.Name = "btnLiveSupport";
            this.btnLiveSupport.Size = new System.Drawing.Size(198, 52);
            this.btnLiveSupport.TabIndex = 18;
            this.btnLiveSupport.UseVisualStyleBackColor = true;
            this.btnLiveSupport.Click += new System.EventHandler(this.btnLiveSupport_Click);
            // 
            // formMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 580);
            this.Controls.Add(this.btnLiveSupport);
            this.Controls.Add(this.lblTeamViewerID);
            this.Controls.Add(this.lblMachineId);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnPhoneSupport);
            this.Controls.Add(this.CheckOnMyRequest);
            this.Controls.Add(this.btnLogSupportRequest);
            this.Controls.Add(this.txtRSSFeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CT Group Solutions";
            this.Shown += new System.EventHandler(this.formMainScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRSSFeed;
        private System.Windows.Forms.Button btnLogSupportRequest;
        private System.Windows.Forms.Button CheckOnMyRequest;
        private System.Windows.Forms.Button btnPhoneSupport;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMachineId;
        private System.Windows.Forms.Label lblTeamViewerID;
        private System.Windows.Forms.Button btnLiveSupport;
    }
}

