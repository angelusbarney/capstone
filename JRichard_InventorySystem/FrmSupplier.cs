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
    public partial class FrmSupplier : Form {
        Supplier EditSupplier;
        int ID;
        public FrmSupplier() {
            InitializeComponent();
        }
        public void AcceptID(int ID) {
            this.ID = ID;
            EditSupplier = new Supplier();
            if (ID > -1) {
                EditSupplier.Initialize(ID);
                LblSupplier.Text = "Edit supplier #" + ID.ToString();
                TxtName.Text = EditSupplier.GetName();
                TxtDescription.Text = EditSupplier.GetDescription();
                TxtAddress1.Text = EditSupplier.GetAddress1();
                TxtAddress2.Text = EditSupplier.GetAddress2();
                TxtCity.Text = EditSupplier.GetCity();
                TxtRegion.Text = EditSupplier.GetRegion();
                TxtCountry.Text = EditSupplier.GetCountry();
                TxtPostalCode.Text = EditSupplier.GetPostalCode();
                TxtPhone1.Text = EditSupplier.GetPhone1();
                TxtPhone2.Text = EditSupplier.GetPhone2();
                TxtFax.Text = EditSupplier.GetFax();
                TxtStatus.Text = EditSupplier.GetStatus();
                TxtNotes.Text = EditSupplier.GetNotes();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            bool Work = true;
            if (ID > -1) {
                Work = EditSupplier.Edit(ID, TxtName.Text, TxtDescription.Text, TxtAddress1.Text,
                    TxtAddress2.Text, TxtCity.Text, TxtRegion.Text, TxtCountry.Text, TxtPostalCode.Text,
                    TxtPhone1.Text, TxtPhone2.Text, TxtFax.Text, TxtStatus.Text, TxtNotes.Text);
            } else {
                Work = EditSupplier.Add(TxtName.Text, TxtDescription.Text, TxtAddress1.Text,
                    TxtAddress2.Text, TxtCity.Text, TxtRegion.Text, TxtCountry.Text, TxtPostalCode.Text,
                    TxtPhone1.Text, TxtPhone2.Text, TxtFax.Text, TxtStatus.Text, TxtNotes.Text);
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