using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuvetteServer
{
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
            ChargerTableVente();
        }

        private void ChargerTableVente()
        {
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand SelectVente = new SqlCommand("SELECT * from vente where EtatCommande=@servi", conn);
                SelectVente.Parameters.Add(new SqlParameter("@servi", "SERVI"));
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = SelectVente;
                DataTable MydataSet = new DataTable();
                sda.Fill(MydataSet);
                BindingSource bS = new BindingSource();
                bS.DataSource = MydataSet;
                TableVente.DataSource = bS;
                sda.Update(MydataSet);
            }
            catch (Exception ec)
            {
                Console.WriteLine("Error: " + ec.Message);
            }

        }

        private void TableVente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
