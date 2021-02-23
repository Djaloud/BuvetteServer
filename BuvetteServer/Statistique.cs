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
            charger_chart();
            TimerStat.Start();
            TimerTVente.Start();
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
            conn.Close();

        }

        private void TableVente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void charger_chart()
        {
            chart1.Titles.Add("Bilan Journalier");
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand insertProduit = new SqlCommand("SELECT date_vente,SUM(prix_unitaire*qte) FROM Vente where EtatCommande=@servi group by date_vente", conn);
      
                insertProduit.Parameters.Add(new SqlParameter("@servi", "SERVI"));
                SqlDataReader rd8 = insertProduit.ExecuteReader();
                while (rd8.Read())
                {
                    
                    chart1.Series["Bilan"].Points.AddXY(rd8[0], rd8[1]);

                }
                
            }
            catch (Exception ec)
            {
                Console.WriteLine("Error: " + ec.Message);
            }
            conn.Close();

        }

     
      
        private void ChargetTableTVente()
        {
            string v = "";
            String Heure_Vente = dateTimePicker1.Value.ToString("dd/MM/yy");
            DateTime Dte = DateTime.Parse(Heure_Vente);
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand insertProduit = new SqlCommand("SELECT SUM(prix_unitaire*qte) FROM Vente where date_vente=@dte and EtatCommande=@servi", conn);
                insertProduit.Parameters.Add(new SqlParameter("@dte", Dte));
                insertProduit.Parameters.Add(new SqlParameter("@servi", "SERVI"));
                SqlDataReader rd = insertProduit.ExecuteReader();
                while (rd.Read())
                {
                    v = Convert.ToString(rd[0]);

                }
                if (v != "")
                {
                    argent.Text = v + " Dirhams";
                }
                else
                {
                    argent.Text = "0 Dirhams";
                }

            }
            catch (Exception ec)
            {
                Console.WriteLine("Error: " + ec.Message);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            ChargetTableTVente();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void TimerStat_Tick(object sender, EventArgs e)
        {
            charger_chart();
        }

        private void TimerTVente_Tick(object sender, EventArgs e)
        {
            ChargetTableTVente();
        }
    }
}
