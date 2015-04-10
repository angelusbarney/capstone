using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_InventoryDB;
namespace JRichard_InventoryClasses {
    public class Supplier : Contact {
        #region values
            InventoryDataSet.SP_GetByID_SupplierDataTable TableAdapter;
            InventoryDataSet.SP_GetByID_ContactDataTable SuperAdapter;
            private string Name;
            private string Description;
        #endregion
        #region getters and setters
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
        #endregion
        #region methods
            public Supplier() {
                //ヽ༼ຈل͜ຈ༽ﾉ
            }
            public bool Initialize(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_SupplierDataTable();
                    SuperAdapter = new InventoryDataSet.SP_GetByID_ContactDataTable();
                    this.Name = TableAdapter.FindByID(ID).Name;
                    this.Description = TableAdapter.FindByID(ID).Description;
                    int ContactID = TableAdapter.FindByID(ID).ContactID;
                    SetAddress1(SuperAdapter.FindById(ContactID).Address1);
                    SetAddress2(SuperAdapter.FindById(ContactID).Address2);
                    SetCity(SuperAdapter.FindById(ContactID).City);
                    SetRegion(SuperAdapter.FindById(ContactID).Region);
                    SetCountry(SuperAdapter.FindById(ContactID).Country);
                    this.CreationDate = SuperAdapter.FindById(ContactID).CreationDate;
                    SetPhone1(SuperAdapter.FindById(ContactID).Phone1);
                    SetPhone2(SuperAdapter.FindById(ContactID).Phone2);
                    SetFax(SuperAdapter.FindById(ContactID).Fax);
                    SetStatus(SuperAdapter.FindById(ContactID).Status);
                    SetNotes(SuperAdapter.FindById(ContactID).Notes);
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Add(int ID, string Name, string Description, string Address1, string Address2,
                string City, string Region, string Country, string PostalCode, string Phone1, string Phone2,
                string Fax, string Status, string Notes) {
                try {
                    this.Name = Name;
                    this.Description = Description;
                    SetAddress1(Address1);
                    SetAddress2(Address2);
                    SetCity(City);
                    SetRegion(Region);
                    SetCountry(Country);
                    SetPostalCode(PostalCode);
                    this.CreationDate = DateTime.Now;
                    SetPhone1(Phone1);
                    SetPhone2(Phone2);
                    SetFax(Fax);
                    SetStatus(Status);
                    SetNotes(Notes);
                    this.ID = ID;
                    SuperAdapter.AddSP_GetByID_ContactRow(ID, Address1, Address2, City, Region, Country, PostalCode, CreationDate, Phone1, Phone2, Fax, Status, Notes);
                    SuperAdapter.AcceptChanges();
                    TableAdapter.AddSP_GetByID_SupplierRow(ID, Name, Description, ID);
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Edit(int ID, string Name, string Description, string Address1,
                string Address2, string City, string Region, string Country, string PostalCode, string Phone1,
                string Phone2, string Fax, string Status, string Notes) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_SupplierDataTable();
                    SuperAdapter = new InventoryDataSet.SP_GetByID_ContactDataTable();
                    this.Name = Name;
                    this.Description = Description;
                    SetAddress1(Address1);
                    SetAddress2(Address2);
                    SetCity(City);
                    SetRegion(Region);
                    SetCountry(Country);
                    SetPostalCode(PostalCode);
                    SetPhone1(Phone1);
                    SetPhone2(Phone2);
                    SetFax(Fax);
                    SetStatus(Status);
                    SetNotes(Notes);
                    int F = TableAdapter.FindByID(ID).ContactID;
                    SuperAdapter.FindById(ID).Address1 = Address1;
                    SuperAdapter.FindById(ID).Address2 = Address2;
                    SuperAdapter.FindById(ID).City = City;
                    SuperAdapter.FindById(ID).Region = Region;
                    SuperAdapter.FindById(ID).Country = Country;
                    SuperAdapter.FindById(ID).PostalCode = PostalCode;
                    SuperAdapter.FindById(ID).Phone1 = Phone1;
                    SuperAdapter.FindById(ID).Phone2 = Phone2;
                    SuperAdapter.FindById(ID).Fax = Fax;
                    SuperAdapter.FindById(ID).Status = Status;
                    SuperAdapter.FindById(ID).Notes = Notes;
                    SuperAdapter.AcceptChanges();
                    TableAdapter.FindByID(ID).Name = Name;
                    TableAdapter.FindByID(ID).Description = Description;
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Delete(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_SupplierDataTable();
                    SuperAdapter = new InventoryDataSet.SP_GetByID_ContactDataTable();
                    TableAdapter.FindByID(ID).Delete();
                    SuperAdapter.FindById(ID).Delete();
                    return true;
                } catch {
                    return false;
                }
            }
        #endregion
    }
}