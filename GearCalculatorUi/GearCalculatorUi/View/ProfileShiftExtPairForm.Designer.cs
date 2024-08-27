using System.ComponentModel;

namespace Bolsover.GearCalculatorUi.View;

partial class ProfileShiftExtPairForm
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
            this.profileShiftExtPairView1 = new Bolsover.GearCalculatorUi.View.ProfileShiftExtPairView();
            this.SuspendLayout();
            // 
            // profileShiftExtPairView1
            // 
            this.profileShiftExtPairView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileShiftExtPairView1.Location = new System.Drawing.Point(0, 0);
            this.profileShiftExtPairView1.Name = "profileShiftExtPairView1";
            this.profileShiftExtPairView1.Padding = new System.Windows.Forms.Padding(5);
            this.profileShiftExtPairView1.Size = new System.Drawing.Size(1638, 1097);
            this.profileShiftExtPairView1.TabIndex = 0;
            // 
            // ProfileShiftExtPairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 1097);
            this.Controls.Add(this.profileShiftExtPairView1);
            this.Name = "ProfileShiftExtPairForm";
            this.Text = "ProfileShiftExtPairForm";
            this.ResumeLayout(false);

    }

    #endregion

    private ProfileShiftExtPairView profileShiftExtPairView1;
}