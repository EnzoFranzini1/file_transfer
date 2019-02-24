using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Windows;

//using System.Windows.Forms;

namespace File_transfer
{
    public class lan_scaner
    {
        MainWindow wnd = (MainWindow)Application.Current.MainWindow;

        public void scan()
        {

            Ping myPing;
            PingReply reply;
            IPAddress addr;
            IPHostEntry entry;

            myPing = new Ping();

            string Ip_destino = wnd.A_IP.Text.ToString() + "." + wnd.B_IP.Text.ToString() + "." + wnd.C_IP.Text.ToString() + "." + wnd.D_IP.Text.ToString();

            try
            {
                reply = myPing.Send(Ip_destino);
            }
            catch (Exception ex)
            {
                wnd.Scan_results.Content = "Verify the input IP\nThe network (" + Ip_destino + ") location cannot be reached";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                Console.WriteLine(ex);
                return;
            }


            Console.WriteLine("Flag 0");

            if (reply.Status == IPStatus.Success)
            {
                try
                {
                    Console.WriteLine("Flag 1");
                    addr = IPAddress.Parse(Ip_destino);
                    Console.WriteLine("Flag 2");
                    Console.WriteLine(reply.Address);
                    Console.WriteLine("Flag 3");
                    //host = Dns.GetHostEntry(addr);
                    try
                    {
                        entry = Dns.GetHostEntry(Ip_destino);
                        wnd.Scan_results.Content = "Host name: " + entry.HostName.ToString() + "\nIp adress: " + Ip_destino.ToString() + "" + "\nStatus: Sucessfull ping\n\n";
                        wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Green;
                    }
                    catch (Exception ex)
                    {
                        wnd.Scan_results.Content = "Host name: No such host is known" + "\nIp adress: " + Ip_destino.ToString() + "" + "\nStatus: Sucessfull ping\n\n";
                        wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Green;
                        Console.WriteLine(ex + " - fail");
                    }

                }
                catch (Exception E)
                {
                    wnd.Scan_results.Content = E + " - fail - " + Ip_destino;
                    wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                }
            }
            else
            {
                wnd.Scan_results.Content = reply.Status.ToString() + " - fail - " + Ip_destino;
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                Console.WriteLine("Flag 1");
            }

        }


    }
}
