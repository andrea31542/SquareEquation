
namespace Vsite.CSharp.KvadratnaJednadzba.GUI
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
            this.resultDisplay = new Vsite.CSharp.KvadratnaJednadzba.GUI.ResultDisplay();
            this.resultDisplay1 = new Vsite.CSharp.KvadratnaJednadzba.GUI.ResultDisplay();
            this.resultDisplay2 = new Vsite.CSharp.KvadratnaJednadzba.GUI.ResultDisplay();
            this.resultDisplay3 = new Vsite.CSharp.KvadratnaJednadzba.GUI.ResultDisplay();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.Location = new System.Drawing.Point(31, 12);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(362, 432);
            this.resultDisplay.TabIndex = 1;
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(0, 0);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(416, 505);
            this.resultDisplay1.TabIndex = 2;
            // 
            // resultDisplay2
            // 
            this.resultDisplay2.Location = new System.Drawing.Point(0, 0);
            this.resultDisplay2.Name = "resultDisplay2";
            this.resultDisplay2.Size = new System.Drawing.Size(416, 505);
            this.resultDisplay2.TabIndex = 3;
            // 
            // resultDisplay3
            // 
            this.resultDisplay3.Location = new System.Drawing.Point(0, 0);
            this.resultDisplay3.Name = "resultDisplay3";
            this.resultDisplay3.Size = new System.Drawing.Size(416, 505);
            this.resultDisplay3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 501);
            this.Controls.Add(this.resultDisplay3);
            this.Controls.Add(this.resultDisplay2);
            this.Controls.Add(this.resultDisplay1);
            this.Controls.Add(this.resultDisplay);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay;
        private ResultDisplay resultDisplay1;
        private ResultDisplay resultDisplay2;
        private ResultDisplay resultDisplay3;
    }
}

