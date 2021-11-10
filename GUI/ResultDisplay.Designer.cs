
namespace Vsite.CSharp.KvadratnaJednadzba.GUI
{
    partial class ResultDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Coefficients = new System.Windows.Forms.GroupBox();
            this.numericUpDownc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowna = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDiscriminant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRoot2 = new System.Windows.Forms.TextBox();
            this.textBoxRoot1 = new System.Windows.Forms.TextBox();
            this.Coefficients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coefficients
            // 
            this.Coefficients.Controls.Add(this.numericUpDownc);
            this.Coefficients.Controls.Add(this.numericUpDownb);
            this.Coefficients.Controls.Add(this.numericUpDowna);
            this.Coefficients.Controls.Add(this.label5);
            this.Coefficients.Controls.Add(this.label3);
            this.Coefficients.Controls.Add(this.label2);
            this.Coefficients.Controls.Add(this.label1);
            this.Coefficients.Location = new System.Drawing.Point(14, 15);
            this.Coefficients.Name = "Coefficients";
            this.Coefficients.Size = new System.Drawing.Size(335, 159);
            this.Coefficients.TabIndex = 0;
            this.Coefficients.TabStop = false;
            this.Coefficients.Text = "Coefficients";
            // 
            // numericUpDownc
            // 
            this.numericUpDownc.DecimalPlaces = 2;
            this.numericUpDownc.Location = new System.Drawing.Point(87, 95);
            this.numericUpDownc.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownc.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownc.Name = "numericUpDownc";
            this.numericUpDownc.Size = new System.Drawing.Size(165, 22);
            this.numericUpDownc.TabIndex = 5;
            this.numericUpDownc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownc.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownb
            // 
            this.numericUpDownb.DecimalPlaces = 2;
            this.numericUpDownb.Location = new System.Drawing.Point(87, 67);
            this.numericUpDownb.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownb.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownb.Name = "numericUpDownb";
            this.numericUpDownb.Size = new System.Drawing.Size(165, 22);
            this.numericUpDownb.TabIndex = 4;
            this.numericUpDownb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownb.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDowna
            // 
            this.numericUpDowna.DecimalPlaces = 2;
            this.numericUpDowna.Location = new System.Drawing.Point(87, 39);
            this.numericUpDowna.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDowna.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDowna.Name = "numericUpDowna";
            this.numericUpDowna.Size = new System.Drawing.Size(165, 22);
            this.numericUpDowna.TabIndex = 3;
            this.numericUpDowna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDowna.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "&c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "&c:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "&b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Discriminat:";
            // 
            // textBoxDiscriminant
            // 
            this.textBoxDiscriminant.Location = new System.Drawing.Point(165, 190);
            this.textBoxDiscriminant.Name = "textBoxDiscriminant";
            this.textBoxDiscriminant.ReadOnly = true;
            this.textBoxDiscriminant.Size = new System.Drawing.Size(121, 22);
            this.textBoxDiscriminant.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRoot2);
            this.groupBox1.Controls.Add(this.textBoxRoot1);
            this.groupBox1.Location = new System.Drawing.Point(14, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Roots";
            // 
            // textBoxRoot2
            // 
            this.textBoxRoot2.Location = new System.Drawing.Point(53, 106);
            this.textBoxRoot2.Name = "textBoxRoot2";
            this.textBoxRoot2.ReadOnly = true;
            this.textBoxRoot2.Size = new System.Drawing.Size(219, 22);
            this.textBoxRoot2.TabIndex = 1;
            // 
            // textBoxRoot1
            // 
            this.textBoxRoot1.Location = new System.Drawing.Point(53, 57);
            this.textBoxRoot1.Name = "textBoxRoot1";
            this.textBoxRoot1.ReadOnly = true;
            this.textBoxRoot1.Size = new System.Drawing.Size(219, 22);
            this.textBoxRoot1.TabIndex = 0;
            // 
            // ResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDiscriminant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Coefficients);
            this.Name = "ResultDisplay";
            this.Size = new System.Drawing.Size(416, 505);
            this.Coefficients.ResumeLayout(false);
            this.Coefficients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Coefficients;
        private System.Windows.Forms.NumericUpDown numericUpDownc;
        private System.Windows.Forms.NumericUpDown numericUpDownb;
        private System.Windows.Forms.NumericUpDown numericUpDowna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDiscriminant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRoot2;
        private System.Windows.Forms.TextBox textBoxRoot1;
    }
}
