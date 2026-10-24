using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFile
{
    public partial class FrmStudentRecord : Form
    {
        private string fileName;
        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        public FrmStudentRecord(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration fr = new FrmRegistration();
            fr.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                lvShowText.Clear();
                openFileDialog1.InitialDirectory = @"";
                openFileDialog1.Title = "";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*"; ;
                openFileDialog1.ShowDialog();
                string path = openFileDialog1.FileName;
                fileName = path;
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no file opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(fileName))
                lvShowText.Items.Add("The record details will appear here.");
            else
                lvShowText.Clear();
            lvShowText.Items.Add(fileName);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lvShowText.Items.Count == 0 || String.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("There is no file opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                MessageBox.Show("Successfully uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowText.Clear();
            lvShowText.Items.Add("This is where the record details will appear.");
        }
    }
}
