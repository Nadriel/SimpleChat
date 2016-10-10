using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Imported Name Spaces: will be used to connect to each other
using System.Net;
using System.Net.Sockets;


namespace SimpleChat
{
    public partial class GeekChat : Form
    {
        //declaring variables for use in connectivity
        Socket sck;
        EndPoint epLocal, epRemote;
        public GeekChat()
        {
            InitializeComponent();
            //
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //we set the local Ip in the Local IP text box
            textLocalIP.Text = getLocalIP();
            textRemoteIP.Text = getLocalIP();

        }

        //method that returns Local(our) IP 
        private string getLocalIP() {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList) {

                if (ip.AddressFamily == AddressFamily.InterNetwork) {

                    return ip.ToString();
                }

            }

            //in case we don't get an ip from the if clause we give him another home ip
            return "127.0.0.1";
        }



        //method that message callback
        private void messageCallback(IAsyncResult aResult)
        {
            //trying to receive data and converting them to strings
            try
            {   
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];

                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);


                    //print messages to the screen
                    messageListBox.Items.Add("Friend: " + receivedMessage);
                    messageListBox.SelectedIndex = messageListBox.Items.Count - 1;
                    messageListBox.SelectedIndex = -1;

                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length,SocketFlags.None, ref epRemote, new AsyncCallback(messageCallback), buffer);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }


        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //get and parse local ip and port
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);
                
                //get and parse remote ip and port
                epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length,SocketFlags.None, ref epRemote, new AsyncCallback(messageCallback), buffer);

                buttonConnect.Enabled = false;
                buttonConnect.Text = "Connected";
                sendButton.Enabled = true;
                textBoxSend.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //send text by pressing the enter key -- actually trigger the sendButtonClick method
        private void textBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("enter key pressed"); used to see if it gets into the if clause
                sendButton_Click(this, new EventArgs());
            }
        }

        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {
            //var fileStream = File.Create("C:\\Path\\To\\File");
            //myOtherObject.InputStream.Seek(0, SeekOrigin.Begin);
            //myOtherObject.InputStream.CopyTo(fileStream);
            //fileStream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get text from textbox and convert it into bytes and send it
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textBoxSend.Text);

                sck.Send(msg);
                messageListBox.Items.Add("Me: " + textBoxSend.Text);
                textBoxSend.Clear();
                messageListBox.SelectedIndex = messageListBox.Items.Count - 1;
                messageListBox.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
