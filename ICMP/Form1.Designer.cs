namespace ICMP
{
    partial class FrmICMP
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtPacketData = new System.Windows.Forms.TextBox();
            this.labHost = new System.Windows.Forms.Label();
            this.labPacketData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(394, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(510, 79);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(394, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(35, 81);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(300, 20);
            this.txtHost.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(35, 131);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(550, 251);
            this.listBox.TabIndex = 4;
            // 
            // txtPacketData
            // 
            this.txtPacketData.Location = new System.Drawing.Point(35, 419);
            this.txtPacketData.Name = "txtPacketData";
            this.txtPacketData.Size = new System.Drawing.Size(300, 20);
            this.txtPacketData.TabIndex = 5;
            this.txtPacketData.Text = "Test Packet";
            // 
            // labHost
            // 
            this.labHost.AutoSize = true;
            this.labHost.Location = new System.Drawing.Point(35, 62);
            this.labHost.Name = "labHost";
            this.labHost.Size = new System.Drawing.Size(93, 13);
            this.labHost.TabIndex = 6;
            this.labHost.Text = "Enter host to ping:";
            // 
            // labPacketData
            // 
            this.labPacketData.AutoSize = true;
            this.labPacketData.Location = new System.Drawing.Point(35, 403);
            this.labPacketData.Name = "labPacketData";
            this.labPacketData.Size = new System.Drawing.Size(68, 13);
            this.labPacketData.TabIndex = 7;
            this.labPacketData.Text = "Packet data:";
            // 
            // FrmICMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 464);
            this.Controls.Add(this.labPacketData);
            this.Controls.Add(this.labHost);
            this.Controls.Add(this.txtPacketData);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmICMP";
            this.Text = "ICMP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtPacketData;
        private System.Windows.Forms.Label labHost;
        private System.Windows.Forms.Label labPacketData;
    }
}

