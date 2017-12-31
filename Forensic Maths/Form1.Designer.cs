namespace Forensic_Maths
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
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

        #region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip ();
			this.trigonometryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.trianglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.complexArithmeticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.vectorArithmeticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.trigonometryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem ();
			this.polynomialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.equationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.simultaneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.gaussianReductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.quadraticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.matriciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.multiplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.loadNewDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator ();
			this.basicStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.distributionAndHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.correlationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.multipleRegressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.varianceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.theoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
			this.menuStrip1.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.trigonometryToolStripMenuItem,
            this.equationsToolStripMenuItem,
            this.matriciesToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point (0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size (658, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// trigonometryToolStripMenuItem
			// 
			this.trigonometryToolStripMenuItem.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.trianglesToolStripMenuItem,
            this.complexArithmeticToolStripMenuItem,
            this.vectorArithmeticToolStripMenuItem,
            this.trigonometryToolStripMenuItem1,
            this.polynomialsToolStripMenuItem});
			this.trigonometryToolStripMenuItem.Name = "trigonometryToolStripMenuItem";
			this.trigonometryToolStripMenuItem.Size = new System.Drawing.Size (92, 20);
			this.trigonometryToolStripMenuItem.Text = "Trigonometry";
			// 
			// trianglesToolStripMenuItem
			// 
			this.trianglesToolStripMenuItem.Name = "trianglesToolStripMenuItem";
			this.trianglesToolStripMenuItem.Size = new System.Drawing.Size (178, 22);
			this.trianglesToolStripMenuItem.Text = "Triangles";
			this.trianglesToolStripMenuItem.Click += new System.EventHandler (this.trianglesToolStripMenuItem_Click);
			// 
			// complexArithmeticToolStripMenuItem
			// 
			this.complexArithmeticToolStripMenuItem.Name = "complexArithmeticToolStripMenuItem";
			this.complexArithmeticToolStripMenuItem.Size = new System.Drawing.Size (178, 22);
			this.complexArithmeticToolStripMenuItem.Text = "Complex arithmetic";
			this.complexArithmeticToolStripMenuItem.Click += new System.EventHandler (this.complexArithmeticToolStripMenuItem_Click);
			// 
			// vectorArithmeticToolStripMenuItem
			// 
			this.vectorArithmeticToolStripMenuItem.Name = "vectorArithmeticToolStripMenuItem";
			this.vectorArithmeticToolStripMenuItem.Size = new System.Drawing.Size (178, 22);
			this.vectorArithmeticToolStripMenuItem.Text = "Vector arithmetic";
			this.vectorArithmeticToolStripMenuItem.Click += new System.EventHandler (this.vectorArithmeticToolStripMenuItem_Click);
			// 
			// trigonometryToolStripMenuItem1
			// 
			this.trigonometryToolStripMenuItem1.Name = "trigonometryToolStripMenuItem1";
			this.trigonometryToolStripMenuItem1.Size = new System.Drawing.Size (178, 22);
			this.trigonometryToolStripMenuItem1.Text = "Advanced Trig";
			this.trigonometryToolStripMenuItem1.Click += new System.EventHandler (this.trigonometryToolStripMenuItem1_Click);
			// 
			// polynomialsToolStripMenuItem
			// 
			this.polynomialsToolStripMenuItem.Name = "polynomialsToolStripMenuItem";
			this.polynomialsToolStripMenuItem.Size = new System.Drawing.Size (178, 22);
			this.polynomialsToolStripMenuItem.Text = "Polynomials";
			// 
			// equationsToolStripMenuItem
			// 
			this.equationsToolStripMenuItem.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.simultaneousToolStripMenuItem,
            this.gaussianReductionToolStripMenuItem,
            this.quadraticsToolStripMenuItem});
			this.equationsToolStripMenuItem.Name = "equationsToolStripMenuItem";
			this.equationsToolStripMenuItem.Size = new System.Drawing.Size (71, 20);
			this.equationsToolStripMenuItem.Text = "Equations";
			// 
			// simultaneousToolStripMenuItem
			// 
			this.simultaneousToolStripMenuItem.Name = "simultaneousToolStripMenuItem";
			this.simultaneousToolStripMenuItem.Size = new System.Drawing.Size (175, 22);
			this.simultaneousToolStripMenuItem.Text = "Simultaneous";
			this.simultaneousToolStripMenuItem.Click += new System.EventHandler (this.simultaneousToolStripMenuItem_Click);
			// 
			// gaussianReductionToolStripMenuItem
			// 
			this.gaussianReductionToolStripMenuItem.Name = "gaussianReductionToolStripMenuItem";
			this.gaussianReductionToolStripMenuItem.Size = new System.Drawing.Size (175, 22);
			this.gaussianReductionToolStripMenuItem.Text = "Gaussian reduction";
			this.gaussianReductionToolStripMenuItem.Click += new System.EventHandler (this.gaussianReductionToolStripMenuItem_Click);
			// 
			// quadraticsToolStripMenuItem
			// 
			this.quadraticsToolStripMenuItem.Name = "quadraticsToolStripMenuItem";
			this.quadraticsToolStripMenuItem.Size = new System.Drawing.Size (175, 22);
			this.quadraticsToolStripMenuItem.Text = "Quadratics";
			// 
			// matriciesToolStripMenuItem
			// 
			this.matriciesToolStripMenuItem.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.multiplicationToolStripMenuItem});
			this.matriciesToolStripMenuItem.Name = "matriciesToolStripMenuItem";
			this.matriciesToolStripMenuItem.Size = new System.Drawing.Size (67, 20);
			this.matriciesToolStripMenuItem.Text = "Matricies";
			// 
			// inversionToolStripMenuItem
			// 
			this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
			this.inversionToolStripMenuItem.Size = new System.Drawing.Size (148, 22);
			this.inversionToolStripMenuItem.Text = "Inversion";
			this.inversionToolStripMenuItem.Click += new System.EventHandler (this.inversionToolStripMenuItem_Click);
			// 
			// multiplicationToolStripMenuItem
			// 
			this.multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
			this.multiplicationToolStripMenuItem.Size = new System.Drawing.Size (148, 22);
			this.multiplicationToolStripMenuItem.Text = "Multiplication";
			this.multiplicationToolStripMenuItem.Click += new System.EventHandler (this.multiplicationToolStripMenuItem_Click);
			// 
			// statisticsToolStripMenuItem
			// 
			this.statisticsToolStripMenuItem.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.loadNewDatafileToolStripMenuItem,
            this.toolStripSeparator1,
            this.basicStatisticsToolStripMenuItem,
            this.distributionAndHistogramToolStripMenuItem,
            this.correlationToolStripMenuItem,
            this.multipleRegressionToolStripMenuItem,
            this.varianceToolStripMenuItem});
			this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
			this.statisticsToolStripMenuItem.Size = new System.Drawing.Size (65, 20);
			this.statisticsToolStripMenuItem.Text = "Statistics";
			// 
			// loadNewDatafileToolStripMenuItem
			// 
			this.loadNewDatafileToolStripMenuItem.Name = "loadNewDatafileToolStripMenuItem";
			this.loadNewDatafileToolStripMenuItem.Size = new System.Drawing.Size (218, 22);
			this.loadNewDatafileToolStripMenuItem.Text = "Load new datafile";
			this.loadNewDatafileToolStripMenuItem.Click += new System.EventHandler (this.loadNewDatafileToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size (215, 6);
			// 
			// basicStatisticsToolStripMenuItem
			// 
			this.basicStatisticsToolStripMenuItem.Enabled = false;
			this.basicStatisticsToolStripMenuItem.Name = "basicStatisticsToolStripMenuItem";
			this.basicStatisticsToolStripMenuItem.Size = new System.Drawing.Size (218, 22);
			this.basicStatisticsToolStripMenuItem.Text = "Basic statistics";
			//this.basicStatisticsToolStripMenuItem.Click += new System.EventHandler(this.basicStatisticsToolStripMenuItem_Click);
			// 
			// distributionAndHistogramToolStripMenuItem
			// 
			this.distributionAndHistogramToolStripMenuItem.Enabled = false;
			this.distributionAndHistogramToolStripMenuItem.Name = "distributionAndHistogramToolStripMenuItem";
			this.distributionAndHistogramToolStripMenuItem.Size = new System.Drawing.Size (218, 22);
			this.distributionAndHistogramToolStripMenuItem.Text = "Distribution and Histogram";
			//this.distributionAndHistogramToolStripMenuItem.Click += new System.EventHandler(this.distributionAndHistogramToolStripMenuItem_Click);
			// 
			// correlationToolStripMenuItem
			// 
			this.correlationToolStripMenuItem.Enabled = false;
			this.correlationToolStripMenuItem.Name = "correlationToolStripMenuItem";
			this.correlationToolStripMenuItem.Size = new System.Drawing.Size (218, 22);
			this.correlationToolStripMenuItem.Text = "Correlation";
			//this.correlationToolStripMenuItem.Click += new System.EventHandler(this.correlationToolStripMenuItem_Click);
			// 
			// multipleRegressionToolStripMenuItem
			// 
			this.multipleRegressionToolStripMenuItem.Enabled = false;
			this.multipleRegressionToolStripMenuItem.Name = "multipleRegressionToolStripMenuItem";
			this.multipleRegressionToolStripMenuItem.Size = new System.Drawing.Size (218, 22);
			this.multipleRegressionToolStripMenuItem.Text = "Multiple regression";
			//this.multipleRegressionToolStripMenuItem.Click += new System.EventHandler(this.multipleRegressionToolStripMenuItem_Click);
			// 
			// varianceToolStripMenuItem
			// 
			this.varianceToolStripMenuItem.Enabled = false;
			this.varianceToolStripMenuItem.Name = "varianceToolStripMenuItem";
			this.varianceToolStripMenuItem.Size = new System.Drawing.Size (218, 22);
			this.varianceToolStripMenuItem.Text = "Variance";
			//this.varianceToolStripMenuItem.Click += new System.EventHandler(this.varianceToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.theoryToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size (44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// theoryToolStripMenuItem
			// 
			this.theoryToolStripMenuItem.Name = "theoryToolStripMenuItem";
			this.theoryToolStripMenuItem.Size = new System.Drawing.Size (111, 22);
			this.theoryToolStripMenuItem.Text = "Theory";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size (111, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler (this.aboutToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (658, 401);
			this.Controls.Add (this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject ("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Forensic Maths";
			this.menuStrip1.ResumeLayout (false);
			this.menuStrip1.PerformLayout ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

        #endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem trigonometryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trianglesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem complexArithmeticToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vectorArithmeticToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trigonometryToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem polynomialsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem equationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem simultaneousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gaussianReductionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quadraticsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem matriciesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem theoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadNewDatafileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem basicStatisticsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem distributionAndHistogramToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem correlationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem multipleRegressionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem varianceToolStripMenuItem;
	}
}

