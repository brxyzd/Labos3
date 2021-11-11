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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            functionPanel.Function = resultDisplay1.CalculateY;
        }

        private void resultDisplay1_CoefficientChanged(object sender, EventArgs e)
        {
            functionPanel.Invalidate();
        }
    }
}
