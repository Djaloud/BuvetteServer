
namespace BuvetteServer
{
    partial class Statistique
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
            this.TableVente = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.argent = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableVente)).BeginInit();
            this.bunifuCards5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bunifuCards5);
            this.tabPage1.Controls.Add(this.bunifuCards2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Toute les ventes";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.bunifuCards2.Controls.Add(this.TableVente);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 122);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(937, 301);
            this.bunifuCards2.TabIndex = 11;
            // 
            // TableVente
            // 
            this.TableVente.AllowUserToAddRows = false;
            this.TableVente.AllowUserToDeleteRows = false;
            this.TableVente.AllowUserToResizeColumns = false;
            this.TableVente.AllowUserToResizeRows = false;
            this.TableVente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableVente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableVente.Location = new System.Drawing.Point(0, 3);
            this.TableVente.Name = "TableVente";
            this.TableVente.ReadOnly = true;
            this.TableVente.Size = new System.Drawing.Size(934, 295);
            this.TableVente.TabIndex = 1;
            this.TableVente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableVente_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistique";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards5.BackColor = System.Drawing.Color.White;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.Tomato;
            this.bunifuCards5.Controls.Add(this.argent);
            this.bunifuCards5.Controls.Add(this.dateTimePicker1);
            this.bunifuCards5.Controls.Add(this.button2);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(3, 9);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(937, 107);
            this.bunifuCards5.TabIndex = 12;
            // 
            // argent
            // 
            this.argent.AutoSize = true;
            this.argent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.argent.Location = new System.Drawing.Point(31, 33);
            this.argent.Name = "argent";
            this.argent.Size = new System.Drawing.Size(0, 31);
            this.argent.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(410, 38);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 18, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(701, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistique";
            this.Text = "Statistique";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableVente)).EndInit();
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.DataGridView TableVente;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private System.Windows.Forms.Label argent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}