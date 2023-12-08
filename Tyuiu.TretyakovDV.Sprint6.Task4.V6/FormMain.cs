using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TretyakovDV.Sprint6.Task4.V6.Lib;

namespace Tyuiu.TretyakovDV.Sprint6.Task4.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonClick_TDV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_TDV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_TDV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_TDV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_TDV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_TDV.Text = "";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_TDV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_TDV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_TDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-1 Третьяков Денис Викторович", "Сообщение");
        }

        private void buttonSave_TDV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{ Directory.GetCurrentDirectory()}/OutPutFileTask4V6.txt";
                File.WriteAllText(path, textBoxResult_TDV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
