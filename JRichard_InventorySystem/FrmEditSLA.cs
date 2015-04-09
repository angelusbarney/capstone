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
    public partial class FrmEditSLA : Form {
        bool Old = false;
        SLA EditSLA;
        Finding[] AllFindings;
        int Findings;
        Supplier[] AllSuppliers;
        int Suppliers;
        int ID;
        public FrmEditSLA() {
            InitializeComponent();
        }
        public void AcceptID(int ID) {
            this.ID = ID;
            EditSLA = new SLA();
            if (EditSLA.Initialize(ID)) {
                Old = true;
                LblSLA.Text = "Edit SLA #" + EditSLA.GetID().ToString();
                CmbFinding.Items.Clear();
                Findings = 0;
                AllFindings = new Finding[1];
                AllFindings[0] = new Finding();
                while (AllFindings[Findings].Initialize(Findings + 1)) {
                    CmbFinding.Items.Add(AllFindings[Findings].GetName());
                    Findings++;
                    Finding[] Temp = new Finding[Findings];
                    for (int T = 0; T < Findings; T++) {
                        Temp[T] = AllFindings[T];
                    }
                    AllFindings = new Finding[Findings + 1];
                    for (int T = 0; T < Findings; T++) {
                        AllFindings[T] = Temp[T];
                    }
                    AllFindings[Findings] = new Finding();
                }
                AllFindings[Findings] = null;
                Findings--;
                CmbSupplier.Items.Clear();
                Suppliers = 0;
                AllSuppliers = new Supplier[1];
                AllSuppliers[0] = new Supplier();
                while (AllSuppliers[Suppliers].Initialize(Suppliers + 1)) {
                    CmbSupplier.Items.Add(AllSuppliers[Suppliers].GetName());
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
                CmbFinding.SelectedIndex = EditSLA.GetFinding().GetID() - 1;
                CmbSupplier.SelectedIndex = EditSLA.GetSupplier().GetID() - 1;
                TxtDescription.Text = EditSLA.GetDescription();
                TxtPenalty.Text = EditSLA.GetPenalty();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            bool Work = true;
            if (Old) {
                Work = EditSLA.Edit(ID, AllFindings[CmbFinding.SelectedIndex],
                    AllSuppliers[CmbSupplier.SelectedIndex], TxtDescription.Text,
                    TxtPenalty.Text);
            } else {
                Work = EditSLA.Add(ID, AllFindings[CmbFinding.SelectedIndex],
                    AllSuppliers[CmbSupplier.SelectedIndex], TxtDescription.Text,
                    TxtPenalty.Text);
            }
            if (Work) {
                this.Close();
            } else {
                MessageBox.Show("Error saving item, please ensure all fields are valid.");
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}