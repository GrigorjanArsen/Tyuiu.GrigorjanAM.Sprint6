using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task0.V26.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task0.V26
{
    public partial class FormMainTask_GAM : Form
    {
        public FormMainTask_GAM()
        {
            InitializeComponent();
        }

        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_GAM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVARX_GAM.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textBoxVARX_GAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-23-3, Григорян Арсен Мовсесович", "Сообщение");
        }
    }
}
