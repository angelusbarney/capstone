using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    class BillOfMaterials {
        #region Values
            public DBConnection Database;
            private int ID;
            private Product product;
            private Finding finding;
            private int Quantity;
            private DateTime CreationTime;
        #endregion
        #region Getters and Setters
            public int GetID() {
                return this.ID;
            }
            public Product GetProduct() {
                return this.product;
            }
            public void SetProduct(Product product) {
                this.product = product;
            }
            public Finding GetFinding() {
                return this.finding;
            }
            public void SetFinding(Finding finding) {
                this.finding = finding;
            }
            public int GetQuantity() {
                return this.Quantity;
            }
            public void SetQuantity(int Quantity) {
                this.Quantity = Quantity;
            }
            public DateTime GetCreationTime() {
                return this.CreationTime;
            }
            public void SetCreationTime(DateTime CreationTime) {
                this.CreationTime = CreationTime;
            }
        #endregion
        #region methods
            
        #endregion
    }
}