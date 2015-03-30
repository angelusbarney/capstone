namespace JRichard_InventoryUI
{
    partial class FrmAddOrder
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
            this.LblOrder = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.LblNotes = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOrder
            // 
            this.LblOrder.AutoSize = true;
            this.LblOrder.Location = new System.Drawing.Point(12, 9);
            this.LblOrder.Name = "LblOrder";
            this.LblOrder.Size = new System.Drawing.Size(122, 13);
            this.LblOrder.TabIndex = 0;
            this.LblOrder.Text = "Create new finding order";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(58, 25);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(121, 20);
            this.TxtStatus.TabIndex = 3;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(12, 28);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(40, 13);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Status:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(58, 51);
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(121, 20);
            this.TxtNotes.TabIndex = 5;
            // 
            // LblNotes
            // 
            this.LblNotes.AutoSize = true;
            this.LblNotes.Location = new System.Drawing.Point(12, 54);
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(38, 13);
            this.LblNotes.TabIndex = 6;
            this.LblNotes.Text = "Notes:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(58, 77);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(58, 106);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 140);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblNotes);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.LblOrder);
            this.Name = "FrmAddOrder";
            this.Text = "FrmAddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOrder;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label LblNotes;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}