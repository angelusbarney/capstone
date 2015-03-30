namespace JRichard_InventoryUI
{
    partial class FrmContacts
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
            this.CmbContacts = new System.Windows.Forms.ComboBox();
            this.BtnAddSupplier = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbContacts
            // 
            this.CmbContacts.FormattingEnabled = true;
            this.CmbContacts.Location = new System.Drawing.Point(12, 12);
            this.CmbContacts.Name = "CmbContacts";
            this.CmbContacts.Size = new System.Drawing.Size(121, 21);
            this.CmbContacts.TabIndex = 0;
            this.CmbContacts.Text = "Please select...";
            // 
            // BtnAddSupplier
            // 
            this.BtnAddSupplier.Location = new System.Drawing.Point(12, 39);
            this.BtnAddSupplier.Name = "BtnAddSupplier";
            this.BtnAddSupplier.Size = new System.Drawing.Size(121, 23);
            this.BtnAddSupplier.TabIndex = 2;
            this.BtnAddSupplier.Text = "Add";
            this.BtnAddSupplier.UseVisualStyleBackColor = true;
            this.BtnAddSupplier.Click += new System.EventHandler(this.BtnAddSupplier_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(12, 68);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(121, 23);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 97);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(121, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 133);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAddSupplier);
            this.Controls.Add(this.CmbContacts);
            this.Name = "FrmContacts";
            this.Text = "FrmContacts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbContacts;
        private System.Windows.Forms.Button BtnAddSupplier;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
    }
}