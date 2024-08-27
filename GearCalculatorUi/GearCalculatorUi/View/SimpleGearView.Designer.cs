using System.ComponentModel;

namespace Bolsover.GearCalculatorUi.View
{
    partial class SimpleGearView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.moduleLabel = new System.Windows.Forms.Label();
            this.moduleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.moduleSymbol = new System.Windows.Forms.Label();
            this.pitchDiameterLabel = new System.Windows.Forms.Label();
            this.pitchDiameterTextBox = new System.Windows.Forms.TextBox();
            this.pitchDiameterFormula = new System.Windows.Forms.Label();
            this.pitchDiameterSymbol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teethLabel = new System.Windows.Forms.Label();
            this.teethSymbol = new System.Windows.Forms.Label();
            this.teethNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pressureAngleLabel = new System.Windows.Forms.Label();
            this.pressureAngleSymbol = new System.Windows.Forms.Label();
            this.pressureAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baseDiameterLabel = new System.Windows.Forms.Label();
            this.baseDiameterSymbol = new System.Windows.Forms.Label();
            this.baseDiameterFormula = new System.Windows.Forms.Label();
            this.baseDiameterTextBox = new System.Windows.Forms.TextBox();
            this.addendumLabel = new System.Windows.Forms.Label();
            this.addendumSymbol = new System.Windows.Forms.Label();
            this.addendumFormula = new System.Windows.Forms.Label();
            this.dedendumLabel = new System.Windows.Forms.Label();
            this.dedendumSymbol = new System.Windows.Forms.Label();
            this.dedendumFormula = new System.Windows.Forms.Label();
            this.addendumTextBox = new System.Windows.Forms.TextBox();
            this.dedendumTextBox = new System.Windows.Forms.TextBox();
            this.outsideDiameterLabel = new System.Windows.Forms.Label();
            this.rootDiameterLabel = new System.Windows.Forms.Label();
            this.outsideDiameterSymbol = new System.Windows.Forms.Label();
            this.rootDiameterSymbol = new System.Windows.Forms.Label();
            this.outsideDiameterFormula = new System.Windows.Forms.Label();
            this.rootDiameterFormula = new System.Windows.Forms.Label();
            this.outsideDiameterTextBox = new System.Windows.Forms.TextBox();
            this.rootDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.moduleImperial = new System.Windows.Forms.TextBox();
            this.teethImperial = new System.Windows.Forms.TextBox();
            this.pressureAngleImperial = new System.Windows.Forms.TextBox();
            this.pitchDiameterImperial = new System.Windows.Forms.TextBox();
            this.baseDiameterImperial = new System.Windows.Forms.TextBox();
            this.addendumImperial = new System.Windows.Forms.TextBox();
            this.dedendumImperial = new System.Windows.Forms.TextBox();
            this.outsideDiameterImperial = new System.Windows.Forms.TextBox();
            this.rootDiameterImperial = new System.Windows.Forms.TextBox();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teethNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureAngleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanel.ColumnCount = 5;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.Controls.Add(this.moduleLabel, 0, 1);
            this.tablePanel.Controls.Add(this.moduleNumericUpDown, 3, 1);
            this.tablePanel.Controls.Add(this.moduleSymbol, 1, 1);
            this.tablePanel.Controls.Add(this.pitchDiameterLabel, 0, 4);
            this.tablePanel.Controls.Add(this.pitchDiameterTextBox, 3, 4);
            this.tablePanel.Controls.Add(this.pitchDiameterFormula, 2, 4);
            this.tablePanel.Controls.Add(this.pitchDiameterSymbol, 1, 4);
            this.tablePanel.Controls.Add(this.label1, 0, 0);
            this.tablePanel.Controls.Add(this.label2, 1, 0);
            this.tablePanel.Controls.Add(this.label3, 2, 0);
            this.tablePanel.Controls.Add(this.label4, 3, 0);
            this.tablePanel.Controls.Add(this.teethLabel, 0, 2);
            this.tablePanel.Controls.Add(this.teethSymbol, 1, 2);
            this.tablePanel.Controls.Add(this.teethNumericUpDown, 3, 2);
            this.tablePanel.Controls.Add(this.pressureAngleLabel, 0, 3);
            this.tablePanel.Controls.Add(this.pressureAngleSymbol, 1, 3);
            this.tablePanel.Controls.Add(this.pressureAngleNumericUpDown, 3, 3);
            this.tablePanel.Controls.Add(this.baseDiameterLabel, 0, 5);
            this.tablePanel.Controls.Add(this.baseDiameterSymbol, 1, 5);
            this.tablePanel.Controls.Add(this.baseDiameterFormula, 2, 5);
            this.tablePanel.Controls.Add(this.baseDiameterTextBox, 3, 5);
            this.tablePanel.Controls.Add(this.addendumLabel, 0, 6);
            this.tablePanel.Controls.Add(this.addendumSymbol, 1, 6);
            this.tablePanel.Controls.Add(this.addendumFormula, 2, 6);
            this.tablePanel.Controls.Add(this.dedendumLabel, 0, 7);
            this.tablePanel.Controls.Add(this.dedendumSymbol, 1, 7);
            this.tablePanel.Controls.Add(this.dedendumFormula, 2, 7);
            this.tablePanel.Controls.Add(this.addendumTextBox, 3, 6);
            this.tablePanel.Controls.Add(this.dedendumTextBox, 3, 7);
            this.tablePanel.Controls.Add(this.outsideDiameterLabel, 0, 8);
            this.tablePanel.Controls.Add(this.rootDiameterLabel, 0, 9);
            this.tablePanel.Controls.Add(this.outsideDiameterSymbol, 1, 8);
            this.tablePanel.Controls.Add(this.rootDiameterSymbol, 1, 9);
            this.tablePanel.Controls.Add(this.outsideDiameterFormula, 2, 8);
            this.tablePanel.Controls.Add(this.rootDiameterFormula, 2, 9);
            this.tablePanel.Controls.Add(this.outsideDiameterTextBox, 3, 8);
            this.tablePanel.Controls.Add(this.rootDiameterTextBox, 3, 9);
            this.tablePanel.Controls.Add(this.label5, 4, 0);
            this.tablePanel.Controls.Add(this.moduleImperial, 4, 1);
            this.tablePanel.Controls.Add(this.teethImperial, 4, 2);
            this.tablePanel.Controls.Add(this.pressureAngleImperial, 4, 3);
            this.tablePanel.Controls.Add(this.pitchDiameterImperial, 4, 4);
            this.tablePanel.Controls.Add(this.baseDiameterImperial, 4, 5);
            this.tablePanel.Controls.Add(this.addendumImperial, 4, 6);
            this.tablePanel.Controls.Add(this.dedendumImperial, 4, 7);
            this.tablePanel.Controls.Add(this.outsideDiameterImperial, 4, 8);
            this.tablePanel.Controls.Add(this.rootDiameterImperial, 4, 9);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 11;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePanel.Size = new System.Drawing.Size(1007, 536);
            this.tablePanel.TabIndex = 0;
            // 
            // moduleLabel
            // 
            this.moduleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleLabel.Location = new System.Drawing.Point(4, 52);
            this.moduleLabel.Name = "moduleLabel";
            this.moduleLabel.Size = new System.Drawing.Size(194, 50);
            this.moduleLabel.TabIndex = 0;
            this.moduleLabel.Text = "m";
            this.moduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moduleNumericUpDown
            // 
            this.moduleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.moduleNumericUpDown.DecimalPlaces = 3;
            this.moduleNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.moduleNumericUpDown.Location = new System.Drawing.Point(607, 63);
            this.moduleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.moduleNumericUpDown.Name = "moduleNumericUpDown";
            this.moduleNumericUpDown.Size = new System.Drawing.Size(194, 27);
            this.moduleNumericUpDown.TabIndex = 2;
            this.moduleNumericUpDown.Value = new decimal(new int[] { 25, 0, 0, 65536 });
            this.moduleNumericUpDown.ValueChanged += new System.EventHandler(this.moduleNumericUpDown_ValueChanged);
            // 
            // moduleSymbol
            // 
            this.moduleSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleSymbol.Location = new System.Drawing.Point(205, 52);
            this.moduleSymbol.Name = "moduleSymbol";
            this.moduleSymbol.Size = new System.Drawing.Size(194, 50);
            this.moduleSymbol.TabIndex = 3;
            // 
            // pitchDiameterLabel
            // 
            this.pitchDiameterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitchDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchDiameterLabel.Location = new System.Drawing.Point(4, 205);
            this.pitchDiameterLabel.Name = "pitchDiameterLabel";
            this.pitchDiameterLabel.Size = new System.Drawing.Size(194, 50);
            this.pitchDiameterLabel.TabIndex = 5;
            this.pitchDiameterLabel.Text = "d";
            this.pitchDiameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pitchDiameterTextBox
            // 
            this.pitchDiameterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pitchDiameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchDiameterTextBox.Location = new System.Drawing.Point(607, 216);
            this.pitchDiameterTextBox.Name = "pitchDiameterTextBox";
            this.pitchDiameterTextBox.Size = new System.Drawing.Size(194, 27);
            this.pitchDiameterTextBox.TabIndex = 6;
            // 
            // pitchDiameterFormula
            // 
            this.pitchDiameterFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitchDiameterFormula.Location = new System.Drawing.Point(406, 205);
            this.pitchDiameterFormula.Name = "pitchDiameterFormula";
            this.pitchDiameterFormula.Size = new System.Drawing.Size(194, 50);
            this.pitchDiameterFormula.TabIndex = 7;
            // 
            // pitchDiameterSymbol
            // 
            this.pitchDiameterSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitchDiameterSymbol.Location = new System.Drawing.Point(205, 205);
            this.pitchDiameterSymbol.Name = "pitchDiameterSymbol";
            this.pitchDiameterSymbol.Size = new System.Drawing.Size(194, 50);
            this.pitchDiameterSymbol.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "Symbol";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "Formula";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 50);
            this.label4.TabIndex = 12;
            this.label4.Text = "Metric";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teethLabel
            // 
            this.teethLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teethLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teethLabel.Location = new System.Drawing.Point(4, 103);
            this.teethLabel.Name = "teethLabel";
            this.teethLabel.Size = new System.Drawing.Size(194, 50);
            this.teethLabel.TabIndex = 14;
            this.teethLabel.Text = "z";
            this.teethLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teethSymbol
            // 
            this.teethSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teethSymbol.Location = new System.Drawing.Point(205, 103);
            this.teethSymbol.Name = "teethSymbol";
            this.teethSymbol.Size = new System.Drawing.Size(194, 50);
            this.teethSymbol.TabIndex = 15;
            // 
            // teethNumericUpDown
            // 
            this.teethNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teethNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teethNumericUpDown.Location = new System.Drawing.Point(607, 114);
            this.teethNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.teethNumericUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.teethNumericUpDown.Name = "teethNumericUpDown";
            this.teethNumericUpDown.Size = new System.Drawing.Size(194, 27);
            this.teethNumericUpDown.TabIndex = 17;
            this.teethNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.teethNumericUpDown.ValueChanged += new System.EventHandler(this.teethNumericUpDown_ValueChanged);
            // 
            // pressureAngleLabel
            // 
            this.pressureAngleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureAngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureAngleLabel.Location = new System.Drawing.Point(4, 154);
            this.pressureAngleLabel.Name = "pressureAngleLabel";
            this.pressureAngleLabel.Size = new System.Drawing.Size(194, 50);
            this.pressureAngleLabel.TabIndex = 18;
            this.pressureAngleLabel.Text = "alpha";
            this.pressureAngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureAngleSymbol
            // 
            this.pressureAngleSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureAngleSymbol.Location = new System.Drawing.Point(205, 154);
            this.pressureAngleSymbol.Name = "pressureAngleSymbol";
            this.pressureAngleSymbol.Size = new System.Drawing.Size(194, 50);
            this.pressureAngleSymbol.TabIndex = 19;
            // 
            // pressureAngleNumericUpDown
            // 
            this.pressureAngleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pressureAngleNumericUpDown.DecimalPlaces = 3;
            this.pressureAngleNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureAngleNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.pressureAngleNumericUpDown.Location = new System.Drawing.Point(607, 165);
            this.pressureAngleNumericUpDown.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
            this.pressureAngleNumericUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.pressureAngleNumericUpDown.Name = "pressureAngleNumericUpDown";
            this.pressureAngleNumericUpDown.Size = new System.Drawing.Size(194, 27);
            this.pressureAngleNumericUpDown.TabIndex = 21;
            this.pressureAngleNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.pressureAngleNumericUpDown.ValueChanged += new System.EventHandler(this.pressureAngleNumericUpDown_ValueChanged);
            // 
            // baseDiameterLabel
            // 
            this.baseDiameterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDiameterLabel.Location = new System.Drawing.Point(4, 256);
            this.baseDiameterLabel.Name = "baseDiameterLabel";
            this.baseDiameterLabel.Size = new System.Drawing.Size(194, 50);
            this.baseDiameterLabel.TabIndex = 22;
            this.baseDiameterLabel.Text = "db";
            this.baseDiameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseDiameterSymbol
            // 
            this.baseDiameterSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDiameterSymbol.Location = new System.Drawing.Point(205, 256);
            this.baseDiameterSymbol.Name = "baseDiameterSymbol";
            this.baseDiameterSymbol.Size = new System.Drawing.Size(194, 50);
            this.baseDiameterSymbol.TabIndex = 23;
            // 
            // baseDiameterFormula
            // 
            this.baseDiameterFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDiameterFormula.Location = new System.Drawing.Point(406, 256);
            this.baseDiameterFormula.Name = "baseDiameterFormula";
            this.baseDiameterFormula.Size = new System.Drawing.Size(194, 50);
            this.baseDiameterFormula.TabIndex = 24;
            // 
            // baseDiameterTextBox
            // 
            this.baseDiameterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseDiameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDiameterTextBox.Location = new System.Drawing.Point(607, 267);
            this.baseDiameterTextBox.Name = "baseDiameterTextBox";
            this.baseDiameterTextBox.Size = new System.Drawing.Size(194, 27);
            this.baseDiameterTextBox.TabIndex = 25;
            // 
            // addendumLabel
            // 
            this.addendumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addendumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addendumLabel.Location = new System.Drawing.Point(4, 307);
            this.addendumLabel.Name = "addendumLabel";
            this.addendumLabel.Size = new System.Drawing.Size(194, 50);
            this.addendumLabel.TabIndex = 26;
            this.addendumLabel.Text = "ha";
            this.addendumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addendumSymbol
            // 
            this.addendumSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addendumSymbol.Location = new System.Drawing.Point(205, 307);
            this.addendumSymbol.Name = "addendumSymbol";
            this.addendumSymbol.Size = new System.Drawing.Size(194, 50);
            this.addendumSymbol.TabIndex = 27;
            // 
            // addendumFormula
            // 
            this.addendumFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addendumFormula.Location = new System.Drawing.Point(406, 307);
            this.addendumFormula.Name = "addendumFormula";
            this.addendumFormula.Size = new System.Drawing.Size(194, 50);
            this.addendumFormula.TabIndex = 28;
            // 
            // dedendumLabel
            // 
            this.dedendumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dedendumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dedendumLabel.Location = new System.Drawing.Point(4, 358);
            this.dedendumLabel.Name = "dedendumLabel";
            this.dedendumLabel.Size = new System.Drawing.Size(194, 50);
            this.dedendumLabel.TabIndex = 29;
            this.dedendumLabel.Text = "hf";
            this.dedendumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dedendumSymbol
            // 
            this.dedendumSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dedendumSymbol.Location = new System.Drawing.Point(205, 358);
            this.dedendumSymbol.Name = "dedendumSymbol";
            this.dedendumSymbol.Size = new System.Drawing.Size(194, 50);
            this.dedendumSymbol.TabIndex = 30;
            // 
            // dedendumFormula
            // 
            this.dedendumFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dedendumFormula.Location = new System.Drawing.Point(406, 358);
            this.dedendumFormula.Name = "dedendumFormula";
            this.dedendumFormula.Size = new System.Drawing.Size(194, 50);
            this.dedendumFormula.TabIndex = 31;
            // 
            // addendumTextBox
            // 
            this.addendumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addendumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addendumTextBox.Location = new System.Drawing.Point(607, 318);
            this.addendumTextBox.Name = "addendumTextBox";
            this.addendumTextBox.Size = new System.Drawing.Size(194, 27);
            this.addendumTextBox.TabIndex = 32;
            // 
            // dedendumTextBox
            // 
            this.dedendumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dedendumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dedendumTextBox.Location = new System.Drawing.Point(607, 369);
            this.dedendumTextBox.Name = "dedendumTextBox";
            this.dedendumTextBox.Size = new System.Drawing.Size(194, 27);
            this.dedendumTextBox.TabIndex = 33;
            // 
            // outsideDiameterLabel
            // 
            this.outsideDiameterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outsideDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsideDiameterLabel.Location = new System.Drawing.Point(4, 409);
            this.outsideDiameterLabel.Name = "outsideDiameterLabel";
            this.outsideDiameterLabel.Size = new System.Drawing.Size(194, 50);
            this.outsideDiameterLabel.TabIndex = 34;
            this.outsideDiameterLabel.Text = "da";
            this.outsideDiameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rootDiameterLabel
            // 
            this.rootDiameterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootDiameterLabel.Location = new System.Drawing.Point(4, 460);
            this.rootDiameterLabel.Name = "rootDiameterLabel";
            this.rootDiameterLabel.Size = new System.Drawing.Size(194, 50);
            this.rootDiameterLabel.TabIndex = 35;
            this.rootDiameterLabel.Text = "df";
            this.rootDiameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outsideDiameterSymbol
            // 
            this.outsideDiameterSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outsideDiameterSymbol.Location = new System.Drawing.Point(205, 409);
            this.outsideDiameterSymbol.Name = "outsideDiameterSymbol";
            this.outsideDiameterSymbol.Size = new System.Drawing.Size(194, 50);
            this.outsideDiameterSymbol.TabIndex = 36;
            // 
            // rootDiameterSymbol
            // 
            this.rootDiameterSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootDiameterSymbol.Location = new System.Drawing.Point(205, 460);
            this.rootDiameterSymbol.Name = "rootDiameterSymbol";
            this.rootDiameterSymbol.Size = new System.Drawing.Size(194, 50);
            this.rootDiameterSymbol.TabIndex = 37;
            // 
            // outsideDiameterFormula
            // 
            this.outsideDiameterFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outsideDiameterFormula.Location = new System.Drawing.Point(406, 409);
            this.outsideDiameterFormula.Name = "outsideDiameterFormula";
            this.outsideDiameterFormula.Size = new System.Drawing.Size(194, 50);
            this.outsideDiameterFormula.TabIndex = 38;
            // 
            // rootDiameterFormula
            // 
            this.rootDiameterFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootDiameterFormula.Location = new System.Drawing.Point(406, 460);
            this.rootDiameterFormula.Name = "rootDiameterFormula";
            this.rootDiameterFormula.Size = new System.Drawing.Size(194, 50);
            this.rootDiameterFormula.TabIndex = 39;
            // 
            // outsideDiameterTextBox
            // 
            this.outsideDiameterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outsideDiameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsideDiameterTextBox.Location = new System.Drawing.Point(607, 420);
            this.outsideDiameterTextBox.Name = "outsideDiameterTextBox";
            this.outsideDiameterTextBox.Size = new System.Drawing.Size(194, 27);
            this.outsideDiameterTextBox.TabIndex = 40;
            // 
            // rootDiameterTextBox
            // 
            this.rootDiameterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rootDiameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootDiameterTextBox.Location = new System.Drawing.Point(607, 471);
            this.rootDiameterTextBox.Name = "rootDiameterTextBox";
            this.rootDiameterTextBox.Size = new System.Drawing.Size(194, 27);
            this.rootDiameterTextBox.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(808, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 50);
            this.label5.TabIndex = 42;
            this.label5.Text = "Imperial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // moduleImperial
            // 
            this.moduleImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.moduleImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleImperial.Location = new System.Drawing.Point(808, 63);
            this.moduleImperial.Name = "moduleImperial";
            this.moduleImperial.Size = new System.Drawing.Size(195, 27);
            this.moduleImperial.TabIndex = 43;
            // 
            // teethImperial
            // 
            this.teethImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teethImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teethImperial.Location = new System.Drawing.Point(808, 114);
            this.teethImperial.Name = "teethImperial";
            this.teethImperial.Size = new System.Drawing.Size(195, 27);
            this.teethImperial.TabIndex = 44;
            // 
            // pressureAngleImperial
            // 
            this.pressureAngleImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pressureAngleImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureAngleImperial.Location = new System.Drawing.Point(808, 165);
            this.pressureAngleImperial.Name = "pressureAngleImperial";
            this.pressureAngleImperial.Size = new System.Drawing.Size(195, 27);
            this.pressureAngleImperial.TabIndex = 45;
            // 
            // pitchDiameterImperial
            // 
            this.pitchDiameterImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pitchDiameterImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchDiameterImperial.Location = new System.Drawing.Point(808, 216);
            this.pitchDiameterImperial.Name = "pitchDiameterImperial";
            this.pitchDiameterImperial.Size = new System.Drawing.Size(195, 27);
            this.pitchDiameterImperial.TabIndex = 46;
            // 
            // baseDiameterImperial
            // 
            this.baseDiameterImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseDiameterImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDiameterImperial.Location = new System.Drawing.Point(808, 267);
            this.baseDiameterImperial.Name = "baseDiameterImperial";
            this.baseDiameterImperial.Size = new System.Drawing.Size(195, 27);
            this.baseDiameterImperial.TabIndex = 47;
            // 
            // addendumImperial
            // 
            this.addendumImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addendumImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addendumImperial.Location = new System.Drawing.Point(808, 318);
            this.addendumImperial.Name = "addendumImperial";
            this.addendumImperial.Size = new System.Drawing.Size(195, 27);
            this.addendumImperial.TabIndex = 48;
            // 
            // dedendumImperial
            // 
            this.dedendumImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dedendumImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dedendumImperial.Location = new System.Drawing.Point(808, 369);
            this.dedendumImperial.Name = "dedendumImperial";
            this.dedendumImperial.Size = new System.Drawing.Size(195, 27);
            this.dedendumImperial.TabIndex = 49;
            // 
            // outsideDiameterImperial
            // 
            this.outsideDiameterImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outsideDiameterImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsideDiameterImperial.Location = new System.Drawing.Point(808, 420);
            this.outsideDiameterImperial.Name = "outsideDiameterImperial";
            this.outsideDiameterImperial.Size = new System.Drawing.Size(195, 27);
            this.outsideDiameterImperial.TabIndex = 50;
            // 
            // rootDiameterImperial
            // 
            this.rootDiameterImperial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rootDiameterImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootDiameterImperial.Location = new System.Drawing.Point(808, 471);
            this.rootDiameterImperial.Name = "rootDiameterImperial";
            this.rootDiameterImperial.Size = new System.Drawing.Size(195, 27);
            this.rootDiameterImperial.TabIndex = 51;
            // 
            // SimpleGearView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tablePanel);
            this.Name = "SimpleGearView";
            this.Size = new System.Drawing.Size(1007, 536);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teethNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureAngleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.TextBox pressureAngleImperial;
        public System.Windows.Forms.TextBox pitchDiameterImperial;
        public System.Windows.Forms.TextBox baseDiameterImperial;
        public System.Windows.Forms.TextBox addendumImperial;
        public System.Windows.Forms.TextBox dedendumImperial;
        public System.Windows.Forms.TextBox outsideDiameterImperial;
        public System.Windows.Forms.TextBox rootDiameterImperial;

        public System.Windows.Forms.TextBox teethImperial;

        public System.Windows.Forms.TextBox moduleImperial;

        private System.Windows.Forms.Label label5;

        public System.Windows.Forms.Label outsideDiameterLabel;
        public System.Windows.Forms.Label rootDiameterLabel;
        public System.Windows.Forms.Label outsideDiameterSymbol;
        public System.Windows.Forms.Label rootDiameterSymbol;
        public System.Windows.Forms.Label outsideDiameterFormula;
        public System.Windows.Forms.Label rootDiameterFormula;
        public System.Windows.Forms.TextBox outsideDiameterTextBox;
        public System.Windows.Forms.TextBox rootDiameterTextBox;

        public System.Windows.Forms.Label addendumLabel;
        public System.Windows.Forms.Label addendumSymbol;
        public System.Windows.Forms.Label addendumFormula;
        public System.Windows.Forms.Label dedendumLabel;
        public System.Windows.Forms.Label dedendumSymbol;
        public System.Windows.Forms.Label dedendumFormula;
        public System.Windows.Forms.TextBox addendumTextBox;
        public System.Windows.Forms.TextBox dedendumTextBox;

        public System.Windows.Forms.Label baseDiameterLabel;
        public System.Windows.Forms.Label baseDiameterSymbol;
        public System.Windows.Forms.Label baseDiameterFormula;
        public System.Windows.Forms.TextBox baseDiameterTextBox;

        public System.Windows.Forms.Label teethLabel;
        public System.Windows.Forms.Label teethSymbol;
        public System.Windows.Forms.NumericUpDown teethNumericUpDown;
        public System.Windows.Forms.Label pressureAngleLabel;
        public System.Windows.Forms.Label pressureAngleSymbol;
        public System.Windows.Forms.NumericUpDown pressureAngleNumericUpDown;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        public System.Windows.Forms.Label pitchDiameterLabel;
        public System.Windows.Forms.TextBox pitchDiameterTextBox;
        public System.Windows.Forms.Label pitchDiameterFormula;
        public System.Windows.Forms.Label pitchDiameterSymbol;

        public System.Windows.Forms.Label moduleSymbol;

        public System.Windows.Forms.NumericUpDown moduleNumericUpDown;

        public System.Windows.Forms.Label moduleLabel;

        private System.Windows.Forms.TableLayoutPanel tablePanel;

        #endregion
    }
}