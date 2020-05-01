using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAN_APP
{
    public partial class Form1 : Form
    {
        string pathpc = @"c:\temp\pc.txt";
        string pathsoft = @"c:\temp\soft.txt";
        List<string> yeslist, nolist;
        int pccnt=0, yescnt=0, nocnt=0;

        public Form1()
        {
            InitializeComponent();
            
            if (!File.Exists(pathpc))
            {
                FileStream fs=File.Create(pathpc);
                fs.Close();
                
            }
            if (!File.Exists(pathsoft))
            {
                FileStream fs=File.Create(pathsoft);
                fs.Close();
            }

            yeslist = new List<string>();
            nolist = new List<string>();

            fillPCList();

            fillsoft();

        }

        public void fillsoft()
        {
            cmbsoft.Items.Clear();
            System.IO.StreamReader myFile = new System.IO.StreamReader(pathsoft);
            string myString = myFile.ReadToEnd();
            myFile.Close();
            string[] lines = myString.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);            
            cmbsoft.Items.AddRange(lines);      
        }

        public void fillPCList()
        {

            lstpc.Items.Clear();
            chklist.Items.Clear();
            System.IO.StreamReader myFile = new System.IO.StreamReader(pathpc);
            string myString = myFile.ReadToEnd();
            myFile.Close();

            string[] lines = myString.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            lstpc.Items.AddRange(lines);
            chklist.Items.AddRange(lines);
            pccnt = lines.Length;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtip_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txthost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtip.Text == "" || txthost.Text == "")
            {
                MessageBox.Show("Insufficient data , all data are necessary ",
                "Error",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            }
            else
            {

                IPAddress ipAddress;
                if (IPAddress.TryParse(txtip.Text, out ipAddress))
                {
                    string[] stringip = txtip.Text.Split(new char[] { '.' },StringSplitOptions.None);
                    byte[] byteip = { Byte.Parse(stringip[0]), Byte.Parse(stringip[1]), Byte.Parse(stringip[2]), Byte.Parse(stringip[3]) };
                    IPAddress ip = new IPAddress(byteip);

                    Ping pingSender = new Ping ();
                    PingOptions options = new PingOptions ();

                    // Use the default Ttl value which is 128,
                    // but change the fragmentation behavior.
                    options.DontFragment = true;

                    // Create a buffer of 32 bytes of data to be transmitted.
                    string data1 = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                    byte[] buffer = Encoding.ASCII.GetBytes (data1);
                    int timeout = 120;
                    PingReply reply = pingSender.Send(ip,timeout,buffer,options);
                    if (reply.Status == IPStatus.Success)
                    {
                        string data = txtip.Text + " : " + txthost.Text + Environment.NewLine;
                        Byte[] info = new UTF8Encoding(true).GetBytes(data);
                        FileStream fs = new FileStream(pathpc, FileMode.Append, FileAccess.Write);
                        fs.Write(info, 0, info.Length);
                        Console.Write("Added");
                        fs.Close();

                        MessageBox.Show("New PC Added to your pool",
                        "Done",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        txthost.Text = "";
                        txtip.Text = "";

                        fillPCList();
                    }
                    else
                    {
                        MessageBox.Show("Unable to add PC to the list\nCheck if the PC is on",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid IP Address Format. ",
                    "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtsoft.Text=="")
            {
                MessageBox.Show("Insufficient data , all data are necessary ",
                "Error",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);


            }
            else
            {

                string data = txtsoft.Text + Environment.NewLine;
                Byte[] info = new UTF8Encoding(true).GetBytes(data);
                FileStream fs = new FileStream(pathsoft, FileMode.Append, FileAccess.Write);
                fs.Write(info, 0, info.Length);
                Console.Write("Added");

                MessageBox.Show("New software added to your pool",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                fs.Close();

                txtsoft.Text = "";
               
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (lstpc.SelectedItems.Count == 0)
            {
                MessageBox.Show("First select the PC to remove ",
                "Error",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            }
            else
            {
                string removestr = lstpc.SelectedItem.ToString();
                Console.Write(removestr);
                File_DeleteLine(lstpc.SelectedIndex+1, pathpc);
                fillPCList();
            }

        }
        void File_DeleteLine(int Line, string Path)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(Path))
            {
                int Countup = 0;
                while (!sr.EndOfStream)
                {
                    Countup++;
                    if (Countup != Line)
                    {
                        using (StringWriter sw = new StringWriter(sb))
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(sb.ToString());
            }
            
        }

        private void chkall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkall.Checked == true)
            {
                chklist.Enabled = false;
                for (int i = 0; i < chklist.Items.Count; i++)
                    chklist.SetItemChecked(i, true);
            }
            else
            {
                chklist.Enabled = true;
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            yeslist.Clear();
            nolist.Clear();
            lstyes.Items.Clear();
            lstno.Items.Clear();
            chart1.Series[0].Points.Clear();
            Console.Write("cool");
            yescnt = 0; nocnt = 0;
            
            if (chklist.SelectedItems.Count == 0 && chkall.Checked == false)
            {
                MessageBox.Show("Insufficient Data\nSelect atleast one PC and software",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                if (cmbsoft.Text == "")
                {
                    MessageBox.Show("Insufficient Data\nSelect atleast one PC and software",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    foreach(Object sitem1 in chklist.CheckedItems)
                    {
                        String sitem = sitem1 as String;
                        //Console.WriteLine(sitem.ToString());
                        string[] split = sitem.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        string[] stringip = split[0].Split(new char[] { '.' }, StringSplitOptions.None);
                        byte[] byteip = { Byte.Parse(stringip[0].Trim()), Byte.Parse(stringip[1].Trim()), Byte.Parse(stringip[2].Trim()), Byte.Parse(stringip[3].Trim()) };
                        IPAddress ip = new IPAddress(byteip);

                        //Console.WriteLine("hi2");
                        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
                        clientSocket.Connect(ip, 8888);
                        NetworkStream serverStream = clientSocket.GetStream();
                        byte[] outStream = System.Text.Encoding.ASCII.GetBytes(cmbsoft.Text + "$");
                        serverStream.Write(outStream, 0, outStream.Length);
                        serverStream.Flush();
                        //Console.WriteLine("hi2");
                        byte[] inStream = new byte[65536];
                        serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                        string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                        returndata = returndata.Substring(0, returndata.IndexOf("$"));
                        //Console.WriteLine("hi");
                        //Console.WriteLine(returndata);
                        //Console.ReadKey();

                        if (returndata.Equals("Yes"))
                        {
                            yeslist.Add(sitem);
                        }
                        else if (returndata.Equals("No"))
                        {
                            nolist.Add(sitem);
                        }
                    }

                    popuplistYes();
                    popuplistNo();
                    showresult();
            
                }

                
            }

        }

        private void showresult()
        {
            yescnt = yeslist.Count;
            nocnt = nolist.Count;
            chart1.Series[0].Points.AddXY("Yes", (yescnt / pccnt) * 100.0);
            chart1.Series[0].Points[0].Color = System.Drawing.Color.Green;
            chart1.Series[0].Points[0].IsValueShownAsLabel = false;
            chart1.Series[0].Points.AddXY("No", (nocnt / pccnt) * 100.0);
            chart1.Series[0].Points[1].Color = System.Drawing.Color.Red;
            chart1.Series[0].Points[1].IsValueShownAsLabel = false;
           
        }

        public void popuplistYes()
        {
            string[] yes=yeslist.ToArray();
            lstyes.Items.AddRange(yes);
        }

        public void popuplistNo()
        {
            string[] no = nolist.ToArray();
            lstno.Items.AddRange(no);
        }

        private void sndpack_Click(object sender, EventArgs e)
        {
            string filename="";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();         

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                Console.Write(filename);

                //String filename = @"c:\temp\soft.zip";
                foreach (string sitem in nolist)
                {

                    //Console.WriteLine(sitem.ToString());
                    string[] split = sitem.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] stringip = split[0].Split(new char[] { '.' }, StringSplitOptions.None);
                    byte[] byteip = { Byte.Parse(stringip[0].Trim()), Byte.Parse(stringip[1].Trim()), Byte.Parse(stringip[2].Trim()), Byte.Parse(stringip[3].Trim()) };
                    IPAddress ip = new IPAddress(byteip);

                    //Console.WriteLine("hi2");
                    Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    clientSocket.Connect(ip, 8089);

                    byte[] preBuffer;
                    using (var memoryStream = new MemoryStream())
                    {
                        using (BinaryWriter writer = new BinaryWriter(memoryStream))
                        {
                            writer.Write(filename);
                        }
                        preBuffer = memoryStream.ToArray();
                    }

                    clientSocket.SendFile(filename,preBuffer,null,TransmitFileOptions.UseDefaultWorkerThread);
                    //clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtsoft_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
