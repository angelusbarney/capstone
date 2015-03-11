using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPSTN_ProductManagement;
namespace JRichard_DB {
    public partial class FrmFinding : Form {
        FrmSupplier FormSupplier;
        public FrmFinding() {
            InitializeComponent();
        }
        private void CmbFinding_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void BtnSave_Click(object sender, EventArgs e) {
            //Save
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            //Delete
            this.Close();
        }
        private void BtnAddSupplier_Click(object sender, EventArgs e) {
            //Also send ID# = 0;
            if (FormSupplier == null) {
                FormSupplier = new FrmSupplier();
                FormSupplier.MdiParent = this.MdiParent;
                FormSupplier.FormClosed += FormSupplier_FormClosed;
                FormSupplier.Show();
            } else {
                FormSupplier.Activate();
            }
        }

        void FormSupplier_FormClosed(object sender, FormClosedEventArgs e) {
            FormSupplier = null;
            CmbSupplier.SelectedIndex = -1;
        }
        private void BtnEditSupplier_Click(object sender, EventArgs e) {
            //Also send ID#;
            if (FormSupplier == null) {
                FormSupplier = new FrmSupplier();
                FormSupplier.MdiParent = this.MdiParent;
                FormSupplier.FormClosed += FormSupplier_FormClosed;
                FormSupplier.Show();
            } else {
                FormSupplier.Activate();
            }
        }
        private void BtnDeleteSupplier_Click(object sender, EventArgs e) {
            //Delete
            CmbSupplier.SelectedIndex = -1;
        }
    }
}