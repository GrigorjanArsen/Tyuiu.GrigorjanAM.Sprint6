using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint6.Task3.V24.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();
        int[,] mx = { { -17,  -6,  10,   5,   3},
                      { -10, -14,  10,  -7,  -3},
                      {  -19,   9,   8, -17,  -9},
                      {  -19,  -5,  -9, -18,  14},
                      {   17,  12,  11,  12,   2} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mx.GetUpperBound(0) + 1;
            int col = mx.Length / rows;

            dataGridViewMatrix_GAM.ColumnCount = col;
            dataGridViewMatrix_GAM.RowCount = rows;

            for(int i = 0; i < col; i++)
            {
                dataGridViewMatrix_GAM.Columns[i].Width = 25;

            }
            
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrix_GAM.Rows[i].Cells[j].Value = Convert.ToString(mx[i, j]);
                }
            }    

        }

        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            textBoxResult_GAM.Text = "Выполнено!";
            int rows = mx.GetUpperBound(0) + 1;
            int col = mx.Length / rows;

            dataGridViewMatrix_GAM.ColumnCount = col;
            dataGridViewMatrix_GAM.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix_GAM.Columns[i].Width = 25;

            }
            int[,] result = ds.Calculate(mx);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrix_GAM.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-23-3, Григорян Арсен Мовсесович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
