using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace File_transfer
{
    public class ip_checker
    {
        MainWindow wnd = (MainWindow)Application.Current.MainWindow;
        lan_scaner _lan_scan = new lan_scaner();
        int A_ip, B_ip, C_ip, D_ip;

        public void check_ip_input()
        {

            wnd.Scan_results.Content = "Wait...";
            wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Black;

            if (wnd.A_IP.Text == "" || wnd.A_IP.Text.Length > 3)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't contain more than 3 digits or be empty";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            if (wnd.B_IP.Text == "" || wnd.B_IP.Text.Length > 3)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't contain more than 3 digits or be empty";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            if (wnd.C_IP.Text == "" || wnd.C_IP.Text.Length > 3)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't contain more than 3 digits or be empty";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            if (wnd.D_IP.Text == "" || wnd.D_IP.Text.Length > 3)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't contain more than 3 digits or be empty";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            foreach (char c in wnd.A_IP.Text)
            {
                if (char.IsDigit(c) == false)
                {
                    wnd.Scan_results.Content = "Verify the input IP";
                    wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                    return;
                }
                else
                {
                    A_ip = Convert.ToInt32(wnd.A_IP.Text);
                }
            }

            foreach (char c in wnd.B_IP.Text)
            {
                if (char.IsDigit(c) == false)
                {
                    wnd.Scan_results.Content = "Verify the input IP";
                    wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                    return;
                }
                else
                {
                    B_ip = Convert.ToInt32(wnd.B_IP.Text);
                }
            }

            foreach (char c in wnd.C_IP.Text)
            {
                if (char.IsDigit(c) == false)
                {
                    wnd.Scan_results.Content = "Verify the input IP";
                    wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                    return;
                }
                else
                {
                    C_ip = Convert.ToInt32(wnd.C_IP.Text);
                }
            }

            foreach (char c in wnd.D_IP.Text)
            {
                if (char.IsDigit(c) == false)
                {
                    wnd.Scan_results.Content = "Verify the input IP";
                    wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                    return;
                }
                else
                {
                    D_ip = Convert.ToInt32(wnd.D_IP.Text);
                }
            }

            if(A_ip > 255)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't exceed 255";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            if (B_ip > 255)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't exceed 255";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            if (C_ip > 255)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't exceed 255";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            if (D_ip > 255)
            {
                wnd.Scan_results.Content = "Verify the input IP\nAn adress can't exceed 255";
                wnd.Scan_results.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }

            _lan_scan.scan();
        }
    }
}
