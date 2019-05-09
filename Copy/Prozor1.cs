using System;
using System.IO;
using System.Windows.Forms;


namespace Copy
{
    public partial class Prozor1 : Form
    {
        public Prozor1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                sourceFolder.Text = folderBrowser.SelectedPath;
                sourceListBox.Items.Clear();
                if (Directory.Exists(sourceFolder.Text))
                {
                    sourceListBox.Items.AddRange
                        (Directory.GetFiles(sourceFolder.Text));
                }
                else
                {
                    sourceFolder.Text = "";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                targetFolder.Text = folderBrowser.SelectedPath;
                targetListBox.Items.Clear();
                if (Directory.Exists(targetFolder.Text))
                {
                    targetListBox.Items.AddRange
                        (Directory.GetFiles(targetFolder.Text));
                }
                else
                {
                    targetFolder.Text = "";
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(sourceFolder.Text) &&
                Directory.Exists(targetFolder.Text))
            {
                foreach (string file in sourceListBox.SelectedItems)
                {
                    var fileName = Path.GetFileName(file);
                    var sourceFile = Path.Combine(sourceFolder.Text, fileName);
                    var destFile = Path.Combine(targetFolder.Text, fileName);
                    currentFile.Text = file;
                    if (File.Exists(destFile))
                    {
                        FileInfo sourceInfo = new FileInfo(sourceFile);
                        FileInfo targetInfo = new FileInfo(destFile);
                        DialogResult dialogResult = 
                            MessageBox.Show("Oprez, datoteka " + destFile + " već postoji! Prepisati?" +
                                Environment.NewLine +
                                "Source file: " + sourceInfo.Length.ToString() + 
                                "B, modified " + sourceInfo.LastWriteTime.ToString() +
                                Environment.NewLine +
                                "Target file: " + targetInfo.Length.ToString() +
                                "B, modified " + targetInfo.LastWriteTime.ToString(),
                                "Datoteka već postoji", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Copy(sourceFile, destFile, true);
                        }
                    }
                    else
                        File.Copy(sourceFile, destFile, true);
                }
                targetListBox.Items.Clear();
                targetListBox.Items.AddRange
                    (Directory.GetFiles(targetFolder.Text));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(sourceFolder.Text) &&
                Directory.Exists(targetFolder.Text))
            {
                foreach (string file in targetListBox.SelectedItems)
                {
                    var fileName = Path.GetFileName(file);
                    var sourceFile = Path.Combine(targetFolder.Text, fileName);
                    var destFile = Path.Combine(sourceFolder.Text, fileName);
                    currentFile.Text = file;
                    if (File.Exists(destFile))
                    { 
                        FileInfo sourceInfo = new FileInfo(sourceFile);
                        FileInfo targetInfo = new FileInfo(destFile);
                        DialogResult dialogResult =
                            MessageBox.Show("Oprez, datoteka " + destFile + " već postoji! Želite ju prepisati?" +
                                Environment.NewLine +
                                "Source file: " + sourceInfo.Length.ToString() +
                                "B, modified " + sourceInfo.LastWriteTime.ToString() +
                                Environment.NewLine +
                                "Target file: " + targetInfo.Length.ToString() +
                                "B, modified " + targetInfo.LastWriteTime.ToString(),
                                "Datoteka već postoji", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Copy(sourceFile, destFile, true);
                        }
                    }
                    else
                        File.Copy(sourceFile, destFile, true);
                }
                sourceListBox.Items.Clear();
                sourceListBox.Items.AddRange
                    (Directory.GetFiles(sourceFolder.Text));
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Oprez, označili ste " + sourceListBox.SelectedItems.Count + " datoteka. Želite sigurno sve obrisati?",
                                "Brisanje datoteka.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && Directory.Exists(sourceFolder.Text))
            {                              
                foreach (string file in sourceListBox.SelectedItems)
                {
                    currentFile.Text = file;
                    if (File.Exists(file))
                    {
                        try
                        {
                            // File.Delete(file);
                            FileInfo fi = new FileInfo(file);
                            fi.Delete();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Greška prilikom brisanja datoteke: " + ex.Message);
                        }
                    }                        
                }
                sourceListBox.Items.Clear();
                sourceListBox.Items.AddRange
                    (Directory.GetFiles(sourceFolder.Text));
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(sourceFolder.Text) &&
                Directory.Exists(targetFolder.Text))
            {
                foreach (string file in sourceListBox.SelectedItems)
                {
                    var fileName = Path.GetFileName(file);
                    var sourceFile = Path.Combine(sourceFolder.Text, fileName);
                    var destFile = Path.Combine(targetFolder.Text, fileName);
                    currentFile.Text = file;
                    if (File.Exists(destFile))
                    {
                        FileInfo sourceInfo = new FileInfo(sourceFile);
                        FileInfo targetInfo = new FileInfo(destFile);
                        DialogResult dialogResult =
                            MessageBox.Show("Oprez, datoteka " + destFile + " već postoji! Prepisati?" +
                                Environment.NewLine +
                                "Source file: " + sourceInfo.Length.ToString() +
                                "B, modified " + sourceInfo.LastWriteTime.ToString() +
                                Environment.NewLine +
                                "Target file: " + targetInfo.Length.ToString() +
                                "B, modified " + targetInfo.LastWriteTime.ToString(),
                                "Datoteka već postoji.", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete(destFile);
                            File.Move(sourceFile, destFile);
                        }
                    }
                    else
                        File.Move(sourceFile, destFile);
                }
                targetListBox.Items.Clear();
                targetListBox.Items.AddRange (Directory.GetFiles(targetFolder.Text));
                sourceListBox.Items.Clear();
                sourceListBox.Items.AddRange (Directory.GetFiles(sourceFolder.Text));
            }
        }

        private void Prozor1_Load(object sender, EventArgs e)
        {

        }
    }
}
