using System;
using System.Windows.Forms;

namespace TrafficColorSocket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonMerahOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMerahOn.Checked.Equals(true))
            {
                varGlobal.alamatIPServer = textBoxIPAddress.Text;
                varGlobal.port = Int16.Parse(textBoxPort.Text);
                SocketTCP.StartClient("Merah,Hidup");
            }
        }

        private void radioButtonMerahOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMerahOff.Checked.Equals(true))
            {
                varGlobal.alamatIPServer = textBoxIPAddress.Text;
                varGlobal.port = Int16.Parse(textBoxPort.Text);
                SocketTCP.StartClient("Merah,Mati");
            }
        }

        private void radioButtonKuningOn_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = textBoxIPAddress.Text;
            varGlobal.port = Int16.Parse(textBoxPort.Text);
            SocketTCP.StartClient("Kuning,Hidup");
        }

        private void radioButtonKuningOff_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = textBoxIPAddress.Text;
            varGlobal.port = Int16.Parse(textBoxPort.Text);
            SocketTCP.StartClient("Kuning,Mati");
        }

        private void radioButtonHijauOn_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = textBoxIPAddress.Text;
            varGlobal.port = Int16.Parse(textBoxPort.Text);
            SocketTCP.StartClient("Hijau,Hidup");
        }

        private void radioButtonHijauOff_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = textBoxIPAddress.Text;
            varGlobal.port = Int16.Parse(textBoxPort.Text);
            SocketTCP.StartClient("Hijau,Mati");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
