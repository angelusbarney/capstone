namespace JRichard_DB
{
    partial class FrmFinding
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
            this.LblSelectFinding = new System.Windows.Forms.Label();
            this.CmbFinding = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblCost = new System.Windows.Forms.Label();
            this.CmbSupplier = new System.Windows.Forms.ComboBox();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.TxtColour = new System.Windows.Forms.TextBox();
            this.LblColour = new System.Windows.Forms.Label();
            this.BtnEditSupplier = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAddSupplier = new System.Windows.Forms.Button();
            this.BtnDeleteSupplier = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSelectFinding
            // 
            this.LblSelectFinding.AutoSize = true;
            this.LblSelectFinding.Location = new System.Drawing.Point(12, 15);
            this.LblSelectFinding.Name = "LblSelectFinding";
            this.LblSelectFinding.Size = new System.Drawing.Size(83, 13);
            this.LblSelectFinding.TabIndex = 0;
            this.LblSelectFinding.Text = "Select a finding:";
            // 
            // CmbFinding
            // 
            this.CmbFinding.FormattingEnabled = true;
            this.CmbFinding.Location = new System.Drawing.Point(101, 12);
            this.CmbFinding.Name = "CmbFinding";
            this.CmbFinding.Size = new System.Drawing.Size(121, 21);
            this.CmbFinding.TabIndex = 1;
            this.CmbFinding.Text = "Please select...";
            this.CmbFinding.SelectedIndexChanged += new System.EventHandler(this.CmbFinding_SelectedIndexChanged);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(101, 39);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(121, 20);
            this.TxtName.TabIndex = 2;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 42);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Name:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(101, 65);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(121, 20);
            this.TxtDescription.TabIndex = 4;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 68);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 5;
            this.LblDescription.Text = "Description:";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(101, 91);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(121, 20);
            this.TxtCost.TabIndex = 6;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(12, 94);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(31, 13);
            this.LblCost.TabIndex = 7;
            this.LblCost.Text = "Cost:";
            // 
            // CmbSupplier
            // 
            this.CmbSupplier.FormattingEnabled = true;
            this.CmbSupplier.Location = new System.Drawing.Point(101, 117);
            this.CmbSupplier.Name = "CmbSupplier";
            this.CmbSupplier.Size = new System.Drawing.Size(121, 21);
            this.CmbSupplier.TabIndex = 8;
            this.CmbSupplier.Text = "Please select...";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Location = new System.Drawing.Point(12, 120);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(48, 13);
            this.LblSupplier.TabIndex = 9;
            this.LblSupplier.Text = "Supplier:";
            // 
            // TxtColour
            // 
            this.TxtColour.Location = new System.Drawing.Point(101, 144);
            this.TxtColour.Name = "TxtColour";
            this.TxtColour.Size = new System.Drawing.Size(121, 20);
            this.TxtColour.TabIndex = 10;
            // 
            // LblColour
            // 
            this.LblColour.AutoSize = true;
            this.LblColour.Location = new System.Drawing.Point(12, 147);
            this.LblColour.Name = "LblColour";
            this.LblColour.Size = new System.Drawing.Size(40, 13);
            this.LblColour.TabIndex = 11;
            this.LblColour.Text = "Colour:";
            // 
            // BtnEditSupplier
            // 
            this.BtnEditSupplier.Location = new System.Drawing.Point(101, 199);
            this.BtnEditSupplier.Name = "BtnEditSupplier";
            this.BtnEditSupplier.Size = new System.Drawing.Size(121, 23);
            this.BtnEditSupplier.TabIndex = 12;
            this.BtnEditSupplier.Text = "Edit supplier...";
            this.BtnEditSupplier.UseVisualStyleBackColor = true;
            this.BtnEditSupplier.Click += new System.EventHandler(this.BtnEditSupplier_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 170);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 23);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save finding";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAddSupplier
            // 
            this.BtnAddSupplier.Location = new System.Drawing.Point(101, 170);
            this.BtnAddSupplier.Name = "BtnAddSupplier";
            this.BtnAddSupplier.Size = new System.Drawing.Size(121, 23);
            this.BtnAddSupplier.TabIndex = 14;
            this.BtnAddSupplier.Text = "Add supplier...";
            this.BtnAddSupplier.UseVisualStyleBackColor = true;
            this.BtnAddSupplier.Click += new System.EventHandler(this.BtnAddSupplier_Click);
            // 
            // BtnDeleteSupplier
            // 
            this.BtnDeleteSupplier.Location = new System.Drawing.Point(101, 228);
            this.BtnDeleteSupplier.Name = "BtnDeleteSupplier";
            this.BtnDeleteSupplier.Size = new System.Drawing.Size(121, 23);
            this.BtnDeleteSupplier.TabIndex = 15;
            this.BtnDeleteSupplier.Text = "Delete supplier";
            this.BtnDeleteSupplier.UseVisualStyleBackColor = true;
            this.BtnDeleteSupplier.Click += new System.EventHandler(this.BtnDeleteSupplier_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(12, 199);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(83, 23);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 228);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(83, 23);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete finding";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmFinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 261);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDeleteSupplier);
            this.Controls.Add(this.BtnAddSupplier);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnEditSupplier);
            this.Controls.Add(this.LblColour);
            this.Controls.Add(this.TxtColour);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.CmbSupplier);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CmbFinding);
            this.Controls.Add(this.LblSelectFinding);
            this.Name = "FrmFinding";
            this.Text = "FrmFinding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelectFinding;
        private System.Windows.Forms.ComboBox CmbFinding;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.ComboBox CmbSupplier;
        private System.Windows.Forms.Label LblSupplier;
        private System.Windows.Forms.TextBox TxtColour;
        private System.Windows.Forms.Label LblColour;
        private System.Windows.Forms.Button BtnEditSupplier;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnAddSupplier;
        private System.Windows.Forms.Button BtnDeleteSupplier;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;

    }
}