using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordpadWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CutBtn_Click(object sender, RoutedEventArgs e)
        {
            Txtb.Cut();
        }

        private void CopyBtn_Click(object sender, RoutedEventArgs e)
        {
            Txtb.Copy();
        }

        private void PasteBtn_Click(object sender, RoutedEventArgs e)
        {
            Txtb.Paste();
        }

        private void SelectAllBtn_Click(object sender, RoutedEventArgs e)
        {
            Txtb.SelectAll();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(FilePathTxtb.Text))
            {
                writer.Write(Txtb.Text);
            }
            MessageBox.Show("Saved Succesfully");
        }

        private void FilePathBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt || ";
            if (openFileDialog.ShowDialog() == true)
            {
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    FilePathTxtb.Text = openFileDialog.FileName;
                }
            }
        }

        private void AutoSaveTBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
