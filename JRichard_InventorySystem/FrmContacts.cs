using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRichard_InventoryClasses;
namespace JRichard_InventoryUI {
    public partial class FrmContacts : Form {
        FrmSupplier FormSupplier;
        Supplier[] AllSuppliers;
        int Suppliers;
        public FrmContacts() {
            InitializeComponent();
            UpdateCMB();
        }
        private void BtnAddSupplier_Click(object sender, EventArgs e) {
            if (FormSupplier == null) {
                FormSupplier = new FrmSupplier();
                FormSupplier.MdiParent = this.MdiParent;
                FormSupplier.FormClosed += FormSupplier_FormClosed;
                FormSupplier.AcceptID(-1);
                FormSupplier.Show();
            } else {
                FormSupplier.Activate();
            }
        }
        void FormSupplier_FormClosed(object sender, FormClosedEventArgs e) {
            FormSupplier = null;
            UpdateCMB();
            CmbContacts.SelectedIndex = -1;
        }
        private void BtnEdit_Click(object sender, EventArgs e) {
            if (CmbContacts.SelectedIndex < 0) {
                if (FormSupplier == null) {
                    FormSupplier = new FrmSupplier();
                    FormSupplier.MdiParent = this.MdiParent;
                    FormSupplier.FormClosed += FormSupplier_FormClosed;
                    FormSupplier.AcceptID(-1);
                    FormSupplier.Show();
                } else {
                    FormSupplier.Activate();
                }
            } else {
                if (FormSupplier == null) {
                    FormSupplier = new FrmSupplier();
                    FormSupplier.MdiParent = this.MdiParent;
                    FormSupplier.FormClosed += FormSupplier_FormClosed;
                    FormSupplier.AcceptID(AllSuppliers[CmbContacts.SelectedIndex + 1].GetID());
                    FormSupplier.Show();
                } else {
                    FormSupplier.Activate();
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            if (CmbContacts.SelectedIndex > -1) {
                if (AllSuppliers[CmbContacts.SelectedIndex].Delete(CmbContacts.SelectedIndex + 1)) {
                    UpdateCMB();
                    CmbContacts.SelectedIndex = -1;
                }
            }
        }
        public void UpdateCMB() {
            CmbContacts.Items.Clear();
            Suppliers = 0;
            AllSuppliers = new Supplier[1];
            AllSuppliers[0] = new Supplier();
            while (AllSuppliers[Suppliers].Initialize(Suppliers + 1)) {
                string S = "Supplier: " + AllSuppliers[Suppliers].GetName();
                CmbContacts.Items.Add(S);
                Suppliers++;
                Supplier[] Temp = new Supplier[Suppliers];
                for (int T = 0; T < Suppliers; T++) {
                    Temp[T] = AllSuppliers[T];
                }
                AllSuppliers = new Supplier[Suppliers + 1];
                for (int T = 0; T < Suppliers; T++) {
                    AllSuppliers[T] = Temp[T];
                }
                AllSuppliers[Suppliers] = new Supplier();
            }
            AllSuppliers[Suppliers] = null;
            Suppliers--;
        }
    }
}