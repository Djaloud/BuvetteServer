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
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
            Table_Produit();
            TableSousProduit();
        }

        private void ValiderCat_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Etes-vous sur de supprimer?", "INFORMATION", MessageBoxButtons.YesNo);
            try
            {
                if (rs==DialogResult.Yes)
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
                    
                        SqlCommand insertProduit = new SqlCommand("DELETE from Produit where ref_produit=@Ref", conn);
                        insertProduit.Parameters.Add(new SqlParameter("@Ref", ref_Gestion.Text));
                        insertProduit.ExecuteNonQuery();
                        ref_Gestion.Text = "";
                        Nom_Gestion.Text = "";

                    Table_Produit();
                    
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        /************** Methode qui permet de charger les donnees dans le datagridview des gestions des sous_produits **************************/
        private void TableSousProduit()
        {
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand insertProduit = new SqlCommand("select id_sous_produit as ID_SOUS_PRODUIT,nom_sous_produit as NOM,prix_unitaire as PRIX,ref_produit as REFERENCE from sous_produit", conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = insertProduit;
                DataTable MydataSet = new DataTable();
                sda.Fill(MydataSet);
                BindingSource bS = new BindingSource();
                bS.DataSource = MydataSet;
                TbleSousProduit.DataSource = bS;
                sda.Update(MydataSet);

            }
            catch (Exception ec)
            {
                Console.WriteLine("Error: " + ec.Message);
            }
        }
        /************** Methode qui permet de charger les donnees dans le datagridview des gestions de produits **************************/
        private void Table_Produit()
        {
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand insertProduit = new SqlCommand("SELECT ref_produit as REFERENCE,nom_produit as NOM_PRODUIT FROM Produit", conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = insertProduit;
                DataTable MydataSet = new DataTable();
                sda.Fill(MydataSet);
                BindingSource bS = new BindingSource();
                bS.DataSource = MydataSet;
                TableCategorie.DataSource = bS;
                sda.Update(MydataSet);
                
               
            }
            catch (Exception ec)
            {
                Console.WriteLine("Error: " + ec.Message);
            }
           
        }

       
        

        private void TbleSousProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TbleSousProduit.SelectedCells.Count > 0)
            {
                Id_produit.Text = TbleSousProduit.Rows[e.RowIndex].Cells[0].Value.ToString();
                NomSProduit.Text = TbleSousProduit.Rows[e.RowIndex].Cells[1].Value.ToString();
                PrixSProduit.Text = TbleSousProduit.Rows[e.RowIndex].Cells[2].Value.ToString();
                CatSProduit.Text = TbleSousProduit.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Etes-vous sur de supprimer?", "INFORMATION", MessageBoxButtons.YesNo);
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

                    SqlCommand insertProduit = new SqlCommand("delete from Sous_Produit where id_sous_produit=@Ref", conn);
                    insertProduit.Parameters.Add(new SqlParameter("@Ref", Id_produit.Text));
                    insertProduit.ExecuteNonQuery();
                    TableSousProduit();
                    Id_produit.Text = "";
                    NomSProduit.Text = "";
                    PrixSProduit.Text = "";
                    CatSProduit.Text = "";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
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
            SqlCommand insertProduit = new SqlCommand("UPDATE Sous_Produit set nom_sous_produit=@nom,prix_unitaire=@prix,ref_produit=@ref_produit where id_sous_produit= @Ref", conn);

            // on remplace les parametre de la requete @ref par ce que l utilisateur va saisir ( Id_produit.Text)
            insertProduit.Parameters.Add(new SqlParameter("@Ref", Id_produit.Text));
            insertProduit.Parameters.Add(new SqlParameter("@nom", NomSProduit.Text));
            insertProduit.Parameters.Add(new SqlParameter("@prix", PrixSProduit.Text));
            insertProduit.Parameters.Add(new SqlParameter("@ref_produit", CatSProduit.Text));
            // execution de la requete
            insertProduit.ExecuteNonQuery();
            // je charge le datagrid pour pouvoir voir les modification
            TableSousProduit();
            // je vide les champs de saisie 
            Id_produit.Text = "";
            NomSProduit.Text = "";
            PrixSProduit.Text = "";
            CatSProduit.Text = "";
        }

        private void ModifierCat_Click(object sender, EventArgs e)
        {

        }

        private void SupprimerProduit_Click(object sender, EventArgs e)
        {
           
                DialogResult rs = MessageBox.Show("Etes-vous sur de supprimer?\nla suppression se fait en cascade.\nles sous categories seront egalement supprimé \nainsi que toutes les ventes associés", "INFORMATION", MessageBoxButtons.YesNo);
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

                        SqlCommand insertProduit = new SqlCommand("DELETE from Produit where ref_produit=@Ref", conn);
                        insertProduit.Parameters.Add(new SqlParameter("@Ref", ref_Gestion.Text));
                        insertProduit.ExecuteNonQuery();
                        ref_Gestion.Text = "";
                        Nom_Gestion.Text = "";

                        Table_Produit();

                    }
                }
                catch (Exception)
                {
                    throw;
                }
            

        }
        /************** Recuperer les donnees apres un clic sur une ligne  **************************/

       

        private void TableCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TableCategorie.SelectedCells.Count > 0)
            {
                ref_Gestion.Text = TableCategorie.Rows[e.RowIndex].Cells[0].Value.ToString();
                Nom_Gestion.Text = TableCategorie.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void ModifierProduit_Click(object sender, EventArgs e)
        {

        }

        private void RechercheCat_Click(object sender, EventArgs e)
        {
           
        }

        private void Recherche_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            TableSousProduit();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Table_Produit();
        }
    }
}
