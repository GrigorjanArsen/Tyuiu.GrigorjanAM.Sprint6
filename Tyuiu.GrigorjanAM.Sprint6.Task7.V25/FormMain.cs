using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task7.V25.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_GAM.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GAM.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int col;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string filedata = File.ReadAllText(filePath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            col = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, col];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < col; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_GAM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GAM.ShowDialog();
            openFilePath = openFileDialogTask_GAM.FileName;

            int[,] arrayValues = new int[rows, col];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInPut_GAM.ColumnCount = col;
            dataGridViewInPut_GAM.RowCount = rows;
            dataGridViewOutPut_GAM.ColumnCount = col;
            dataGridViewOutPut_GAM.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewInPut_GAM.Columns[i].Width = 25;
                dataGridViewOutPut_GAM.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewInPut_GAM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_GAM.Enabled = true;
        }

        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, col];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewOutPut_GAM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_GAM.Enabled = true;

        }

        private void buttonSave_GAM_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GAM.FileName = "OutPutFileTask7V25.csv";
            saveFileDialogMatrix_GAM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GAM.ShowDialog();

            string path = saveFileDialogMatrix_GAM.FileName;
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPut_GAM.RowCount;
            int col = dataGridViewOutPut_GAM.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col - 1)
                    {
                        str = str + dataGridViewOutPut_GAM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_GAM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_GAM.ColumnCount = 50;
            dataGridViewOutPut_GAM.ColumnCount = 50;

            dataGridViewOutPut_GAM.RowCount = 50;
            dataGridViewInPut_GAM.RowCount = 50;
            panelInPut_GAM.Width = this.Width / 2;
            panelOutPut_GAM.Width = this.Width / 2;


        }

        private void buttonOpenFile_GAM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_GAM.ToolTipTitle = "Открыть файл";
            
        }

        private void buttonDone_GAM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_GAM.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_GAM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_GAM.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_GAM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_GAM.ToolTipTitle = "Справка";
        }
    }
}
