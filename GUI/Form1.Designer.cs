
using DrawingQuadraticEquation;

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
            //this.functionPanel1 = new FunctionPanel();
            this.resultDisplay1 = new Vsite.Csharp.KvadratnaJednadzba.Gui.ResultDisplay();
            //((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // functionPanel1
            // 
            //this.functionPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.functionPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //this.functionPanel1.Location = new System.Drawing.Point(464, 12);
            //this.functionPanel1.Name = "functionPanel1";
            //this.functionPanel1.Size = new System.Drawing.Size(517, 520);
            //this.functionPanel1.TabIndex = 1;
            //this.functionPanel1.TabStop = false;
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(21, 12);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(437, 489);
            this.resultDisplay1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 562);
            //this.Controls.Add(this.functionPanel1);
            this.Controls.Add(this.resultDisplay1);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            //((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay1;
        //private FunctionPanel functionPanel1;
    }
}

