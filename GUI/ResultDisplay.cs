using QuadraticEquation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.Csharp.KvadratnaJednadzba.Gui
{
    public partial class ResultDisplay : UserControl
    {
        public Action<int> MyFunction;
        private QuadraticEquation.QuadraticEquation quadraticEquation;

        public event EventHandler CoefficientChanged;
        
        public ResultDisplay()
        {
            quadraticEquation = new QuadraticEquation.QuadraticEquation();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public double CalculateY(double x)
        {
            return this.quadraticEquation.Y(x);
        }

        private void FillResults()
        {
            quadraticEquation.A = (double)this.numericUpDownA.Value;
            quadraticEquation.B = (double)this.numericUpDownB.Value;
            quadraticEquation.C = (double)this.numericUpDownC.Value;

            this.Discriminant.Text = quadraticEquation.Discriminant.ToString();
            var roots = quadraticEquation.RootsComplex;
            this.textBoxRoots1.Text = roots[0].ToString();
            this.textBoxRoots2.Text = roots[1].ToString();

        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            FillResults();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
            if (CoefficientChanged != null)
            {
                CoefficientChanged(this, EventArgs.Empty);
            }
        }
    }
}
