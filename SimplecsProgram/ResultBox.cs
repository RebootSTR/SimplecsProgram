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
    public partial class ResultBox : Form
    {
        private const int LIMITER = 20;

        SimplecsObject simplecs;
        List<SimplecsObject> simplecsObjects = new List<SimplecsObject>();
        private bool isMax;

        public ResultBox(bool isMax, SimplecsObject simplecs)
        {
            InitializeComponent();
            this.simplecs = simplecs;
            this.isMax = isMax;
            this.message.Text = "Подождите...";
            this.title.Text = isMax ? "Поиск максимума" : "Поиск минимума";
            Task task = new Task(startCalculating);
            task.Start();
        }

        private void startCalculating()
        {
            simplecsObjects.Add(simplecs);
            for (int i = 0; i < LIMITER; i++)
            {
                try
                {
                    if (i + 1 == LIMITER)
                    {
                        throw new NoResultException();
                    }
                    simplecs = isMax ? SimplecsCalc.calculateMax(simplecs) : SimplecsCalc.calculateMin(simplecs);
                    simplecsObjects.Add(simplecs);
                }
                catch (NoResultException exception)
                {
                    message.Text = "Результата нет";
                    showTablesButton.Enabled = false;
                    return;
                }
                catch (AlreadySolvedException exception)
                {
                    break;
                }
            }
            var builder = new StringBuilder();
            builder.Append("F = ");
            builder.Append(simplecs.getF());
            builder.Append("\n\n");
            for (int i = 0; i < simplecs.args.Count; i++)
            {
                builder.Append("x");
                builder.Append(i + 1);
                builder.Append(" = ");
                builder.Append(simplecs.getX(i));
                builder.Append("\n");
            }
            message.Text = builder.ToString();
        }

        private void showTablesButton_Click(object sender, EventArgs e)
        {
            new SimplecsTables(simplecsObjects).Show();
        }
    }
}
