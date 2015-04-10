using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_InventoryDB;
namespace JRichard_InventoryClasses {
    public class Finding {
        #region values
            InventoryDataSet.SP_GetByID_FindingDataTable TableAdapter;
            private int ID;
            private string Name;
            private string Description;
            private double Cost;
            private string ImageFile;
            private string Colour;
            private int Quantity;
        #endregion
        #region getters and setters
            public int GetID() {
                return ID;
            }
            public string GetName() {
                return Name;
            }
            public void SetName(string Name) {
                this.Name = Name;
            }
            public string GetDescription() {
                return Description;
            }
            public void SetDescription(string Description) {
                this.Description = Description;
            }
            public double GetCost() {
                return Cost;
            }
            public void SetCost(double Cost) {
                this.Cost = Cost;
            }
            public string GetImageFile() {
                return ImageFile;
            }
            public void SetImageFile(string ImageFile) {
                this.ImageFile = ImageFile;
            }
            public string GetColour() {
                return Colour;
            }
            public void SetColour(string Colour) {
                this.Colour = Colour;
            }
            public int GetQuantity() {
                return Quantity;
            }
            public void SetQuantity(int Quantity) {
                this.Quantity = Quantity;
            }
        #endregion
        #region methods
            public Finding() {
                //ヽ༼ຈل͜ຈ༽ﾉ
            }
            public bool Initialize(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingDataTable();
                    this.ID = ID;
                    for (int R = 0; R < TableAdapter.Rows.Count; R++) {
                        if (Convert.ToInt32(TableAdapter.Rows[R]["Id"]) == ID) {
                            this.Name = TableAdapter.Rows[R]["Name"].ToString();
                            this.Description = TableAdapter.Rows[R]["Description"].ToString();
                            this.Cost = Convert.ToDouble(TableAdapter.Rows[R]["Description"]);
                            this.ImageFile = TableAdapter.Rows[R]["ImageFile"].ToString();
                            this.Quantity = Convert.ToInt32(TableAdapter.Rows[R]["Quantity"]);
                        }
                    }
                    if (this.Name != null) {
                        return true;
                    } else {
                        return false;
                    }
                } catch {
                    return false;
                }
            }
            public bool Add(int ID, string Name, string Description, double Cost, string ImageFile, string Colour, int Quantity) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingDataTable();
                    this.Name = Name;
                    this.Description = Description;
                    this.Cost = Cost;
                    this.ImageFile = ImageFile;
                    this.Colour = Colour;
                    this.Quantity = Quantity;
                    this.ID = ID;
                    DataRow AddedRow = TableAdapter.NewRow();
                    AddedRow["Id"] = ID;
                    AddedRow["Name"] = Name;
                    AddedRow["Cost"] = Convert.ToDouble(Cost);
                    AddedRow["Description"] = Description;
                    AddedRow["ImageFile"] = ImageFile;
                    AddedRow["Colour"] = Colour;
                    AddedRow["Quantity"] = Quantity;
                    TableAdapter.Rows.Add(AddedRow);
                    //TableAdapter.AddSP_GetByID_FindingRow(ID, Name, Description, Convert.ToDecimal(Cost), ImageFile, Colour, Quantity);
                    //TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Edit(int ID, string Name, string Description, double Cost, string ImageFile, string Colour, int Quantity) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingDataTable();
                    //InventoryDataSet.SP_GetByID_FindingRow FindingRow = new InventoryDataSet.SP_GetByID_FindingRow();
                    this.Name = Name;
                    this.Description = Description;
                    this.Cost = Cost;
                    this.ImageFile = ImageFile;
                    this.Colour = Colour;
                    this.Quantity = Quantity;
                    TableAdapter.FindByID(ID).Name = Name;
                    TableAdapter.FindByID(ID).Description = Description;
                    TableAdapter.FindByID(ID).Cost = Convert.ToDecimal(Cost);
                    TableAdapter.FindByID(ID).ImageFile = ImageFile;
                    TableAdapter.FindByID(ID).Colour = Colour;
                    TableAdapter.FindByID(ID).Quantity = Quantity;
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Delete(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingDataTable();
                    TableAdapter.FindByID(ID).Delete();
                    return true;
                } catch {
                    return false;
                }
            }
        #endregion
    }
}