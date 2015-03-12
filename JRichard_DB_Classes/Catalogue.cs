using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class Catalogue {
        #region Values
            public DBConnection Database;
            private int ID;
            private string Name;
            private string Description;
            private DateTime BeginDate;
            private DateTime EndDate;
        #endregion
        #region Setters and Getters
            public int GetID() {
                return this.ID;
            }
            public string GetName() {
                return this.Name;
            }
            public void SetName(string Name) {
                this.Name = Name;
            }
            public string GetDescription() {
                return this.Description;
            }
            public void SetDescription(string Description) {
                this.Description = Description;
            }
            public DateTime GetBeginDate() {
                return this.BeginDate;
            }
            public void SetBeginDate(DateTime BeginDate) {
                this.BeginDate = BeginDate;
            }
            public DateTime GetEndDate() {
                return this.EndDate;
            }
            public void SetEndDate(DateTime EndDate) {
                this.EndDate = EndDate;
            }
        #endregion
        #region methods
        #endregion
    }
}