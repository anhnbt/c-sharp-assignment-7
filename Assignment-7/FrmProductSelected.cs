using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment_7
{
    public partial class FrmProductSelected : Form
    {

        private int productId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        private DataTable dtAvaiableProducts;
        private DataTable dtSelectedProducts;
        public FrmProductSelected(int productId)
        {
            InitializeComponent();
            this.productId = productId;
        }

        private void FrmProductSelected_Load(object sender, EventArgs e)
        {
            loadProductList();
            loadPicture(productId);
        }

        private void loadProductList()
        {
            try
            {
                string queryString = "SELECT ProductID, ProductName FROM Products WHERE ProductID <> " + productId + " ORDER BY ProductID DESC";
                SqlConnection connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }


                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                dtAvaiableProducts = new DataTable();
                dataAdapter.Fill(dtAvaiableProducts);
                lstAvaiableProducts.DataSource = dtAvaiableProducts;
                lstAvaiableProducts.DisplayMember = "ProductName";
                lstAvaiableProducts.ValueMember = "ProductID";

                queryString = "SELECT ProductID, ProductName FROM Products WHERE ProductID = " + productId;
                dataAdapter = new SqlDataAdapter(queryString, connection);
                dtSelectedProducts = new DataTable();
                dataAdapter.Fill(dtSelectedProducts);
                lstSelectedProducts.DataSource = dtSelectedProducts;
                lstSelectedProducts.DisplayMember = "ProductName";
                lstSelectedProducts.ValueMember = "ProductID";

                connection.Close();


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadPicture(int productId)
        {
            string queryString = "SELECT ImagePath FROM Products WHERE ProductID = " + productId;
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                picImagePath.ImageLocation = dataTable.Rows[0]["ImagePath"].ToString();
                picImagePath.Size = new Size(175, 300);
            }
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtAvaiableProducts.Rows.Count > 0)
            {
                DataRow dataRow = dtSelectedProducts.NewRow();
                dataRow["ProductID"] = lstAvaiableProducts.SelectedValue;
                dataRow["ProductName"] = lstAvaiableProducts.Text;

                dtSelectedProducts.Rows.Add(dataRow);
                dtSelectedProducts.AcceptChanges();

                foreach (DataRow dr in dtAvaiableProducts.Rows)
                {
                    if (dr["ProductID"].ToString() == dataRow["ProductID"].ToString())
                    {
                        dr.Delete();
                    }
                }
                dtAvaiableProducts.AcceptChanges();
            }
        }

        private void lstAvaiableProducts_Click(object sender, EventArgs e)
        {
            loadPicture((int)lstAvaiableProducts.SelectedValue);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dtSelectedProducts.Rows.Count > 0)
            {
                DataRow dataRow = dtAvaiableProducts.NewRow();
                dataRow["ProductID"] = lstSelectedProducts.SelectedValue;
                dataRow["ProductName"] = lstSelectedProducts.Text;

                dtAvaiableProducts.Rows.Add(dataRow);
                dtAvaiableProducts.AcceptChanges();

                foreach (DataRow dr in dtSelectedProducts.Rows)
                {
                    if (dr["ProductID"].ToString() == dataRow["ProductID"].ToString())
                    {
                        dr.Delete();
                    }
                }
                dtSelectedProducts.AcceptChanges();
            }
        }

        private void lstSelectedProducts_Click(object sender, EventArgs e)
        {
            loadPicture((int)lstSelectedProducts.SelectedValue);
        }
    }
}
