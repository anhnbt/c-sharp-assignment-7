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
    public partial class FrmProductList : Form
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;
        public FrmProductList()
        {
            InitializeComponent();
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                string queryString = "SELECT * FROM Products ORDER BY ProductID DESC";
                SqlConnection connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvwProductList.DataSource = dataTable;
                dgvwProductList.AutoGenerateColumns = false;
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvwProductList_Click(object sender, EventArgs e)
        {
            int productId;
            productId = (int)dgvwProductList.CurrentRow.Cells[0].Value;
            lblSelectedItem.Text = productId.ToString();
        }

        private void dgvwProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Yes" : "No";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvwProductList_DoubleClick(object sender, EventArgs e)
        {
            int productId;
            productId = (int)dgvwProductList.CurrentRow.Cells[0].Value;
            FrmProductSelected frmProductSelected = new FrmProductSelected(productId);
            frmProductSelected.MdiParent = this.MdiParent;
            frmProductSelected.Show();
        }
    }
}
