using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading;

namespace MultiThreadClient
{

    public partial class Form1 : Form
    {


        private TcpClient clientSocket = new TcpClient();
        private NetworkStream serverStream;
        private string message = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 8888);
                greetingLabel.Text = "You are connected to the server!";
            }
            catch (Exception)
            {
                MessageBox.Show("The server is not available");
            }
        }

        public void msg(string mesg)
        {
            chatBox.Text = chatBox.Text + Environment.NewLine + " > " + mesg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = Encoding.ASCII.GetBytes(message + "$");
                msg("Me: " + message);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                messageBox.Clear();            
            }
            catch (Exception)
            {
                MessageBox.Show("Can't send message");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            message = messageBox.Text;
        }

        private void chatBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void response_Click(object sender, EventArgs e)
        {
            string returndata = "";
            while (returndata == "")
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] inStream = new byte[4096];
                clientSocket.ReceiveBufferSize = 4095;
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                returndata = Encoding.ASCII.GetString(inStream);
            }
            msg("Friend: " + returndata);
        }
    }
}