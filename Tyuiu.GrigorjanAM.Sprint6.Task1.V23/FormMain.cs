using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task1.V23.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task1.V23
{
    public partial class FormMainTask_GAM : Form
    {
        public FormMainTask_GAM()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_GAM.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_GAM.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_GAM.Text = "";
                textBoxResult_GAM.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_GAM.AppendText("|     X      +    f(x)    |" + Environment.NewLine);
                textBoxResult_GAM.AppendText("+------------+------------+" + Environment.NewLine);

                string str;
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,7:d}     |  {1,7:f2}   |", startValue, valueArray[i]);
                    textBoxResult_GAM.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_GAM.AppendText("+------------+------------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-3, Григорян Арсен Мовсесович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
