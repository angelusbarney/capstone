namespace JRichard_DB
{
    partial class FrmOrder
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
            this.CmbOrder = new System.Windows.Forms.ComboBox();
            this.LblSelectOrder = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.LblNotes = new System.Windows.Forms.Label();
            this.LstOrderLines = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnFullDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbOrder
            // 
            this.CmbOrder.FormattingEnabled = true;
            this.CmbOrder.Location = new System.Drawing.Point(100, 12);
            this.CmbOrder.Name = "CmbOrder";
            this.CmbOrder.Size = new System.Drawing.Size(121, 21);
            this.CmbOrder.TabIndex = 0;
            this.CmbOrder.Text = "Please select...";
            this.CmbOrder.SelectedIndexChanged += new System.EventHandler(this.CmbOrder_SelectedIndexChanged);
            // 
            // LblSelectOrder
            // 
            this.LblSelectOrder.AutoSize = true;
            this.LblSelectOrder.Location = new System.Drawing.Point(12, 15);
            this.LblSelectOrder.Name = "LblSelectOrder";
            this.LblSelectOrder.Size = new System.Drawing.Size(82, 13);
            this.LblSelectOrder.TabIndex = 1;
            this.LblSelectOrder.Text = "Select an order:";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(100, 39);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(121, 20);
            this.TxtStatus.TabIndex = 2;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(12, 42);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(40, 13);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "Status:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(100, 65);
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(121, 20);
            this.TxtNotes.TabIndex = 4;
            // 
            // LblNotes
            // 
            this.LblNotes.AutoSize = true;
            this.LblNotes.Location = new System.Drawing.Point(12, 68);
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(38, 13);
            this.LblNotes.TabIndex = 5;
            this.LblNotes.Text = "Notes:";
            // 
            // LstOrderLines
            // 
            this.LstOrderLines.FormattingEnabled = true;
            this.LstOrderLines.Location = new System.Drawing.Point(100, 91);
            this.LstOrderLines.Name = "LstOrderLines";
            this.LstOrderLines.Size = new System.Drawing.Size(120, 173);
            this.LstOrderLines.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 91);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(82, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add line";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(12, 120);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(82, 23);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Edit line";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 149);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(82, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete line";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnFullDelete
            // 
            this.BtnFullDelete.Location = new System.Drawing.Point(12, 236);
            this.BtnFullDelete.Name = "BtnFullDelete";
            this.BtnFullDelete.Size = new System.Drawing.Size(82, 23);
            this.BtnFullDelete.TabIndex = 10;
            this.BtnFullDelete.Text = "Delete order";
            this.BtnFullDelete.UseVisualStyleBackColor = true;
            this.BtnFullDelete.Click += new System.EventHandler(this.BtnFullDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 178);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(82, 23);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save order";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(12, 207);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 276);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnFullDelete);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstOrderLines);
            this.Controls.Add(this.LblNotes);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.LblSelectOrder);
            this.Controls.Add(this.CmbOrder);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbOrder;
        private System.Windows.Forms.Label LblSelectOrder;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label LblNotes;
        private System.Windows.Forms.ListBox LstOrderLines;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnFullDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}