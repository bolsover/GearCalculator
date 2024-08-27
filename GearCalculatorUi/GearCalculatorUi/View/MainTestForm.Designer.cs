using System.ComponentModel;

namespace Bolsover.GearCalculatorUi.View;

partial class MainTestForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.pairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.profileShiftPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.formsToolStripMenuItem });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(800, 28);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // formsToolStripMenuItem
        // 
        this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.simpleToolStripMenuItem, this.pairToolStripMenuItem, this.profileShiftPairToolStripMenuItem });
        this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
        this.formsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
        this.formsToolStripMenuItem.Text = "Forms";
        // 
        // simpleToolStripMenuItem
        // 
        this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
        this.simpleToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
        this.simpleToolStripMenuItem.Text = "Simple";
        this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
        // 
        // pairToolStripMenuItem
        // 
        this.pairToolStripMenuItem.Name = "pairToolStripMenuItem";
        this.pairToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
        this.pairToolStripMenuItem.Text = "Pair";
        this.pairToolStripMenuItem.Click += new System.EventHandler(this.pairToolStripMenuItem_Click);
        // 
        // profileShiftPairToolStripMenuItem
        // 
        this.profileShiftPairToolStripMenuItem.Name = "profileShiftPairToolStripMenuItem";
        this.profileShiftPairToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
        this.profileShiftPairToolStripMenuItem.Text = "ProfileShiftPair";
        this.profileShiftPairToolStripMenuItem.Click += new System.EventHandler(this.profileShiftPairToolStripMenuItem_Click);
        // 
        // MainTestForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "MainTestForm";
        this.Text = "MainTestForm";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pairToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem profileShiftPairToolStripMenuItem;

    #endregion
}