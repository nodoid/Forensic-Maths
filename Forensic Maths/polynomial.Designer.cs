namespace Forensic_Maths
{
    partial class polynomial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(polynomial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setCoefficientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polynomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateFxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differentiateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonianRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCoefficientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setCoefficientsToolStripMenuItem
            // 
            this.setCoefficientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polynomialToolStripMenuItem,
            this.evaluateFxToolStripMenuItem,
            this.differentiateToolStripMenuItem,
            this.integrateToolStripMenuItem,
            this.newtonianRootToolStripMenuItem});
            this.setCoefficientsToolStripMenuItem.Name = "setCoefficientsToolStripMenuItem";
            this.setCoefficientsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.setCoefficientsToolStripMenuItem.Text = "Calculate";
            // 
            // polynomialToolStripMenuItem
            // 
            this.polynomialToolStripMenuItem.Name = "polynomialToolStripMenuItem";
            this.polynomialToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.polynomialToolStripMenuItem.Text = "Polynomial";
            // 
            // evaluateFxToolStripMenuItem
            // 
            this.evaluateFxToolStripMenuItem.Name = "evaluateFxToolStripMenuItem";
            this.evaluateFxToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.evaluateFxToolStripMenuItem.Text = "Evaluate F(x)";
            // 
            // differentiateToolStripMenuItem
            // 
            this.differentiateToolStripMenuItem.Name = "differentiateToolStripMenuItem";
            this.differentiateToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.differentiateToolStripMenuItem.Text = "Differentiate";
            // 
            // integrateToolStripMenuItem
            // 
            this.integrateToolStripMenuItem.Name = "integrateToolStripMenuItem";
            this.integrateToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.integrateToolStripMenuItem.Text = "Integrate";
            // 
            // newtonianRootToolStripMenuItem
            // 
            this.newtonianRootToolStripMenuItem.Name = "newtonianRootToolStripMenuItem";
            this.newtonianRootToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newtonianRootToolStripMenuItem.Text = "Newtonian Root";
            // 
            // polynomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 314);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "polynomial";
            this.Text = "Polynomials";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setCoefficientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polynomialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateFxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differentiateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonianRootToolStripMenuItem;

    }
}