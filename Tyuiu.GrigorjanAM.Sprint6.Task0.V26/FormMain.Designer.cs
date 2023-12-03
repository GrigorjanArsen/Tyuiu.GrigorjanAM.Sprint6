
namespace Tyuiu.GrigorjanAM.Sprint6.Task0.V26
{
    partial class FormMainTask_GAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTask_GAM));
            this.groupBoxCondition_GAM = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_GAM = new System.Windows.Forms.PictureBox();
            this.textBoxTask_GAM = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_GAM = new System.Windows.Forms.GroupBox();
            this.labelinput_GAM = new System.Windows.Forms.Label();
            this.textBoxVARX_GAM = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_GAM = new System.Windows.Forms.GroupBox();
            this.labeloutput_GAM = new System.Windows.Forms.Label();
            this.textBoxResult_GAM = new System.Windows.Forms.TextBox();
            this.buttonDone_GAM = new System.Windows.Forms.Button();
            this.buttonHelp_GAM = new System.Windows.Forms.Button();
            this.groupBoxCondition_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GAM)).BeginInit();
            this.groupBoxInPut_GAM.SuspendLayout();
            this.groupBoxOutPut_GAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_GAM
            // 
            this.groupBoxCondition_GAM.Controls.Add(this.pictureBoxFormula_GAM);
            this.groupBoxCondition_GAM.Controls.Add(this.textBoxTask_GAM);
            this.groupBoxCondition_GAM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_GAM.Name = "groupBoxCondition_GAM";
            this.groupBoxCondition_GAM.Size = new System.Drawing.Size(457, 157);
            this.groupBoxCondition_GAM.TabIndex = 0;
            this.groupBoxCondition_GAM.TabStop = false;
            this.groupBoxCondition_GAM.Text = "Условие:";
            // 
            // pictureBoxFormula_GAM
            // 
            this.pictureBoxFormula_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_GAM.Image")));
            this.pictureBoxFormula_GAM.Location = new System.Drawing.Point(315, 53);
            this.pictureBoxFormula_GAM.Name = "pictureBoxFormula_GAM";
            this.pictureBoxFormula_GAM.Size = new System.Drawing.Size(115, 54);
            this.pictureBoxFormula_GAM.TabIndex = 1;
            this.pictureBoxFormula_GAM.TabStop = false;
            // 
            // textBoxTask_GAM
            // 
            this.textBoxTask_GAM.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_GAM.Multiline = true;
            this.textBoxTask_GAM.Name = "textBoxTask_GAM";
            this.textBoxTask_GAM.ReadOnly = true;
            this.textBoxTask_GAM.Size = new System.Drawing.Size(287, 131);
            this.textBoxTask_GAM.TabIndex = 0;
            this.textBoxTask_GAM.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPut_GAM
            // 
            this.groupBoxInPut_GAM.Controls.Add(this.labelinput_GAM);
            this.groupBoxInPut_GAM.Controls.Add(this.textBoxVARX_GAM);
            this.groupBoxInPut_GAM.Location = new System.Drawing.Point(12, 187);
            this.groupBoxInPut_GAM.Name = "groupBoxInPut_GAM";
            this.groupBoxInPut_GAM.Size = new System.Drawing.Size(132, 76);
            this.groupBoxInPut_GAM.TabIndex = 1;
            this.groupBoxInPut_GAM.TabStop = false;
            this.groupBoxInPut_GAM.Text = "Ввод данных";
            // 
            // labelinput_GAM
            // 
            this.labelinput_GAM.AutoSize = true;
            this.labelinput_GAM.Location = new System.Drawing.Point(7, 25);
            this.labelinput_GAM.Name = "labelinput_GAM";
            this.labelinput_GAM.Size = new System.Drawing.Size(84, 13);
            this.labelinput_GAM.TabIndex = 1;
            this.labelinput_GAM.Text = "Переменная X:";
            // 
            // textBoxVARX_GAM
            // 
            this.textBoxVARX_GAM.Location = new System.Drawing.Point(10, 40);
            this.textBoxVARX_GAM.Name = "textBoxVARX_GAM";
            this.textBoxVARX_GAM.Size = new System.Drawing.Size(81, 20);
            this.textBoxVARX_GAM.TabIndex = 0;
            this.textBoxVARX_GAM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVARX_GAM_KeyPress);
            // 
            // groupBoxOutPut_GAM
            // 
            this.groupBoxOutPut_GAM.Controls.Add(this.labeloutput_GAM);
            this.groupBoxOutPut_GAM.Controls.Add(this.textBoxResult_GAM);
            this.groupBoxOutPut_GAM.Location = new System.Drawing.Point(324, 187);
            this.groupBoxOutPut_GAM.Name = "groupBoxOutPut_GAM";
            this.groupBoxOutPut_GAM.Size = new System.Drawing.Size(145, 76);
            this.groupBoxOutPut_GAM.TabIndex = 1;
            this.groupBoxOutPut_GAM.TabStop = false;
            this.groupBoxOutPut_GAM.Text = "Вывод данных";
            // 
            // labeloutput_GAM
            // 
            this.labeloutput_GAM.AutoSize = true;
            this.labeloutput_GAM.Location = new System.Drawing.Point(6, 25);
            this.labeloutput_GAM.Name = "labeloutput_GAM";
            this.labeloutput_GAM.Size = new System.Drawing.Size(59, 13);
            this.labeloutput_GAM.TabIndex = 1;
            this.labeloutput_GAM.Text = "Результат";
            // 
            // textBoxResult_GAM
            // 
            this.textBoxResult_GAM.Location = new System.Drawing.Point(6, 41);
            this.textBoxResult_GAM.Name = "textBoxResult_GAM";
            this.textBoxResult_GAM.ReadOnly = true;
            this.textBoxResult_GAM.Size = new System.Drawing.Size(77, 20);
            this.textBoxResult_GAM.TabIndex = 0;
            // 
            // buttonDone_GAM
            // 
            this.buttonDone_GAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_GAM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDone_GAM.Location = new System.Drawing.Point(372, 280);
            this.buttonDone_GAM.Name = "buttonDone_GAM";
            this.buttonDone_GAM.Size = new System.Drawing.Size(97, 32);
            this.buttonDone_GAM.TabIndex = 2;
            this.buttonDone_GAM.Text = "Выполнить";
            this.buttonDone_GAM.UseVisualStyleBackColor = true;
            this.buttonDone_GAM.Click += new System.EventHandler(this.buttonDone_GAM_Click);
            // 
            // buttonHelp_GAM
            // 
            this.buttonHelp_GAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_GAM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelp_GAM.Location = new System.Drawing.Point(333, 280);
            this.buttonHelp_GAM.Name = "buttonHelp_GAM";
            this.buttonHelp_GAM.Size = new System.Drawing.Size(32, 32);
            this.buttonHelp_GAM.TabIndex = 3;
            this.buttonHelp_GAM.Text = "?";
            this.buttonHelp_GAM.UseVisualStyleBackColor = true;
            this.buttonHelp_GAM.Click += new System.EventHandler(this.buttonHelp_GAM_Click);
            // 
            // FormMainTask_GAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.buttonHelp_GAM);
            this.Controls.Add(this.buttonDone_GAM);
            this.Controls.Add(this.groupBoxOutPut_GAM);
            this.Controls.Add(this.groupBoxInPut_GAM);
            this.Controls.Add(this.groupBoxCondition_GAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainTask_GAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Григорян А. М.";
            this.groupBoxCondition_GAM.ResumeLayout(false);
            this.groupBoxCondition_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GAM)).EndInit();
            this.groupBoxInPut_GAM.ResumeLayout(false);
            this.groupBoxInPut_GAM.PerformLayout();
            this.groupBoxOutPut_GAM.ResumeLayout(false);
            this.groupBoxOutPut_GAM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_GAM;
        private System.Windows.Forms.PictureBox pictureBoxFormula_GAM;
        private System.Windows.Forms.TextBox textBoxTask_GAM;
        private System.Windows.Forms.GroupBox groupBoxInPut_GAM;
        private System.Windows.Forms.Label labelinput_GAM;
        private System.Windows.Forms.TextBox textBoxVARX_GAM;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GAM;
        private System.Windows.Forms.Label labeloutput_GAM;
        private System.Windows.Forms.TextBox textBoxResult_GAM;
        private System.Windows.Forms.Button buttonDone_GAM;
        private System.Windows.Forms.Button buttonHelp_GAM;
    }
}

