﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using Visualisator.Packets;
using System.Collections;
using System.Windows.Forms;

namespace Visualisator
{
    [Serializable()]
    class AP :  RFDevice, IBoardObjects,IRFDevice,ISerializable
    {
        const int _UPDATE_KEEP_ALIVE_PERIOD = 15; //sec
        
        private Int32 _BeaconPeriod = 500;

        private Int32 _AP_MAX_SEND_PERIOD = 150;
        private Int32 _AP_MIN_SEND_PERIOD = 100;
        private static Random rnadomBeacon = new Random();
        private String _SSID = "";
        private ArrayListCounted _AssociatedDevices = new ArrayListCounted();
        private Int32 _KeepAliveReceived = 0;

        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden

        public String SSID
        {
            get { return _SSID; }
            set { _SSID = value; }
        }
        public Int32 KeepAliveReceived
        {
            get { return _KeepAliveReceived; }
            set { _KeepAliveReceived = value; }
        }

        public ArrayListCounted getAssociatedDevices()
        {
           return _AssociatedDevices; 
        }


        //*********************************************************************
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }


        public Int32 CenntedDevicesCount()
        {
            return _AssociatedDevices.Count;
        }
        //*********************************************************************
        public AP(Medium med)
        {
            this._MEDIUM = med;
            this.VColor = Color.YellowGreen;
            this._SSID = RandomString(8);
            _BeaconPeriod = rnadomBeacon.Next(_AP_MIN_SEND_PERIOD, _AP_MAX_SEND_PERIOD);
            
            Enable();
        }
        //*********************************************************************
        ~AP()
        {
            _Enabled = false;
        }
        //*********************************************************************
        public void Enable()
        {
            RF_STATUS = "NONE";
            _Enabled = true;
            Thread newThread = new Thread(new ThreadStart(SendBeacon));
            newThread.Start();

          Thread newThreadListen = new Thread(new ThreadStart(Listen));
          newThreadListen.Start();

          Thread newThreadKeepAliveDecrease = new Thread(new ThreadStart(UpdateKeepAlive));
          newThreadKeepAliveDecrease.Start();

          Thread tempname = new Thread(new ThreadStart(sendTXpackets));
          tempname.Start();
        }

        private void UpdateKeepAlive()
        {
            while (_Enabled)
            {
                _AssociatedDevices.DecreaseAll();
              
                Thread.Sleep(_UPDATE_KEEP_ALIVE_PERIOD * 1000); // sec *
            }

        }

        //*********************************************************************
        public void Disable()
        {
            _Enabled = false;
        }
        //*********************************************************************
        public void SendBeacon()
        {
            while (_Enabled)
            {
                Beacon _beac = new Beacon(CreatePacket());
                _beac.Destination = "FF:FF:FF:FF:FF:FF";
                //_beac.setTransmitRate(300);
                this.SendData(_beac);
                Thread.Sleep(_BeaconPeriod);               
            }
        }
        //*********************************************************************
        public void SendConnectionACK(String DEST_MAN)
        {
            //while (_Enabled)
            //{
                ConnectionACK _ack = new ConnectionACK(CreatePacket());
                _ack.Destination = DEST_MAN;
                this.SendData(_ack);
                //Thread.Sleep(_BeaconPeriod);
            //}
        }
        //*********************************************************************
        public void SendData(SimulatorPacket pack)
        {

            //Random ran = new Random((int)DateTime.Now.Ticks);
            //while (RF_STATUS != "NONE")
            //{
                //Thread.Sleep(ran.Next(3,10));
            //}
            SpinWait.SpinUntil(RF_Ready);
            RF_STATUS = "TX";
            while (!_MEDIUM.Registration(this.getOperateBand(),this.getOperateChannel(),this.x,this.y))
            {
                RF_STATUS = "NONE";
                //Thread.Sleep(ran.Next(1, 2));
                Thread.Sleep(new TimeSpan(20));
                Thread.Sleep(1);
                SpinWait.SpinUntil(RF_Ready);
               
                //while (RF_STATUS != "NONE")
                //    Thread.Sleep(ran.Next(1, 3));
                RF_STATUS = "TX";
            }
         
            _MEDIUM.SendData(pack);
            //Thread.Sleep(ran.Next(1, 2));
            //Thread.Sleep(1);
            //Thread.Sleep(new TimeSpan(100));
            RF_STATUS = "NONE";
            
    
        }
        //*********************************************************************
       // public Packets.IPacket ReceiveData(IRFDevice ThisDevice)
        //{
         //   throw new NotImplementedException();
       // }
        private bool checkIfHaveDataReceive()
        {
            return _MEDIUM.MediumHaveAIRWork(this);
        }
        //*********************************************************************
        public void Listen()
        {
            while (_Enabled)
            {
                Packets.IPacket pack = null;
                Random ran = new Random((int)DateTime.Now.Ticks);
                //while (RF_STATUS != "NONE")
                //{
                //    Thread.Sleep(ran.Next(1,4));
               // }

                SpinWait.SpinUntil(checkIfHaveDataReceive);
                SpinWait.SpinUntil(RF_Ready);
                lock (RF_STATUS)
                {
                    RF_STATUS = "RX";
                    pack = _MEDIUM.ReceiveData(this);
                    RF_STATUS = "NONE";
                }
                /*SpinWait.SpinUntil(RF_Ready);
                //lock (RF_STATUS)
                //{
                    RF_STATUS = "RX";
                    if (_MEDIUM.MediumHaveAIRWork(this))
                        pack = _MEDIUM.ReceiveData(this);
                    RF_STATUS = "NONE";
               // }*/
                if (pack != null)
                    ParseReceivedPacket(pack);

                //Thread.Sleep(1);
            }
        }

