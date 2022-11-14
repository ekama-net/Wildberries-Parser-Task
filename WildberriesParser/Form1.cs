using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WildberriesParser
{
    public partial class MainForm : Form
    {
        //default path
        private string TxtFilePath = @"..\..\..\WB_Content\Keys.txt"; 
        public MainForm()
        {
            InitializeComponent();
            File_Name.Text = Path.GetFileName(TxtFilePath);
            File_Data.Text = File.ReadAllText(TxtFilePath);
        }

        private void Parse_button_Click(object sender, EventArgs e)
        {
            if (new FileInfo(TxtFilePath).Length != 0)
            {
                Wildberries.ConfigureExel(TxtFilePath);
                var proc = new Process();
                proc.StartInfo = new ProcessStartInfo($"{TxtFilePath}\\..\\Report.xlsx")
                {
                    UseShellExecute = true
                };
                proc.Start();
            }
            else MessageBox.Show("This .txt file is empty. At least one entry is required.");
        }

        private void New_txt_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (Path.GetExtension(openFileDialog.FileName) == ".txt")
            {
                TxtFilePath = openFileDialog.FileName;
                File_Name.Text = Path.GetFileName(TxtFilePath);
                File_Data.Text = File.ReadAllText(TxtFilePath);
            }
            else MessageBox.Show("Please select .txt file");
        }
    }
}
