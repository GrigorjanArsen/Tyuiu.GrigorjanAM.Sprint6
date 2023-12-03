
namespace Tyuiu.GrigorjanAM.Sprint6.Task2.V16
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_GAM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_GAM = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GAM = new System.Windows.Forms.GroupBox();
            this.labelstop_GAM = new System.Windows.Forms.Label();
            this.labelstart_GAM = new System.Windows.Forms.Label();
            this.textBoxStop_GAM = new System.Windows.Forms.TextBox();
            this.textBoxStart_GAM = new System.Windows.Forms.TextBox();
            this.buttonHelp_GAM = new System.Windows.Forms.Button();
            this.buttonDone_GAM = new System.Windows.Forms.Button();
            this.dataGridViewFunction_GAM = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_GAM = new System.Windows.Forms.GroupBox();
            this.chartResult_GAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_GAM = new System.Windows.Forms.Label();
            this.X_GAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_GAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_GAM.SuspendLayout();
            this.groupBoxInput_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_GAM)).BeginInit();
            this.groupBoxOutput_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_GAM
            // 
            this.groupBoxCondition_GAM.Controls.Add(this.textBoxCondition_GAM);
            this.groupBoxCondition_GAM.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_GAM.Name = "groupBoxCondition_GAM";
            this.groupBoxCondition_GAM.Size = new System.Drawing.Size(441, 231);
            this.groupBoxCondition_GAM.TabIndex = 0;
            this.groupBoxCondition_GAM.TabStop = false;
            this.groupBoxCondition_GAM.Text = "Условие";
            // 
            // textBoxCondition_GAM
            // 
            this.textBoxCondition_GAM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_GAM.Location = new System.Drawing.Point(3, 16);
            this.textBoxCondition_GAM.Multiline = true;
            this.textBoxCondition_GAM.Name = "textBoxCondition_GAM";
            this.textBoxCondition_GAM.ReadOnly = true;
            this.textBoxCondition_GAM.Size = new System.Drawing.Size(432, 209);
            this.textBoxCondition_GAM.TabIndex = 0;
            this.textBoxCondition_GAM.Text = "Протабулировать функцию cos(x) / (x - 0.4) + sin(x) * 8x + 2\r\nна заданном диапазо" +
    "не.\r\nРезультат вывести в DataGridView и построить график функции";
            // 
            // groupBoxInput_GAM
            // 
            this.groupBoxInput_GAM.Controls.Add(this.labelstop_GAM);
            this.groupBoxInput_GAM.Controls.Add(this.labelstart_GAM);
            this.groupBoxInput_GAM.Controls.Add(this.textBoxStop_GAM);
            this.groupBoxInput_GAM.Controls.Add(this.textBoxStart_GAM);
            this.groupBoxInput_GAM.Location = new System.Drawing.Point(16, 250);
            this.groupBoxInput_GAM.Name = "groupBoxInput_GAM";
            this.groupBoxInput_GAM.Size = new System.Drawing.Size(228, 60);
            this.groupBoxInput_GAM.TabIndex = 1;
            this.groupBoxInput_GAM.TabStop = false;
            this.groupBoxInput_GAM.Text = "Ввод данных";
            // 
            // labelstop_GAM
            // 
            this.labelstop_GAM.AutoSize = true;
            this.labelstop_GAM.Location = new System.Drawing.Point(110, 16);
            this.labelstop_GAM.Name = "labelstop_GAM";
            this.labelstop_GAM.Size = new System.Drawing.Size(69, 13);
            this.labelstop_GAM.TabIndex = 1;
            this.labelstop_GAM.Text = "Конец шага:";
            // 
            // labelstart_GAM
            // 
            this.labelstart_GAM.AutoSize = true;
            this.labelstart_GAM.Location = new System.Drawing.Point(7, 16);
            this.labelstart_GAM.Name = "labelstart_GAM";
            this.labelstart_GAM.Size = new System.Drawing.Size(67, 13);
            this.labelstart_GAM.TabIndex = 1;
            this.labelstart_GAM.Text = "Старт шага:";
            // 
            // textBoxStop_GAM
            // 
            this.textBoxStop_GAM.Location = new System.Drawing.Point(113, 32);
            this.textBoxStop_GAM.Name = "textBoxStop_GAM";
            this.textBoxStop_GAM.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_GAM.TabIndex = 0;
            // 
            // textBoxStart_GAM
            // 
            this.textBoxStart_GAM.Location = new System.Drawing.Point(7, 32);
            this.textBoxStart_GAM.Name = "textBoxStart_GAM";
            this.textBoxStart_GAM.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_GAM.TabIndex = 0;
            // 
            // buttonHelp_GAM
            // 
            this.buttonHelp_GAM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_GAM.Location = new System.Drawing.Point(251, 255);
            this.buttonHelp_GAM.Name = "buttonHelp_GAM";
            this.buttonHelp_GAM.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_GAM.TabIndex = 2;
            this.buttonHelp_GAM.Text = "Справка";
            this.buttonHelp_GAM.UseVisualStyleBackColor = false;
            this.buttonHelp_GAM.Click += new System.EventHandler(this.buttonHelp_GAM_Click);
            // 
            // buttonDone_GAM
            // 
            this.buttonDone_GAM.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone_GAM.Location = new System.Drawing.Point(332, 255);
            this.buttonDone_GAM.Name = "buttonDone_GAM";
            this.buttonDone_GAM.Size = new System.Drawing.Size(122, 55);
            this.buttonDone_GAM.TabIndex = 2;
            this.buttonDone_GAM.Text = "Выполнить";
            this.buttonDone_GAM.UseVisualStyleBackColor = false;
            this.buttonDone_GAM.Click += new System.EventHandler(this.buttonDone_GAM_Click);
            this.buttonDone_GAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_GAM_MouseDown);
            this.buttonDone_GAM.MouseEnter += new System.EventHandler(this.buttonDone_GAM_MouseEnter);
            this.buttonDone_GAM.MouseLeave += new System.EventHandler(this.buttonDone_GAM_MouseLeave);
            // 
            // dataGridViewFunction_GAM
            // 
            this.dataGridViewFunction_GAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_GAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_GAM,
            this.F_GAM});
            this.dataGridViewFunction_GAM.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewFunction_GAM.Name = "dataGridViewFunction_GAM";
            this.dataGridViewFunction_GAM.RowHeadersVisible = false;
            this.dataGridViewFunction_GAM.Size = new System.Drawing.Size(117, 254);
            this.dataGridViewFunction_GAM.TabIndex = 3;
            // 
            // groupBoxOutput_GAM
            // 
            this.groupBoxOutput_GAM.Controls.Add(this.chartResult_GAM);
            this.groupBoxOutput_GAM.Controls.Add(this.labelResult_GAM);
            this.groupBoxOutput_GAM.Controls.Add(this.dataGridViewFunction_GAM);
            this.groupBoxOutput_GAM.Location = new System.Drawing.Point(470, 13);
            this.groupBoxOutput_GAM.Name = "groupBoxOutput_GAM";
            this.groupBoxOutput_GAM.Size = new System.Drawing.Size(547, 297);
            this.groupBoxOutput_GAM.TabIndex = 3;
            this.groupBoxOutput_GAM.TabStop = false;
            this.groupBoxOutput_GAM.Text = "Вывод данных";
            // 
            // chartResult_GAM
            // 
            chartArea9.Name = "ChartArea1";
            this.chartResult_GAM.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartResult_GAM.Legends.Add(legend9);
            this.chartResult_GAM.Location = new System.Drawing.Point(133, 32);
            this.chartResult_GAM.Name = "chartResult_GAM";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartResult_GAM.Series.Add(series9);
            this.chartResult_GAM.Size = new System.Drawing.Size(408, 257);
            this.chartResult_GAM.TabIndex = 5;
            this.chartResult_GAM.Text = "chartResult";
            // 
            // labelResult_GAM
            // 
            this.labelResult_GAM.AutoSize = true;
            this.labelResult_GAM.Location = new System.Drawing.Point(7, 19);
            this.labelResult_GAM.Name = "labelResult_GAM";
            this.labelResult_GAM.Size = new System.Drawing.Size(62, 13);
            this.labelResult_GAM.TabIndex = 4;
            this.labelResult_GAM.Text = "Результат:";
            // 
            // X_GAM
            // 
            this.X_GAM.HeaderText = "x";
            this.X_GAM.Name = "X_GAM";
            this.X_GAM.ReadOnly = true;
            this.X_GAM.Width = 50;
            // 
            // F_GAM
            // 
            this.F_GAM.HeaderText = "f(x)";
            this.F_GAM.Name = "F_GAM";
            this.F_GAM.ReadOnly = true;
            this.F_GAM.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.groupBoxOutput_GAM);
            this.Controls.Add(this.buttonDone_GAM);
            this.Controls.Add(this.buttonHelp_GAM);
            this.Controls.Add(this.groupBoxInput_GAM);
            this.Controls.Add(this.groupBoxCondition_GAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 16 | Григорян А. М.";
            this.groupBoxCondition_GAM.ResumeLayout(false);
            this.groupBoxCondition_GAM.PerformLayout();
            this.groupBoxInput_GAM.ResumeLayout(false);
            this.groupBoxInput_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_GAM)).EndInit();
            this.groupBoxOutput_GAM.ResumeLayout(false);
            this.groupBoxOutput_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_GAM;
        private System.Windows.Forms.TextBox textBoxCondition_GAM;
        private System.Windows.Forms.GroupBox groupBoxInput_GAM;
        private System.Windows.Forms.Label labelstop_GAM;
        private System.Windows.Forms.Label labelstart_GAM;
        private System.Windows.Forms.TextBox textBoxStop_GAM;
        private System.Windows.Forms.TextBox textBoxStart_GAM;
        private System.Windows.Forms.Button buttonHelp_GAM;
        private System.Windows.Forms.Button buttonDone_GAM;
        private System.Windows.Forms.DataGridView dataGridViewFunction_GAM;
        private System.Windows.Forms.GroupBox groupBoxOutput_GAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_GAM;
        private System.Windows.Forms.Label labelResult_GAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_GAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_GAM;
    }
}

