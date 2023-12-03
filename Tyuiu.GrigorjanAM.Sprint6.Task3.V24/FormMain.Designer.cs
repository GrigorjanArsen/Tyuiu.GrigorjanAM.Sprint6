
namespace Tyuiu.GrigorjanAM.Sprint6.Task3.V24
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
            this.groupBoxCondition_GAM = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_GAM = new System.Windows.Forms.DataGridView();
            this.buttonDone_GAM = new System.Windows.Forms.Button();
            this.buttonHelp_GAM = new System.Windows.Forms.Button();
            this.groupBoxOutPut_GAM = new System.Windows.Forms.GroupBox();
            this.textBoxResult_GAM = new System.Windows.Forms.TextBox();
            this.labelResult_GAM = new System.Windows.Forms.Label();
            this.groupBoxCondition_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_GAM)).BeginInit();
            this.groupBoxOutPut_GAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_GAM
            // 
            this.groupBoxCondition_GAM.Controls.Add(this.dataGridViewMatrix_GAM);
            this.groupBoxCondition_GAM.Controls.Add(this.textBox1);
            this.groupBoxCondition_GAM.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_GAM.Name = "groupBoxCondition_GAM";
            this.groupBoxCondition_GAM.Size = new System.Drawing.Size(454, 208);
            this.groupBoxCondition_GAM.TabIndex = 0;
            this.groupBoxCondition_GAM.TabStop = false;
            this.groupBoxCondition_GAM.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(238, 182);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dataGridViewMatrix_GAM
            // 
            this.dataGridViewMatrix_GAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_GAM.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_GAM.Location = new System.Drawing.Point(252, 20);
            this.dataGridViewMatrix_GAM.Name = "dataGridViewMatrix_GAM";
            this.dataGridViewMatrix_GAM.RowHeadersVisible = false;
            this.dataGridViewMatrix_GAM.Size = new System.Drawing.Size(196, 182);
            this.dataGridViewMatrix_GAM.TabIndex = 1;
            // 
            // buttonDone_GAM
            // 
            this.buttonDone_GAM.Location = new System.Drawing.Point(514, 192);
            this.buttonDone_GAM.Name = "buttonDone_GAM";
            this.buttonDone_GAM.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_GAM.TabIndex = 1;
            this.buttonDone_GAM.Text = "Выполнить";
            this.buttonDone_GAM.UseVisualStyleBackColor = true;
            this.buttonDone_GAM.Click += new System.EventHandler(this.buttonDone_GAM_Click);
            // 
            // buttonHelp_GAM
            // 
            this.buttonHelp_GAM.Location = new System.Drawing.Point(474, 192);
            this.buttonHelp_GAM.Name = "buttonHelp_GAM";
            this.buttonHelp_GAM.Size = new System.Drawing.Size(24, 23);
            this.buttonHelp_GAM.TabIndex = 2;
            this.buttonHelp_GAM.Text = "?";
            this.buttonHelp_GAM.UseVisualStyleBackColor = true;
            this.buttonHelp_GAM.Click += new System.EventHandler(this.buttonHelp_GAM_Click);
            // 
            // groupBoxOutPut_GAM
            // 
            this.groupBoxOutPut_GAM.Controls.Add(this.labelResult_GAM);
            this.groupBoxOutPut_GAM.Controls.Add(this.textBoxResult_GAM);
            this.groupBoxOutPut_GAM.Location = new System.Drawing.Point(474, 13);
            this.groupBoxOutPut_GAM.Name = "groupBoxOutPut_GAM";
            this.groupBoxOutPut_GAM.Size = new System.Drawing.Size(115, 173);
            this.groupBoxOutPut_GAM.TabIndex = 3;
            this.groupBoxOutPut_GAM.TabStop = false;
            this.groupBoxOutPut_GAM.Text = "Вывод данных";
            // 
            // textBoxResult_GAM
            // 
            this.textBoxResult_GAM.Location = new System.Drawing.Point(9, 39);
            this.textBoxResult_GAM.Name = "textBoxResult_GAM";
            this.textBoxResult_GAM.ReadOnly = true;
            this.textBoxResult_GAM.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_GAM.TabIndex = 0;
            this.textBoxResult_GAM.TabStop = false;
            this.textBoxResult_GAM.Text = "Не выполнено";
            // 
            // labelResult_GAM
            // 
            this.labelResult_GAM.AutoSize = true;
            this.labelResult_GAM.Location = new System.Drawing.Point(6, 23);
            this.labelResult_GAM.Name = "labelResult_GAM";
            this.labelResult_GAM.Size = new System.Drawing.Size(62, 13);
            this.labelResult_GAM.TabIndex = 0;
            this.labelResult_GAM.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 233);
            this.Controls.Add(this.groupBoxOutPut_GAM);
            this.Controls.Add(this.buttonHelp_GAM);
            this.Controls.Add(this.buttonDone_GAM);
            this.Controls.Add(this.groupBoxCondition_GAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 23 | Григорян А. М.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_GAM.ResumeLayout(false);
            this.groupBoxCondition_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_GAM)).EndInit();
            this.groupBoxOutPut_GAM.ResumeLayout(false);
            this.groupBoxOutPut_GAM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_GAM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_GAM;
        private System.Windows.Forms.Button buttonDone_GAM;
        private System.Windows.Forms.Button buttonHelp_GAM;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GAM;
        private System.Windows.Forms.Label labelResult_GAM;
        private System.Windows.Forms.TextBox textBoxResult_GAM;
    }
}

