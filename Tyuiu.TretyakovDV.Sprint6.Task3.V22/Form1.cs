using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TretyakovDV.Sprint6.Task3.V22.Lib;

namespace Tyuiu.TretyakovDV.Sprint6.Task2.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int [,] mtrx = new int[5,5] { { 17, 0, 19, -8, -1 },
                                           { 9, 4, -5, 7, 15 },
                                           { 11, 13, 4, -4, -14 },
                                           { 11, 14, 5, -15, 16 },
                                           { 2, -14, -2, 11, 11 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_TDV.ColumnCount = columns;
            dataGridViewMatrix_TDV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_TDV.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    dataGridViewMatrix_TDV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
            }
        }
        private void buttonClick_TDV_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_TDV.ColumnCount = columns;
            dataGridViewResult_TDV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_TDV.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    dataGridViewResult_TDV.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
            }
        }

        private void buttonHelp_TDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-1 Третьяков Денис Викторович", "Сообщение");
        }
    }
}
