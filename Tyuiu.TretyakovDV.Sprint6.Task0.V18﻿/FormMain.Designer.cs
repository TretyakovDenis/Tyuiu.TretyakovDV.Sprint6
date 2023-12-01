
namespace Tyuiu.TretyakovDV.Sprint6.Task0.V18﻿
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
            this.groupBoxCondition_TDV = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_TDV = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_TDV = new System.Windows.Forms.TextBox();
            this.groupBoxValue_TDV = new System.Windows.Forms.GroupBox();
            this.textBoxInputX_TDV = new System.Windows.Forms.TextBox();
            this.textBoxX_TDV = new System.Windows.Forms.TextBox();
            this.groupBoxResult_TDV = new System.Windows.Forms.GroupBox();
            this.textBoxResultOutput_TDV = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonClick_TDV = new System.Windows.Forms.Button();
            this.buttonHelp_TDV = new System.Windows.Forms.Button();
            this.groupBoxCondition_TDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TDV)).BeginInit();
            this.groupBoxValue_TDV.SuspendLayout();
            this.groupBoxResult_TDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_TDV
            // 
            this.groupBoxCondition_TDV.Controls.Add(this.pictureBoxFormula_TDV);
            this.groupBoxCondition_TDV.Controls.Add(this.textBoxCondition_TDV);
            this.groupBoxCondition_TDV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_TDV.Name = "groupBoxCondition_TDV";
            this.groupBoxCondition_TDV.Size = new System.Drawing.Size(759, 281);
            this.groupBoxCondition_TDV.TabIndex = 0;
            this.groupBoxCondition_TDV.TabStop = false;
            this.groupBoxCondition_TDV.Text = "Условие";
            // 
            // pictureBoxFormula_TDV
            // 
            this.pictureBoxFormula_TDV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_TDV.Image")));
            this.pictureBoxFormula_TDV.Location = new System.Drawing.Point(591, 20);
            this.pictureBoxFormula_TDV.Name = "pictureBoxFormula_TDV";
            this.pictureBoxFormula_TDV.Size = new System.Drawing.Size(127, 63);
            this.pictureBoxFormula_TDV.TabIndex = 1;
            this.pictureBoxFormula_TDV.TabStop = false;
            // 
            // textBoxCondition_TDV
            // 
            this.textBoxCondition_TDV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxCondition_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_TDV.Location = new System.Drawing.Point(7, 20);
            this.textBoxCondition_TDV.Name = "textBoxCondition_TDV";
            this.textBoxCondition_TDV.Size = new System.Drawing.Size(289, 13);
            this.textBoxCondition_TDV.TabIndex = 0;
            this.textBoxCondition_TDV.Text = "Вычислить значение выражения по формуле";
            // 
            // groupBoxValue_TDV
            // 
            this.groupBoxValue_TDV.Controls.Add(this.textBoxInputX_TDV);
            this.groupBoxValue_TDV.Controls.Add(this.textBoxX_TDV);
            this.groupBoxValue_TDV.Location = new System.Drawing.Point(13, 301);
            this.groupBoxValue_TDV.Name = "groupBoxValue_TDV";
            this.groupBoxValue_TDV.Size = new System.Drawing.Size(545, 73);
            this.groupBoxValue_TDV.TabIndex = 1;
            this.groupBoxValue_TDV.TabStop = false;
            this.groupBoxValue_TDV.Text = "Введите данные";
            // 
            // textBoxInputX_TDV
            // 
            this.textBoxInputX_TDV.Location = new System.Drawing.Point(7, 40);
            this.textBoxInputX_TDV.Name = "textBoxInputX_TDV";
            this.textBoxInputX_TDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputX_TDV.TabIndex = 1;
            this.textBoxInputX_TDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputX_TDV_KeyPress);
            // 
            // textBoxX_TDV
            // 
            this.textBoxX_TDV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxX_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX_TDV.Location = new System.Drawing.Point(7, 20);
            this.textBoxX_TDV.Name = "textBoxX_TDV";
            this.textBoxX_TDV.Size = new System.Drawing.Size(100, 13);
            this.textBoxX_TDV.TabIndex = 0;
            this.textBoxX_TDV.Text = "Переменная Х:";
            // 
            // groupBoxResult_TDV
            // 
            this.groupBoxResult_TDV.Controls.Add(this.textBoxResultOutput_TDV);
            this.groupBoxResult_TDV.Controls.Add(this.textBoxResult);
            this.groupBoxResult_TDV.Location = new System.Drawing.Point(565, 301);
            this.groupBoxResult_TDV.Name = "groupBoxResult_TDV";
            this.groupBoxResult_TDV.Size = new System.Drawing.Size(207, 73);
            this.groupBoxResult_TDV.TabIndex = 2;
            this.groupBoxResult_TDV.TabStop = false;
            this.groupBoxResult_TDV.Text = "Вывод данных";
            // 
            // textBoxResultOutput_TDV
            // 
            this.textBoxResultOutput_TDV.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResultOutput_TDV.Location = new System.Drawing.Point(7, 40);
            this.textBoxResultOutput_TDV.Name = "textBoxResultOutput_TDV";
            this.textBoxResultOutput_TDV.ReadOnly = true;
            this.textBoxResultOutput_TDV.Size = new System.Drawing.Size(194, 20);
            this.textBoxResultOutput_TDV.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 13);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Text = "Результат:";
            // 
            // buttonClick_TDV
            // 
            this.buttonClick_TDV.Location = new System.Drawing.Point(616, 381);
            this.buttonClick_TDV.Name = "buttonClick_TDV";
            this.buttonClick_TDV.Size = new System.Drawing.Size(156, 45);
            this.buttonClick_TDV.TabIndex = 3;
            this.buttonClick_TDV.Text = "Выполнить";
            this.buttonClick_TDV.UseVisualStyleBackColor = true;
            this.buttonClick_TDV.Click += new System.EventHandler(this.buttonClick_TDV_Click);
            // 
            // buttonHelp_TDV
            // 
            this.buttonHelp_TDV.Location = new System.Drawing.Point(565, 381);
            this.buttonHelp_TDV.Name = "buttonHelp_TDV";
            this.buttonHelp_TDV.Size = new System.Drawing.Size(45, 45);
            this.buttonHelp_TDV.TabIndex = 4;
            this.buttonHelp_TDV.Text = "?";
            this.buttonHelp_TDV.UseVisualStyleBackColor = true;
            this.buttonHelp_TDV.Click += new System.EventHandler(this.buttonHelp_TDV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_TDV);
            this.Controls.Add(this.buttonClick_TDV);
            this.Controls.Add(this.groupBoxResult_TDV);
            this.Controls.Add(this.groupBoxValue_TDV);
            this.Controls.Add(this.groupBoxCondition_TDV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 18 | Третьяков Д. В.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCondition_TDV.ResumeLayout(false);
            this.groupBoxCondition_TDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TDV)).EndInit();
            this.groupBoxValue_TDV.ResumeLayout(false);
            this.groupBoxValue_TDV.PerformLayout();
            this.groupBoxResult_TDV.ResumeLayout(false);
            this.groupBoxResult_TDV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_TDV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_TDV;
        private System.Windows.Forms.TextBox textBoxCondition_TDV;
        private System.Windows.Forms.GroupBox groupBoxValue_TDV;
        private System.Windows.Forms.TextBox textBoxInputX_TDV;
        private System.Windows.Forms.TextBox textBoxX_TDV;
        private System.Windows.Forms.GroupBox groupBoxResult_TDV;
        private System.Windows.Forms.TextBox textBoxResultOutput_TDV;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonClick_TDV;
        private System.Windows.Forms.Button buttonHelp_TDV;
    }
}

