namespace JRichard_DB
{
    partial class FrmProduct
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.LblSize = new System.Windows.Forms.Label();
            this.TxtColour = new System.Windows.Forms.TextBox();
            this.LblColour = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.LblNotes = new System.Windows.Forms.Label();
            this.LstFindings = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddFinding = new System.Windows.Forms.Button();
            this.BtnEditFinding = new System.Windows.Forms.Button();
            this.BtnDeleteFinding = new System.Windows.Forms.Button();
            this.BtnDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(81, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 15);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(81, 38);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 20);
            this.TxtDescription.TabIndex = 2;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 41);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(81, 64);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtPrice.TabIndex = 4;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(12, 67);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(34, 13);
            this.LblPrice.TabIndex = 5;
            this.LblPrice.Text = "Price:";
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(81, 90);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(100, 20);
            this.TxtSize.TabIndex = 6;
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(12, 93);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(30, 13);
            this.LblSize.TabIndex = 7;
            this.LblSize.Text = "Size:";
            // 
            // TxtColour
            // 
            this.TxtColour.Location = new System.Drawing.Point(81, 116);
            this.TxtColour.Name = "TxtColour";
            this.TxtColour.Size = new System.Drawing.Size(100, 20);
            this.TxtColour.TabIndex = 8;
            // 
            // LblColour
            // 
            this.LblColour.AutoSize = true;
            this.LblColour.Location = new System.Drawing.Point(12, 119);
            this.LblColour.Name = "LblColour";
            this.LblColour.Size = new System.Drawing.Size(40, 13);
            this.LblColour.TabIndex = 9;
            this.LblColour.Text = "Colour:";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(81, 142);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(100, 20);
            this.TxtStatus.TabIndex = 10;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(12, 145);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(40, 13);
            this.LblStatus.TabIndex = 11;
            this.LblStatus.Text = "Status:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(81, 168);
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(100, 20);
            this.TxtNotes.TabIndex = 12;
            // 
            // LblNotes
            // 
            this.LblNotes.AutoSize = true;
            this.LblNotes.Location = new System.Drawing.Point(12, 171);
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(38, 13);
            this.LblNotes.TabIndex = 13;
            this.LblNotes.Text = "Notes:";
            // 
            // LstFindings
            // 
            this.LstFindings.FormattingEnabled = true;
            this.LstFindings.Location = new System.Drawing.Point(187, 12);
            this.LstFindings.Name = "LstFindings";
            this.LstFindings.Size = new System.Drawing.Size(120, 173);
            this.LstFindings.TabIndex = 14;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(81, 194);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 23);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save product";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(12, 194);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(63, 52);
            this.BtnOrder.TabIndex = 16;
            this.BtnOrder.Text = "Order product";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(81, 223);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 23);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddFinding
            // 
            this.BtnAddFinding.Location = new System.Drawing.Point(187, 194);
            this.BtnAddFinding.Name = "BtnAddFinding";
            this.BtnAddFinding.Size = new System.Drawing.Size(120, 23);
            this.BtnAddFinding.TabIndex = 18;
            this.BtnAddFinding.Text = "Add finding";
            this.BtnAddFinding.UseVisualStyleBackColor = true;
            this.BtnAddFinding.Click += new System.EventHandler(this.BtnAddFinding_Click);
            // 
            // BtnEditFinding
            // 
            this.BtnEditFinding.Location = new System.Drawing.Point(187, 223);
            this.BtnEditFinding.Name = "BtnEditFinding";
            this.BtnEditFinding.Size = new System.Drawing.Size(120, 23);
            this.BtnEditFinding.TabIndex = 19;
            this.BtnEditFinding.Text = "Edit finding";
            this.BtnEditFinding.UseVisualStyleBackColor = true;
            this.BtnEditFinding.Click += new System.EventHandler(this.BtnEditFinding_Click);
            // 
            // BtnDeleteFinding
            // 
            this.BtnDeleteFinding.Location = new System.Drawing.Point(187, 252);
            this.BtnDeleteFinding.Name = "BtnDeleteFinding";
            this.BtnDeleteFinding.Size = new System.Drawing.Size(120, 23);
            this.BtnDeleteFinding.TabIndex = 20;
            this.BtnDeleteFinding.Text = "Delete finding";
            this.BtnDeleteFinding.UseVisualStyleBackColor = true;
            this.BtnDeleteFinding.Click += new System.EventHandler(this.BtnDeleteFinding_Click);
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.Location = new System.Drawing.Point(81, 252);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(100, 23);
            this.BtnDeleteItem.TabIndex = 21;
            this.BtnDeleteItem.Text = "Delete product";
            this.BtnDeleteItem.UseVisualStyleBackColor = true;
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 286);
            this.Controls.Add(this.BtnDeleteItem);
            this.Controls.Add(this.BtnDeleteFinding);
            this.Controls.Add(this.BtnEditFinding);
            this.Controls.Add(this.BtnAddFinding);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LstFindings);
            this.Controls.Add(this.LblNotes);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.LblColour);
            this.Controls.Add(this.TxtColour);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.TextBox TxtColour;
        private System.Windows.Forms.Label LblColour;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label LblNotes;
        private System.Windows.Forms.ListBox LstFindings;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddFinding;
        private System.Windows.Forms.Button BtnEditFinding;
        private System.Windows.Forms.Button BtnDeleteFinding;
        private System.Windows.Forms.Button BtnDeleteItem;
    }
}