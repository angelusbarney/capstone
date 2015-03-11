using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSTN_ProductManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] names = { "", "" };
            dbObjects dbData = new dbObjects();
            foreach(String localProductName in names) {
                dbData += new Product();
            }
            List<String> comboContents = new List<String>();
            //comboBox1.Text = dbData.getIndex(0).ElementAt(0).name; 
            //for (int counter = 0; counter < dbData.getCount(); counter++)
            //{
            //        comboContents.Add(dbData.getIndex(counter).ElementAt(0).name);
            //}

                comboBox1.Items.Equals(names);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
