namespace JRichard_DB
{
    partial class FrmCatalogue
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
            this.CmbCatalogue = new System.Windows.Forms.ComboBox();
            this.LblSelectCatalogue = new System.Windows.Forms.Label();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.BtnItem = new System.Windows.Forms.Button();
            this.BtnDeleteItem = new System.Windows.Forms.Button();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbCatalogue
            // 
            this.CmbCatalogue.FormattingEnabled = true;
            this.CmbCatalogue.Location = new System.Drawing.Point(117, 12);
            this.CmbCatalogue.Name = "CmbCatalogue";
            this.CmbCatalogue.Size = new System.Drawing.Size(121, 21);
            this.CmbCatalogue.TabIndex = 0;
            this.CmbCatalogue.Text = "Please select...";
            this.CmbCatalogue.SelectedIndexChanged += new System.EventHandler(this.CmbCatalogue_SelectedIndexChanged);
            // 
            // LblSelectCatalogue
            // 
            this.LblSelectCatalogue.AutoSize = true;
            this.LblSelectCatalogue.Location = new System.Drawing.Point(12, 15);
            this.LblSelectCatalogue.Name = "LblSelectCatalogue";
            this.LblSelectCatalogue.Size = new System.Drawing.Size(99, 13);
            this.LblSelectCatalogue.TabIndex = 1;
            this.LblSelectCatalogue.Text = "Select a catalogue:";
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Location = new System.Drawing.Point(117, 52);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(121, 56);
            this.LstItems.TabIndex = 2;
            // 
            // BtnItem
            // 
            this.BtnItem.Location = new System.Drawing.Point(12, 52);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(99, 23);
            this.BtnItem.TabIndex = 3;
            this.BtnItem.Text = "Item details...";
            this.BtnItem.UseVisualStyleBackColor = true;
            this.BtnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.Location = new System.Drawing.Point(12, 81);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(99, 23);
            this.BtnDeleteItem.TabIndex = 4;
            this.BtnDeleteItem.Text = "Delete item";
            this.BtnDeleteItem.UseVisualStyleBackColor = true;
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(12, 36);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(93, 13);
            this.LblStartDate.TabIndex = 5;
            this.LblStartDate.Text = "Start: 00/00/0000";
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Location = new System.Drawing.Point(114, 36);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(90, 13);
            this.LblEndDate.TabIndex = 6;
            this.LblEndDate.Text = "End: 00/00/0000";
            // 
            // FrmCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 119);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.BtnDeleteItem);
            this.Controls.Add(this.BtnItem);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.LblSelectCatalogue);
            this.Controls.Add(this.CmbCatalogue);
            this.Name = "FrmCatalogue";
            this.Text = "FrmCatalogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbCatalogue;
        private System.Windows.Forms.Label LblSelectCatalogue;
        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.Button BtnItem;
        private System.Windows.Forms.Button BtnDeleteItem;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblEndDate;
    }
}