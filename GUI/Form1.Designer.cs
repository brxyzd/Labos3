
namespace Vsite.Csharp.KvadratnaJednadzba.Gui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.functionPanel = new Vsite.Csharp.KvadratnaJednadzba.Gui.FunctionPanel();
            this.resultDisplay1 = new Vsite.Csharp.KvadratnaJednadzba.Gui.ResultDisplay();
            this.SuspendLayout();
            // 
            // functionPanel
            // 
            this.functionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.functionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionPanel.Location = new System.Drawing.Point(428, 12);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(531, 489);
            this.functionPanel.TabIndex = 1;
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(21, 12);
            this.resultDisplay1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(437, 489);
            this.resultDisplay1.TabIndex = 0;
            this.resultDisplay1.CoefficientChanged += new System.EventHandler(this.resultDisplay1_CoefficientChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 562);
            this.Controls.Add(this.functionPanel);
            this.Controls.Add(this.resultDisplay1);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay1;
        private FunctionPanel functionPanel;
    }
}

