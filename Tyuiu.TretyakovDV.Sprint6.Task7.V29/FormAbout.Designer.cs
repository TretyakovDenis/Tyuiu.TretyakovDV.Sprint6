
namespace Tyuiu.TretyakovDV.Sprint6.Task7.V29
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
            this.buttonOk_TDV = new System.Windows.Forms.Button();
            this.textBoxInfo_TDV = new System.Windows.Forms.TextBox();
            this.pictureBoxInfo_TDV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_TDV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_TDV
            // 
            this.buttonOk_TDV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOk_TDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_TDV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOk_TDV.Location = new System.Drawing.Point(401, 252);
            this.buttonOk_TDV.Name = "buttonOk_TDV";
            this.buttonOk_TDV.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_TDV.TabIndex = 5;
            this.buttonOk_TDV.Text = "ОК";
            this.buttonOk_TDV.UseVisualStyleBackColor = false;
            this.buttonOk_TDV.Click += new System.EventHandler(this.buttonOk_TDV_Click);
            // 
            // textBoxInfo_TDV
            // 
            this.textBoxInfo_TDV.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBoxInfo_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_TDV.Location = new System.Drawing.Point(187, 11);
            this.textBoxInfo_TDV.Multiline = true;
            this.textBoxInfo_TDV.Name = "textBoxInfo_TDV";
            this.textBoxInfo_TDV.ReadOnly = true;
            this.textBoxInfo_TDV.Size = new System.Drawing.Size(289, 264);
            this.textBoxInfo_TDV.TabIndex = 4;
            this.textBoxInfo_TDV.Text = resources.GetString("textBoxInfo_TDV.Text");
            // 
            // pictureBoxInfo_TDV
            // 
            this.pictureBoxInfo_TDV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo_TDV.Image")));
            this.pictureBoxInfo_TDV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxInfo_TDV.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInfo_TDV.Name = "pictureBoxInfo_TDV";
            this.pictureBoxInfo_TDV.Size = new System.Drawing.Size(169, 263);
            this.pictureBoxInfo_TDV.TabIndex = 3;
            this.pictureBoxInfo_TDV.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(485, 284);
            this.Controls.Add(this.buttonOk_TDV);
            this.Controls.Add(this.textBoxInfo_TDV);
            this.Controls.Add(this.pictureBoxInfo_TDV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсказка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_TDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_TDV;
        private System.Windows.Forms.TextBox textBoxInfo_TDV;
        private System.Windows.Forms.PictureBox pictureBoxInfo_TDV;
    }
}