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
    public partial class AddProductChangeMaterial : Form
    {
        int value;
        int quantity;
        int materialID;

        Product product;
        public AddProductChangeMaterial(Product p)
        {
            InitializeComponent();
            product = p;
            fillList();
        }

        private void AddProductChangeMaterial_Load(object sender, EventArgs e)
        {
            //Material mm = new Material();
            List<Material> ml = MaterialMapper.getAllMaterials();
            foreach (Material m in ml)
            {
                notAddedListBox.Items.Add(m.MaterialID.ToString() + " : " + m.Name);
            }


        }

        private void fillList()
        {
            foreach(BillOfMaterial m in BillOfMaterial.testing(product))
            {
                //Material temp = MaterialMapper.getMaterialById(m);
                Material derp = new Material(m.MaterialId);
                 derp = MaterialMapper.getMaterialById(derp);
                string quant = m.Quantity.ToString();
                addedListBox.Items.Add("ID - "+ derp.MaterialID+ " - " + derp.Name + " Quantity " + quant);
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            List<Material> test = new List<Material>();
            if (notAddedListBox.SelectedItem != null)
            {
                addedListBox.Items.Add(notAddedListBox.SelectedItem + " Quantity: " + txtQuantity.Text);
            }




        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            if (addedListBox.SelectedItem != null)
            {
                Material m = new Material();
                string temp = addedListBox.SelectedItem.ToString();
                string resultString = Regex.Match(temp, @"\d+").Value;
                m.MaterialID = System.Convert.ToInt16(resultString);
                addedListBox.Items.Remove(addedListBox.SelectedItem);
                ProductMapper.deleteMaterialFromProduct(product, m);
            }
        }
        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int i;
            foreach (var item in addedListBox.Items)
            {
                i = 0;
                String temp = item.ToString();
                MatchCollection v = Regex.Matches(temp, @"\d+");

                foreach (Match match in v)
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
                ProductMapper.addProductReqMaterial(product, m, quantity);

            }

           
            // int materialID = Int32.Parse(resultString);

            // Material m = new Material(materialID);


            




        }













    }
}

