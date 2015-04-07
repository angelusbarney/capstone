using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] names = { "", "" };
            dbObjects dbData = new dbObjects();
            foreach(String localProductName in names) {
                dbData += new Product(localProductName);
            }
            List<String> comboContents = new List<String>();
            for (int counter = 0; counter < dbData.getCount(); counter++)
            {
                comboContents.Add(dbData.getIndex(counter).ElementAt(counter).name);
            }

                comboBox1.Items.Equals(names);
        }
    }
}
