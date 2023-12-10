
namespace Tyuiu.TretyakovDV.Sprint6.Task6.V22
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
            this.buttonHelp_TDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_TDV = new System.Windows.Forms.Button();
            this.buttonDone_TDV = new System.Windows.Forms.Button();
            this.panelData_TDV = new System.Windows.Forms.Panel();
            this.groupBoxData_TDV = new System.Windows.Forms.GroupBox();
            this.textBoxData_TDV = new System.Windows.Forms.TextBox();
            this.panelIn_TDV = new System.Windows.Forms.Panel();
            this.groupBoxIn_TDV = new System.Windows.Forms.GroupBox();
            this.textBoxIn_TDV = new System.Windows.Forms.TextBox();
            this.panelOut_TDV = new System.Windows.Forms.Panel();
            this.groupBoxOut_TDV = new System.Windows.Forms.GroupBox();
            this.textBoxOut_TDV = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_TDV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_TDV = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelButtons_TDV.SuspendLayout();
            this.panelData_TDV.SuspendLayout();
            this.groupBoxData_TDV.SuspendLayout();
            this.panelIn_TDV.SuspendLayout();
            this.groupBoxIn_TDV.SuspendLayout();
            this.panelOut_TDV.SuspendLayout();
            this.groupBoxOut_TDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_TDV
            // 
            this.panelButtons_TDV.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtons_TDV.Controls.Add(this.buttonHelp_TDV);
            this.panelButtons_TDV.Controls.Add(this.buttonOpenFile_TDV);
            this.panelButtons_TDV.Controls.Add(this.buttonDone_TDV);
            this.panelButtons_TDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_TDV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_TDV.Name = "panelButtons_TDV";
            this.panelButtons_TDV.Size = new System.Drawing.Size(1110, 67);
            this.panelButtons_TDV.TabIndex = 0;
            // 
            // buttonHelp_TDV
            // 
            this.buttonHelp_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TDV.BackColor = System.Drawing.Color.White;
            this.buttonHelp_TDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_TDV.Image")));
            this.buttonHelp_TDV.Location = new System.Drawing.Point(1048, 7);
            this.buttonHelp_TDV.Name = "buttonHelp_TDV";
            this.buttonHelp_TDV.Size = new System.Drawing.Size(50, 50);
            this.buttonHelp_TDV.TabIndex = 6;
            this.toolTip_TDV.SetToolTip(this.buttonHelp_TDV, "Сведения о программе");
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
            this.toolTip_TDV.SetToolTip(this.buttonOpenFile_TDV, "Открыть Файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_TDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_TDV.Click += new System.EventHandler(this.buttonOpenFile_TDV_Click);
            // 
            // buttonDone_TDV
            // 
            this.buttonDone_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_TDV.BackColor = System.Drawing.Color.White;
            this.buttonDone_TDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_TDV.Image")));
            this.buttonDone_TDV.Location = new System.Drawing.Point(67, 7);
            this.buttonDone_TDV.Name = "buttonDone_TDV";
            this.buttonDone_TDV.Size = new System.Drawing.Size(50, 50);
            this.buttonDone_TDV.TabIndex = 5;
            this.toolTip_TDV.SetToolTip(this.buttonDone_TDV, "Выводит первое слово каждой строки в результирующею строку\r\n");
            this.buttonDone_TDV.UseVisualStyleBackColor = false;
            this.buttonDone_TDV.Click += new System.EventHandler(this.buttonDone_TDV_Click);
            // 
            // panelData_TDV
            // 
            this.panelData_TDV.BackColor = System.Drawing.SystemColors.Control;
            this.panelData_TDV.Controls.Add(this.groupBoxData_TDV);
            this.panelData_TDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData_TDV.Location = new System.Drawing.Point(0, 67);
            this.panelData_TDV.Name = "panelData_TDV";
            this.panelData_TDV.Size = new System.Drawing.Size(1110, 100);
            this.panelData_TDV.TabIndex = 1;
            // 
            // groupBoxData_TDV
            // 
            this.groupBoxData_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_TDV.Controls.Add(this.textBoxData_TDV);
            this.groupBoxData_TDV.Location = new System.Drawing.Point(11, 7);
            this.groupBoxData_TDV.Name = "groupBoxData_TDV";
            this.groupBoxData_TDV.Size = new System.Drawing.Size(1087, 87);
            this.groupBoxData_TDV.TabIndex = 0;
            this.groupBoxData_TDV.TabStop = false;
            this.groupBoxData_TDV.Text = "Условие";
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
            this.textBoxData_TDV.Size = new System.Drawing.Size(1071, 61);
            this.textBoxData_TDV.TabIndex = 0;
            this.textBoxData_TDV.Text = resources.GetString("textBoxData_TDV.Text");
            // 
            // panelIn_TDV
            // 
            this.panelIn_TDV.AutoSize = true;
            this.panelIn_TDV.Controls.Add(this.groupBoxIn_TDV);
            this.panelIn_TDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIn_TDV.Location = new System.Drawing.Point(0, 167);
            this.panelIn_TDV.Name = "panelIn_TDV";
            this.panelIn_TDV.Size = new System.Drawing.Size(566, 447);
            this.panelIn_TDV.TabIndex = 2;
            // 
            // groupBoxIn_TDV
            // 
            this.groupBoxIn_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIn_TDV.AutoSize = true;
            this.groupBoxIn_TDV.Controls.Add(this.textBoxIn_TDV);
            this.groupBoxIn_TDV.Location = new System.Drawing.Point(4, 7);
            this.groupBoxIn_TDV.Name = "groupBoxIn_TDV";
            this.groupBoxIn_TDV.Size = new System.Drawing.Size(559, 428);
            this.groupBoxIn_TDV.TabIndex = 0;
            this.groupBoxIn_TDV.TabStop = false;
            this.groupBoxIn_TDV.Text = "Ввод:";
            // 
            // textBoxIn_TDV
            // 
            this.textBoxIn_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn_TDV.Location = new System.Drawing.Point(7, 65);
            this.textBoxIn_TDV.Multiline = true;
            this.textBoxIn_TDV.Name = "textBoxIn_TDV";
            this.textBoxIn_TDV.ReadOnly = true;
            this.textBoxIn_TDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_TDV.Size = new System.Drawing.Size(546, 344);
            this.textBoxIn_TDV.TabIndex = 0;
            // 
            // panelOut_TDV
            // 
            this.panelOut_TDV.AutoSize = true;
            this.panelOut_TDV.Controls.Add(this.groupBoxOut_TDV);
            this.panelOut_TDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOut_TDV.Location = new System.Drawing.Point(566, 167);
            this.panelOut_TDV.Name = "panelOut_TDV";
            this.panelOut_TDV.Size = new System.Drawing.Size(544, 447);
            this.panelOut_TDV.TabIndex = 3;
            // 
            // groupBoxOut_TDV
            // 
            this.groupBoxOut_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut_TDV.AutoSize = true;
            this.groupBoxOut_TDV.Controls.Add(this.textBoxOut_TDV);
            this.groupBoxOut_TDV.Location = new System.Drawing.Point(9, 7);
            this.groupBoxOut_TDV.Name = "groupBoxOut_TDV";
            this.groupBoxOut_TDV.Size = new System.Drawing.Size(523, 428);
            this.groupBoxOut_TDV.TabIndex = 1;
            this.groupBoxOut_TDV.TabStop = false;
            this.groupBoxOut_TDV.Text = "Вывод:";
            // 
            // textBoxOut_TDV
            // 
            this.textBoxOut_TDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut_TDV.Location = new System.Drawing.Point(6, 20);
            this.textBoxOut_TDV.Multiline = true;
            this.textBoxOut_TDV.Name = "textBoxOut_TDV";
            this.textBoxOut_TDV.ReadOnly = true;
            this.textBoxOut_TDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_TDV.Size = new System.Drawing.Size(508, 389);
            this.textBoxOut_TDV.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(566, 167);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 447);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 614);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOut_TDV);
            this.Controls.Add(this.panelIn_TDV);
            this.Controls.Add(this.panelData_TDV);
            this.Controls.Add(this.panelButtons_TDV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 22 | Третьяков Д. В.";
            this.panelButtons_TDV.ResumeLayout(false);
            this.panelData_TDV.ResumeLayout(false);
            this.groupBoxData_TDV.ResumeLayout(false);
            this.groupBoxData_TDV.PerformLayout();
            this.panelIn_TDV.ResumeLayout(false);
            this.panelIn_TDV.PerformLayout();
            this.groupBoxIn_TDV.ResumeLayout(false);
            this.groupBoxIn_TDV.PerformLayout();
            this.panelOut_TDV.ResumeLayout(false);
            this.panelOut_TDV.PerformLayout();
            this.groupBoxOut_TDV.ResumeLayout(false);
            this.groupBoxOut_TDV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_TDV;
        private System.Windows.Forms.Panel panelData_TDV;
        private System.Windows.Forms.GroupBox groupBoxData_TDV;
        private System.Windows.Forms.TextBox textBoxData_TDV;
        private System.Windows.Forms.Panel panelIn_TDV;
        private System.Windows.Forms.GroupBox groupBoxIn_TDV;
        private System.Windows.Forms.TextBox textBoxIn_TDV;
        private System.Windows.Forms.Panel panelOut_TDV;
        private System.Windows.Forms.GroupBox groupBoxOut_TDV;
        private System.Windows.Forms.TextBox textBoxOut_TDV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_TDV;
        private System.Windows.Forms.Button buttonOpenFile_TDV;
        private System.Windows.Forms.Button buttonDone_TDV;
        private System.Windows.Forms.ToolTip toolTip_TDV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_TDV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

