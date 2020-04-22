namespace SRTPluginUIRE3WinForms
{
    partial class MainUI
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
            this.playerHealthStatus = new System.Windows.Forms.PictureBox();
            this.statisticsPanel = new DoubleBufferedPanel();
            this.inventoryPanel = new DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.playerHealthStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // playerHealthStatus
            // 
            this.playerHealthStatus.Image = (System.Drawing.Bitmap)global::SRTPluginUIRE3WinForms.Properties.Resources.ResourceManager.GetObject("EMPTY");
            this.playerHealthStatus.InitialImage = (System.Drawing.Bitmap)global::SRTPluginUIRE3WinForms.Properties.Resources.ResourceManager.GetObject("EMPTY");
            this.playerHealthStatus.Location = new System.Drawing.Point(12, 13);
            this.playerHealthStatus.Name = "playerHealthStatus";
            this.playerHealthStatus.Size = new System.Drawing.Size(325, 161);
            this.playerHealthStatus.TabIndex = 0;
            this.playerHealthStatus.TabStop = false;
            this.playerHealthStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerHealthStatus_MouseDown);
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Location = new System.Drawing.Point(3, 175);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(334, 139);
            this.statisticsPanel.TabIndex = 2;
            this.statisticsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statisticsPanel_MouseDown);
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Location = new System.Drawing.Point(3, 318);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(334, 414);
            this.inventoryPanel.TabIndex = 3;
            this.inventoryPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inventoryPanel_MouseDown);
            // 
            // MainUI
            // 
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(340, 800);
            this.Controls.Add(this.inventoryPanel);
            this.Controls.Add(this.statisticsPanel);
            this.Controls.Add(this.playerHealthStatus);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 780);
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.Text = "RE3 (2020) SRT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUI_FormClosed);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerHealthStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerHealthStatus;
        private DoubleBufferedPanel statisticsPanel;
        private DoubleBufferedPanel inventoryPanel;
    }
}