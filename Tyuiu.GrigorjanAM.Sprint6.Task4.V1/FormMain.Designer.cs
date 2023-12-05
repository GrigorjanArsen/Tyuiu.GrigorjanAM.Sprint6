
namespace Tyuiu.GrigorjanAM.Sprint6.Task4.V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelCondition__GAM = new System.Windows.Forms.Panel();
            this.buttonDone_GAM = new System.Windows.Forms.Button();
            this.buttonSave_GAM = new System.Windows.Forms.Button();
            this.groupBoxInput_GAM = new System.Windows.Forms.GroupBox();
            this.labelstop_GAM = new System.Windows.Forms.Label();
            this.labelstart_GAM = new System.Windows.Forms.Label();
            this.textBoxstop_GAM = new System.Windows.Forms.TextBox();
            this.textBoxstart_GAM = new System.Windows.Forms.TextBox();
            this.buttonHelp_GAM = new System.Windows.Forms.Button();
            this.groupBoxCondition_GAM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_GAM = new System.Windows.Forms.TextBox();
            this.panelTable_GAM = new System.Windows.Forms.Panel();
            this.groupBoxResult_GAM = new System.Windows.Forms.GroupBox();
            this.textBoxResult_GAM = new System.Windows.Forms.TextBox();
            this.splitterTandG_GAM = new System.Windows.Forms.Splitter();
            this.panelGraph_GAM = new System.Windows.Forms.Panel();
            this.chartResult_GAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCondition__GAM.SuspendLayout();
            this.groupBoxInput_GAM.SuspendLayout();
            this.groupBoxCondition_GAM.SuspendLayout();
            this.panelTable_GAM.SuspendLayout();
            this.groupBoxResult_GAM.SuspendLayout();
            this.panelGraph_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition__GAM
            // 
            this.panelCondition__GAM.BackColor = System.Drawing.SystemColors.Control;
            this.panelCondition__GAM.Controls.Add(this.buttonDone_GAM);
            this.panelCondition__GAM.Controls.Add(this.buttonSave_GAM);
            this.panelCondition__GAM.Controls.Add(this.groupBoxInput_GAM);
            this.panelCondition__GAM.Controls.Add(this.buttonHelp_GAM);
            this.panelCondition__GAM.Controls.Add(this.groupBoxCondition_GAM);
            this.panelCondition__GAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition__GAM.Location = new System.Drawing.Point(0, 0);
            this.panelCondition__GAM.Name = "panelCondition__GAM";
            this.panelCondition__GAM.Size = new System.Drawing.Size(784, 107);
            this.panelCondition__GAM.TabIndex = 0;
            // 
            // buttonDone_GAM
            // 
            this.buttonDone_GAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_GAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_GAM.Location = new System.Drawing.Point(574, 28);
            this.buttonDone_GAM.Name = "buttonDone_GAM";
            this.buttonDone_GAM.Size = new System.Drawing.Size(75, 44);
            this.buttonDone_GAM.TabIndex = 0;
            this.buttonDone_GAM.Text = "Выполнить";
            this.buttonDone_GAM.UseVisualStyleBackColor = false;
            this.buttonDone_GAM.Click += new System.EventHandler(this.buttonDone_GAM_Click);
            // 
            // buttonSave_GAM
            // 
            this.buttonSave_GAM.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSave_GAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_GAM.Location = new System.Drawing.Point(655, 28);
            this.buttonSave_GAM.Name = "buttonSave_GAM";
            this.buttonSave_GAM.Size = new System.Drawing.Size(75, 44);
            this.buttonSave_GAM.TabIndex = 0;
            this.buttonSave_GAM.Text = "Сохранить";
            this.buttonSave_GAM.UseVisualStyleBackColor = false;
            this.buttonSave_GAM.Click += new System.EventHandler(this.buttonSave_GAM_Click);
            // 
            // groupBoxInput_GAM
            // 
            this.groupBoxInput_GAM.Controls.Add(this.labelstop_GAM);
            this.groupBoxInput_GAM.Controls.Add(this.labelstart_GAM);
            this.groupBoxInput_GAM.Controls.Add(this.textBoxstop_GAM);
            this.groupBoxInput_GAM.Controls.Add(this.textBoxstart_GAM);
            this.groupBoxInput_GAM.Location = new System.Drawing.Point(397, 20);
            this.groupBoxInput_GAM.Name = "groupBoxInput_GAM";
            this.groupBoxInput_GAM.Size = new System.Drawing.Size(171, 60);
            this.groupBoxInput_GAM.TabIndex = 2;
            this.groupBoxInput_GAM.TabStop = false;
            this.groupBoxInput_GAM.Text = "Ввод данных";
            // 
            // labelstop_GAM
            // 
            this.labelstop_GAM.AutoSize = true;
            this.labelstop_GAM.Location = new System.Drawing.Point(92, 16);
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
            // textBoxstop_GAM
            // 
            this.textBoxstop_GAM.Location = new System.Drawing.Point(95, 32);
            this.textBoxstop_GAM.Name = "textBoxstop_GAM";
            this.textBoxstop_GAM.Size = new System.Drawing.Size(70, 20);
            this.textBoxstop_GAM.TabIndex = 0;
            // 
            // textBoxstart_GAM
            // 
            this.textBoxstart_GAM.Location = new System.Drawing.Point(7, 32);
            this.textBoxstart_GAM.Name = "textBoxstart_GAM";
            this.textBoxstart_GAM.Size = new System.Drawing.Size(70, 20);
            this.textBoxstart_GAM.TabIndex = 0;
            // 
            // buttonHelp_GAM
            // 
            this.buttonHelp_GAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GAM.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonHelp_GAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_GAM.Location = new System.Drawing.Point(736, 28);
            this.buttonHelp_GAM.Name = "buttonHelp_GAM";
            this.buttonHelp_GAM.Size = new System.Drawing.Size(45, 44);
            this.buttonHelp_GAM.TabIndex = 0;
            this.buttonHelp_GAM.Text = "?";
            this.buttonHelp_GAM.UseVisualStyleBackColor = false;
            this.buttonHelp_GAM.Click += new System.EventHandler(this.buttonHelp_GAM_Click);
            // 
            // groupBoxCondition_GAM
            // 
            this.groupBoxCondition_GAM.Controls.Add(this.textBoxCondition_GAM);
            this.groupBoxCondition_GAM.Location = new System.Drawing.Point(13, 4);
            this.groupBoxCondition_GAM.Name = "groupBoxCondition_GAM";
            this.groupBoxCondition_GAM.Size = new System.Drawing.Size(373, 97);
            this.groupBoxCondition_GAM.TabIndex = 1;
            this.groupBoxCondition_GAM.TabStop = false;
            this.groupBoxCondition_GAM.Text = "Условие";
            // 
            // textBoxCondition_GAM
            // 
            this.textBoxCondition_GAM.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCondition_GAM.Location = new System.Drawing.Point(6, 16);
            this.textBoxCondition_GAM.Multiline = true;
            this.textBoxCondition_GAM.Name = "textBoxCondition_GAM";
            this.textBoxCondition_GAM.Size = new System.Drawing.Size(355, 75);
            this.textBoxCondition_GAM.TabIndex = 1;
            this.textBoxCondition_GAM.Text = resources.GetString("textBoxCondition_GAM.Text");
            // 
            // panelTable_GAM
            // 
            this.panelTable_GAM.BackColor = System.Drawing.SystemColors.Control;
            this.panelTable_GAM.Controls.Add(this.groupBoxResult_GAM);
            this.panelTable_GAM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTable_GAM.Location = new System.Drawing.Point(0, 107);
            this.panelTable_GAM.Name = "panelTable_GAM";
            this.panelTable_GAM.Size = new System.Drawing.Size(200, 304);
            this.panelTable_GAM.TabIndex = 0;
            // 
            // groupBoxResult_GAM
            // 
            this.groupBoxResult_GAM.Controls.Add(this.textBoxResult_GAM);
            this.groupBoxResult_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_GAM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_GAM.Name = "groupBoxResult_GAM";
            this.groupBoxResult_GAM.Size = new System.Drawing.Size(200, 304);
            this.groupBoxResult_GAM.TabIndex = 0;
            this.groupBoxResult_GAM.TabStop = false;
            this.groupBoxResult_GAM.Text = "Результат";
            // 
            // textBoxResult_GAM
            // 
            this.textBoxResult_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_GAM.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_GAM.Multiline = true;
            this.textBoxResult_GAM.Name = "textBoxResult_GAM";
            this.textBoxResult_GAM.ReadOnly = true;
            this.textBoxResult_GAM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GAM.Size = new System.Drawing.Size(194, 285);
            this.textBoxResult_GAM.TabIndex = 0;
            // 
            // splitterTandG_GAM
            // 
            this.splitterTandG_GAM.Location = new System.Drawing.Point(200, 107);
            this.splitterTandG_GAM.Name = "splitterTandG_GAM";
            this.splitterTandG_GAM.Size = new System.Drawing.Size(3, 304);
            this.splitterTandG_GAM.TabIndex = 1;
            this.splitterTandG_GAM.TabStop = false;
            // 
            // panelGraph_GAM
            // 
            this.panelGraph_GAM.Controls.Add(this.chartResult_GAM);
            this.panelGraph_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_GAM.Location = new System.Drawing.Point(203, 107);
            this.panelGraph_GAM.Name = "panelGraph_GAM";
            this.panelGraph_GAM.Size = new System.Drawing.Size(581, 304);
            this.panelGraph_GAM.TabIndex = 2;
            // 
            // chartResult_GAM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_GAM.ChartAreas.Add(chartArea1);
            this.chartResult_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_GAM.Legends.Add(legend1);
            this.chartResult_GAM.Location = new System.Drawing.Point(0, 0);
            this.chartResult_GAM.Name = "chartResult_GAM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_GAM.Series.Add(series1);
            this.chartResult_GAM.Size = new System.Drawing.Size(581, 304);
            this.chartResult_GAM.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.ForestGreen;
            title1.Name = "TitleFunction_GAM";
            title1.ShadowColor = System.Drawing.Color.Silver;
            title1.ShadowOffset = 3;
            title1.Text = "График функции F(x)";
            this.chartResult_GAM.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panelGraph_GAM);
            this.Controls.Add(this.splitterTandG_GAM);
            this.Controls.Add(this.panelTable_GAM);
            this.Controls.Add(this.panelCondition__GAM);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 1 | Григорян А.М.";
            this.panelCondition__GAM.ResumeLayout(false);
            this.groupBoxInput_GAM.ResumeLayout(false);
            this.groupBoxInput_GAM.PerformLayout();
            this.groupBoxCondition_GAM.ResumeLayout(false);
            this.groupBoxCondition_GAM.PerformLayout();
            this.panelTable_GAM.ResumeLayout(false);
            this.groupBoxResult_GAM.ResumeLayout(false);
            this.groupBoxResult_GAM.PerformLayout();
            this.panelGraph_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition__GAM;
        private System.Windows.Forms.Panel panelTable_GAM;
        private System.Windows.Forms.GroupBox groupBoxResult_GAM;
        private System.Windows.Forms.TextBox textBoxResult_GAM;
        private System.Windows.Forms.Splitter splitterTandG_GAM;
        private System.Windows.Forms.Panel panelGraph_GAM;
        private System.Windows.Forms.GroupBox groupBoxCondition_GAM;
        private System.Windows.Forms.Button buttonDone_GAM;
        private System.Windows.Forms.Button buttonHelp_GAM;
        private System.Windows.Forms.Button buttonSave_GAM;
        private System.Windows.Forms.GroupBox groupBoxInput_GAM;
        private System.Windows.Forms.TextBox textBoxstop_GAM;
        private System.Windows.Forms.TextBox textBoxstart_GAM;
        private System.Windows.Forms.TextBox textBoxCondition_GAM;
        private System.Windows.Forms.Label labelstop_GAM;
        private System.Windows.Forms.Label labelstart_GAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_GAM;
    }
}

