using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TretyakovDV.Sprint6.Task6.V22.Lib;
using System.IO;


namespace Tyuiu.TretyakovDV.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_TDV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_TDV.ShowDialog();
            openFilePath = openFileDialogTask_TDV.FileName;
            textBoxIn_TDV.Text = File.ReadAllText(openFilePath);
            groupBoxIn_TDV.Text = groupBoxIn_TDV.Text + " " + openFileDialogTask_TDV.FileName;
            buttonDone_TDV.Enabled = true;
        }

        private void buttonDone_TDV_Click(object sender, EventArgs e)
        {
            textBoxOut_TDV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_TDV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

    }
}
