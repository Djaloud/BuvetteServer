
namespace BuvetteServer
{
    
    partial class Categorie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.TableCategorie = new System.Windows.Forms.DataGridView();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.SupprimerProduit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ModifierProduit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ref_Gestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nom_Gestion = new System.Windows.Forms.TextBox();
            this.RechercheCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TbleSousProduit = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CatSProduit = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.PrixSProduit = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomSProduit = new System.Windows.Forms.TextBox();
            this.Id_produit = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableCategorie)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbleSousProduit)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.bunifuCards2);
            this.tabPage1.Controls.Add(this.bunifuCards1);
            this.tabPage1.Controls.Add(this.RechercheCat);
            this.tabPage1.Controls.Add(this.Recherche);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1056, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion Categorie";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DarkBlue;
            this.bunifuCards2.Controls.Add(this.TableCategorie);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(8, 202);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1017, 270);
            this.bunifuCards2.TabIndex = 9;
            // 
            // TableCategorie
            // 
            this.TableCategorie.AllowUserToAddRows = false;
            this.TableCategorie.AllowUserToDeleteRows = false;
            this.TableCategorie.AllowUserToResizeColumns = false;
            this.TableCategorie.AllowUserToResizeRows = false;
            this.TableCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableCategorie.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableCategorie.Location = new System.Drawing.Point(0, 3);
            this.TableCategorie.Name = "TableCategorie";
            this.TableCategorie.ReadOnly = true;
            this.TableCategorie.Size = new System.Drawing.Size(1014, 264);
            this.TableCategorie.TabIndex = 1;
            this.TableCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCategorie_CellContentClick);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 8;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.DarkBlue;
            this.bunifuCards1.Controls.Add(this.SupprimerProduit);
            this.bunifuCards1.Controls.Add(this.ModifierProduit);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.ref_Gestion);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.Nom_Gestion);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(8, 14);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1017, 127);
            this.bunifuCards1.TabIndex = 8;
            // 
            // SupprimerProduit
            // 
            this.SupprimerProduit.Activecolor = System.Drawing.Color.Blue;
            this.SupprimerProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupprimerProduit.BackColor = System.Drawing.Color.RoyalBlue;
            this.SupprimerProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupprimerProduit.BorderRadius = 7;
            this.SupprimerProduit.ButtonText = "Supprimer";
            this.SupprimerProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupprimerProduit.DisabledColor = System.Drawing.Color.Gray;
            this.SupprimerProduit.Iconcolor = System.Drawing.Color.Transparent;
            this.SupprimerProduit.Iconimage = null;
            this.SupprimerProduit.Iconimage_right = null;
            this.SupprimerProduit.Iconimage_right_Selected = null;
            this.SupprimerProduit.Iconimage_Selected = null;
            this.SupprimerProduit.IconMarginLeft = 0;
            this.SupprimerProduit.IconMarginRight = 0;
            this.SupprimerProduit.IconRightVisible = false;
            this.SupprimerProduit.IconRightZoom = 0D;
            this.SupprimerProduit.IconVisible = false;
            this.SupprimerProduit.IconZoom = 90D;
            this.SupprimerProduit.IsTab = false;
            this.SupprimerProduit.Location = new System.Drawing.Point(860, 62);
            this.SupprimerProduit.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.SupprimerProduit.Name = "SupprimerProduit";
            this.SupprimerProduit.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.SupprimerProduit.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.SupprimerProduit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.SupprimerProduit.selected = false;
            this.SupprimerProduit.Size = new System.Drawing.Size(127, 29);
            this.SupprimerProduit.TabIndex = 11;
            this.SupprimerProduit.Text = "Supprimer";
            this.SupprimerProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SupprimerProduit.Textcolor = System.Drawing.Color.White;
            this.SupprimerProduit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerProduit.Click += new System.EventHandler(this.SupprimerProduit_Click);
            // 
            // ModifierProduit
            // 
            this.ModifierProduit.Activecolor = System.Drawing.Color.Blue;
            this.ModifierProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifierProduit.BackColor = System.Drawing.Color.RoyalBlue;
            this.ModifierProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModifierProduit.BorderRadius = 7;
            this.ModifierProduit.ButtonText = "Modifier";
            this.ModifierProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifierProduit.DisabledColor = System.Drawing.Color.Gray;
            this.ModifierProduit.Iconcolor = System.Drawing.Color.Transparent;
            this.ModifierProduit.Iconimage = null;
            this.ModifierProduit.Iconimage_right = null;
            this.ModifierProduit.Iconimage_right_Selected = null;
            this.ModifierProduit.Iconimage_Selected = null;
            this.ModifierProduit.IconMarginLeft = 0;
            this.ModifierProduit.IconMarginRight = 0;
            this.ModifierProduit.IconRightVisible = false;
            this.ModifierProduit.IconRightZoom = 0D;
            this.ModifierProduit.IconVisible = false;
            this.ModifierProduit.IconZoom = 90D;
            this.ModifierProduit.IsTab = false;
            this.ModifierProduit.Location = new System.Drawing.Point(675, 62);
            this.ModifierProduit.Margin = new System.Windows.Forms.Padding(8);
            this.ModifierProduit.Name = "ModifierProduit";
            this.ModifierProduit.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.ModifierProduit.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.ModifierProduit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.ModifierProduit.selected = false;
            this.ModifierProduit.Size = new System.Drawing.Size(117, 29);
            this.ModifierProduit.TabIndex = 10;
            this.ModifierProduit.Text = "Modifier";
            this.ModifierProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModifierProduit.Textcolor = System.Drawing.Color.White;
            this.ModifierProduit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierProduit.Click += new System.EventHandler(this.ModifierProduit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reference";
            // 
            // ref_Gestion
            // 
            this.ref_Gestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref_Gestion.Location = new System.Drawing.Point(19, 64);
            this.ref_Gestion.Name = "ref_Gestion";
            this.ref_Gestion.Size = new System.Drawing.Size(204, 24);
            this.ref_Gestion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom";
            // 
            // Nom_Gestion
            // 
            this.Nom_Gestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nom_Gestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_Gestion.Location = new System.Drawing.Point(340, 63);
            this.Nom_Gestion.Name = "Nom_Gestion";
            this.Nom_Gestion.Size = new System.Drawing.Size(212, 24);
            this.Nom_Gestion.TabIndex = 7;
            // 
            // RechercheCat
            // 
            this.RechercheCat.Activecolor = System.Drawing.Color.Blue;
            this.RechercheCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercheCat.BackColor = System.Drawing.Color.RoyalBlue;
            this.RechercheCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RechercheCat.BorderRadius = 7;
            this.RechercheCat.ButtonText = "Rechercher";
            this.RechercheCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RechercheCat.DisabledColor = System.Drawing.Color.Gray;
            this.RechercheCat.Iconcolor = System.Drawing.Color.Transparent;
            this.RechercheCat.Iconimage = null;
            this.RechercheCat.Iconimage_right = null;
            this.RechercheCat.Iconimage_right_Selected = null;
            this.RechercheCat.Iconimage_Selected = null;
            this.RechercheCat.IconMarginLeft = 0;
            this.RechercheCat.IconMarginRight = 0;
            this.RechercheCat.IconRightVisible = false;
            this.RechercheCat.IconRightZoom = 0D;
            this.RechercheCat.IconVisible = false;
            this.RechercheCat.IconZoom = 90D;
            this.RechercheCat.IsTab = false;
            this.RechercheCat.Location = new System.Drawing.Point(852, 157);
            this.RechercheCat.Margin = new System.Windows.Forms.Padding(5);
            this.RechercheCat.Name = "RechercheCat";
            this.RechercheCat.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.RechercheCat.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.RechercheCat.OnHoverTextColor = System.Drawing.Color.Gray;
            this.RechercheCat.selected = false;
            this.RechercheCat.Size = new System.Drawing.Size(142, 32);
            this.RechercheCat.TabIndex = 7;
            this.RechercheCat.Text = "Rechercher";
            this.RechercheCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RechercheCat.Textcolor = System.Drawing.Color.White;
            this.RechercheCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercheCat.Click += new System.EventHandler(this.RechercheCat_Click);
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(36, 161);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(593, 26);
            this.Recherche.TabIndex = 2;
            this.Recherche.TextChanged += new System.EventHandler(this.Recherche_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.bunifuFlatButton4);
            this.tabPage2.Controls.Add(this.bunifuFlatButton3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1056, 480);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Gestion SousCategorie";
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 7;
            this.bunifuFlatButton4.ButtonText = "Rechercher";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = false;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = false;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(838, 169);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(162, 31);
            this.bunifuFlatButton4.TabIndex = 10;
            this.bunifuFlatButton4.Text = "Rechercher";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 7;
            this.bunifuFlatButton3.ButtonText = "Rechercher";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = false;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = false;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1401, 225);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(235, 44);
            this.bunifuFlatButton3.TabIndex = 9;
            this.bunifuFlatButton3.Text = "Rechercher";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(593, 24);
            this.textBox4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.TbleSousProduit);
            this.panel3.Location = new System.Drawing.Point(20, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 258);
            this.panel3.TabIndex = 3;
            // 
            // TbleSousProduit
            // 
            this.TbleSousProduit.AllowUserToAddRows = false;
            this.TbleSousProduit.AllowUserToDeleteRows = false;
            this.TbleSousProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbleSousProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TbleSousProduit.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TbleSousProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbleSousProduit.Location = new System.Drawing.Point(20, 16);
            this.TbleSousProduit.Name = "TbleSousProduit";
            this.TbleSousProduit.ReadOnly = true;
            this.TbleSousProduit.Size = new System.Drawing.Size(972, 228);
            this.TbleSousProduit.TabIndex = 0;
            this.TbleSousProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbleSousProduit_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.CatSProduit);
            this.panel4.Controls.Add(this.p);
            this.panel4.Controls.Add(this.PrixSProduit);
            this.panel4.Controls.Add(this.bunifuFlatButton1);
            this.panel4.Controls.Add(this.bunifuFlatButton2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.NomSProduit);
            this.panel4.Controls.Add(this.Id_produit);
            this.panel4.Location = new System.Drawing.Point(20, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1017, 146);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Categorie";
            // 
            // CatSProduit
            // 
            this.CatSProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CatSProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatSProduit.Location = new System.Drawing.Point(343, 99);
            this.CatSProduit.Name = "CatSProduit";
            this.CatSProduit.Size = new System.Drawing.Size(227, 24);
            this.CatSProduit.TabIndex = 13;
            // 
            // p
            // 
            this.p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(26, 78);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(37, 18);
            this.p.TabIndex = 12;
            this.p.Text = "Prix";
            // 
            // PrixSProduit
            // 
            this.PrixSProduit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrixSProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixSProduit.Location = new System.Drawing.Point(18, 99);
            this.PrixSProduit.Name = "PrixSProduit";
            this.PrixSProduit.Size = new System.Drawing.Size(214, 24);
            this.PrixSProduit.TabIndex = 11;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Supprimer";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(868, 72);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(112, 29);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "Supprimer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Modifier";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(725, 72);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(113, 29);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "Modifier";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Produit";
            // 
            // NomSProduit
            // 
            this.NomSProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NomSProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomSProduit.Location = new System.Drawing.Point(343, 29);
            this.NomSProduit.Name = "NomSProduit";
            this.NomSProduit.Size = new System.Drawing.Size(227, 24);
            this.NomSProduit.TabIndex = 7;
            // 
            // Id_produit
            // 
            this.Id_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_produit.Location = new System.Drawing.Point(18, 29);
            this.Id_produit.Name = "Id_produit";
            this.Id_produit.Size = new System.Drawing.Size(214, 24);
            this.Id_produit.TabIndex = 6;
            // 
            // Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorie";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorie";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableCategorie)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TbleSousProduit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Recherche;
        private Bunifu.Framework.UI.BunifuFlatButton RechercheCat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView TbleSousProduit;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomSProduit;
        private System.Windows.Forms.TextBox Id_produit;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CatSProduit;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox PrixSProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nom_Gestion;
        private System.Windows.Forms.TextBox ref_Gestion;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton ModifierProduit;
        private Bunifu.Framework.UI.BunifuFlatButton SupprimerProduit;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.DataGridView TableCategorie;
    }
}