
namespace Tyuiu.TretyakovDV.Sprint6.Task7.V29
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
            this.panelButtons_TDV = new System.Windows.Forms.Panel();
            this.buttonSaveFile_TDV = new System.Windows.Forms.Button();
            this.buttonHelp_TDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_TDV = new System.Windows.Forms.Button();
            this.buttonDone_TDV = new System.Windows.Forms.Button();
            this.textBoxData_TDV = new System.Windows.Forms.TextBox();
            this.groupBoxData_TDV = new System.Windows.Forms.GroupBox();
            this.panelData_TDV = new System.Windows.Forms.Panel();
            this.panelInPut_TDV = new System.Windows.Forms.Panel();
            this.groupBoxIn_TDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_TDV = new System.Windows.Forms.DataGridView();
            this.panelOutPut_TDV = new System.Windows.Forms.Panel();
            this.groupBoxOut_TDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_TDV = new System.Windows.Forms.DataGridView();
            this.splitter_TDV = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_TDV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_TDV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogMatrix_TDV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_TDV.SuspendLayout();
            this.groupBoxData_TDV.SuspendLayout();
            this.panelData_TDV.SuspendLayout();
            this.panelInPut_TDV.SuspendLayout();
            this.groupBoxIn_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_TDV)).BeginInit();
            this.panelOutPut_TDV.SuspendLayout();
            this.groupBoxOut_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_TDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_TDV
            // 
            this.panelButtons_TDV.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtons_TDV.Controls.Add(this.buttonSaveFile_TDV);
            this.panelButtons_TDV.Controls.Add(this.buttonHelp_TDV);
            this.panelButtons_TDV.Controls.Add(this.buttonOpenFile_TDV);
            this.panelButtons_TDV.Controls.Add(this.buttonDone_TDV);
            this.panelButtons_TDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_TDV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_TDV.Name = "panelButtons_TDV";
            this.panelButtons_TDV.Size = new System.Drawing.Size(1173, 67);
            this.panelButtons_TDV.TabIndex = 1;
            // 
            // buttonSaveFile_TDV
            // 
            this.buttonSaveFile_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveFile_TDV.BackColor = System.Drawing.Color.White;
            this.buttonSaveFile_TDV.Enabled = false;
            this.buttonSaveFile_TDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_TDV.Image")));
            this.buttonSaveFile_TDV.Location = new System.Drawing.Point(123, 7);
            this.buttonSaveFile_TDV.Name = "buttonSaveFile_TDV";
            this.buttonSaveFile_TDV.Size = new System.Drawing.Size(50, 50);
            this.buttonSaveFile_TDV.TabIndex = 7;
            this.toolTip_TDV.SetToolTip(this.buttonSaveFile_TDV, "Сохранить файл");
            this.buttonSaveFile_TDV.UseVisualStyleBackColor = false;
            this.buttonSaveFile_TDV.Click += new System.EventHandler(this.buttonSaveFile_TDV_Click);
            // 
            // buttonHelp_TDV
            // 
            this.buttonHelp_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TDV.BackColor = System.Drawing.Color.White;
            this.buttonHelp_TDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_TDV.Image")));
            this.buttonHelp_TDV.Location = new System.Drawing.Point(1111, 7);
            this.buttonHelp_TDV.Name = "buttonHelp_TDV";
            this.buttonHelp_TDV.Size = new System.Drawing.Size(50, 50);
            this.buttonHelp_TDV.TabIndex = 6;
            this.toolTip_TDV.SetToolTip(this.buttonHelp_TDV, "Справка");
            this.buttonHelp_TDV.UseVisualStyleBackColor = false;
            this.buttonHelp_TDV.Click += new System.EventHandler(this.buttonHelp_TDV_Click);
            // 
            // buttonOpenFile_TDV
            // 
            this.buttonOpenFile_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile_TDV.BackColor = System.Drawing.Color.White;
            this.buttonOpenFile_TDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_TDV.Image")));
            this.buttonOpenFile_TDV.Location = new System.Drawing.Point(11, 7);
            this.buttonOpenFile_TDV.Name = "buttonOpenFile_TDV";
            this.buttonOpenFile_TDV.Size = new System.Drawing.Size(50, 50);
            this.buttonOpenFile_TDV.TabIndex = 4;
            this.toolTip_TDV.SetToolTip(this.buttonOpenFile_TDV, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_TDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_TDV.Click += new System.EventHandler(this.buttonOpenFile_TDV_Click);
            // 
            // buttonDone_TDV
            // 
            this.buttonDone_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_TDV.BackColor = System.Drawing.Color.White;
            this.buttonDone_TDV.Enabled = false;
            this.buttonDone_TDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_TDV.Image")));
            this.buttonDone_TDV.Location = new System.Drawing.Point(67, 7);
            this.buttonDone_TDV.Name = "buttonDone_TDV";
            this.buttonDone_TDV.Size = new System.Drawing.Size(50, 50);
            this.buttonDone_TDV.TabIndex = 5;
            this.toolTip_TDV.SetToolTip(this.buttonDone_TDV, "Запускает обработку матрицы");
            this.buttonDone_TDV.UseVisualStyleBackColor = false;
            this.buttonDone_TDV.Click += new System.EventHandler(this.buttonDone_TDV_Click);
            // 
            // textBoxData_TDV
            // 
            this.textBoxData_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData_TDV.Location = new System.Drawing.Point(7, 20);
            this.textBoxData_TDV.Multiline = true;
            this.textBoxData_TDV.Name = "textBoxData_TDV";
            this.textBoxData_TDV.ReadOnly = true;
            this.textBoxData_TDV.Size = new System.Drawing.Size(1134, 61);
            this.textBoxData_TDV.TabIndex = 0;
            this.textBoxData_TDV.Text = resources.GetString("textBoxData_TDV.Text");
            // 
            // groupBoxData_TDV
            // 
            this.groupBoxData_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_TDV.Controls.Add(this.textBoxData_TDV);
            this.groupBoxData_TDV.Location = new System.Drawing.Point(11, 7);
            this.groupBoxData_TDV.Name = "groupBoxData_TDV";
            this.groupBoxData_TDV.Size = new System.Drawing.Size(1150, 87);
            this.groupBoxData_TDV.TabIndex = 0;
            this.groupBoxData_TDV.TabStop = false;
            this.groupBoxData_TDV.Text = "Условие";
            // 
            // panelData_TDV
            // 
            this.panelData_TDV.BackColor = System.Drawing.SystemColors.Control;
            this.panelData_TDV.Controls.Add(this.groupBoxData_TDV);
            this.panelData_TDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData_TDV.Location = new System.Drawing.Point(0, 67);
            this.panelData_TDV.Name = "panelData_TDV";
            this.panelData_TDV.Size = new System.Drawing.Size(1173, 100);
            this.panelData_TDV.TabIndex = 2;
            // 
            // panelInPut_TDV
            // 
            this.panelInPut_TDV.Controls.Add(this.groupBoxIn_TDV);
            this.panelInPut_TDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_TDV.Location = new System.Drawing.Point(0, 167);
            this.panelInPut_TDV.Name = "panelInPut_TDV";
            this.panelInPut_TDV.Size = new System.Drawing.Size(633, 456);
            this.panelInPut_TDV.TabIndex = 3;
            // 
            // groupBoxIn_TDV
            // 
            this.groupBoxIn_TDV.AutoSize = true;
            this.groupBoxIn_TDV.Controls.Add(this.dataGridViewIn_TDV);
            this.groupBoxIn_TDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxIn_TDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_TDV.Name = "groupBoxIn_TDV";
            this.groupBoxIn_TDV.Size = new System.Drawing.Size(629, 456);
            this.groupBoxIn_TDV.TabIndex = 1;
            this.groupBoxIn_TDV.TabStop = false;
            this.groupBoxIn_TDV.Text = "Ввод:";
            // 
            // dataGridViewIn_TDV
            // 
            this.dataGridViewIn_TDV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewIn_TDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_TDV.ColumnHeadersVisible = false;
            this.dataGridViewIn_TDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewIn_TDV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_TDV.Name = "dataGridViewIn_TDV";
            this.dataGridViewIn_TDV.RowHeadersVisible = false;
            this.dataGridViewIn_TDV.Size = new System.Drawing.Size(623, 437);
            this.dataGridViewIn_TDV.TabIndex = 1;
            // 
            // panelOutPut_TDV
            // 
            this.panelOutPut_TDV.Controls.Add(this.groupBoxOut_TDV);
            this.panelOutPut_TDV.Controls.Add(this.splitter_TDV);
            this.panelOutPut_TDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_TDV.Location = new System.Drawing.Point(633, 167);
            this.panelOutPut_TDV.Name = "panelOutPut_TDV";
            this.panelOutPut_TDV.Size = new System.Drawing.Size(540, 456);
            this.panelOutPut_TDV.TabIndex = 4;
            // 
            // groupBoxOut_TDV
            // 
            this.groupBoxOut_TDV.AutoSize = true;
            this.groupBoxOut_TDV.Controls.Add(this.dataGridViewOut_TDV);
            this.groupBoxOut_TDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_TDV.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOut_TDV.Name = "groupBoxOut_TDV";
            this.groupBoxOut_TDV.Size = new System.Drawing.Size(537, 456);
            this.groupBoxOut_TDV.TabIndex = 2;
            this.groupBoxOut_TDV.TabStop = false;
            this.groupBoxOut_TDV.Text = "Вывод:";
            // 
            // dataGridViewOut_TDV
            // 
            this.dataGridViewOut_TDV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOut_TDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_TDV.ColumnHeadersVisible = false;
            this.dataGridViewOut_TDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_TDV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_TDV.Name = "dataGridViewOut_TDV";
            this.dataGridViewOut_TDV.RowHeadersVisible = false;
            this.dataGridViewOut_TDV.Size = new System.Drawing.Size(531, 437);
            this.dataGridViewOut_TDV.TabIndex = 1;
            // 
            // splitter_TDV
            // 
            this.splitter_TDV.Location = new System.Drawing.Point(0, 0);
            this.splitter_TDV.Name = "splitter_TDV";
            this.splitter_TDV.Size = new System.Drawing.Size(3, 456);
            this.splitter_TDV.TabIndex = 0;
            this.splitter_TDV.TabStop = false;
            // 
            // openFileDialogTask_TDV
            // 
            this.openFileDialogTask_TDV.FileName = "openFileDialogTask_TDV";
            // 
            // toolTip_TDV
            // 
            this.toolTip_TDV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_TDV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogMatrix_TDV
            // 
            this.openFileDialogMatrix_TDV.FileName = "openFileDialogMatrix";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 623);
            this.Controls.Add(this.panelOutPut_TDV);
            this.Controls.Add(this.panelInPut_TDV);
            this.Controls.Add(this.panelData_TDV);
            this.Controls.Add(this.panelButtons_TDV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 29 | Третьяков Д. В.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButtons_TDV.ResumeLayout(false);
            this.groupBoxData_TDV.ResumeLayout(false);
            this.groupBoxData_TDV.PerformLayout();
            this.panelData_TDV.ResumeLayout(false);
            this.panelInPut_TDV.ResumeLayout(false);
            this.panelInPut_TDV.PerformLayout();
            this.groupBoxIn_TDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_TDV)).EndInit();
            this.panelOutPut_TDV.ResumeLayout(false);
            this.panelOutPut_TDV.PerformLayout();
            this.groupBoxOut_TDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_TDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_TDV;
        private System.Windows.Forms.Button buttonHelp_TDV;
        private System.Windows.Forms.Button buttonOpenFile_TDV;
        private System.Windows.Forms.Button buttonDone_TDV;
        private System.Windows.Forms.TextBox textBoxData_TDV;
        private System.Windows.Forms.GroupBox groupBoxData_TDV;
        private System.Windows.Forms.Panel panelData_TDV;
        private System.Windows.Forms.Panel panelInPut_TDV;
        private System.Windows.Forms.Panel panelOutPut_TDV;
        private System.Windows.Forms.Splitter splitter_TDV;
        private System.Windows.Forms.GroupBox groupBoxIn_TDV;
        private System.Windows.Forms.GroupBox groupBoxOut_TDV;
        private System.Windows.Forms.ToolTip toolTip_TDV;
        private System.Windows.Forms.DataGridView dataGridViewIn_TDV;
        private System.Windows.Forms.DataGridView dataGridViewOut_TDV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_TDV;
        private System.Windows.Forms.Button buttonSaveFile_TDV;
        private System.Windows.Forms.OpenFileDialog openFileDialogMatrix_TDV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}

