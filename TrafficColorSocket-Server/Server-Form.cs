using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TrafficColorSocket_Client;

namespace TrafficColorSocket_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (textBoxIPAddress.Text != "" && textBoxPort.Text != "")
            {
                thr.Start();
                buttonListen.Enabled = false;
                textBoxIPAddress.Enabled = false;
                textBoxPort.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi port dan alamat IP terlebih dahulu !!!");
            }
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(textBoxPort.Text); // konversi dari string ke integer
            varGlobal.alamatIPServer = textBoxIPAddress.Text;
            SocketTCP.StartListening();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if (varGlobal.terimapesandiserver.Length > 1)
            {
                textBoxPesan.Clear();
                String[] data = varGlobal.terimapesandiserver.Trim().Split(',');
                StringBuilder sb = new StringBuilder();
                sb.Append("Lampu ").Append(data[0]).Append(" ").Append(data[1]);
                changer(data);
                textBoxPesan.Text = sb.ToString();
            }
        }

        private void changer(string[] tmp)
        {
            Color color = Color.Black;
            if (tmp[1].Equals("Hidup"))
            {
                color = chooserColor(tmp[0]);
            }
            switch (tmp[0])
            {
                case "Merah":
                    panelMerah.BackColor = color;
                    break;
                case "Kuning":
                    panelKuning.BackColor = color;
                    break;
                case "Hijau":
                    panelHijau.BackColor = color;
                    break;
            }
        }

        private Color chooserColor(String choose)
        {
            switch (choose)
            {
                case "Merah":
                    return Color.Red;
                case "Kuning":
                    return Color.Yellow;
                case "Hijau":
                    return Color.Green;
                default:
                    return Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
