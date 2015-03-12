using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class SLA {
        #region Values
            public DBConnection Database;
            private int ID;
            private Finding finding;
            private Supplier supplier;
            private string Description;
            private string Penalty;
        #endregion
        #region Getters and Setters
            public int GetID() {
                return this.ID;
            }
            public Finding GetFinding() {
                return this.finding;
            }
            public void SetFinding(Finding finding) {
                this.finding = finding;
            }
            public Supplier GetSupplier() {
                return this.supplier;
            }
            public void SetSupplier(Supplier supplier) {
                this.supplier = supplier;
            }
            public string GetDescription() {
                return this.Description;
            }
            public void SetDescription(string Description) {
                this.Description = Description;
            }
            public string GetPenalty() {
                return this.Penalty;
            }
            public void SetPenalty(string Penalty) {
                this.Penalty = Penalty;
            }
        #endregion
        #region methods
        #endregion
    }
}