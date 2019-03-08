using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace File_transfer
{
    public class file_selector
    {
        MainWindow wnd = (MainWindow)Application.Current.MainWindow;
        public string file_full_path;

        public void Open_FileDialog()
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog File_Dialog = new Microsoft.Win32.OpenFileDialog();

            Console.WriteLine("click");

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = File_Dialog.ShowDialog();

            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                wnd.Current_file.Content = " - " + Path.GetFileName(File_Dialog.FileName.ToString());
                file_full_path = Path.GetFullPath(File_Dialog.FileName);
            }

        }

    }
}
