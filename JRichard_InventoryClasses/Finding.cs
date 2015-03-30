﻿using System;
using System.Collections.Generic;
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
                    this.Name = TableAdapter.FindByID(ID).Name;
                    this.Description = TableAdapter.FindByID(ID).Description;
                    this.Cost = Convert.ToDouble(TableAdapter.FindByID(ID).Cost);
                    this.ImageFile = TableAdapter.FindByID(ID).ImageFile;
                    this.Colour = TableAdapter.FindByID(ID).Colour;
                    this.Quantity = TableAdapter.FindByID(ID).Quantity;
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Add(string Name, string Description, double Cost, string ImageFile, string Colour, int Quantity) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingDataTable();
                    this.Name = Name;
                    this.Description = Description;
                    this.Cost = Cost;
                    this.ImageFile = ImageFile;
                    this.Colour = Colour;
                    this.Quantity = Quantity;
                    int F = 1;
                    while (TableAdapter.FindByID(F) != null) {
                        F++;
                    }
                    TableAdapter.NewRow();
                    TableAdapter.FindByID(F).Name = Name;
                    TableAdapter.FindByID(F).Description = Description;
                    TableAdapter.FindByID(F).Cost = Convert.ToDecimal(Cost);
                    TableAdapter.FindByID(F).ImageFile = ImageFile;
                    TableAdapter.FindByID(F).Colour = Colour;
                    TableAdapter.FindByID(F).Quantity = Quantity;
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Edit(int ID, string Name, string Description, double Cost, string ImageFile, string Colour, int Quantity) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingDataTable();
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