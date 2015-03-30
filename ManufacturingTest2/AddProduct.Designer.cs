namespace ManufacturingTest2
{
    partial class AddProduct
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductNotes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NotAddedMaterials = new System.Windows.Forms.ListBox();
            this.AddedMaterialsList = new System.Windows.Forms.ListBox();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.txtMaterialQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(210, 264);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Confirm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductNotes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProductCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter A Material";
            // 
            // ProductNotes
            // 
            this.ProductNotes.Location = new System.Drawing.Point(94, 122);
            this.ProductNotes.Name = "ProductNotes";
            this.ProductNotes.Size = new System.Drawing.Size(173, 106);
            this.ProductNotes.TabIndex = 7;
            this.ProductNotes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // ProductCost
            // 
            this.ProductCost.Location = new System.Drawing.Point(146, 93);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(121, 20);
            this.ProductCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(146, 40);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(121, 20);
            this.ProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NotAddedMaterials
            // 
            this.NotAddedMaterials.FormattingEnabled = true;
            this.NotAddedMaterials.Location = new System.Drawing.Point(291, 20);
            this.NotAddedMaterials.Name = "NotAddedMaterials";
            this.NotAddedMaterials.Size = new System.Drawing.Size(148, 160);
            this.NotAddedMaterials.TabIndex = 4;
            // 
            // AddedMaterialsList
            // 
            this.AddedMaterialsList.FormattingEnabled = true;
            this.AddedMaterialsList.Location = new System.Drawing.Point(526, 20);
            this.AddedMaterialsList.Name = "AddedMaterialsList";
            this.AddedMaterialsList.Size = new System.Drawing.Size(203, 160);
            this.AddedMaterialsList.TabIndex = 5;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(445, 81);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAddMaterial.TabIndex = 6;
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.Location = new System.Drawing.Point(445, 143);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMaterial.TabIndex = 7;
            this.btnRemoveMaterial.Text = "Remove Material";
            this.btnRemoveMaterial.UseVisualStyleBackColor = true;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // txtMaterialQuantity
            // 
            this.txtMaterialQuantity.Location = new System.Drawing.Point(445, 55);
            this.txtMaterialQuantity.Name = "txtMaterialQuantity";
            this.txtMaterialQuantity.Size = new System.Drawing.Size(75, 20);
            this.txtMaterialQuantity.TabIndex = 8;
            this.txtMaterialQuantity.Text = "1";
            this.txtMaterialQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaterialQuantity);
            this.Controls.Add(this.btnRemoveMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.AddedMaterialsList);
            this.Controls.Add(this.NotAddedMaterials);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox ProductNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NotAddedMaterials;
        private System.Windows.Forms.ListBox AddedMaterialsList;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnRemoveMaterial;
        private System.Windows.Forms.TextBox txtMaterialQuantity;
        private System.Windows.Forms.Label label2;
    }
}