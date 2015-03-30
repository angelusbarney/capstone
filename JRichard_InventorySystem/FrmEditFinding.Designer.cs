namespace JRichard_InventoryUI
{
    partial class FrmEditFinding
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
            this.LblFinding = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblCost = new System.Windows.Forms.Label();
            this.TxtImageFile = new System.Windows.Forms.TextBox();
            this.LblImageFile = new System.Windows.Forms.Label();
            this.TxtColour = new System.Windows.Forms.TextBox();
            this.LblColour = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFinding
            // 
            this.LblFinding.AutoSize = true;
            this.LblFinding.Location = new System.Drawing.Point(12, 9);
            this.LblFinding.Name = "LblFinding";
            this.LblFinding.Size = new System.Drawing.Size(97, 13);
            this.LblFinding.TabIndex = 0;
            this.LblFinding.Text = "Adding new finding";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(81, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 28);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(81, 51);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 20);
            this.TxtDescription.TabIndex = 3;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 54);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 4;
            this.LblDescription.Text = "Description:";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(81, 77);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(100, 20);
            this.TxtCost.TabIndex = 5;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(12, 80);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(31, 13);
            this.LblCost.TabIndex = 6;
            this.LblCost.Text = "Cost:";
            // 
            // TxtImageFile
            // 
            this.TxtImageFile.Location = new System.Drawing.Point(81, 103);
            this.TxtImageFile.Name = "TxtImageFile";
            this.TxtImageFile.Size = new System.Drawing.Size(100, 20);
            this.TxtImageFile.TabIndex = 7;
            // 
            // LblImageFile
            // 
            this.LblImageFile.AutoSize = true;
            this.LblImageFile.Location = new System.Drawing.Point(12, 106);
            this.LblImageFile.Name = "LblImageFile";
            this.LblImageFile.Size = new System.Drawing.Size(55, 13);
            this.LblImageFile.TabIndex = 8;
            this.LblImageFile.Text = "Image file:";
            // 
            // TxtColour
            // 
            this.TxtColour.Location = new System.Drawing.Point(81, 129);
            this.TxtColour.Name = "TxtColour";
            this.TxtColour.Size = new System.Drawing.Size(100, 20);
            this.TxtColour.TabIndex = 9;
            // 
            // LblColour
            // 
            this.LblColour.AutoSize = true;
            this.LblColour.Location = new System.Drawing.Point(12, 132);
            this.LblColour.Name = "LblColour";
            this.LblColour.Size = new System.Drawing.Size(40, 13);
            this.LblColour.TabIndex = 10;
            this.LblColour.Text = "Colour:";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(81, 155);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantity.TabIndex = 11;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(12, 158);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(49, 13);
            this.LblQuantity.TabIndex = 12;
            this.LblQuantity.Text = "Quantity:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(81, 181);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 23);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(81, 210);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 23);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmEditFinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 245);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.LblColour);
            this.Controls.Add(this.TxtColour);
            this.Controls.Add(this.LblImageFile);
            this.Controls.Add(this.TxtImageFile);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblFinding);
            this.Name = "FrmEditFinding";
            this.Text = "FrmEditFinding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFinding;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.TextBox TxtImageFile;
        private System.Windows.Forms.Label LblImageFile;
        private System.Windows.Forms.TextBox TxtColour;
        private System.Windows.Forms.Label LblColour;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}