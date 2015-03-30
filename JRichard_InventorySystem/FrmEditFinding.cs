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
    public partial class FrmEditFinding : Form {
        Finding EditFinding;
        int ID;
        public FrmEditFinding() {
            InitializeComponent();
        }
        public void AcceptID(int ID) {
            this.ID = ID;
            EditFinding = new Finding();
            if (ID > -1) {
                EditFinding.Initialize(ID);
                LblFinding.Text = "Edit finding #" + ID.ToString();
                TxtName.Text = EditFinding.GetName();
                TxtDescription.Text = EditFinding.GetDescription();
                TxtCost.Text = EditFinding.GetCost().ToString();
                TxtImageFile.Text = EditFinding.GetImageFile();
                TxtColour.Text = EditFinding.GetColour();
                TxtQuantity.Text = EditFinding.GetQuantity().ToString();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            bool Work = true;
            if (ID > -1) {
                Work = EditFinding.Edit(ID, TxtName.Text, TxtDescription.Text,
                    Convert.ToDouble(TxtCost.Text), TxtImageFile.Text,
                    TxtColour.Text, Convert.ToInt32(TxtQuantity.Text));
            } else {
                Work = EditFinding.Add(TxtName.Text, TxtDescription.Text,
                    Convert.ToDouble(TxtCost.Text), TxtImageFile.Text,
                    TxtColour.Text, Convert.ToInt32(TxtQuantity.Text));
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