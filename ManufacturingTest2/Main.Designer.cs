namespace ManufacturingTest2
{
    partial class Main
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
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.MaterialsDisplay = new System.Windows.Forms.ComboBox();
            this.ProductDisplay = new System.Windows.Forms.ComboBox();
            this.grpBoxMaterials = new System.Windows.Forms.GroupBox();
            this.btnMaterialUpdate = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.txtMaterialCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterialDesc = new System.Windows.Forms.RichTextBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxProduct = new System.Windows.Forms.GroupBox();
            this.btnEditProductMaterial = new System.Windows.Forms.Button();
            this.lstMaterialsRequired = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductDesc = new System.Windows.Forms.RichTextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxMaterials.SuspendLayout();
            this.grpBxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(541, 12);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAddMaterial.TabIndex = 0;
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 41);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // MaterialsDisplay
            // 
            this.MaterialsDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialsDisplay.FormattingEnabled = true;
            this.MaterialsDisplay.Location = new System.Drawing.Point(495, 41);
            this.MaterialsDisplay.Name = "MaterialsDisplay";
            this.MaterialsDisplay.Size = new System.Drawing.Size(121, 21);
            this.MaterialsDisplay.TabIndex = 2;
            this.MaterialsDisplay.SelectedIndexChanged += new System.EventHandler(this.MaterialsDisplay_SelectedIndexChanged);
            // 
            // ProductDisplay
            // 
            this.ProductDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductDisplay.Location = new System.Drawing.Point(93, 41);
            this.ProductDisplay.Name = "ProductDisplay";
            this.ProductDisplay.Size = new System.Drawing.Size(121, 21);
            this.ProductDisplay.TabIndex = 3;
            this.ProductDisplay.SelectedIndexChanged += new System.EventHandler(this.ProductDisplay_SelectedIndexChanged);
            // 
            // grpBoxMaterials
            // 
            this.grpBoxMaterials.Controls.Add(this.btnMaterialUpdate);
            this.grpBoxMaterials.Controls.Add(this.btnDeleteMaterial);
            this.grpBoxMaterials.Controls.Add(this.txtMaterialCost);
            this.grpBoxMaterials.Controls.Add(this.label3);
            this.grpBoxMaterials.Controls.Add(this.label2);
            this.grpBoxMaterials.Controls.Add(this.txtMaterialDesc);
            this.grpBoxMaterials.Controls.Add(this.txtMaterialName);
            this.grpBoxMaterials.Controls.Add(this.label1);
            this.grpBoxMaterials.Location = new System.Drawing.Point(386, 70);
            this.grpBoxMaterials.Name = "grpBoxMaterials";
            this.grpBoxMaterials.Size = new System.Drawing.Size(230, 263);
            this.grpBoxMaterials.TabIndex = 4;
            this.grpBoxMaterials.TabStop = false;
            this.grpBoxMaterials.Text = "Materials";
            // 
            // btnMaterialUpdate
            // 
            this.btnMaterialUpdate.Location = new System.Drawing.Point(7, 204);
            this.btnMaterialUpdate.Name = "btnMaterialUpdate";
            this.btnMaterialUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialUpdate.TabIndex = 7;
            this.btnMaterialUpdate.Text = "Update";
            this.btnMaterialUpdate.UseVisualStyleBackColor = true;
            this.btnMaterialUpdate.Click += new System.EventHandler(this.btnMaterialUpdate_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Location = new System.Drawing.Point(7, 233);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMaterial.TabIndex = 6;
            this.btnDeleteMaterial.Text = "Delete";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // txtMaterialCost
            // 
            this.txtMaterialCost.Location = new System.Drawing.Point(124, 135);
            this.txtMaterialCost.Name = "txtMaterialCost";
            this.txtMaterialCost.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtMaterialDesc
            // 
            this.txtMaterialDesc.Location = new System.Drawing.Point(124, 161);
            this.txtMaterialDesc.Name = "txtMaterialDesc";
            this.txtMaterialDesc.Size = new System.Drawing.Size(100, 96);
            this.txtMaterialDesc.TabIndex = 2;
            this.txtMaterialDesc.Text = "";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(124, 27);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // grpBxProduct
            // 
            this.grpBxProduct.Controls.Add(this.btnEditProductMaterial);
            this.grpBxProduct.Controls.Add(this.lstMaterialsRequired);
            this.grpBxProduct.Controls.Add(this.label7);
            this.grpBxProduct.Controls.Add(this.btnUpdateProduct);
            this.grpBxProduct.Controls.Add(this.btnDeleteProduct);
            this.grpBxProduct.Controls.Add(this.txtProductCost);
            this.grpBxProduct.Controls.Add(this.label4);
            this.grpBxProduct.Controls.Add(this.label5);
            this.grpBxProduct.Controls.Add(this.txtProductDesc);
            this.grpBxProduct.Controls.Add(this.txtProductName);
            this.grpBxProduct.Controls.Add(this.label6);
            this.grpBxProduct.Location = new System.Drawing.Point(12, 70);
            this.grpBxProduct.Name = "grpBxProduct";
            this.grpBxProduct.Size = new System.Drawing.Size(280, 263);
            this.grpBxProduct.TabIndex = 8;
            this.grpBxProduct.TabStop = false;
            this.grpBxProduct.Text = "Products";
            // 
            // btnEditProductMaterial
            // 
            this.btnEditProductMaterial.Location = new System.Drawing.Point(7, 125);
            this.btnEditProductMaterial.Name = "btnEditProductMaterial";
            this.btnEditProductMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnEditProductMaterial.TabIndex = 10;
            this.btnEditProductMaterial.Text = "BoM";
            this.btnEditProductMaterial.UseVisualStyleBackColor = true;
            this.btnEditProductMaterial.Click += new System.EventHandler(this.btnEditProductMaterial_Click);
            // 
            // lstMaterialsRequired
            // 
            this.lstMaterialsRequired.FormattingEnabled = true;
            this.lstMaterialsRequired.Location = new System.Drawing.Point(124, 99);
            this.lstMaterialsRequired.Name = "lstMaterialsRequired";
            this.lstMaterialsRequired.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstMaterialsRequired.Size = new System.Drawing.Size(150, 56);
            this.lstMaterialsRequired.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Req. Materials";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(7, 204);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 7;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(7, 233);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // txtProductCost
            // 
            this.txtProductCost.Location = new System.Drawing.Point(177, 53);
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(97, 20);
            this.txtProductCost.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Retail Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description";
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(124, 161);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(150, 96);
            this.txtProductDesc.TabIndex = 2;
            this.txtProductDesc.Text = "";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(177, 27);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(97, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 346);
            this.Controls.Add(this.grpBxProduct);
            this.Controls.Add(this.grpBoxMaterials);
            this.Controls.Add(this.ProductDisplay);
            this.Controls.Add(this.MaterialsDisplay);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddMaterial);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpBoxMaterials.ResumeLayout(false);
            this.grpBoxMaterials.PerformLayout();
            this.grpBxProduct.ResumeLayout(false);
            this.grpBxProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox MaterialsDisplay;
        private System.Windows.Forms.ComboBox ProductDisplay;
        private System.Windows.Forms.GroupBox grpBoxMaterials;
        private System.Windows.Forms.TextBox txtMaterialCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMaterialDesc;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.Button btnMaterialUpdate;
        private System.Windows.Forms.GroupBox grpBxProduct;
        private System.Windows.Forms.ListBox lstMaterialsRequired;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtProductDesc;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditProductMaterial;
    }
}