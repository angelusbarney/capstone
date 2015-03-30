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
    public partial class FrmAddOrder : Form {
        FindingOrder Order;
        int ID;
        public FrmAddOrder() {
            InitializeComponent();
        }
        public void AcceptID(int ID) {
            this.ID = ID;
            Order = new FindingOrder();
            if (ID > -1) {
                Order.Initialize(ID);
                LblOrder.Text = "Edit order #" + Order.GetID().ToString();
                TxtNotes.Text = Order.GetNotes();
                TxtStatus.Text = Order.GetStatus();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            bool Work = true;
            if (ID > -1) {
                Work = Order.Edit(ID, TxtStatus.Text, TxtNotes.Text);
            } else {
                Work = Order.Add(DateTime.Now, TxtStatus.Text, TxtNotes.Text);
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