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

        objectCounter counter;
        Order orderData;
        Product productData;
        Client clientData;

        void SetClientId()
        {
            label2.Text = clientData.id.ToString() + "/" + clientData.getMax();
        }
        void SetOrderId()
        {
            label11.Text = orderData.id.ToString() + "/" + orderData.getMax();
        }
        void SetProductId()
        {
            label8.Text = productData.id.ToString() + "/" + productData.getMax();
        }
        public Form1()
        {
            InitializeComponent();
            counter = new objectCounter();
            orderData = new Order(counter, 0);
            productData = new Product(counter, 0);
            clientData = new Client(counter, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Product Refresh
            productData.getProperties();

            textProductName.Text = productData.name;
            numericPrice.Value = productData.price;
            calEndDate.SelectionStart = productData.enddate;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Product Commit
            productData.name = textProductName.Text;
            productData.price = numericPrice.Value;
            productData.enddate = calEndDate.SelectionStart;

            productData.setProperties();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Client Refresh
            clientData.getProperties();


            clientData.name = textClientName.Text;
            clientData.Address = textAddress.Text;
            clientData.City = textCity.Text;
            clientData.Country = textCountry.Text;
            clientData.PhoneNumber = textPhone.Text;
            clientData.Email = textEmail.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Client Commit
            textClientName.Text = clientData.name;
            textAddress.Text = clientData.Address;
            textCity.Text = clientData.City;
            textCountry.Text = clientData.Country;
            textPhone.Text = clientData.PhoneNumber;
            textEmail.Text = clientData.Email;

            clientData.setProperties();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Order Commit
            orderData.client.id = counter.fetchClientId(comboClient.SelectedIndex);
            orderData.product.id = counter.fetchProductId(comboProduct.SelectedIndex);
            orderData.orderDate = calOrderDate.SelectionStart;
            orderData.orderPaid = Convert.ToBoolean(boxOrderPaid.Checked);

            orderData.setProperties();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Order Refresh
            orderData.getProperties();

            orderData.client.id = counter.fetchClientId(comboClient.SelectedIndex);
            orderData.product.id = counter.fetchProductId(comboProduct.SelectedIndex);
            calOrderDate.SelectionStart = orderData.orderDate;
            if (orderData.orderPaid)
            {
                boxOrderPaid.Checked = true;
            }
            else
            {
                boxOrderPaid.Checked = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call Refresh for each Tab
            clientData.getProperties();
            orderData.getProperties();
            productData.getProperties();

            clientData.name = textClientName.Text;
            clientData.Address = textAddress.Text;
            clientData.City = textCity.Text;
            clientData.Country = textCountry.Text;
            clientData.PhoneNumber = textPhone.Text;
            clientData.Email = textEmail.Text;

            productData.name = textProductName.Text;
            productData.price = numericPrice.Value;
            productData.enddate = calEndDate.SelectionStart;

            orderData.client.id = counter.fetchClientId(comboClient.SelectedIndex);
            orderData.product.id = counter.fetchProductId(comboProduct.SelectedIndex);
            orderData.orderDate = calOrderDate.SelectionStart;
            orderData.orderPaid = Convert.ToBoolean(boxOrderPaid.Checked);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Backtrack Product ID
            if (productData.id > 0) { productData.id--; }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (orderData.id > 0) { orderData.id--; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (clientData.id > 0) { clientData.id--; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clientData.id <= clientData.getMax())
            {
                clientData.id++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (orderData.id <= orderData.getMax())
            {
                orderData.id++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (productData.id <= productData.getMax())
            {
                productData.id++;
            }
        }
    }
}
