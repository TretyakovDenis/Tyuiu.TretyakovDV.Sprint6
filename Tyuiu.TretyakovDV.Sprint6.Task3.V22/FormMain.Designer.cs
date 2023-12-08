
namespace Tyuiu.TretyakovDV.Sprint6.Task2.V4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxTask_TDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_TDV = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_TDV = new System.Windows.Forms.GroupBox();
            this.buttonClick_TDV = new System.Windows.Forms.Button();
            this.buttonHelp_TDV = new System.Windows.Forms.Button();
            this.textBoxResultInfo_TDV = new System.Windows.Forms.TextBox();
            this.pictureBoxData_TDV = new System.Windows.Forms.PictureBox();
            this.dataGridViewResult_TDV = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_TDV)).BeginInit();
            this.groupBoxResult_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData_TDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_TDV
            // 
            this.groupBoxTask_TDV.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxTask_TDV.Controls.Add(this.pictureBoxData_TDV);
            this.groupBoxTask_TDV.Controls.Add(this.dataGridViewMatrix_TDV);
            this.groupBoxTask_TDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_TDV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_TDV.Name = "groupBoxTask_TDV";
            this.groupBoxTask_TDV.Size = new System.Drawing.Size(1012, 327);
            this.groupBoxTask_TDV.TabIndex = 8;
            this.groupBoxTask_TDV.TabStop = false;
            this.groupBoxTask_TDV.Text = "Условие";
            // 
            // dataGridViewMatrix_TDV
            // 
            this.dataGridViewMatrix_TDV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewMatrix_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrix_TDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_TDV.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_TDV.Location = new System.Drawing.Point(752, 51);
            this.dataGridViewMatrix_TDV.Name = "dataGridViewMatrix_TDV";
            this.dataGridViewMatrix_TDV.ReadOnly = true;
            this.dataGridViewMatrix_TDV.RowHeadersVisible = false;
            this.dataGridViewMatrix_TDV.Size = new System.Drawing.Size(254, 254);
            this.dataGridViewMatrix_TDV.TabIndex = 1;
            // 
            // groupBoxResult_TDV
            // 
            this.groupBoxResult_TDV.Controls.Add(this.dataGridViewResult_TDV);
            this.groupBoxResult_TDV.Controls.Add(this.textBoxResultInfo_TDV);
            this.groupBoxResult_TDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_TDV.Location = new System.Drawing.Point(1030, 12);
            this.groupBoxResult_TDV.Name = "groupBoxResult_TDV";
            this.groupBoxResult_TDV.Size = new System.Drawing.Size(270, 327);
            this.groupBoxResult_TDV.TabIndex = 9;
            this.groupBoxResult_TDV.TabStop = false;
            this.groupBoxResult_TDV.Text = "Вывод данных";
            // 
            // buttonClick_TDV
            // 
            this.buttonClick_TDV.BackColor = System.Drawing.Color.Green;
            this.buttonClick_TDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClick_TDV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick_TDV.Location = new System.Drawing.Point(1132, 345);
            this.buttonClick_TDV.Name = "buttonClick_TDV";
            this.buttonClick_TDV.Size = new System.Drawing.Size(168, 93);
            this.buttonClick_TDV.TabIndex = 11;
            this.buttonClick_TDV.Text = "Выполнить";
            this.buttonClick_TDV.UseVisualStyleBackColor = false;
            this.buttonClick_TDV.Click += new System.EventHandler(this.buttonClick_TDV_Click);
            // 
            // buttonHelp_TDV
            // 
            this.buttonHelp_TDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_TDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_TDV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_TDV.Location = new System.Drawing.Point(1030, 345);
            this.buttonHelp_TDV.Name = "buttonHelp_TDV";
            this.buttonHelp_TDV.Size = new System.Drawing.Size(93, 93);
            this.buttonHelp_TDV.TabIndex = 10;
            this.buttonHelp_TDV.Text = "Справка";
            this.buttonHelp_TDV.UseVisualStyleBackColor = false;
            this.buttonHelp_TDV.Click += new System.EventHandler(this.buttonHelp_TDV_Click);
            // 
            // textBoxResultInfo_TDV
            // 
            this.textBoxResultInfo_TDV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResultInfo_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultInfo_TDV.Location = new System.Drawing.Point(7, 26);
            this.textBoxResultInfo_TDV.Name = "textBoxResultInfo_TDV";
            this.textBoxResultInfo_TDV.Size = new System.Drawing.Size(100, 19);
            this.textBoxResultInfo_TDV.TabIndex = 1;
            this.textBoxResultInfo_TDV.Text = "Результат:";
            // 
            // pictureBoxData_TDV
            // 
            this.pictureBoxData_TDV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxData_TDV.Image")));
            this.pictureBoxData_TDV.Location = new System.Drawing.Point(7, 26);
            this.pictureBoxData_TDV.Name = "pictureBoxData_TDV";
            this.pictureBoxData_TDV.Size = new System.Drawing.Size(697, 279);
            this.pictureBoxData_TDV.TabIndex = 2;
            this.pictureBoxData_TDV.TabStop = false;
            // 
            // dataGridViewResult_TDV
            // 
            this.dataGridViewResult_TDV.AllowUserToResizeColumns = false;
            this.dataGridViewResult_TDV.AllowUserToResizeRows = false;
            this.dataGridViewResult_TDV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewResult_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult_TDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_TDV.ColumnHeadersVisible = false;
            this.dataGridViewResult_TDV.Location = new System.Drawing.Point(7, 51);
            this.dataGridViewResult_TDV.Name = "dataGridViewResult_TDV";
            this.dataGridViewResult_TDV.ReadOnly = true;
            this.dataGridViewResult_TDV.RowHeadersVisible = false;
            this.dataGridViewResult_TDV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewResult_TDV.Size = new System.Drawing.Size(254, 254);
            this.dataGridViewResult_TDV.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 450);
            this.Controls.Add(this.buttonClick_TDV);
            this.Controls.Add(this.buttonHelp_TDV);
            this.Controls.Add(this.groupBoxResult_TDV);
            this.Controls.Add(this.groupBoxTask_TDV);
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск 3 | Вариант 22 | Третьяков Д. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_TDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_TDV)).EndInit();
            this.groupBoxResult_TDV.ResumeLayout(false);
            this.groupBoxResult_TDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData_TDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_TDV;
        private System.Windows.Forms.GroupBox groupBoxResult_TDV;
        private System.Windows.Forms.Button buttonClick_TDV;
        private System.Windows.Forms.Button buttonHelp_TDV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_TDV;
        private System.Windows.Forms.TextBox textBoxResultInfo_TDV;
        private System.Windows.Forms.PictureBox pictureBoxData_TDV;
        private System.Windows.Forms.DataGridView dataGridViewResult_TDV;
    }
}

