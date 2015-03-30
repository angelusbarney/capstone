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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial f = new AddMaterial();
            f.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void fillCombo()
        {
            MaterialsDisplay.Items.Clear();
            //Material mm = new Material();
            List<Material> materials = MaterialMapper.getAllMaterials();
            foreach(Material m in materials)
            {
                MaterialsDisplay.Items.Add(m.MaterialID.ToString() + " : " + m.Name);
            }//end foreach

            ProductDisplay.Items.Clear();
            Product pp = new Product();
            foreach(Product p in ProductMapper.getAllProducts())
            {
                ProductDisplay.Items.Add(p.ProductlID.ToString() + " : " + p.Name);
            }
        }

        private void MaterialsDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp2 = MaterialsDisplay.Text;
            string resultString = Regex.Match(temp2, @"\d+").Value;
            int x = Int32.Parse(resultString);
            Material m = new Material();
            m.MaterialID = x;
            m=MaterialMapper.getMaterialById(m);

            txtMaterialName.Text = m.Name;
            txtMaterialDesc.Text = m.Description;
            txtMaterialCost.Text = Convert.ToString(m.Cost);
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            string temp2 = MaterialsDisplay.Text;
            string resultString = Regex.Match(temp2, @"\d+").Value;
            int x = Int32.Parse(resultString);
            Material m = new Material(x);
            MaterialMapper.deleteMaterial(m);
            fillCombo();
        }

        private void btnMaterialUpdate_Click(object sender, EventArgs e)
        {
            string temp2 = MaterialsDisplay.Text;
            string resultString = Regex.Match(temp2, @"\d+").Value;
            int x = Int32.Parse(resultString);
            Material m = new Material(x);
            m.MaterialID = x;
            m.Name = txtMaterialName.Text;
            m.Cost = Decimal.Parse(txtMaterialCost.Text);
            m.Description = txtMaterialDesc.Text;
            MaterialMapper.updateMaterial(m);
            fillCombo();
        }

        private void ProductDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMaterialsRequired.Items.Clear();
            string temp2 = ProductDisplay.Text;
            string resultString = Regex.Match(temp2, @"\d+").Value;
            int x = Int32.Parse(resultString);
            Product p = new Product(x);
            p = ProductMapper.getProductById(p);
            //p = ProductMapper.getMaterialsRequired(p);

            txtProductName.Text = p.Name;
            txtProductDesc.Text = p.Description;
            txtProductCost.Text = Convert.ToString(p.RetailPrice);

            foreach (BillOfMaterial m in BillOfMaterial.testing(p))
            {
                Material derp = new Material(m.MaterialId);
                derp = MaterialMapper.getMaterialById(derp);
                string quant = m.Quantity.ToString();
                lstMaterialsRequired.Items.Add(derp.Name + " Quantity " + quant);

            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string temp2 = ProductDisplay.Text;
            string resultString = Regex.Match(temp2, @"\d+").Value;
            int x = Int32.Parse(resultString);
            Product p = new Product(x);
            p.Name = txtProductName.Text;
            p.RetailPrice = Decimal.Parse(txtProductCost.Text);
            p.Description = txtProductDesc.Text;
            int z = ProductMapper.updateProduct(p);
            fillCombo();
        }

        private void btnEditProductMaterial_Click(object sender, EventArgs e)
        {
            string temp2 = ProductDisplay.Text;
            string resultString = Regex.Match(temp2, @"\d+").Value;
            int x = Int32.Parse(resultString);
            Product p = new Product(x);
            //p = ProductMapper.getMaterialsRequired(p);
            AddProductChangeMaterial w = new AddProductChangeMaterial(p);
            w.Show();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct w = new AddProduct();
            w.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string temp2 = ProductDisplay.Text;
            string resultString = Regex.Match(temp2, @"\d+").Value;
            int x = Int32.Parse(resultString);
            Product p = new Product(x);

            ProductMapper.deleteProduct(p);
            fillCombo();
        }//end fillCombo


    






    }
}
