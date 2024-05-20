using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionTalleres
{
    public partial class DatosClientes : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;

        public DatosClientes()
        {
            InitializeComponent();
            CargarDatosClientes();
        }

        private void CargarDatosClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Datos_Cliente";
                SqlCommand command = new SqlCommand(query, connection);
 
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                datosClientesDb.DataSource = dataTable;
            }
        }
    }
}
