using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task4.V1.Lib;
using System.IO;
namespace Tyuiu.GrigorjanAM.Sprint6.Task4.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxstart_GAM.Text);
                int stop = Convert.ToInt32(textBoxstop_GAM.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chartResult_GAM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_GAM.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_GAM.Text = "";
                chartResult_GAM.Series[0].Points.Clear();
                for( int i = 0; i < len; i++)
                {
                    this.chartResult_GAM.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxResult_GAM.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFile.Task4.txt";
                File.WriteAllText(path, textBoxResult_GAM.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-3, Григорян Арсен Мовсесович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
