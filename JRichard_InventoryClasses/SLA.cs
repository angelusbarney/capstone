using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_InventoryDB;
namespace JRichard_InventoryClasses {
    public class SLA {
        #region values
            InventoryDataSet.SP_GetByID_SLADataTable TableAdapter;
            private int ID;
            private Finding finding;
            private Supplier supplier;
            private string Description;
            private string Penalty;
        #endregion
        #region getters and setters
            public int GetID() {
                return ID;
            }
            public Finding GetFinding() {
                return finding;
            }
            public void SetFinding(Finding finding) {
                this.finding = finding;
            }
            public Supplier GetSupplier() {
                return supplier;
            }
            public void SetSupplier(Supplier supplier) {
                this.supplier = supplier;
            }
            public string GetDescription() {
                return Description;
            }
            public void SetDescription(string Description) {
                this.Description = Description;
            }
            public string GetPenalty() {
                return Penalty;
            }
            public void SetPenalty(string Penalty) {
                this.Penalty = Penalty;
            }
        #endregion
        #region methods
            public SLA() {
                //ヽ༼ຈل͜ຈ༽ﾉ
            }
            public bool Initialize(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_SLADataTable();
                    this.ID = ID;
                    this.finding = new Finding();
                    this.finding.Initialize(TableAdapter.FindByID(ID).FindingID);
                    this.supplier = new Supplier();
                    this.supplier.Initialize(TableAdapter.FindByID(ID).SupplierID);
                    this.Description = TableAdapter.FindByID(ID).Description;
                    this.Penalty = TableAdapter.FindByID(ID).Penalty;
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Add(int ID, Finding finding, Supplier supplier, string Description, string Penalty) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_SLADataTable();
                    this.finding = finding;
                    this.supplier = supplier;
                    this.Description = Description;
                    this.Penalty = Penalty;
                    this.ID = ID;
                    TableAdapter.AddSP_GetByID_SLARow(ID, finding.GetID(), supplier.GetID(), Description, Penalty);
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Edit(int ID, Finding finding, Supplier supplier, string Description, string Penalty) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_SLADataTable();
                    this.finding = finding;
                    this.supplier = supplier;
                    this.Description = Description;
                    this.Penalty = Penalty;
                    TableAdapter.FindByID(ID).FindingID = finding.GetID();
                    TableAdapter.FindByID(ID).SupplierID = supplier.GetID();
                    TableAdapter.FindByID(ID).Description = Description;
                    TableAdapter.FindByID(ID).Penalty = Penalty;
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Delete(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_SLADataTable();
                    TableAdapter.FindByID(ID).Delete();
                    return true;
                } catch {
                    return false;
                }
            }
        #endregion
    }
}