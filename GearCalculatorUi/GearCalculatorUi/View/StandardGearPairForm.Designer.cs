using System.ComponentModel;

namespace Bolsover.GearCalculatorUi.View;

partial class StandardGearPairForm
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
        this.view = new Bolsover.GearCalculatorUi.View.StandardGearPairView();
        this.SuspendLayout();
        // 
        // view
        // 
        this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.view.Dock = System.Windows.Forms.DockStyle.Fill;
        this.view.Location = new System.Drawing.Point(0, 0);
        this.view.Margin = new System.Windows.Forms.Padding(2);
        this.view.Name = "view";
        this.view.Padding = new System.Windows.Forms.Padding(8);
        this.view.Size = new System.Drawing.Size(929, 406);
        this.view.TabIndex = 0;
        // 
        // StandardGearPairForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.ClientSize = new System.Drawing.Size(929, 406);
        this.Controls.Add(this.view);
        this.Margin = new System.Windows.Forms.Padding(2);
        this.Name = "StandardGearPairForm";
        this.Text = "Standard Gear Pair";
        this.ResumeLayout(false);
    }
    private Bolsover.GearCalculatorUi.View.StandardGearPairView view;
    #endregion
}