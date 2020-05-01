using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using Microsoft.Win32;
using System.Net;

namespace MyService
{
    public partial class Service1 : ServiceBase
    {
        Thread th;
        bool isRunning = false;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            th = new Thread(DoThis);
            th.Start();
            isRunning = true;
        }

        private void DoThis()
        {
            while (isRunning)
            {
                byte[] addr = { (byte)127, (byte)0, (byte)0, (byte)1 };
                TcpListener serverSocket = new TcpListener(new IPAddress(addr), 8888);
                
                TcpClient clientSocket = default(TcpClient);
                
                serverSocket.Start();
                clientSocket = serverSocket.AcceptTcpClient();

                try
                {
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[65536];
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    string serverResponse="No$";
                    string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                    using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
                    {
                        foreach (string subkey_name in key.GetSubKeyNames())
                        {
                            using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                            {
                                //Console.WriteLine(subkey.GetValue("DisplayName")); 
                                if (subkey.GetValue("DisplayName") != null)
                                {
                                    if (subkey.GetValue("DisplayName").ToString().Equals(dataFromClient,StringComparison.OrdinalIgnoreCase))
                                    {
                                        serverResponse = "Yes$";
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                }

                catch (Exception ex)
                {

                }

                clientSocket.Close();
                serverSocket.Stop();
            }
        }

        protected override void OnStop()
        {
            isRunning = false;
            th = null;
        }
    }
}
