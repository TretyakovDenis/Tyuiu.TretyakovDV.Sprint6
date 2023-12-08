
namespace Tyuiu.TretyakovDV.Sprint6.Task2.V4
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
            this.groupBoxDataInput = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_TDV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_TDV = new System.Windows.Forms.TextBox();
            this.textBoxStopStepText_TDV = new System.Windows.Forms.TextBox();
            this.textBoxStartStepText_TDV = new System.Windows.Forms.TextBox();
            this.buttonClick_TDV = new System.Windows.Forms.Button();
            this.buttonHelp_TDV = new System.Windows.Forms.Button();
            this.groupBoxTask_TDV = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_TDV = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chartFunction_TDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_TDV = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDataInput.SuspendLayout();
            this.groupBoxTask_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResult_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_TDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_TDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDataInput
            // 
            this.groupBoxDataInput.Controls.Add(this.textBoxStopStep_TDV);
            this.groupBoxDataInput.Controls.Add(this.textBoxStartStep_TDV);
            this.groupBoxDataInput.Controls.Add(this.textBoxStopStepText_TDV);
            this.groupBoxDataInput.Controls.Add(this.textBoxStartStepText_TDV);
            this.groupBoxDataInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDataInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataInput.Location = new System.Drawing.Point(12, 345);
            this.groupBoxDataInput.Name = "groupBoxDataInput";
            this.groupBoxDataInput.Size = new System.Drawing.Size(383, 93);
            this.groupBoxDataInput.TabIndex = 4;
            this.groupBoxDataInput.TabStop = false;
            this.groupBoxDataInput.Text = "Ввод данных";
            // 
            // textBoxStopStep_TDV
            // 
            this.textBoxStopStep_TDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStopStep_TDV.Location = new System.Drawing.Point(194, 46);
            this.textBoxStopStep_TDV.Name = "textBoxStopStep_TDV";
            this.textBoxStopStep_TDV.Size = new System.Drawing.Size(180, 26);
            this.textBoxStopStep_TDV.TabIndex = 3;
            // 
            // textBoxStartStep_TDV
            // 
            this.textBoxStartStep_TDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStartStep_TDV.Location = new System.Drawing.Point(7, 46);
            this.textBoxStartStep_TDV.Name = "textBoxStartStep_TDV";
            this.textBoxStartStep_TDV.Size = new System.Drawing.Size(180, 26);
            this.textBoxStartStep_TDV.TabIndex = 2;
            // 
            // textBoxStopStepText_TDV
            // 
            this.textBoxStopStepText_TDV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStopStepText_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStopStepText_TDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopStepText_TDV.Location = new System.Drawing.Point(194, 20);
            this.textBoxStopStepText_TDV.Name = "textBoxStopStepText_TDV";
            this.textBoxStopStepText_TDV.Size = new System.Drawing.Size(100, 19);
            this.textBoxStopStepText_TDV.TabIndex = 1;
            this.textBoxStopStepText_TDV.Text = "Конец шага:";
            // 
            // textBoxStartStepText_TDV
            // 
            this.textBoxStartStepText_TDV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStartStepText_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartStepText_TDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartStepText_TDV.Location = new System.Drawing.Point(7, 20);
            this.textBoxStartStepText_TDV.Name = "textBoxStartStepText_TDV";
            this.textBoxStartStepText_TDV.Size = new System.Drawing.Size(100, 19);
            this.textBoxStartStepText_TDV.TabIndex = 0;
            this.textBoxStartStepText_TDV.Text = "Старт шага:";
            // 
            // buttonClick_TDV
            // 
            this.buttonClick_TDV.BackColor = System.Drawing.Color.Green;
            this.buttonClick_TDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClick_TDV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick_TDV.Location = new System.Drawing.Point(500, 345);
            this.buttonClick_TDV.Name = "buttonClick_TDV";
            this.buttonClick_TDV.Size = new System.Drawing.Size(168, 93);
            this.buttonClick_TDV.TabIndex = 6;
            this.buttonClick_TDV.Text = "Выполнить";
            this.buttonClick_TDV.UseVisualStyleBackColor = false;
            this.buttonClick_TDV.Click += new System.EventHandler(this.buttonClick_TDV_Click);
            this.buttonClick_TDV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonClick_TDV_MouseDown);
            this.buttonClick_TDV.MouseEnter += new System.EventHandler(this.buttonClick_TDV_MouseEnter);
            this.buttonClick_TDV.MouseLeave += new System.EventHandler(this.buttonClick_TDV_MouseLeave);
            // 
            // buttonHelp_TDV
            // 
            this.buttonHelp_TDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_TDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_TDV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_TDV.Location = new System.Drawing.Point(401, 345);
            this.buttonHelp_TDV.Name = "buttonHelp_TDV";
            this.buttonHelp_TDV.Size = new System.Drawing.Size(93, 93);
            this.buttonHelp_TDV.TabIndex = 5;
            this.buttonHelp_TDV.Text = "Справка";
            this.buttonHelp_TDV.UseVisualStyleBackColor = false;
            // 
            // groupBoxTask_TDV
            // 
            this.groupBoxTask_TDV.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxTask_TDV.Controls.Add(this.pictureBox1);
            this.groupBoxTask_TDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_TDV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_TDV.Name = "groupBoxTask_TDV";
            this.groupBoxTask_TDV.Size = new System.Drawing.Size(656, 326);
            this.groupBoxTask_TDV.TabIndex = 7;
            this.groupBoxTask_TDV.TabStop = false;
            this.groupBoxTask_TDV.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 306);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxResult_TDV
            // 
            this.groupBoxResult_TDV.Controls.Add(this.dataGridViewFunction_TDV);
            this.groupBoxResult_TDV.Controls.Add(this.chartFunction_TDV);
            this.groupBoxResult_TDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_TDV.Location = new System.Drawing.Point(674, 13);
            this.groupBoxResult_TDV.Name = "groupBoxResult_TDV";
            this.groupBoxResult_TDV.Size = new System.Drawing.Size(606, 425);
            this.groupBoxResult_TDV.TabIndex = 8;
            this.groupBoxResult_TDV.TabStop = false;
            this.groupBoxResult_TDV.Text = "Вывод данных";
            // 
            // chartFunction_TDV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_TDV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_TDV.Legends.Add(legend1);
            this.chartFunction_TDV.Location = new System.Drawing.Point(258, 26);
            this.chartFunction_TDV.Name = "chartFunction_TDV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_TDV.Series.Add(series1);
            this.chartFunction_TDV.Size = new System.Drawing.Size(342, 393);
            this.chartFunction_TDV.TabIndex = 1;
            this.chartFunction_TDV.Text = "График функции";
            // 
            // dataGridViewFunction_TDV
            // 
            this.dataGridViewFunction_TDV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFunction_TDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewFunction_TDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_TDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_TDV.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewFunction_TDV.Name = "dataGridViewFunction_TDV";
            this.dataGridViewFunction_TDV.RowHeadersVisible = false;
            this.dataGridViewFunction_TDV.Size = new System.Drawing.Size(203, 393);
            this.dataGridViewFunction_TDV.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 450);
            this.Controls.Add(this.groupBoxResult_TDV);
            this.Controls.Add(this.groupBoxTask_TDV);
            this.Controls.Add(this.groupBoxDataInput);
            this.Controls.Add(this.buttonClick_TDV);
            this.Controls.Add(this.buttonHelp_TDV);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Третьяков Д. В.";
            this.groupBoxDataInput.ResumeLayout(false);
            this.groupBoxDataInput.PerformLayout();
            this.groupBoxTask_TDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResult_TDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_TDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_TDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataInput;
        private System.Windows.Forms.TextBox textBoxStopStep_TDV;
        private System.Windows.Forms.TextBox textBoxStartStep_TDV;
        private System.Windows.Forms.TextBox textBoxStopStepText_TDV;
        private System.Windows.Forms.TextBox textBoxStartStepText_TDV;
        private System.Windows.Forms.Button buttonClick_TDV;
        private System.Windows.Forms.Button buttonHelp_TDV;
        private System.Windows.Forms.GroupBox groupBoxTask_TDV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxResult_TDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_TDV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewFunction_TDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

