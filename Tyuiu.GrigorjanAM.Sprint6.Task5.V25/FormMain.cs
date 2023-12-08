using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task5.V25.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"D:\Users\djura\source\repos\Tyuiu.GrigorjanAM.Sprint6\Tyuiu.GrigorjanAM.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";
        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            dataGridViewNums_GAM.ColumnCount = 2;
            dataGridViewNums_GAM.Columns[0].Width = 20;
            dataGridViewNums_GAM.Columns[1].Width = 50;
            this.chartDiag_GAM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_GAM.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_GAM.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_GAM.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_GAM.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_GAM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-3, Григорян Арсен Мовсесович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
