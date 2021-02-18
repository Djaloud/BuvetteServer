using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuvetteServer
{
    public partial class Vente : Form
    {
        public Vente()
        {
            InitializeComponent();
            DataGridViewRow row = this.TableVente.RowTemplate;
            row.DefaultCellStyle.BackColor = Color.Snow;
            row.Height = 27;
            row.MinimumHeight = 20;
            ChargerTableVente();
            timer1.Start();
            DateTime Heure_Vente = DateTime.Parse(DateTime.Now.Date.ToString("d/M/yyyy"));
           MessageBox.Show(Convert.ToString(Heure_Vente));
            

        }

        private void TableVente_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
           
           
            if (TableVente.Columns[e.ColumnIndex].Name == "Etat")
            {
                String Id = Convert.ToString(TableVente.Rows[e.RowIndex].Cells[2].Value);
                // connexion a la base de donnee
                SqlConnection conn = ConnexionDb.GetDBConnection();
                try
                {
                    // ouverture de la base de donnée
                    conn.Open();

                }
                catch (Exception ec)
                {
                    Console.WriteLine("Error: " + ec.Message);
                }
                
                // requette pour la modification dans la base de donnnee
                SqlCommand insertProduit = new SqlCommand("UPDATE VENTE set EtatCommande = @nom where id_vente= @Ref", conn);

                // on remplace les parametre de la requete @ref par ce que l utilisateur va saisir ( Id_produit.Text)
                insertProduit.Parameters.Add(new SqlParameter("@nom", "SERVI"));
                insertProduit.Parameters.Add(new SqlParameter("@Ref", Id));
           
                // execution de la requete
                insertProduit.ExecuteNonQuery();
                // je charge le datagrid pour pouvoir voir les modification
                ChargerTableVente();

            }else if (TableVente.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                String Id = Convert.ToString(TableVente.Rows[e.RowIndex].Cells[2].Value);
                DialogResult rs = MessageBox.Show("Etes-vous sur d'annuler la commande?", "INFORMATION", MessageBoxButtons.YesNo);
                try
                {
                    if (rs == DialogResult.Yes)
                    {
                        SqlConnection conn = ConnexionDb.GetDBConnection();
                        try
                        {
                            conn.Open();

                        }
                        catch (Exception ec)
                        {
                            Console.WriteLine("Error: " + ec.Message);
                        }

                        SqlCommand insertProduit = new SqlCommand("DELETE from Vente where id_vente=@IDvente", conn);
                        insertProduit.Parameters.Add(new SqlParameter("@IDvente",Id));
                        insertProduit.ExecuteNonQuery();
                        ChargerTableVente();
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                
            }
            
        }

        private void ChargerTableVente()
        {
            DateTime Heure_Vente=DateTime.Parse(DateTime.Now.ToString("d/M/yyyy"));
            String date = Convert.ToString(Heure_Vente);
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand SelectVente = new SqlCommand("SELECT * from vente where date_vente=@dat", conn);
                SelectVente.Parameters.Add(new SqlParameter("@dat", date));
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChargerTableVente();
        }
    }
}
