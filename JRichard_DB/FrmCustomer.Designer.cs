namespace JRichard_DB
{
    partial class FrmCustomer
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
            this.LblSelectCustomer = new System.Windows.Forms.Label();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.LblCustomerFirstName = new System.Windows.Forms.Label();
            this.TxtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLsatName = new System.Windows.Forms.Label();
            this.TxtSalutation = new System.Windows.Forms.TextBox();
            this.LblSalutation = new System.Windows.Forms.Label();
            this.TxtExtension = new System.Windows.Forms.TextBox();
            this.LblExtension = new System.Windows.Forms.Label();
            this.TxtBranch = new System.Windows.Forms.TextBox();
            this.LblBranch = new System.Windows.Forms.Label();
            this.TxtSignature = new System.Windows.Forms.TextBox();
            this.LblSignature = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnContact = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSelectCustomer
            // 
            this.LblSelectCustomer.AutoSize = true;
            this.LblSelectCustomer.Location = new System.Drawing.Point(12, 15);
            this.LblSelectCustomer.Name = "LblSelectCustomer";
            this.LblSelectCustomer.Size = new System.Drawing.Size(95, 13);
            this.LblSelectCustomer.TabIndex = 0;
            this.LblSelectCustomer.Text = "Select a customer:";
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(113, 12);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(121, 21);
            this.CmbCustomer.TabIndex = 1;
            this.CmbCustomer.Text = "Please select...";
            this.CmbCustomer.SelectedIndexChanged += new System.EventHandler(this.CmbSelectCustomer_SelectedIndexChanged);
            // 
            // LblCustomerFirstName
            // 
            this.LblCustomerFirstName.AutoSize = true;
            this.LblCustomerFirstName.Location = new System.Drawing.Point(12, 68);
            this.LblCustomerFirstName.Name = "LblCustomerFirstName";
            this.LblCustomerFirstName.Size = new System.Drawing.Size(58, 13);
            this.LblCustomerFirstName.TabIndex = 2;
            this.LblCustomerFirstName.Text = "First name:";
            // 
            // TxtCustomerFirstName
            // 
            this.TxtCustomerFirstName.Location = new System.Drawing.Point(113, 65);
            this.TxtCustomerFirstName.Name = "TxtCustomerFirstName";
            this.TxtCustomerFirstName.Size = new System.Drawing.Size(121, 20);
            this.TxtCustomerFirstName.TabIndex = 3;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(113, 39);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(121, 20);
            this.TxtTitle.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(12, 42);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Title:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(113, 91);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(121, 20);
            this.TxtLastName.TabIndex = 6;
            // 
            // LblLsatName
            // 
            this.LblLsatName.AutoSize = true;
            this.LblLsatName.Location = new System.Drawing.Point(12, 94);
            this.LblLsatName.Name = "LblLsatName";
            this.LblLsatName.Size = new System.Drawing.Size(59, 13);
            this.LblLsatName.TabIndex = 7;
            this.LblLsatName.Text = "Last name:";
            // 
            // TxtSalutation
            // 
            this.TxtSalutation.Location = new System.Drawing.Point(113, 117);
            this.TxtSalutation.Name = "TxtSalutation";
            this.TxtSalutation.Size = new System.Drawing.Size(121, 20);
            this.TxtSalutation.TabIndex = 8;
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Location = new System.Drawing.Point(12, 120);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(57, 13);
            this.LblSalutation.TabIndex = 9;
            this.LblSalutation.Text = "Salutation:";
            // 
            // TxtExtension
            // 
            this.TxtExtension.Location = new System.Drawing.Point(113, 143);
            this.TxtExtension.Name = "TxtExtension";
            this.TxtExtension.Size = new System.Drawing.Size(121, 20);
            this.TxtExtension.TabIndex = 10;
            // 
            // LblExtension
            // 
            this.LblExtension.AutoSize = true;
            this.LblExtension.Location = new System.Drawing.Point(12, 146);
            this.LblExtension.Name = "LblExtension";
            this.LblExtension.Size = new System.Drawing.Size(56, 13);
            this.LblExtension.TabIndex = 11;
            this.LblExtension.Text = "Extension:";
            // 
            // TxtBranch
            // 
            this.TxtBranch.Location = new System.Drawing.Point(113, 169);
            this.TxtBranch.Name = "TxtBranch";
            this.TxtBranch.Size = new System.Drawing.Size(121, 20);
            this.TxtBranch.TabIndex = 12;
            // 
            // LblBranch
            // 
            this.LblBranch.AutoSize = true;
            this.LblBranch.Location = new System.Drawing.Point(12, 172);
            this.LblBranch.Name = "LblBranch";
            this.LblBranch.Size = new System.Drawing.Size(44, 13);
            this.LblBranch.TabIndex = 13;
            this.LblBranch.Text = "Branch:";
            // 
            // TxtSignature
            // 
            this.TxtSignature.Location = new System.Drawing.Point(113, 195);
            this.TxtSignature.Name = "TxtSignature";
            this.TxtSignature.Size = new System.Drawing.Size(121, 20);
            this.TxtSignature.TabIndex = 14;
            // 
            // LblSignature
            // 
            this.LblSignature.AutoSize = true;
            this.LblSignature.Location = new System.Drawing.Point(12, 198);
            this.LblSignature.Name = "LblSignature";
            this.LblSignature.Size = new System.Drawing.Size(55, 13);
            this.LblSignature.TabIndex = 15;
            this.LblSignature.Text = "Signature:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(113, 221);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 23);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(113, 250);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 23);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(113, 279);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(121, 23);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnContact
            // 
            this.BtnContact.Location = new System.Drawing.Point(12, 221);
            this.BtnContact.Name = "BtnContact";
            this.BtnContact.Size = new System.Drawing.Size(95, 23);
            this.BtnContact.TabIndex = 19;
            this.BtnContact.Text = "Contact info...";
            this.BtnContact.UseVisualStyleBackColor = true;
            this.BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // BtnOrders
            // 
            this.BtnOrders.Location = new System.Drawing.Point(12, 250);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(95, 23);
            this.BtnOrders.TabIndex = 20;
            this.BtnOrders.Text = "Orders...";
            this.BtnOrders.UseVisualStyleBackColor = true;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 316);
            this.Controls.Add(this.BtnOrders);
            this.Controls.Add(this.BtnContact);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblSignature);
            this.Controls.Add(this.TxtSignature);
            this.Controls.Add(this.LblBranch);
            this.Controls.Add(this.TxtBranch);
            this.Controls.Add(this.LblExtension);
            this.Controls.Add(this.TxtExtension);
            this.Controls.Add(this.LblSalutation);
            this.Controls.Add(this.TxtSalutation);
            this.Controls.Add(this.LblLsatName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TxtCustomerFirstName);
            this.Controls.Add(this.LblCustomerFirstName);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.LblSelectCustomer);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelectCustomer;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.Label LblCustomerFirstName;
        private System.Windows.Forms.TextBox TxtCustomerFirstName;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLsatName;
        private System.Windows.Forms.TextBox TxtSalutation;
        private System.Windows.Forms.Label LblSalutation;
        private System.Windows.Forms.TextBox TxtExtension;
        private System.Windows.Forms.Label LblExtension;
        private System.Windows.Forms.TextBox TxtBranch;
        private System.Windows.Forms.Label LblBranch;
        private System.Windows.Forms.TextBox TxtSignature;
        private System.Windows.Forms.Label LblSignature;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnContact;
        private System.Windows.Forms.Button BtnOrders;
    }
}