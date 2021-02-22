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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnexionDb.GetDBConnection();
            try
            {

                conn.Open();
                SqlCommand insertProduit = new SqlCommand("SELECT identifiant,Passwrd FROM Administateur where identifiant=@log and Passwrd=@pass", conn);
                insertProduit.Parameters.Add(new SqlParameter("@log", txtLogin.Text));
                insertProduit.Parameters.Add(new SqlParameter("@pass", TxtPassword.Text));
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = insertProduit;
                DataTable Cat = new DataTable("Produit");
                sda.Fill(Cat);
                if (Cat.Rows.Count == 1)
                {
                    Form1 fm = new Form1();
                    this.Hide();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorect");
                }

                sda.Update(Cat);


            }
            catch (Exception ec)
            {
                Console.WriteLine("Error: " + ec.Message);
            }

        }
    }
}
