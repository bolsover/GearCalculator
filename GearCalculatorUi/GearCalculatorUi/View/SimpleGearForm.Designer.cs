namespace Bolsover.GearCalculatorUi.View
{
    partial class SimpleGearForm
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
            this.view = new Bolsover.GearCalculatorUi.View.SimpleGearView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(3, 120);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(10);
            this.view.Size = new System.Drawing.Size(1117, 602);
            this.view.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.view);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 833);
            this.panel1.TabIndex = 2;
            // 
            // SimpleGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 833);
            this.Controls.Add(this.panel1);
            this.Name = "SimpleGearForm";
            this.Text = "Simple Involute Gear";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;

        private Bolsover.GearCalculatorUi.View.SimpleGearView view;

        #endregion
    }
}