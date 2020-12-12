using System;
using System.Windows.Forms;
using S7.Net;
namespace Humble
{
    public partial class Form1 : Form
    {
        Plc plc = new Plc(CpuType.S71500, "10.8.77.70", 0, 1);
        public Form1()
        {
            InitializeComponent();
            using (Plc plc = new Plc(CpuType.S71500, "10.8.77.70", 0, 1))
            {
              this.plc = plc;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            plc.Open();
            plc.Write("DB1.DBX0.1", false);
            plc.Write("DB1.DBX0.2", false);
            plc.Write("DB1.DBX0.3", false);
            plc.Write("DB1.DBX0.0", false);
            plc.Close();
        }

        
        
        //Frente
        private void button1_Click(object sender, EventArgs e)
        {
           
                plc.Open();
                //plc.Write("DB210.DBW828", (short)dados.Data.Year);
                plc.Write("DB1.DBX0.0", true);
                plc.Write("DB1.DBX0.1", false);
                plc.Write("DB1.DBX0.2", false);
                plc.Write("DB1.DBX0.3", false);
           
            plc.Close();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            plc.Open();
                //plc.Write("DB210.DBW828", (short)dados.Data.Year);
                plc.Write("DB1.DBX0.0", false);
                plc.Write("DB1.DBX0.1", false);
                plc.Write("DB1.DBX0.2", true);
                plc.Write("DB1.DBX0.3", false);
                plc.Close();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //plc.Write("DB210.DBW828", (short)dados.Data.Year);
            plc.Open();
            plc.Write("DB1.DBX0.0", false);
                plc.Write("DB1.DBX0.1", false);
                plc.Write("DB1.DBX0.2", false);
                plc.Write("DB1.DBX0.3", true);
                plc.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                plc.Open();
                //plc.Write("DB210.DBW828", (short)dados.Data.Year);
                plc.Write("DB1.DBX0.0", false);
                plc.Write("DB1.DBX0.1", true);
                plc.Write("DB1.DBX0.2", false);
                plc.Write("DB1.DBX0.3", false);
                plc.Close();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axVideoChatReceiver1.ReceiveVideoStream = true;
            axVideoChatReceiver1.ReceiveAudioStream = true;
            axVideoChatReceiver1.Listen("127.0.0.1", 1234);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axVideoChatSender1.VideoDevice = 0;
            axVideoChatSender1.AudioDevice = 0;
            axVideoChatSender1.VideoFormat = 0;
            axVideoChatSender1.FrameRate = 15;
            axVideoChatSender1.VideoBitrate = 128000;
            axVideoChatSender1.AudioComplexity = 0;
            axVideoChatSender1.AudioQuality = 8;
            axVideoChatSender1.SendAudioStream = true;
            axVideoChatSender1.SendVideoStream = true;
            axVideoChatSender1.Connect("127.0.0.1", 1234);
        }

        private void axVideoChatReceiver1_OnNewUserConnection(object sender, AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnNewUserConnectionEvent e)
        {

        }

        private void axVideoChatSender1_SendStream(object sender, AxVideoChatSenderLib._DvideochatEvents_SendStreamEvent e)
        {

        }
    }
}
