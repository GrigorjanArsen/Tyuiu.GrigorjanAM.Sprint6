using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task6.V29.Lib;
using System.IO;
namespace Tyuiu.GrigorjanAM.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFIle_GAM_Click(object sender, EventArgs e)
        {
            openFileDialogOpen_GAM.ShowDialog();
            openFilePath = openFileDialogOpen_GAM.FileName;
            textBoxInPut_GAM.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_GAM.Text = groupBoxOutPut_GAM.Text + " " + openFileDialogOpen_GAM.FileName;
            buttonDone_GAM.Enabled = true;
            
        }

        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            string i = "i";
            textBoxOutPut_GAM.Text = ds.CollectTextFromFile(i, openFilePath);
        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
    }
}
