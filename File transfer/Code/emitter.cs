using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Threading;

namespace File_transfer
{
    public class emitter
    {
        MainWindow wnd = (MainWindow)System.Windows.Application.Current.MainWindow;

        lan_scaner _lan_scaner = new lan_scaner();
        file_selector _file_selector = new file_selector();

        byte[] b1;

        public void Send_file()
        {
            //Host a conectar
            //TcpClient client = new TcpClient(_lan_scaner.Host_Name, 5050);
            TcpClient client = new TcpClient("DESKTOP-EIMTOEV", 80);
            
            Stream s = client.GetStream();

            b1 = File.ReadAllBytes(_file_selector.file_full_path);

            s.Write(b1, 0, b1.Length);
            
            client.Close();

/*
            Stream Fs = File.OpenRead(textBox1.Text);
            Byte[] buffer = new Byte[Fs.Length];
            Fs.Read(buffer, 0, buffer.Length);
            TcpClient socket = new TcpClient(“Localhost”, 1095);
            NetworkStream nw = socket.GetStream();
            nw.Write(buffer, 0, buffer.Length);
            nw.Close();
            */
        }

    }
}