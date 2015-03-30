namespace JRichard_InventoryUI
{
    partial class FrmOrders
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
            this.CmbOrders = new System.Windows.Forms.ComboBox();
            this.LstOrderItems = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbOrders
            // 
            this.CmbOrders.FormattingEnabled = true;
            this.CmbOrders.Location = new System.Drawing.Point(12, 12);
            this.CmbOrders.Name = "CmbOrders";
            this.CmbOrders.Size = new System.Drawing.Size(237, 21);
            this.CmbOrders.TabIndex = 0;
            this.CmbOrders.Text = "Please select...";
            this.CmbOrders.SelectedIndexChanged += new System.EventHandler(this.CmbOrders_SelectedIndexChanged);
            // 
            // LstOrderItems
            // 
            this.LstOrderItems.FormattingEnabled = true;
            this.LstOrderItems.Location = new System.Drawing.Point(12, 39);
            this.LstOrderItems.Name = "LstOrderItems";
            this.LstOrderItems.Size = new System.Drawing.Size(237, 95);
            this.LstOrderItems.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 140);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(93, 140);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(174, 140);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Location = new System.Drawing.Point(12, 169);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(237, 23);
            this.BtnNewOrder.TabIndex = 5;
            this.BtnNewOrder.Text = "Add/Edit order...";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 204);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstOrderItems);
            this.Controls.Add(this.CmbOrders);
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbOrders;
        private System.Windows.Forms.ListBox LstOrderItems;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnNewOrder;
    }
}