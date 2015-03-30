namespace JRichard_InventoryUI
{
    partial class FrmOrderLine
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
            this.LblLine = new System.Windows.Forms.Label();
            this.CmbFindings = new System.Windows.Forms.ComboBox();
            this.LblFinding = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblLine
            // 
            this.LblLine.AutoSize = true;
            this.LblLine.Location = new System.Drawing.Point(12, 9);
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(129, 13);
            this.LblLine.TabIndex = 0;
            this.LblLine.Text = "Add new finding order line";
            // 
            // CmbFindings
            // 
            this.CmbFindings.FormattingEnabled = true;
            this.CmbFindings.Location = new System.Drawing.Point(67, 25);
            this.CmbFindings.Name = "CmbFindings";
            this.CmbFindings.Size = new System.Drawing.Size(121, 21);
            this.CmbFindings.TabIndex = 1;
            this.CmbFindings.Text = "Please select...";
            // 
            // LblFinding
            // 
            this.LblFinding.AutoSize = true;
            this.LblFinding.Location = new System.Drawing.Point(12, 28);
            this.LblFinding.Name = "LblFinding";
            this.LblFinding.Size = new System.Drawing.Size(44, 13);
            this.LblFinding.TabIndex = 2;
            this.LblFinding.Text = "Finding:";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(67, 52);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(121, 20);
            this.TxtQuantity.TabIndex = 3;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(12, 55);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(49, 13);
            this.LblQuantity.TabIndex = 4;
            this.LblQuantity.Text = "Quantity:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(67, 78);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(67, 107);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmOrderLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 142);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.LblFinding);
            this.Controls.Add(this.CmbFindings);
            this.Controls.Add(this.LblLine);
            this.Name = "FrmOrderLine";
            this.Text = "FrmOrderLine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLine;
        private System.Windows.Forms.ComboBox CmbFindings;
        private System.Windows.Forms.Label LblFinding;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}