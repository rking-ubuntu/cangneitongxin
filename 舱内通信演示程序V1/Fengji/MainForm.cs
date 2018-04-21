using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;


using System.Text.RegularExpressions;

namespace Fengji
{

    public partial class MainForm : Form
    {       

        private MyAppServer appServer = new MyAppServer();
        private bool start = false;

        int count_sum = 0;
        Series hori_vib { get { return chartControl1.Series["振动信号"]; } }
        Series vert_vib { get { return chartControl1.Series["温度信号"]; } }
        XYDiagram diagram1 { get { return (XYDiagram)chartControl1.Diagram; } }

        public MainForm()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

            var serverConfig = new ServerConfig
            {
                Port = 1400,
                Ip = "Any",
                ReceiveBufferSize = 160*1044,
                MaxRequestLength = 6000,
            };
            try
            {
                appServer.Setup(serverConfig);
                appServer.NewRequestReceived += new RequestHandler<MyAppSession, BinaryRequestInfo>(appServer_NewRequestReceived);
                appServer.NewSessionConnected += new SessionHandler<MyAppSession>(appServer_NewSessionConnected);
                appServer.SessionClosed += new SessionHandler<MyAppSession,SuperSocket.SocketBase.CloseReason>(appServer_SessionClosed);
                appServer.Start();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void appServer_NewSessionConnected(MyAppSession session)
        {
            this.textBox1.Text = session.SocketSession.LocalEndPoint.Address.ToString();
            this.textBox2.Text = session.SocketSession.LocalEndPoint.Port.ToString();
            string ip = session.SocketSession.RemoteEndPoint.Address.ToString();
            string port = session.SocketSession.RemoteEndPoint.Port.ToString();
            session.IP = ip;
            if (!listView1.Items.ContainsKey(ip))
            {
                this.listView1.Items.Add(ip, ip, null);
                this.listView1.Items[ip].SubItems.AddRange(new string[] { port, "已连接" });
  
            }
            else
            {
                this.listView1.Items[ip].SubItems[1].Text = port;
                this.listView1.Items[ip].SubItems[2].Text = "已连接";
            }
            this.listView1.Items[ip].Selected = true;
            
        }

        private void appServer_SessionClosed(MyAppSession session,SuperSocket.SocketBase.CloseReason reason)
        {
            string ip = session.SocketSession.RemoteEndPoint.Address.ToString();
            this.listView1.Items[ip].SubItems[2].Text = "断开连接";
        }

        private void appServer_NewRequestReceived(MyAppSession session, BinaryRequestInfo requestInfo)
        {
            session.Send("OK");
            if (true)
            {

                NodeData nd = SysPublic.getInstance().AllNode.insertNode(session, requestInfo);
                if (nd != null)
                {
                    if (listView1.Items.ContainsKey(nd.IP))
                    {
                        //this.listView1.Items.Add(nd.IP, nd.IP, null);
                        //this.listView1.Items[nd.IP].SubItems.Add(nd.ID);
                    }
                    this.listView1.Items[nd.IP].Selected = true;
                    this.showdata();
                }
                else MessageBox.Show("meishoudao");
            }
        }
        private void showdata()
         {
             string ip = listView1.SelectedItems[0].Text;
             NodeData nd = SysPublic.getInstance().AllNode.getNode(ip);
             if (nd != null)
             {
                text_show(nd);
            }
         }

        public static bool IsFloat(string str)
        {
            string regextext = @"^(-?\d+)(\.\d+)?$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(str.Trim());
        }
        SeriesPoint p1;
        SeriesPoint p2;
        float data1;
        float data2;
        TimeSpan timeSpan_30_s = new TimeSpan(0, 0, 1, 30);
        private void text_show(NodeData nd)
        {
            DateTime time = DateTime.Now;
            try
            {
                textBox_41.Text = nd.Data[40][0].ToString("F3");
                textBox_42.Text = nd.Data[41][0].ToString("F3");

                //float data1 = (float)Convert.ToDouble(nd.Data[40][0]);
                //float data2 = (float)Convert.ToDouble(nd.Data[41][0]);
                data1 = (float)Convert.ToDouble(nd.Data[40][0].ToString("F3"));
                data2 = (float)Convert.ToDouble(nd.Data[41][0].ToString("F3"));
                if (data1==0 || data1 >=20|| data2 == 0 || data2 >= 20)
                    return;
                //SeriesPoint p1 = new SeriesPoint((float)count_sum, data1);
                //SeriesPoint p2 = new SeriesPoint((float)count_sum, data2);
                p1 = new SeriesPoint(time, data1);

                p2 = new SeriesPoint(time, data2);

                hori_vib.Points.Add(p1);
                vert_vib.Points.Add(p2);

                diagram1.AxisX.VisualRange.MaxValue = time;
                diagram1.AxisX.VisualRange.MinValue = time - timeSpan_30_s;



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            
            count_sum++;
        }

      

        private void 开始采集_Click(object sender, EventArgs e)
        {
            /* byte[] data = new byte[1]{0xBB};
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("172.17.134.209", 8887);
            socket.Send(data);*/
            (sender as Button).Enabled = false;
            停止采集.Enabled = true;
            start = true;

        }
  
        private void 停止采集_Click(object sender, EventArgs e)
        {

            start = false;
            (sender as Button).Enabled = false;
            开始采集.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
