using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CookBook
{
    public partial class FrmMain : Form
    {
        SqlConnection connection;
        string connectionStr;
        public FrmMain()
        {
            InitializeComponent();
            connectionStr = ConfigurationManager.ConnectionStrings["CookBook.Properties.Settings.CookbookConnectionString"].ConnectionString;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PopulateReceipes();
            PopulateAllIngridents();
            
        }

        private void PopulateReceipes() {
            using (connection = new SqlConnection(connectionStr))
            using (SqlDataAdapter adapter=new SqlDataAdapter("Select * From Receipe",connection))
            {
                DataTable receipeTable = new DataTable();
                adapter.Fill(receipeTable);

                lstReceipes.DisplayMember = "Name";
                lstReceipes.ValueMember = "Id";
                lstReceipes.DataSource = receipeTable;
            }
        }

        private void PopulateAllIngridents() {
            using (connection = new SqlConnection(connectionStr))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Ingredient", connection))
            {
                DataTable ingredientDataTable = new DataTable();
                adapter.Fill(ingredientDataTable);

                lstAllIngredients.DisplayMember = "Name";
                lstAllIngredients.ValueMember = "Id";
                lstAllIngredients.DataSource=ingredientDataTable;
            }
        }


        private void PopulateIngredients() {
            string query = "select a.Name from Ingredient a "
                           + " Inner Join ReceipeIngredient b On a.Id = b.IngredientId "
                           + " WHERE b.ReceipeId = @ReceipeId; ";
            //string query = "Select * From Ingredient";
            using (connection = new SqlConnection(connectionStr))
            using (SqlCommand command=new SqlCommand(query,connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ReceipeId", lstReceipes.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                lstIngredients.DisplayMember = "Name";
                lstIngredients.ValueMember = "Id";
                lstIngredients.DataSource = ingredientTable;

            }
        }



        private void lstReceipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstReceipes.SelectedValue.ToString());
            PopulateIngredients();
        }

        private void btnAddReceipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Receipe VALUES(@ReceipeName,80,'blah blah')";
            using (connection = new SqlConnection(connectionStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ReceipeName",textReceipe1.Text);
                command.ExecuteScalar();
                
            }

            PopulateReceipes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Receipe SET Name=@ReceipeName Where Id=@ReceipeId";
            using (connection = new SqlConnection(connectionStr)) 
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ReceipeName", textReceipe1.Text);
                command.Parameters.AddWithValue("@ReceipeId", lstReceipes.SelectedValue);

                command.ExecuteScalar();
            }

            PopulateReceipes();
        }

        private void BtnSelectIngredient_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ReceipeIngredient VALUES(@ReceipeId,@IngredientId)";
            using (connection = new SqlConnection(connectionStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ReceipeId", lstReceipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", lstAllIngredients.SelectedValue);

                command.ExecuteScalar();
            }
            PopulateReceipes();

        }
    }
}
