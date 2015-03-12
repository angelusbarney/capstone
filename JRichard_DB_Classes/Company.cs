using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class Company : Contact {
        #region Values
            public DBConnection Database;
            private string Name;
            private string Description;
        #endregion
        #region Setters and Getters
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
        #endregion
        #region methods
        #endregion
    }
}