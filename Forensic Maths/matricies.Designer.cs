namespace Forensic_Maths
{
    partial class matricies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(matricies));
            this.label1 = new System.Windows.Forms.Label();
            this.x1min = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.x1max = new System.Windows.Forms.NumericUpDown();
            this.x2max = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.x2min = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x1min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2min)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrix 1";
            // 
            // x1min
            // 
            this.x1min.Location = new System.Drawing.Point(63, 11);
            this.x1min.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x1min.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x1min.Name = "x1min";
            this.x1min.Size = new System.Drawing.Size(44, 20);
            this.x1min.TabIndex = 1;
            this.x1min.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x1min.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "by";
            // 
            // x1max
            // 
            this.x1max.Location = new System.Drawing.Point(137, 11);
            this.x1max.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x1max.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x1max.Name = "x1max";
            this.x1max.Size = new System.Drawing.Size(44, 20);
            this.x1max.TabIndex = 3;
            this.x1max.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x1max.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // x2max
            // 
            this.x2max.Location = new System.Drawing.Point(332, 11);
            this.x2max.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x2max.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x2max.Name = "x2max";
            this.x2max.Size = new System.Drawing.Size(44, 20);
            this.x2max.TabIndex = 7;
            this.x2max.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x2max.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "by";
            // 
            // x2min
            // 
            this.x2min.Location = new System.Drawing.Point(258, 11);
            this.x2min.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x2min.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x2min.Name = "x2min";
            this.x2min.Size = new System.Drawing.Size(44, 20);
            this.x2min.TabIndex = 5;
            this.x2min.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.x2min.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Matrix 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(187, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrix 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(358, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 144);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(16, 192);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(97, 191);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "Multiply";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // matricies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 225);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.x2max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x2min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x1max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x1min);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "matricies";
            this.Text = "Matrix multiplication";
            ((System.ComponentModel.ISupportInitialize)(this.x1min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown x1min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown x1max;
        private System.Windows.Forms.NumericUpDown x2max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown x2min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multiply;
    }
}