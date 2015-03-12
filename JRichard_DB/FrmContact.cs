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
    public partial class FrmContact : Form {
        public Contact contact;
        public FrmContact() {
            InitializeComponent();
        }
        public void LoadContact(int ID) {
            if (ID < 1) {
                ID = 1;
            }
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            //Save
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void BtnDelete_Click(object sender, EventArgs e)  {
            //Delete cascade
            this.Close();
        }
    }
}