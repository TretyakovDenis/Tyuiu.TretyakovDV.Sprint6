using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TretyakovDV.Sprint4.Task1.V29.Lib;

namespace Tyuiu.TretyakovDV.Sprint6.Task1.V29
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
                textBoxResult_TDV.Text = "";
                textBoxResult_TDV.AppendText("+-----------+-------------+" + Environment.NewLine);
                textBoxResult_TDV.AppendText("|     X     +    f(x)     |" + Environment.NewLine);
                textBoxResult_TDV.AppendText("+-----------+-------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("| {0,5:d}     | {1, 7:f2}     |", startStep, valueArray[i]);
                    textBoxResult_TDV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_TDV.AppendText("+-----------+-------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_TDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-1 Третьяков Денис Викторович", "Сообщение");
        }
        
    }
}
