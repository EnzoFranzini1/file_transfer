using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace File_transfer
{
    public class lan_scaner
    {

        public void scan_lan_ip()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                {
                    Console.WriteLine(ip.Address);
                    if (!ip.IsDnsEligible)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            //Console.WriteLine(ip.Address.AddressFamily);
                            // All IP Address in the LAN
                        }
                    }
                }
            }
        }

    }
}
