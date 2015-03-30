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
    public partial class FrmOrderLine : Form {
        FindingOrderLine OrderLine;
        FindingOrder Order;
        Finding[] AllFindings;
        int Findings;
        int ID;
        public FrmOrderLine() {
            InitializeComponent();
            CmbFindings.Items.Clear();
            Findings = 0;
            AllFindings = new Finding[1];
            AllFindings[0] = new Finding();
            while (AllFindings[Findings].Initialize(Findings + 1)) {
                string F = AllFindings[Findings].GetName() + " x" + AllFindings[Findings].GetQuantity().ToString();
                CmbFindings.Items.Add(F);
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
        }
        public void AcceptID(int ID, FindingOrder Order) {
            this.ID = ID;
            this.Order = Order;
            OrderLine = new FindingOrderLine();
            if (ID > -1) {
                OrderLine.Initialize(ID);
                LblLine.Text = "Edit order line #" + ID.ToString();
                TxtQuantity.Text = OrderLine.GetQuantity().ToString();
                CmbFindings.SelectedIndex = OrderLine.GetFinding().GetID();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            bool Work = true;
            if (ID > -1) {
                Work = OrderLine.Edit(ID, AllFindings[CmbFindings.SelectedIndex], this.Order, Convert.ToInt32(TxtQuantity.Text));
            } else {
                Work = OrderLine.Add(AllFindings[CmbFindings.SelectedIndex], this.Order, Convert.ToInt32(TxtQuantity.Text));
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