using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task2.V16.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task2.V16
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
                int start = Convert.ToInt32(textBoxStart_GAM.Text);
                int stop = Convert.ToInt32(textBoxStop_GAM.Text);
                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);
                this.chartResult_GAM.Titles.Add("График функции");
                this.chartResult_GAM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_GAM.ChartAreas[0].AxisY.Title = "Ось Y";

                for(int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_GAM.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    this.chartResult_GAM.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonDone_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_GAM.BackColor = Color.IndianRed;
        }

        private void buttonDone_GAM_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_GAM.BackColor = Color.AliceBlue;
        }

        private void buttonDone_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_GAM.BackColor = Color.SeaGreen;
        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-3, Григорян Арсен Мовсесович","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
