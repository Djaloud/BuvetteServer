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
    public partial class SousCategorie : Form
    {
        public SousCategorie()
        {
            InitializeComponent();
            Charger_Data();
        }

        private void ValiderCat_Click(object sender, EventArgs e)
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

            if (ref_produit.Text.Equals("") || nom_produit.Text.Equals(""))
            {
                MessageBox.Show("Veuillez Renseignez le(s) champs!");
            }
            else
            {
                SqlCommand insertProduit = new SqlCommand("insert into Produit(ref_produit,nom_produit) values(@id,@nom)", conn);
                insertProduit.Parameters.Add(new SqlParameter("@id", ref_produit.Text));
                insertProduit.Parameters.Add(new SqlParameter("@nom", nom_produit.Text));
                insertProduit.ExecuteNonQuery();
                Ref_SousProduit.Text = ref_produit.Text;
                ref_produit.Text = "";
                nom_produit.Text = "";
                Charger_Data();
            }
           
        }

        /************** Recuperer les donnees apres un clic sur une ligne  **************************/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                Ref_SousProduit.Text= dataGridView1.SelectedCells[0].Value.ToString();
            }
          
        }
       
        /************** Methode qui permet de charger les donnees dans le datagridview des produits **************************/
        private  void Charger_Data()
        {
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand insertProduit = new SqlCommand("SELECT ref_produit as REFERENCE FROM Produit", conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = insertProduit;
                DataTable MydataSet = new DataTable();
                sda.Fill(MydataSet);
                BindingSource bS = new BindingSource();
                bS.DataSource = MydataSet;
                dataGridView1.DataSource = bS;
                sda.Update(MydataSet);

            }
            catch (Exception ec)
            {
                Console.WriteLine("Error: " + ec.Message);
            }
            
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
            if (Nom_SousProduit.Text.Equals("") || Prix_SousProduit.Text.Equals(""))
            {
                MessageBox.Show("Veuillez Renseignez le(s) champs!");
            }
            else
            {
                SqlCommand insertProduit = new SqlCommand("insert into Sous_Produit(nom_sous_produit,prix_unitaire,ref_produit) values(@nom_Sous,@Prix_Sous,@Ref_Sous)", conn);
                insertProduit.Parameters.Add(new SqlParameter("@nom_Sous", Nom_SousProduit.Text));
                insertProduit.Parameters.Add(new SqlParameter("@Prix_Sous", Prix_SousProduit.Text));
                insertProduit.Parameters.Add(new SqlParameter("@Ref_Sous", Ref_SousProduit.Text));
                insertProduit.ExecuteNonQuery();
                Nom_SousProduit.Text = "";
                Prix_SousProduit.Text = "";
            }
            
        }

        private void SousCategorie_Load(object sender, EventArgs e)
        {

        }
    }
}
