using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;


namespace BuvetteServer
{
    public partial class Form1 : Form
    {
        Categorie n1; 
        SousCategorie sc;
        Vente vt;
        Statistique st;
        public Form1()
        {
            n1 = new Categorie();
            sc = new SousCategorie();
            vt = new Vente();
            st = new Statistique();
            InitializeComponent();
            if (this.PannPrincipale.Controls.Count > 0)
            {
                this.PannPrincipale.Controls.RemoveAt(0);
            }
            vt.TopLevel = false;
            vt.Dock = DockStyle.Fill;
            this.PannPrincipale.Controls.Add(vt);
            this.PannPrincipale.Tag = vt;
            vt.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
             if (this.PannPrincipale.Controls.Count > 0)
            {
                this.PannPrincipale.Controls.RemoveAt(0);
            }
            vt.TopLevel = false;
            vt.Dock = DockStyle.Fill;
            this.PannPrincipale.Controls.Add(vt);
            this.PannPrincipale.Tag = vt;
            vt.Visible = true;

        }

       
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (this.PannPrincipale.Controls.Count > 0)
            {
                this.PannPrincipale.Controls.RemoveAt(0);
            }
            n1.TopLevel = false;
            n1.Dock = DockStyle.Fill;
            this.PannPrincipale.Controls.Add(n1);
            this.PannPrincipale.Tag = n1;
            n1.Visible = true;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (this.PannPrincipale.Controls.Count > 0)
            {
                this.PannPrincipale.Controls.RemoveAt(0);
            }
            sc.TopLevel = false;
            sc.Dock = DockStyle.Fill;
            this.PannPrincipale.Controls.Add(sc);
            this.PannPrincipale.Tag = sc;
            sc.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void PannPrincipale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (this.PannPrincipale.Controls.Count > 0)
            {
                this.PannPrincipale.Controls.RemoveAt(0);
            }
            st.TopLevel = false;
            st.Dock = DockStyle.Fill;
            this.PannPrincipale.Controls.Add(st);
            this.PannPrincipale.Tag = st;
            st.Visible = true;
        }
    }
}
