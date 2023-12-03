using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TretyakovDV.Sprint4.Task2.V4.Lib;

namespace Tyuiu.TretyakovDV.Sprint6.Task2.V4
{
    public partial class Form1 : Form
    {
        public Form1()
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

                this.chartFunction_TDV.Titles.Add("График функции");
                this.chartFunction_TDV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_TDV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_TDV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_TDV.Series[0].Points.AddXY(startStep, valueArray[i]);
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
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-1 Третьяков Денис Викторович", "Сообщение");
        }

        private void buttonClick_TDV_MouseEnter(object sender, EventArgs e)
        {
            buttonClick_TDV.BackColor = Color.Red;
        }

        private void buttonClick_TDV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonClick_TDV.BackColor = Color.Green;
        }

        private void buttonClick_TDV_MouseLeave(object sender, EventArgs e)
        {
            buttonClick_TDV.BackColor = Color.Blue;
        }
    }
}
