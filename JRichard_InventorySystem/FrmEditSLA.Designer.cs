namespace JRichard_InventoryUI
{
    partial class FrmEditSLA
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
            this.LblSLA = new System.Windows.Forms.Label();
            this.LblFinding = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblPenalty = new System.Windows.Forms.Label();
            this.CmbFinding = new System.Windows.Forms.ComboBox();
            this.CmbSupplier = new System.Windows.Forms.ComboBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtPenalty = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSLA
            // 
            this.LblSLA.AutoSize = true;
            this.LblSLA.Location = new System.Drawing.Point(12, 9);
            this.LblSLA.Name = "LblSLA";
            this.LblSLA.Size = new System.Drawing.Size(180, 13);
            this.LblSLA.TabIndex = 0;
            this.LblSLA.Text = "Add a new Service-Level Agreement";
            // 
            // LblFinding
            // 
            this.LblFinding.AutoSize = true;
            this.LblFinding.Location = new System.Drawing.Point(12, 28);
            this.LblFinding.Name = "LblFinding";
            this.LblFinding.Size = new System.Drawing.Size(44, 13);
            this.LblFinding.TabIndex = 1;
            this.LblFinding.Text = "Finding:";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Location = new System.Drawing.Point(12, 55);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(48, 13);
            this.LblSupplier.TabIndex = 2;
            this.LblSupplier.Text = "Supplier:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 82);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description:";
            // 
            // LblPenalty
            // 
            this.LblPenalty.AutoSize = true;
            this.LblPenalty.Location = new System.Drawing.Point(12, 108);
            this.LblPenalty.Name = "LblPenalty";
            this.LblPenalty.Size = new System.Drawing.Size(45, 13);
            this.LblPenalty.TabIndex = 4;
            this.LblPenalty.Text = "Penalty:";
            // 
            // CmbFinding
            // 
            this.CmbFinding.FormattingEnabled = true;
            this.CmbFinding.Location = new System.Drawing.Point(81, 25);
            this.CmbFinding.Name = "CmbFinding";
            this.CmbFinding.Size = new System.Drawing.Size(121, 21);
            this.CmbFinding.TabIndex = 5;
            this.CmbFinding.Text = "Please select...";
            // 
            // CmbSupplier
            // 
            this.CmbSupplier.FormattingEnabled = true;
            this.CmbSupplier.Location = new System.Drawing.Point(81, 52);
            this.CmbSupplier.Name = "CmbSupplier";
            this.CmbSupplier.Size = new System.Drawing.Size(121, 21);
            this.CmbSupplier.TabIndex = 6;
            this.CmbSupplier.Text = "Please select...";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(81, 79);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(121, 20);
            this.TxtDescription.TabIndex = 7;
            // 
            // TxtPenalty
            // 
            this.TxtPenalty.Location = new System.Drawing.Point(81, 105);
            this.TxtPenalty.Name = "TxtPenalty";
            this.TxtPenalty.Size = new System.Drawing.Size(121, 20);
            this.TxtPenalty.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(81, 131);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 23);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(81, 160);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmEditSLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 199);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtPenalty);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.CmbSupplier);
            this.Controls.Add(this.CmbFinding);
            this.Controls.Add(this.LblPenalty);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.LblFinding);
            this.Controls.Add(this.LblSLA);
            this.Name = "FrmEditSLA";
            this.Text = "FrmEditSLA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSLA;
        private System.Windows.Forms.Label LblFinding;
        private System.Windows.Forms.Label LblSupplier;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblPenalty;
        private System.Windows.Forms.ComboBox CmbFinding;
        private System.Windows.Forms.ComboBox CmbSupplier;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtPenalty;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}