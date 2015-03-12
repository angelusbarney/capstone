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
using Functionality;
namespace JRichard_DB {
    public partial class FrmCatalogue : Form {
        FrmProduct FormProduct;
        public FrmCatalogue() {
            InitializeComponent();
        }
        private void BtnItem_Click(object sender, EventArgs e) {
            //Also send ID#
            if (FormProduct == null) {
                FormProduct = new FrmProduct();
                FormProduct.MdiParent = this.MdiParent;
                FormProduct.FormClosed += FormProduct_FormClosed;
                FormProduct.Show();
            } else {
                FormProduct.Activate();
            }
        }
        void FormProduct_FormClosed(object sender, FormClosedEventArgs e) {
            FormProduct = null;
            CmbCatalogue.SelectedIndex = -1;
        }
        private void BtnDeleteItem_Click(object sender, EventArgs e) {
            //Delete
            CmbCatalogue.SelectedIndex = -1;
        }
        private void CmbCatalogue_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}