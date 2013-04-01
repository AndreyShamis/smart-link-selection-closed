﻿namespace Visualisator
{
    partial class APInfo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblBand = new System.Windows.Forms.Label();
            this.lblSSID = new System.Windows.Forms.Label();
            this.lblConnectedSTA = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.tbrGUISlow = new System.Windows.Forms.Timer(this.components);
            this.lblKeepAliveReceived = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDataReceived = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDataAckReceived = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tmrFast = new System.Windows.Forms.Timer(this.components);
            this.listStations = new System.Windows.Forms.ListBox();
            this.lblTXPackets = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AP MAC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AP STA connected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AP SSID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AP Band";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "AP Channel";
            // 
            // lblChannel
            // 
            this.lblChannel.Location = new System.Drawing.Point(227, 101);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(63, 13);
            this.lblChannel.TabIndex = 9;
            this.lblChannel.Text = "AP Channel";
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBand
            // 
            this.lblBand.Location = new System.Drawing.Point(241, 78);
            this.lblBand.Name = "lblBand";
            this.lblBand.Size = new System.Drawing.Size(49, 13);
            this.lblBand.TabIndex = 8;
            this.lblBand.Text = "AP Band";
            this.lblBand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSSID
            // 
            this.lblSSID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSSID.ForeColor = System.Drawing.Color.Navy;
            this.lblSSID.Location = new System.Drawing.Point(142, 32);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(148, 13);
            this.lblSSID.TabIndex = 7;
            this.lblSSID.Text = "AP SSID";
            this.lblSSID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConnectedSTA
            // 
            this.lblConnectedSTA.Location = new System.Drawing.Point(161, 54);
            this.lblConnectedSTA.Name = "lblConnectedSTA";
            this.lblConnectedSTA.Size = new System.Drawing.Size(129, 13);
            this.lblConnectedSTA.TabIndex = 6;
            this.lblConnectedSTA.Text = "AP STA connected";
            this.lblConnectedSTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMAC
            // 
            this.lblMAC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMAC.ForeColor = System.Drawing.Color.Green;
            this.lblMAC.Location = new System.Drawing.Point(139, 9);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(151, 13);
            this.lblMAC.TabIndex = 5;
            this.lblMAC.Text = "AP MAC";
            this.lblMAC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbrGUISlow
            // 
            this.tbrGUISlow.Enabled = true;
            this.tbrGUISlow.Interval = 1000;
            this.tbrGUISlow.Tick += new System.EventHandler(this.tbrGUISlow_Tick);
            // 
            // lblKeepAliveReceived
            // 
            this.lblKeepAliveReceived.ForeColor = System.Drawing.Color.Maroon;
            this.lblKeepAliveReceived.Location = new System.Drawing.Point(243, 123);
            this.lblKeepAliveReceived.Name = "lblKeepAliveReceived";
            this.lblKeepAliveReceived.Size = new System.Drawing.Size(47, 13);
            this.lblKeepAliveReceived.TabIndex = 11;
            this.lblKeepAliveReceived.Text = "0";
            this.lblKeepAliveReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "KeepAlive Recieved";
            // 
            // lblDataReceived
            // 
            this.lblDataReceived.ForeColor = System.Drawing.Color.Teal;
            this.lblDataReceived.Location = new System.Drawing.Point(246, 147);
            this.lblDataReceived.Name = "lblDataReceived";
            this.lblDataReceived.Size = new System.Drawing.Size(44, 13);
            this.lblDataReceived.TabIndex = 13;
            this.lblDataReceived.Text = "0";
            this.lblDataReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data Received";
            // 
            // lblDataAckReceived
            // 
            this.lblDataAckReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataAckReceived.Location = new System.Drawing.Point(249, 169);
            this.lblDataAckReceived.Name = "lblDataAckReceived";
            this.lblDataAckReceived.Size = new System.Drawing.Size(41, 13);
            this.lblDataAckReceived.TabIndex = 15;
            this.lblDataAckReceived.Text = "0";
            this.lblDataAckReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "DataACK Recieved";
            // 
            // tmrFast
            // 
            this.tmrFast.Enabled = true;
            this.tmrFast.Interval = 5;
            this.tmrFast.Tick += new System.EventHandler(this.tmrFast_Tick);
            // 
            // listStations
            // 
            this.listStations.FormattingEnabled = true;
            this.listStations.Location = new System.Drawing.Point(373, 0);
            this.listStations.Name = "listStations";
            this.listStations.Size = new System.Drawing.Size(206, 342);
            this.listStations.TabIndex = 16;
            this.listStations.SelectedIndexChanged += new System.EventHandler(this.listStations_SelectedIndexChanged);
            this.listStations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listStations_MouseDoubleClick);
            // 
            // lblTXPackets
            // 
            this.lblTXPackets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTXPackets.Location = new System.Drawing.Point(249, 192);
            this.lblTXPackets.Name = "lblTXPackets";
            this.lblTXPackets.Size = new System.Drawing.Size(41, 13);
            this.lblTXPackets.TabIndex = 18;
            this.lblTXPackets.Text = "0";
            this.lblTXPackets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "TX Packets";
            // 
            // APInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 343);
            this.Controls.Add(this.lblTXPackets);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listStations);
            this.Controls.Add(this.lblDataAckReceived);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDataReceived);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblKeepAliveReceived);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.lblSSID);
            this.Controls.Add(this.lblConnectedSTA);
            this.Controls.Add(this.lblMAC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "APInfo";
            this.Text = "APInfo";
            this.Load += new System.EventHandler(this.APInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblBand;
        private System.Windows.Forms.Label lblSSID;
        private System.Windows.Forms.Label lblConnectedSTA;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Timer tbrGUISlow;
        private System.Windows.Forms.Label lblKeepAliveReceived;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDataReceived;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDataAckReceived;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrFast;
        private System.Windows.Forms.ListBox listStations;
        private System.Windows.Forms.Label lblTXPackets;
        private System.Windows.Forms.Label label9;
    }
}