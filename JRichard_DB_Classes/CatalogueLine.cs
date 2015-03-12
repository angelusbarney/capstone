using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class CatalogueLine {
        #region Values
            public DBConnection Database;
            private int ID;
            private Product product;
            private Catalogue catalogue;
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
            public Catalogue GetCatalogue() {
                return this.catalogue;
            }
            public void SetCatalogue(Catalogue catalogue) {
                this.catalogue = catalogue;
            }
        #endregion
        #region methods
        #endregion
    }
}