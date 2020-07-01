using System;
using System.Text;
using System.Collections;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace chatApp
{
    public partial class form1 : Form        //Form1 is the name of the Form, which represents System.Windows.Forms.Form
    {
        Socket s = null;

        ASCIIEncoding encoding = new ASCIIEncoding();

        public form1()
        {
            InitializeComponent();   //for initializing the values of the form
            timer1.Start();
            timer1.Interval = 1000;
            userList.View = View.Details;  // Set the view to show details for 20 rooms (lsit)
        }

        //sets up the state object and then calls the BeginReceive method to read the data from the socket asynchronously
        //The receive callback method ReceiveCallback implements the AsyncCallback delegate. 
        //It receives the data from the network device and builds a message string. 
        //It reads one or more bytes of data from the network into the data buffer and then calls the BeginReceive method again until the data sent by the client is complete. 
        //Once all the data is read from the client, ReceiveCallback signals the application thread that the data is complete.
        private static void Receive(Socket client)
        {
            try
            {
                // creates the state object.  
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begins receiving the data from the remote device.  
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static string responseSERV = String.Empty;

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client (handler) socket from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;    
                Socket handler = state.workSocket;

                // Read data from the remote device.  
                int bytesRead = handler.EndReceive(ar);           

                if (bytesRead > 0)
                {
                    // There  might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // All the data has arrived; put it in responseSERV.  
                    if (state.sb.Length > 1)
                    {
                        responseSERV = Encoding.ASCII.GetString(state.buffer, 0, bytesRead).ToString();
                        if (responseSERV.StartsWith("message:"))
                        {
                            responseSERV = responseSERV.Replace("message:", "");
                            string[] chatMsgList = responseSERV.Split(',');
                            Program.chatLogList.Clear();
                            Program.chatLogList.InsertRange(0, chatMsgList);
                        }
                    }
                    //client.BeginReceive(state.buffer, 0, StateObject.BufferSize, ref epRemote, new AsyncCallback(ReceiveCallback), state);
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }              
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Connect to a remote device.  
        private void connect_Click(object sender, EventArgs ea)
        {
            try
            {
                // Establish the remote endpoint for the socket.  
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 4321);

                // Create a TCP/IP socket.  
                s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(remoteEP);

                //Async Read form the server side 
                // Receive the response from the remote device. 
                Receive(s);
                byte[] Serbyte = new byte[30];

                s.Send(encoding.GetBytes(login.Text));

                login.Enabled = false;
                connect.Enabled = false;
                panel1.Visible = false;
                label2.Text = login.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Message:" + e.Message);
            }
        }

        private void send_Click(object sender, EventArgs ea)
        {
            try
            {
                string textmsg = login.Text + "-"+chatSelectedUser.Text+"-"+ chatText.Text;
                s.Send(encoding.GetBytes(textmsg));     //sending encoded message via socket
                chatText.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception ee:" + e.Message);
            }
        }

             
       /* private void chatText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string textmsg = login.Text + "-" + chatSelectedUser.Text + "-" + chatText.Text;
                s.Send(encoding.GetBytes(textmsg));     //sending encoded message via socket
                chatText.Text = "";
            }
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            chatHistory.Text= "";
            if (Program.chatLogList != null && Program.chatLogList.Count > 0) {
                for (int i = 0; i < Program.chatLogList.Count; i++) {
                    chatHistory.Text += Program.chatLogList[i]+"\r\n";
                }
            }          
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.userList.SelectedItems.Count == 0)
                return;
            chatSelectedUser.Text = this.userList.SelectedItems[0].Text;
            Program.chatLogList.Clear();
            Program.chatLogText = "";
            chatHistory.Text = "";

            s.Send(encoding.GetBytes("switchroom:" + login.Text+"-"+ this.userList.SelectedItems[0].Text));
            send.Enabled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chatSelectedUser_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chatHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void chatText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    // State object for receiving data from remote device.  
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 256;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }
}
