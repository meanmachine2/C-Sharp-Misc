namespace GUI_Currency_Converter
{
    partial class CurrencyConverter
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
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(52, 16);
            this.numericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BGN TO EURO";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(49, 65);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(351, 30);
            this.labelResult.TabIndex = 2;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Click += new System.EventHandler(this.LabelResult_Click);
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 133);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown);
            this.Name = "CurrencyConverter";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
    }
}

