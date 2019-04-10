namespace Winforms
{
    partial class DlgCoordonnées
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgCoordonnées));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCoordonnées = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.checkBoxVerrouiller = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOk, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonAnnuler, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCoordonnées, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownY, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelY, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxVerrouiller, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(3, 371);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(166, 87);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "O&K";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(175, 371);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(166, 87);
            this.buttonAnnuler.TabIndex = 8;
            this.buttonAnnuler.Text = "&Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coordonnées:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoordonnées
            // 
            this.labelCoordonnées.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCoordonnées.AutoSize = true;
            this.labelCoordonnées.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordonnées.ForeColor = System.Drawing.Color.Red;
            this.labelCoordonnées.Location = new System.Drawing.Point(175, 309);
            this.labelCoordonnées.Name = "labelCoordonnées";
            this.labelCoordonnées.Size = new System.Drawing.Size(62, 25);
            this.labelCoordonnées.TabIndex = 6;
            this.labelCoordonnées.Text = "(x, y)";
            this.labelCoordonnées.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownY.Location = new System.Drawing.Point(175, 218);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(166, 23);
            this.numericUpDownY.TabIndex = 4;
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownX.Location = new System.Drawing.Point(175, 126);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(166, 23);
            this.numericUpDownX.TabIndex = 2;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelX
            // 
            this.labelX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(144, 129);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(25, 17);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "&X :";
            // 
            // labelY
            // 
            this.labelY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(144, 221);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(25, 17);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "&Y :";
            // 
            // checkBoxVerrouiller
            // 
            this.checkBoxVerrouiller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxVerrouiller.AutoSize = true;
            this.checkBoxVerrouiller.Checked = true;
            this.checkBoxVerrouiller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxVerrouiller, 2);
            this.checkBoxVerrouiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVerrouiller.Location = new System.Drawing.Point(3, 34);
            this.checkBoxVerrouiller.Name = "checkBoxVerrouiller";
            this.checkBoxVerrouiller.Size = new System.Drawing.Size(338, 24);
            this.checkBoxVerrouiller.TabIndex = 0;
            this.checkBoxVerrouiller.Text = "&Verrouiller les coordonnées";
            this.checkBoxVerrouiller.UseVisualStyleBackColor = true;
            this.checkBoxVerrouiller.CheckedChanged += new System.EventHandler(this.checkBoxVerrouiller_CheckedChanged);
            // 
            // DlgCoordonnées
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnnuler;
            this.ClientSize = new System.Drawing.Size(368, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgCoordonnées";
            this.Text = "Coordonnées";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCoordonnées;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.CheckBox checkBoxVerrouiller;
    }
}