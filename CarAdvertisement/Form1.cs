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

namespace CarAdvertisement
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-84LNPPD;Initial Catalog=CarsDB;Integrated Security=True");
        int CarsID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnSave.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("CarsAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@CarsID", 0);
                    sqlCmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Color", txtColor.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Brand", txtBrand.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Year", txtYear.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelType", txtFuelType.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Gear", txtGear.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Succesfully!");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("CarsAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@CarsID", CarsID);
                    sqlCmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Color", txtColor.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Brand", txtBrand.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Year", txtYear.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelType", txtFuelType.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Gear", txtGear.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Succesfully!");
                }
                Reset();
                FillDataGridView();
                FillDataGridView1();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("AdvertisementViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Model", txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvCarList.DataSource = dtbl;
            dgvCarList.Columns[0].Visible = false;


            sqlCon.Close();
        }
        void FillDataGridView1()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("AdvertisementSearchColor", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Color", txtSearchByColor.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvCarList.DataSource = dtbl;
            dgvCarList.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView1();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void dgvCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCarList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCarList.CurrentRow.Index != -1)
            {
                CarsID= Convert.ToInt32(dgvCarList.CurrentRow.Cells[0].Value.ToString());
                txtModel.Text = dgvCarList.CurrentRow.Cells[1].Value.ToString();
                txtColor.Text = dgvCarList.CurrentRow.Cells[2].Value.ToString();
                txtBrand.Text = dgvCarList.CurrentRow.Cells[3].Value.ToString();
                txtYear.Text = dgvCarList.CurrentRow.Cells[4].Value.ToString();
                txtFuelType.Text = dgvCarList.CurrentRow.Cells[5].Value.ToString();
                txtGear.Text = dgvCarList.CurrentRow.Cells[6].Value.ToString();
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
        void Reset()
        {
            txtModel.Text = txtColor.Text = txtBrand.Text = txtYear.Text = txtFuelType.Text = txtGear.Text = "";
            btnSave.Text = "Save";
            CarsID = 0;
            btnDelete.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
            FillDataGridView1();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
               
                    SqlCommand sqlCmd = new SqlCommand("CarsDeletion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    
                    sqlCmd.Parameters.AddWithValue("@CarsID", CarsID);

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succesfully!");
                Reset();
                FillDataGridView();
                FillDataGridView1();
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}
