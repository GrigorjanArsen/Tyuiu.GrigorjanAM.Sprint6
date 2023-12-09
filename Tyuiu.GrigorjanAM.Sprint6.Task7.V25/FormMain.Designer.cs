
namespace Tyuiu.GrigorjanAM.Sprint6.Task7.V25
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_GAM = new System.Windows.Forms.Panel();
            this.panelCondition_GAM = new System.Windows.Forms.Panel();
            this.panelInPut_GAM = new System.Windows.Forms.Panel();
            this.panelOutPut_GAM = new System.Windows.Forms.Panel();
            this.buttonOpenFile_GAM = new System.Windows.Forms.Button();
            this.buttonDone_GAM = new System.Windows.Forms.Button();
            this.buttonHelp_GAM = new System.Windows.Forms.Button();
            this.buttonSave_GAM = new System.Windows.Forms.Button();
            this.splitterINandOUT_GAM = new System.Windows.Forms.Splitter();
            this.groupBoxCondition_GAM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_GAM = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_GAM = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_GAM = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_GAM = new System.Windows.Forms.DataGridView();
            this.Columns_GAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOutPut_GAM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialogTask_GAM = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogMatrix_GAM = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_GAM = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButtons_GAM = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_GAM.SuspendLayout();
            this.panelCondition_GAM.SuspendLayout();
            this.panelInPut_GAM.SuspendLayout();
            this.panelOutPut_GAM.SuspendLayout();
            this.groupBoxCondition_GAM.SuspendLayout();
            this.groupBoxInPut_GAM.SuspendLayout();
            this.groupBoxOutPut_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_GAM
            // 
            this.panelButtons_GAM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelButtons_GAM.Controls.Add(this.buttonHelp_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonSave_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonDone_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonOpenFile_GAM);
            this.panelButtons_GAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_GAM.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_GAM.Name = "panelButtons_GAM";
            this.panelButtons_GAM.Size = new System.Drawing.Size(814, 66);
            this.panelButtons_GAM.TabIndex = 0;
            // 
            // panelCondition_GAM
            // 
            this.panelCondition_GAM.BackColor = System.Drawing.Color.DarkGray;
            this.panelCondition_GAM.Controls.Add(this.groupBoxCondition_GAM);
            this.panelCondition_GAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_GAM.Location = new System.Drawing.Point(0, 66);
            this.panelCondition_GAM.Name = "panelCondition_GAM";
            this.panelCondition_GAM.Size = new System.Drawing.Size(814, 77);
            this.panelCondition_GAM.TabIndex = 1;
            // 
            // panelInPut_GAM
            // 
            this.panelInPut_GAM.BackColor = System.Drawing.Color.Silver;
            this.panelInPut_GAM.Controls.Add(this.groupBoxInPut_GAM);
            this.panelInPut_GAM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_GAM.Location = new System.Drawing.Point(0, 143);
            this.panelInPut_GAM.Name = "panelInPut_GAM";
            this.panelInPut_GAM.Size = new System.Drawing.Size(407, 268);
            this.panelInPut_GAM.TabIndex = 2;
            // 
            // panelOutPut_GAM
            // 
            this.panelOutPut_GAM.BackColor = System.Drawing.Color.Silver;
            this.panelOutPut_GAM.Controls.Add(this.groupBoxOutPut_GAM);
            this.panelOutPut_GAM.Controls.Add(this.splitterINandOUT_GAM);
            this.panelOutPut_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_GAM.Location = new System.Drawing.Point(407, 143);
            this.panelOutPut_GAM.Name = "panelOutPut_GAM";
            this.panelOutPut_GAM.Size = new System.Drawing.Size(407, 268);
            this.panelOutPut_GAM.TabIndex = 2;
            // 
            // buttonOpenFile_GAM
            // 
            this.buttonOpenFile_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_GAM.BackgroundImage")));
            this.buttonOpenFile_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_GAM.Location = new System.Drawing.Point(12, 5);
            this.buttonOpenFile_GAM.Name = "buttonOpenFile_GAM";
            this.buttonOpenFile_GAM.Size = new System.Drawing.Size(58, 58);
            this.buttonOpenFile_GAM.TabIndex = 0;
            this.toolTipButtons_GAM.SetToolTip(this.buttonOpenFile_GAM, "Открыть файл в формате .csv для обработки данных");
            this.buttonOpenFile_GAM.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GAM.Click += new System.EventHandler(this.buttonOpenFile_GAM_Click);
            this.buttonOpenFile_GAM.MouseEnter += new System.EventHandler(this.buttonOpenFile_GAM_MouseEnter);
            // 
            // buttonDone_GAM
            // 
            this.buttonDone_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone_GAM.BackgroundImage")));
            this.buttonDone_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_GAM.Enabled = false;
            this.buttonDone_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_GAM.Location = new System.Drawing.Point(76, 5);
            this.buttonDone_GAM.Name = "buttonDone_GAM";
            this.buttonDone_GAM.Size = new System.Drawing.Size(58, 58);
            this.buttonDone_GAM.TabIndex = 0;
            this.toolTipButtons_GAM.SetToolTip(this.buttonDone_GAM, "Выполнить обработку данных");
            this.buttonDone_GAM.UseVisualStyleBackColor = true;
            this.buttonDone_GAM.Click += new System.EventHandler(this.buttonDone_GAM_Click);
            this.buttonDone_GAM.MouseEnter += new System.EventHandler(this.buttonDone_GAM_MouseEnter);
            // 
            // buttonHelp_GAM
            // 
            this.buttonHelp_GAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_GAM.BackgroundImage")));
            this.buttonHelp_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_GAM.Location = new System.Drawing.Point(744, 5);
            this.buttonHelp_GAM.Name = "buttonHelp_GAM";
            this.buttonHelp_GAM.Size = new System.Drawing.Size(58, 58);
            this.buttonHelp_GAM.TabIndex = 0;
            this.toolTipButtons_GAM.SetToolTip(this.buttonHelp_GAM, "Сведения о программе");
            this.buttonHelp_GAM.UseVisualStyleBackColor = true;
            this.buttonHelp_GAM.Click += new System.EventHandler(this.buttonHelp_GAM_Click);
            this.buttonHelp_GAM.MouseEnter += new System.EventHandler(this.buttonHelp_GAM_MouseEnter);
            // 
            // buttonSave_GAM
            // 
            this.buttonSave_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave_GAM.BackgroundImage")));
            this.buttonSave_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave_GAM.Enabled = false;
            this.buttonSave_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_GAM.Location = new System.Drawing.Point(140, 5);
            this.buttonSave_GAM.Name = "buttonSave_GAM";
            this.buttonSave_GAM.Size = new System.Drawing.Size(58, 58);
            this.buttonSave_GAM.TabIndex = 0;
            this.toolTipButtons_GAM.SetToolTip(this.buttonSave_GAM, "Сохранить обработанные данные в файл формата .csv");
            this.buttonSave_GAM.UseVisualStyleBackColor = true;
            this.buttonSave_GAM.Click += new System.EventHandler(this.buttonSave_GAM_Click);
            this.buttonSave_GAM.MouseEnter += new System.EventHandler(this.buttonSave_GAM_MouseEnter);
            // 
            // splitterINandOUT_GAM
            // 
            this.splitterINandOUT_GAM.Location = new System.Drawing.Point(0, 0);
            this.splitterINandOUT_GAM.Name = "splitterINandOUT_GAM";
            this.splitterINandOUT_GAM.Size = new System.Drawing.Size(3, 268);
            this.splitterINandOUT_GAM.TabIndex = 0;
            this.splitterINandOUT_GAM.TabStop = false;
            // 
            // groupBoxCondition_GAM
            // 
            this.groupBoxCondition_GAM.Controls.Add(this.textBoxCondition_GAM);
            this.groupBoxCondition_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_GAM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_GAM.Name = "groupBoxCondition_GAM";
            this.groupBoxCondition_GAM.Size = new System.Drawing.Size(814, 77);
            this.groupBoxCondition_GAM.TabIndex = 0;
            this.groupBoxCondition_GAM.TabStop = false;
            this.groupBoxCondition_GAM.Text = "Условие";
            // 
            // textBoxCondition_GAM
            // 
            this.textBoxCondition_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition_GAM.Location = new System.Drawing.Point(3, 16);
            this.textBoxCondition_GAM.Multiline = true;
            this.textBoxCondition_GAM.Name = "textBoxCondition_GAM";
            this.textBoxCondition_GAM.ReadOnly = true;
            this.textBoxCondition_GAM.Size = new System.Drawing.Size(808, 58);
            this.textBoxCondition_GAM.TabIndex = 0;
            this.textBoxCondition_GAM.Text = resources.GetString("textBoxCondition_GAM.Text");
            // 
            // groupBoxInPut_GAM
            // 
            this.groupBoxInPut_GAM.Controls.Add(this.dataGridViewInPut_GAM);
            this.groupBoxInPut_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_GAM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_GAM.Name = "groupBoxInPut_GAM";
            this.groupBoxInPut_GAM.Size = new System.Drawing.Size(407, 268);
            this.groupBoxInPut_GAM.TabIndex = 0;
            this.groupBoxInPut_GAM.TabStop = false;
            this.groupBoxInPut_GAM.Text = "Ввод:";
            // 
            // groupBoxOutPut_GAM
            // 
            this.groupBoxOutPut_GAM.Controls.Add(this.dataGridViewOutPut_GAM);
            this.groupBoxOutPut_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GAM.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOutPut_GAM.Name = "groupBoxOutPut_GAM";
            this.groupBoxOutPut_GAM.Size = new System.Drawing.Size(404, 268);
            this.groupBoxOutPut_GAM.TabIndex = 0;
            this.groupBoxOutPut_GAM.TabStop = false;
            this.groupBoxOutPut_GAM.Text = "Вывод:";
            // 
            // dataGridViewInPut_GAM
            // 
            this.dataGridViewInPut_GAM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInPut_GAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_GAM.ColumnHeadersVisible = false;
            this.dataGridViewInPut_GAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columns_GAM});
            this.dataGridViewInPut_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_GAM.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_GAM.Name = "dataGridViewInPut_GAM";
            this.dataGridViewInPut_GAM.ReadOnly = true;
            this.dataGridViewInPut_GAM.RowHeadersVisible = false;
            this.dataGridViewInPut_GAM.Size = new System.Drawing.Size(401, 249);
            this.dataGridViewInPut_GAM.TabIndex = 0;
            // 
            // Columns_GAM
            // 
            this.Columns_GAM.HeaderText = "";
            this.Columns_GAM.Name = "Columns_GAM";
            this.Columns_GAM.ReadOnly = true;
            this.Columns_GAM.Visible = false;
            // 
            // dataGridViewOutPut_GAM
            // 
            this.dataGridViewOutPut_GAM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOutPut_GAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_GAM.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_GAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewOutPut_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_GAM.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_GAM.Name = "dataGridViewOutPut_GAM";
            this.dataGridViewOutPut_GAM.ReadOnly = true;
            this.dataGridViewOutPut_GAM.RowHeadersVisible = false;
            this.dataGridViewOutPut_GAM.Size = new System.Drawing.Size(398, 249);
            this.dataGridViewOutPut_GAM.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // openFileDialogTask_GAM
            // 
            this.openFileDialogTask_GAM.FileName = "openFileDialog1";
            // 
            // openFileDialogMatrix_GAM
            // 
            this.openFileDialogMatrix_GAM.FileName = "openFileDialog1";
            // 
            // toolTipButtons_GAM
            // 
            this.toolTipButtons_GAM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTipButtons_GAM.IsBalloon = true;
            this.toolTipButtons_GAM.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_GAM.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 411);
            this.Controls.Add(this.panelOutPut_GAM);
            this.Controls.Add(this.panelInPut_GAM);
            this.Controls.Add(this.panelCondition_GAM);
            this.Controls.Add(this.panelButtons_GAM);
            this.MinimumSize = new System.Drawing.Size(830, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 25 | Григорян А.М.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_GAM.ResumeLayout(false);
            this.panelCondition_GAM.ResumeLayout(false);
            this.panelInPut_GAM.ResumeLayout(false);
            this.panelOutPut_GAM.ResumeLayout(false);
            this.groupBoxCondition_GAM.ResumeLayout(false);
            this.groupBoxCondition_GAM.PerformLayout();
            this.groupBoxInPut_GAM.ResumeLayout(false);
            this.groupBoxOutPut_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_GAM;
        private System.Windows.Forms.Panel panelCondition_GAM;
        private System.Windows.Forms.Panel panelInPut_GAM;
        private System.Windows.Forms.Panel panelOutPut_GAM;
        private System.Windows.Forms.Button buttonHelp_GAM;
        private System.Windows.Forms.Button buttonSave_GAM;
        private System.Windows.Forms.Button buttonDone_GAM;
        private System.Windows.Forms.Button buttonOpenFile_GAM;
        private System.Windows.Forms.Splitter splitterINandOUT_GAM;
        private System.Windows.Forms.GroupBox groupBoxCondition_GAM;
        private System.Windows.Forms.TextBox textBoxCondition_GAM;
        private System.Windows.Forms.GroupBox groupBoxInPut_GAM;
        private System.Windows.Forms.DataGridView dataGridViewInPut_GAM;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columns_GAM;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_GAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GAM;
        private System.Windows.Forms.OpenFileDialog openFileDialogMatrix_GAM;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_GAM;
        private System.Windows.Forms.ToolTip toolTipButtons_GAM;
    }
}

