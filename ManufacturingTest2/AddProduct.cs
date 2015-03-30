using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Text.RegularExpressions;

namespace ManufacturingTest2
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            fillList();

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }











        private void fillList()
        {
            foreach(Material m in MaterialMapper.getAllMaterials())
            {
                NotAddedMaterials.Items.Add("ID -" + m.MaterialID + " Name - " + m.Name);
            }
            



        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            List<Material> test = new List<Material>();
            if(NotAddedMaterials.SelectedItem != null)
            {
                AddedMaterialsList.Items.Add(NotAddedMaterials.SelectedItem + " Quantity: " + txtMaterialQuantity.Text);
            }
        }

        int value, materialID, quantity;
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int i;
            Product p = new Product();
            p.Name = ProductName.Text;
            p.Description = ProductNotes.Text;
            p.RetailPrice = System.Convert.ToDecimal(ProductCost.Text);
            p.ProductlID = ProductMapper.insertProduct(p);

            foreach(var item in AddedMaterialsList.Items)
            {
                i = 0;
                String temp = item.ToString();
                MatchCollection v = Regex.Matches(temp, @"\d+");

                foreach(Match match in v)
                {
                    value = Int32.Parse(match.Value);
                    if (i == 0)
                    {
                        materialID = value;
                    }
                    else if (i == 1)
                    {
                        quantity = value;
                    }
                    i++;
                }
                Material m = new Material(materialID);
                ProductMapper.addProductReqMaterial(p, m, quantity);
                
            }
            MessageBox.Show("New Product added");
            this.Close();
        }




        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            if (AddedMaterialsList.SelectedItem != null)
            {
                AddedMaterialsList.Items.Remove(AddedMaterialsList.SelectedItem);
            }
        }



    }
}
