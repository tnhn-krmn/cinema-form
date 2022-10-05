using Microsoft.Data.SqlClient;
using System.Data;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetCategory();
        }

        SqlConnection _connection = new SqlConnection(@"server=DESKTOP-A5RCAJ3;initial Catalog=Cinema;integrated security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            MoviesList();
        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Passive_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("update movies set IsActive=0 where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(lbl_IsActive.Text));
            cmd.ExecuteNonQuery();
            _connection.Close();
            MoviesList();
        }

        private void MoviesList()
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("select Movies.Id as 'Film Id',Category.Name as 'Kategori Adý', Movies.Director as 'Yönetmen Adý', Movies.Name as 'Film Adý', Movies.IsActive as 'Aktif' from movies INNER JOIN category ON Movies.Category_id = Category.Id  where IsActive=1 ", _connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgw_Movies.DataSource = dt;
            _connection.Close();
        }

        private void dgw_Movies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_IsActive.Text = dgw_Movies.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("insert into movies(Name,Category_id,Director) values(@Name,@Category_id,@Director)", _connection);
            int itemID = Convert.ToInt32(cmbx_Categori.ValueMember);
            MessageBox.Show("id" + itemID);
            cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@Category_id", itemID);
            cmd.Parameters.AddWithValue("@Director", txt_Director.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MoviesList();
        }

        void GetCategory()
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Select * from category", _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string category = reader.GetString("Name");
                cmbx_Categori.Items.Add(category);
            }

            reader.Close();
            _connection.Close();

        }
    }
}