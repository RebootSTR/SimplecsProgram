using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplecsProgram
{
    public partial class SimplecsTables : Form
    {
        private List<SimplecsObject> simplecsObjects;
        private int selected = 0;
        
        public SimplecsTables(List<SimplecsObject> simplecsObjects)
        {
            InitializeComponent();
            this.simplecsObjects = simplecsObjects;
            initTable(0);

            prevButton.Enabled = false;
            if (selected == simplecsObjects.Count - 1)
            {
                nextButton.Enabled = false;
            }
        }

        private void initTable(int index)
        {
            table.Rows.Clear();
            table.Columns.Clear();
            table.Columns.Add("", "");

            table.Rows.Add();
            table.Rows.Add();
            
            table.Columns.Add("", "");
            table[0, 0].Value = "N";
            table.Columns.Add("", "");
            table[1, 0].Value = "Базис";
            table.Columns.Add("", "");
            table[2, 0].Value = "Cb";
            table.Columns.Add("", "");
            table[3, 0].Value = "b";
            
            table.Columns.Add("", "");
            table.Columns.Add("", "");
            table.Columns.Add("", "");
            table.Columns.Add("", "");

            int row;
            for (row = 0; row < simplecsObjects[index].limits.Count; row++)
            {
                table.Rows.Add();

                table[0, row+1].Value = "" + row;
                    
                table[1, row+1].Value = "A" + (simplecsObjects[index].basisIndexes[row] + 1);
                    
                table[2, row+1].Value = simplecsObjects[index].basis[row];
                    
                table[3, row+1].Value = simplecsObjects[index].limitValues[row];
                
                for (int column = 0; column < simplecsObjects[index].args.Count; column++)
                {
                    if (row == 0)
                    {
                        // header
                        table[4 + column, 0].Value = "A" + (column + 1);
                    }
                    
                    table[4 + column, row+1].Value = simplecsObjects[index].limits[row][column];
                }
            }
            
            // F
            table[3, row + 1].Value = "F=" + simplecsObjects[index].getF();
            
            for (int column = 0; column < simplecsObjects[index].args.Count; column++)
            {
                // alpha;
                table[4 + column, row+1].Value = "a" + (column + 1) + "=" + simplecsObjects[index].getAlpha(column);
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (selected - 1 >= 0)
            {
                selected--;
                if (selected == 0)
                {
                    prevButton.Enabled = false;
                }
                initTable(selected);
                nextButton.Enabled = true;
            } 
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (selected + 1 <= simplecsObjects.Count)
            {
                selected++;
                if (selected == simplecsObjects.Count - 1)
                {
                    nextButton.Enabled = false;
                }
                initTable(selected);
                prevButton.Enabled = true;
            }
        }
    }
}
