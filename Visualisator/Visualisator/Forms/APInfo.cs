﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Visualisator
{
    partial class APInfo : Form
    {
        private AP _ap = null;
        public ArrayList _objects = null;
        public APInfo(AP apP,ArrayList _obj)
        {
            InitializeComponent();
            _ap = apP;
            _objects = _obj;
        }

        private void APInfo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbrGUISlow_Tick(object sender, EventArgs e)
        {
            lblMAC.Text = _ap.getMACAddress();
            lblChannel.Text = _ap.getOperateChannel().ToString();
            lblBand.Text = _ap.getOperateBand();
            lblSSID.Text = _ap.SSID;


            ArrayListCounted devicesList = _ap.getAssociatedDevices();
            listStations.Items.Clear();
            foreach (object __o in devicesList)
            {
                string s = (string)__o;
                listStations.Items.Add(s);
                // loop body
            }
            
        }

        private void tmrFast_Tick(object sender, EventArgs e)
        {
            lblDataReceived.Text = _ap.getDataRecieved().ToString();
            lblDataAckReceived.Text = _ap.getDataAckRecieved().ToString();
            lblConnectedSTA.Text = _ap.CenntedDevicesCount().ToString();
            lblKeepAliveReceived.Text = _ap.KeepAliveReceived.ToString();
            lblTXPackets.Text = _ap.get_TX_SIZE().ToString();
        }

        private void listStations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listStations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            for (int i = 0; i < _objects.Count; i++)
            {
                
                if (_objects[i].GetType() == typeof (STA))
                {
                    STA _tsta = (STA) _objects[i];
                    if (_tsta.getMACAddress().Equals(listStations.Text))
                    {
                        //txtConsole.Text = "Station selected for view :" + i.ToString() + "\r\n" + txtConsole.Text;
                        StationInfo staForm = new StationInfo(_tsta,_objects);
                        staForm.Show();
                        return;
                    }
                }
            }
        }
    }
}
