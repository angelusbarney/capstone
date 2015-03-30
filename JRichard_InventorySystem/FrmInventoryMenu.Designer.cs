namespace JRichard_InventoryUI
{
    partial class FrmInventoryMenu
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
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.BtnContacts = new System.Windows.Forms.Button();
            this.BtnSLAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(12, 12);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(75, 23);
            this.BtnInventory.TabIndex = 0;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnOrders
            // 
            this.BtnOrders.Location = new System.Drawing.Point(12, 41);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(75, 23);
            this.BtnOrders.TabIndex = 1;
            this.BtnOrders.Text = "Orders";
            this.BtnOrders.UseVisualStyleBackColor = true;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // BtnContacts
            // 
            this.BtnContacts.Location = new System.Drawing.Point(12, 70);
            this.BtnContacts.Name = "BtnContacts";
            this.BtnContacts.Size = new System.Drawing.Size(75, 23);
            this.BtnContacts.TabIndex = 2;
            this.BtnContacts.Text = "Contacts";
            this.BtnContacts.UseVisualStyleBackColor = true;
            this.BtnContacts.Click += new System.EventHandler(this.BtnContacts_Click);
            // 
            // BtnSLAs
            // 
            this.BtnSLAs.Location = new System.Drawing.Point(12, 99);
            this.BtnSLAs.Name = "BtnSLAs";
            this.BtnSLAs.Size = new System.Drawing.Size(75, 23);
            this.BtnSLAs.TabIndex = 3;
            this.BtnSLAs.Text = "Agreements";
            this.BtnSLAs.UseVisualStyleBackColor = true;
            this.BtnSLAs.Click += new System.EventHandler(this.BtnSLAs_Click);
            // 
            // FrmInventoryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(112, 146);
            this.Controls.Add(this.BtnSLAs);
            this.Controls.Add(this.BtnContacts);
            this.Controls.Add(this.BtnOrders);
            this.Controls.Add(this.BtnInventory);
            this.Name = "FrmInventoryMenu";
            this.Text = "FrmInventoryMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnOrders;
        private System.Windows.Forms.Button BtnContacts;
        private System.Windows.Forms.Button BtnSLAs;
    }
}