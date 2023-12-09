
namespace Tyuiu.GrigorjanAM.Sprint6.Task7.V25
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_GAM = new System.Windows.Forms.PictureBox();
            this.buttonOK_GAM = new System.Windows.Forms.Button();
            this.labelInfo_GAM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_GAM
            // 
            this.pictureBoxAvatar_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_GAM.BackgroundImage")));
            this.pictureBoxAvatar_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAvatar_GAM.Location = new System.Drawing.Point(2, 12);
            this.pictureBoxAvatar_GAM.Name = "pictureBoxAvatar_GAM";
            this.pictureBoxAvatar_GAM.Size = new System.Drawing.Size(138, 132);
            this.pictureBoxAvatar_GAM.TabIndex = 6;
            this.pictureBoxAvatar_GAM.TabStop = false;
            // 
            // buttonOK_GAM
            // 
            this.buttonOK_GAM.Location = new System.Drawing.Point(345, 133);
            this.buttonOK_GAM.Name = "buttonOK_GAM";
            this.buttonOK_GAM.Size = new System.Drawing.Size(75, 26);
            this.buttonOK_GAM.TabIndex = 5;
            this.buttonOK_GAM.Text = "OK";
            this.buttonOK_GAM.UseVisualStyleBackColor = true;
            this.buttonOK_GAM.Click += new System.EventHandler(this.buttonOK_GAM_Click);
            // 
            // labelInfo_GAM
            // 
            this.labelInfo_GAM.AutoSize = true;
            this.labelInfo_GAM.Location = new System.Drawing.Point(146, 0);
            this.labelInfo_GAM.Name = "labelInfo_GAM";
            this.labelInfo_GAM.Size = new System.Drawing.Size(284, 130);
            this.labelInfo_GAM.TabIndex = 4;
            this.labelInfo_GAM.Text = resources.GetString("labelInfo_GAM.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.pictureBoxAvatar_GAM);
            this.Controls.Add(this.buttonOK_GAM);
            this.Controls.Add(this.labelInfo_GAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_GAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_GAM;
        private System.Windows.Forms.Button buttonOK_GAM;
        private System.Windows.Forms.Label labelInfo_GAM;
    }
}