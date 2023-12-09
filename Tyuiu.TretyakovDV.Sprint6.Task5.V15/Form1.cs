using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TretyakovDV.Sprint6.Task5.V15.Lib;
using System.IO;

namespace Tyuiu.TretyakovDV.Sprint6.Task5.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\Денис\source\repos\Tyuiu.TretyakovDV.Sprint6\Tyuiu.TretyakovDV.Sprint6.Task5.V15\bin\Debug\InPutFileTask5V15.txt";
        private void buttonClick_TDV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_TDV.ColumnCount = 2;
            dataGridViewResult_TDV.Columns[0].Width = 20;
            dataGridViewResult_TDV.Columns[1].Width = 50;

            this.chartDiag_TDV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_TDV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_TDV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_TDV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_TDV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_TDV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_TDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-1 Третьяков Денис Викторович", "Сообщение");
        }
    }
}
