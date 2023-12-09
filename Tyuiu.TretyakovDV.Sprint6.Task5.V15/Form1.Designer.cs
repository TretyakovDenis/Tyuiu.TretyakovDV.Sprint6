
namespace Tyuiu.TretyakovDV.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop_TDV = new System.Windows.Forms.Panel();
            this.panelLeft_TDV = new System.Windows.Forms.Panel();
            this.panelFill_TDV = new System.Windows.Forms.Panel();
            this.groupBoxData_TDV = new System.Windows.Forms.GroupBox();
            this.buttonClick_TDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_TDV = new System.Windows.Forms.Button();
            this.buttonHelp_TDV = new System.Windows.Forms.Button();
            this.groupBoxResult_TDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_TDV = new System.Windows.Forms.DataGridView();
            this.chartDiag_TDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxData_TDV = new System.Windows.Forms.TextBox();
            this.panelTop_TDV.SuspendLayout();
            this.panelLeft_TDV.SuspendLayout();
            this.panelFill_TDV.SuspendLayout();
            this.groupBoxData_TDV.SuspendLayout();
            this.groupBoxResult_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_TDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_TDV
            // 
            this.panelTop_TDV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTop_TDV.Controls.Add(this.buttonHelp_TDV);
            this.panelTop_TDV.Controls.Add(this.buttonOpenFile_TDV);
            this.panelTop_TDV.Controls.Add(this.buttonClick_TDV);
            this.panelTop_TDV.Controls.Add(this.groupBoxData_TDV);
            this.panelTop_TDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_TDV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_TDV.Name = "panelTop_TDV";
            this.panelTop_TDV.Size = new System.Drawing.Size(1179, 73);
            this.panelTop_TDV.TabIndex = 0;
            // 
            // panelLeft_TDV
            // 
            this.panelLeft_TDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelLeft_TDV.Controls.Add(this.groupBoxResult_TDV);
            this.panelLeft_TDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_TDV.Location = new System.Drawing.Point(0, 73);
            this.panelLeft_TDV.Name = "panelLeft_TDV";
            this.panelLeft_TDV.Size = new System.Drawing.Size(200, 442);
            this.panelLeft_TDV.TabIndex = 1;
            // 
            // panelFill_TDV
            // 
            this.panelFill_TDV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelFill_TDV.Controls.Add(this.chartDiag_TDV);
            this.panelFill_TDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_TDV.Location = new System.Drawing.Point(200, 73);
            this.panelFill_TDV.Name = "panelFill_TDV";
            this.panelFill_TDV.Size = new System.Drawing.Size(979, 442);
            this.panelFill_TDV.TabIndex = 2;
            // 
            // groupBoxData_TDV
            // 
            this.groupBoxData_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_TDV.Controls.Add(this.textBoxData_TDV);
            this.groupBoxData_TDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData_TDV.Name = "groupBoxData_TDV";
            this.groupBoxData_TDV.Size = new System.Drawing.Size(798, 73);
            this.groupBoxData_TDV.TabIndex = 0;
            this.groupBoxData_TDV.TabStop = false;
            this.groupBoxData_TDV.Text = "Условие:";
            // 
            // buttonClick_TDV
            // 
            this.buttonClick_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClick_TDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonClick_TDV.Location = new System.Drawing.Point(804, 19);
            this.buttonClick_TDV.Name = "buttonClick_TDV";
            this.buttonClick_TDV.Size = new System.Drawing.Size(75, 41);
            this.buttonClick_TDV.TabIndex = 1;
            this.buttonClick_TDV.Text = "Выполнить";
            this.buttonClick_TDV.UseVisualStyleBackColor = false;
            this.buttonClick_TDV.Click += new System.EventHandler(this.buttonClick_TDV_Click);
            // 
            // buttonOpenFile_TDV
            // 
            this.buttonOpenFile_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_TDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_TDV.Location = new System.Drawing.Point(886, 19);
            this.buttonOpenFile_TDV.Name = "buttonOpenFile_TDV";
            this.buttonOpenFile_TDV.Size = new System.Drawing.Size(75, 41);
            this.buttonOpenFile_TDV.TabIndex = 2;
            this.buttonOpenFile_TDV.Text = "Открыть файл";
            this.buttonOpenFile_TDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_TDV.Click += new System.EventHandler(this.buttonOpenFile_TDV_Click);
            // 
            // buttonHelp_TDV
            // 
            this.buttonHelp_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_TDV.Location = new System.Drawing.Point(967, 19);
            this.buttonHelp_TDV.Name = "buttonHelp_TDV";
            this.buttonHelp_TDV.Size = new System.Drawing.Size(68, 41);
            this.buttonHelp_TDV.TabIndex = 3;
            this.buttonHelp_TDV.Text = "Справка";
            this.buttonHelp_TDV.UseVisualStyleBackColor = false;
            this.buttonHelp_TDV.Click += new System.EventHandler(this.buttonHelp_TDV_Click);
            // 
            // groupBoxResult_TDV
            // 
            this.groupBoxResult_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxResult_TDV.AutoSize = true;
            this.groupBoxResult_TDV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxResult_TDV.Controls.Add(this.dataGridViewResult_TDV);
            this.groupBoxResult_TDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_TDV.Name = "groupBoxResult_TDV";
            this.groupBoxResult_TDV.Size = new System.Drawing.Size(200, 449);
            this.groupBoxResult_TDV.TabIndex = 0;
            this.groupBoxResult_TDV.TabStop = false;
            this.groupBoxResult_TDV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_TDV
            // 
            this.dataGridViewResult_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewResult_TDV.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewResult_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult_TDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_TDV.ColumnHeadersVisible = false;
            this.dataGridViewResult_TDV.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewResult_TDV.Name = "dataGridViewResult_TDV";
            this.dataGridViewResult_TDV.ReadOnly = true;
            this.dataGridViewResult_TDV.RowHeadersVisible = false;
            this.dataGridViewResult_TDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_TDV.Size = new System.Drawing.Size(187, 410);
            this.dataGridViewResult_TDV.TabIndex = 0;
            // 
            // chartDiag_TDV
            // 
            this.chartDiag_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDiag_TDV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDiag_TDV.Legends.Add(legend1);
            this.chartDiag_TDV.Location = new System.Drawing.Point(25, 20);
            this.chartDiag_TDV.Name = "chartDiag_TDV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_TDV.Series.Add(series1);
            this.chartDiag_TDV.Size = new System.Drawing.Size(923, 410);
            this.chartDiag_TDV.TabIndex = 0;
            this.chartDiag_TDV.Text = "chart1";
            // 
            // textBoxData_TDV
            // 
            this.textBoxData_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData_TDV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxData_TDV.Location = new System.Drawing.Point(7, 13);
            this.textBoxData_TDV.Multiline = true;
            this.textBoxData_TDV.Name = "textBoxData_TDV";
            this.textBoxData_TDV.ReadOnly = true;
            this.textBoxData_TDV.Size = new System.Drawing.Size(785, 54);
            this.textBoxData_TDV.TabIndex = 0;
            this.textBoxData_TDV.Text = resources.GetString("textBoxData_TDV.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 515);
            this.Controls.Add(this.panelFill_TDV);
            this.Controls.Add(this.panelLeft_TDV);
            this.Controls.Add(this.panelTop_TDV);
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск 5 | Вариант 15 | Третьяков Д. В.";
            this.panelTop_TDV.ResumeLayout(false);
            this.panelLeft_TDV.ResumeLayout(false);
            this.panelLeft_TDV.PerformLayout();
            this.panelFill_TDV.ResumeLayout(false);
            this.groupBoxData_TDV.ResumeLayout(false);
            this.groupBoxData_TDV.PerformLayout();
            this.groupBoxResult_TDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_TDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_TDV;
        private System.Windows.Forms.Panel panelLeft_TDV;
        private System.Windows.Forms.Panel panelFill_TDV;
        private System.Windows.Forms.Button buttonHelp_TDV;
        private System.Windows.Forms.Button buttonOpenFile_TDV;
        private System.Windows.Forms.Button buttonClick_TDV;
        private System.Windows.Forms.GroupBox groupBoxData_TDV;
        private System.Windows.Forms.GroupBox groupBoxResult_TDV;
        private System.Windows.Forms.DataGridView dataGridViewResult_TDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_TDV;
        private System.Windows.Forms.TextBox textBoxData_TDV;
    }
}

