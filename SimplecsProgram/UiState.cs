using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplecsProgram
{
    public class UiState
    {
        private Form1 form;

        public UiState(Form1 form)
        {
            this.form = form;
            initForm();
        } 

        public int countArgs { private set; get; } = 2;
        public int countLimits { private set; get; } = 3;

        public bool isMath { private set; get; } = true;
        public bool isCanon { private set; get; } = false;

        private void initForm()
        {
            form.mathButton.Enabled = !isMath;
            form.canonButton.Enabled = !isCanon;
            form.countArgsLabel.Text = countArgs.ToString();
            form.countLimitLabel.Text = countLimits.ToString();
            form.funcTable.Rows.Add();
            updateTablesAndLabels();
        }

        public void setMath()
        {
            if (isMath) return;
            changeCountArgs(-countLimits);

            isMath = true;
            isCanon = false;

            form.mathButton.Enabled = false;
            form.canonButton.Enabled = true;
        }

        public void setCanon()
        {
            if (isCanon) return;
            changeCountArgs(+countLimits);

            isMath = false;
            isCanon = true;

            form.mathButton.Enabled = true;
            form.canonButton.Enabled = false;
        }

        public void changeCountArgs(int difference)
        {
            if (countArgs + difference < 0)
            {
                countArgs = 0;
            } 
            else
            {
                countArgs += difference;
            }
            form.countArgsLabel.Text = countArgs.ToString();
            
            updateTablesAndLabels();
        }

        public void changeCountLimits(int difference)
        {
            if (countLimits + difference < 0)
            {
                countLimits = 0;
            } 
            else
            {
                countLimits += difference;
            }
            form.countLimitLabel.Text = countLimits.ToString();
            
            updateTablesAndLabels();
        }

        public void updateFuncLabel()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("F(x) = ");
            for (int i = 0; i < countArgs; i++)
            {
                float value = getFloat(form.funcTable[i, 0].Value);
                if (value >= 0 && i != 0) 
                    builder.Append("+ ");
                builder.Append(value);
                builder.Append("x");
                builder.Append(i+1);
                builder.Append(" ");
            }
            form.functionLabel.Text = builder.ToString();
        }

        public void updateLimitsLabel()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < countLimits; i++)
            {
                int j;
                for (j = 0; j < countArgs; j++)
                {
                    float value = getFloat(form.limitTable[j, i].Value);
                    if (value >= 0 && j != 0) 
                        builder.Append("+ ");
                    builder.Append(value);
                    builder.Append("x");
                    builder.Append(j+1);
                    builder.Append(" ");
                }
                builder.Append(" = ");
                builder.Append(getFloat(form.limitValuesTable[0, i].Value));
                builder.Append("\n");
            }
            form.limitsLabel.Text = builder.ToString();
        }
        
        private float getFloat(object value)
        {
            try
            {
                return float.Parse(value.ToString());
            }
            catch (Exception exception)
            {
                return 0;
            }
        }

        public void updateTablesAndLabels()
        {
            if (form.funcTable.ColumnCount != countArgs)
            {
                if (form.funcTable.ColumnCount < countArgs)
                {
                    for (int i = form.funcTable.ColumnCount; i < countArgs; i++)
                    {
                        form.funcTable.Columns.Add("", "");
                    }
                }
                else
                {
                    for (int i = form.funcTable.ColumnCount - 1; i >= countArgs; i--)
                    {
                        form.funcTable.Columns.RemoveAt(form.funcTable.ColumnCount - 1);
                    }
                }
            }

            if (form.limitTable.ColumnCount != countArgs)
            {
                if (form.limitTable.ColumnCount < countArgs)
                {
                    for (int i = form.limitTable.ColumnCount; i < countArgs; i++)
                    {
                        form.limitTable.Columns.Add("", "");
                    }
                }
                else
                {
                    for (int i = form.limitTable.ColumnCount - 1; i >= countArgs; i--)
                    {
                        form.limitTable.Columns.RemoveAt(form.limitTable.ColumnCount - 1);
                    }
                }
            }

            if (form.limitTable.RowCount != countLimits)
            {
                if (form.limitTable.RowCount < countLimits)
                {
                    for (int i = form.limitTable.RowCount; i < countLimits; i++)
                    {
                        form.limitTable.Rows.Add();
                        form.limitValuesTable.Rows.Add();
                    }
                }
                else
                {
                    for (int i = form.limitTable.RowCount - 1; i >= countLimits; i--)
                    {
                        form.limitTable.Rows.RemoveAt(form.limitTable.RowCount - 1);
                        form.limitValuesTable.Rows.RemoveAt(form.limitValuesTable.RowCount - 1);
                    }
                }
            }

            updateFuncLabel();
            updateLimitsLabel();
        }
        
        public List<List<float>> getFloatLimits()
        {
            List<List<float>> result = new List<List<float>>();
            for (int row = 0; row < form.limitTable.RowCount; row++)
            {
                result.Add(new List<float>());
                for (int column = 0; column < form.limitTable.ColumnCount; column++)
                {
                    result[row].Add(getFloat(form.limitTable[column, row].Value));
                }
            }
            return result;
        }
        
        public List<float> getFloatArgs()
        {
            List<float> result = new List<float>();
            for (int column = 0; column < form.funcTable.ColumnCount; column++)
            {
                result.Add(getFloat(form.funcTable[column, 0].Value));
            }
            return result;
        }
        
        public List<float> getFloatLimitValues()
        {
            List<float> result = new List<float>();
            for (int row = 0; row < form.limitValuesTable.RowCount; row++)
            {
                result.Add(getFloat(form.limitValuesTable[0, row].Value));
            }
            return result;
        }
    }
}
