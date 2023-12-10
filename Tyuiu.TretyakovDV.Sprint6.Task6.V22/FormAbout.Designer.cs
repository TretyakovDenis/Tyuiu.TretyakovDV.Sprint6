
namespace Tyuiu.TretyakovDV.Sprint6.Task6.V22
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
            this.pictureBoxInfo_TDV = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_TDV = new System.Windows.Forms.TextBox();
            this.buttonOk_TDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_TDV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInfo_TDV
            // 
            resources.ApplyResources(this.pictureBoxInfo_TDV, "pictureBoxInfo_TDV");
            this.pictureBoxInfo_TDV.Name = "pictureBoxInfo_TDV";
            this.pictureBoxInfo_TDV.TabStop = false;
            // 
            // textBoxInfo_TDV
            // 
            this.textBoxInfo_TDV.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBoxInfo_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxInfo_TDV, "textBoxInfo_TDV");
            this.textBoxInfo_TDV.Name = "textBoxInfo_TDV";
            this.textBoxInfo_TDV.ReadOnly = true;
            // 
            // buttonOk_TDV
            // 
            this.buttonOk_TDV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.buttonOk_TDV, "buttonOk_TDV");
            this.buttonOk_TDV.Name = "buttonOk_TDV";
            this.buttonOk_TDV.UseVisualStyleBackColor = false;
            this.buttonOk_TDV.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAbout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.buttonOk_TDV);
            this.Controls.Add(this.textBoxInfo_TDV);
            this.Controls.Add(this.pictureBoxInfo_TDV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_TDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfo_TDV;
        private System.Windows.Forms.TextBox textBoxInfo_TDV;
        private System.Windows.Forms.Button buttonOk_TDV;
    }
}