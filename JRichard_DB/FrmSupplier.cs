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
    public partial class FrmSupplier : Form {
        FrmContact FormContact;
        public FrmSupplier() {
            InitializeComponent();
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            //Delete
            this.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            //Save
        }
        private void BtnContact_Click(object sender, EventArgs e) {
            //Also send ID#
            if (FormContact == null) {
                FormContact = new FrmContact();
                FormContact.MdiParent = this.MdiParent;
                FormContact.FormClosed += FormContact_FormClosed;
                FormContact.Show();
            } else {
                FormContact.Activate();
            }
        }
        void FormContact_FormClosed(object sender, FormClosedEventArgs e) {
            FormContact = null;
        }
    }
}