        private void UpdateSTAKeepAliveInfoOnReceive(String STA_MAC)
        {
            if (_AssociatedDevices.Contains(STA_MAC))
            {
                _KeepAliveReceived++;
                _AssociatedDevices.Increase(STA_MAC);
            }
            else
            {
                MessageBox.Show(STA_MAC + " not associated UpdateSTAKeepAliveInfo");
            }
        }
        //*********************************************************************
        public void ParseReceivedPacket(IPacket pack)
        {
            Type Pt = pack.GetType();
            if (Pt == typeof(Connect))
            {
                Connect _conn = (Connect)pack;
                if (!_AssociatedDevices.Contains(_conn.Source))
                    _AssociatedDevices.Add(_conn.Source);
                SendConnectionACK(_conn.Source);

            }
            else if (Pt == typeof(KeepAlive))
            {
                KeepAlive _wp   = (KeepAlive)pack;
     

                Thread newThread = new Thread(() => UpdateSTAKeepAliveInfoOnReceive(_wp.Source));
                newThread.Start();
            }
            else if (Pt == typeof(Data))
            {
                Data _wp        = (Data)pack;
                // Update Keep Alive
                //Thread newThread = new Thread(() => UpdateSTAKeepAliveInfoOnReceive(_wp.Source));
                //newThread.Start();

                DataAck ack = new DataAck(CreatePacket());
                ack.Destination = _wp.Source;
                ack.X = this.x;
                ack.Y = this.y;
                ack.PacketID = _wp.PacketID;
                SendData(ack);
                _wp.Destination = _wp.Reciver;
                _wp.X = this.x;
                _wp.Y = this.y;
                AddTXPacket(_wp);
                //SendData(_wp);
                DataReceived++;

            }
            else if (Pt == typeof(DataAck))
            {

                DataAck _wp     = (DataAck)pack;

                // Update Keep Alive
                //Thread newThread = new Thread(() => UpdateSTAKeepAliveInfoOnReceive(_wp.Source));
                //newThread.Start();

                //_wp.Destination = _wp.Reciver;
                //_wp.X = this.x;
                //_wp.Y = this.y;
                DeleteTXpacketByID(_wp.PacketID);
                //SendData(_wp);
                DataAckReceived++;
            }
            else
            {

                //Console.WriteLine("[" + getMACAddress() + "]" + " listening.");
            }
        }
        //*********************************************************************
        public void RegisterToMedium(int x, int y, int Channel, string Band, int Radius)
        {
            //
        }



    }
}
