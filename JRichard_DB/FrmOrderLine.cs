using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functionality;
namespace JRichard_DB {
    public partial class FrmOrderLine : Form {
        public FrmOrderLine() {
            InitializeComponent();
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
    }
}