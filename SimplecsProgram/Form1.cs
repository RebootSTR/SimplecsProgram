using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplecsProgram
{
    public partial class Form1 : Form
    {
        private UiState uiState;
        
        public Form1()
        {
            InitializeComponent();
            uiState = new UiState(this);
            //debugInit();
        }

        private void debugInit()
        {
            this.funcTable[0, 0].Value = "3";
            this.funcTable[1, 0].Value = "-2";

            this.limitTable[0, 0].Value = "1";
            this.limitTable[1, 0].Value = "2";
            
            this.limitTable[0, 1].Value = "-2";
            this.limitTable[1, 1].Value = "1";
            
            this.limitTable[0, 2].Value = "1";
            this.limitTable[1, 2].Value = "-1";

            this.limitValuesTable[0, 0].Value = "8";
            this.limitValuesTable[0, 1].Value = "2";
            this.limitValuesTable[0, 2].Value = "12";
            
            uiState.updateTablesAndLabels();
        }

        private void canonButton_Click(object sender, EventArgs e)
        {
            uiState.setCanon();
        }

        private void mathButton_Click(object sender, EventArgs e)
        {
            uiState.setMath();
        }

        private void argLessButton_Click(object sender, EventArgs e)
        {
            uiState.changeCountArgs(-1);
        }

        private void argMoreButton_Click(object sender, EventArgs e)
        {
            uiState.changeCountArgs(1);
        }

        private void limitLessButton_Click(object sender, EventArgs e)
        {
            uiState.changeCountLimits(-1);
        }

        private void limitMoreButton_Click(object sender, EventArgs e)
        {
            uiState.changeCountLimits(1);
        }

        private void funcTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            uiState.updateFuncLabel();
        }

        private void limitTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            uiState.updateLimitsLabel();
        }

        private void limitValuesTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            uiState.updateLimitsLabel();
        }

        private void findMaxButton_Click(object sender, EventArgs e)
        {
            calculate(true);
        }

        private void finMinButton_Click(object sender, EventArgs e)
        {
            calculate(false);
        }

        private void calculate(bool isMax)
        {
            var args = uiState.getFloatArgs();
            var limits = uiState.getFloatLimits();
            var limitValues = uiState.getFloatLimitValues();
            var simplecs = new SimplecsObject(args, limits, limitValues, uiState.isCanon);
            new ResultBox(isMax, simplecs).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] templateFile = Properties.Resources.Тема_1;
            string tempPath = $"{Path.GetTempFileName()}.pdf";
            using (MemoryStream ms = new MemoryStream(templateFile))
            {
                using (FileStream fs = new FileStream(tempPath, FileMode.OpenOrCreate))
                {
                    ms.WriteTo(fs);
                    fs.Close();
                }
                ms.Close();
            }
            Process.Start(tempPath);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель программы: Рафиков А.Р.\nПрограмма создана для предмета \"Математическое Программирование\"\n\nP.S. Запомните меня, скоро буду на вершине :)");
        }
    }
}
