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
using Tyuiu.TretyakovDV.Sprint6.Task7.V29.Lib;

namespace Tyuiu.TretyakovDV.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_TDV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogMatrix_TDV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_TDV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_TDV.ShowDialog();
            openFilePath = openFileDialogTask_TDV.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_TDV.ColumnCount = columns;
            dataGridViewIn_TDV.RowCount = rows;
            dataGridViewOut_TDV.ColumnCount = columns;
            dataGridViewOut_TDV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_TDV.Columns[i].Width = 25;
                dataGridViewOut_TDV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_TDV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_TDV.Enabled = true;
        }

        private void buttonHelp_TDV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_TDV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_TDV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_TDV.Enabled = true;
        }

        private void buttonSaveFile_TDV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V29.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_TDV.RowCount;
            int colums = dataGridViewOut_TDV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums -1)
                    {
                        str = str + dataGridViewOut_TDV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_TDV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
