
namespace Projekat2
{
    partial class Form1
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
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.txtMemorija = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtNapajanje = new System.Windows.Forms.TextBox();
            this.lblCpu = new System.Windows.Forms.Label();
            this.lblMemorija = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblNapajanje = new System.Windows.Forms.Label();
            this.lblObavestenje = new System.Windows.Forms.Label();
            this.btnProvera = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnKreirajListu = new System.Windows.Forms.Button();
            this.btnProdaj = new System.Windows.Forms.Button();
            this.btnDostava = new System.Windows.Forms.Button();
            this.btnPromocije = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(142, 41);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(123, 20);
            this.txtCpu.TabIndex = 0;
            // 
            // txtMemorija
            // 
            this.txtMemorija.Location = new System.Drawing.Point(142, 90);
            this.txtMemorija.Name = "txtMemorija";
            this.txtMemorija.Size = new System.Drawing.Size(123, 20);
            this.txtMemorija.TabIndex = 1;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(142, 138);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(123, 20);
            this.txtRam.TabIndex = 2;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(142, 188);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(123, 20);
            this.txtProizvodjac.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(142, 238);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(123, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtNapajanje
            // 
            this.txtNapajanje.Location = new System.Drawing.Point(142, 284);
            this.txtNapajanje.Name = "txtNapajanje";
            this.txtNapajanje.Size = new System.Drawing.Size(123, 20);
            this.txtNapajanje.TabIndex = 5;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(45, 41);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(52, 13);
            this.lblCpu.TabIndex = 6;
            this.lblCpu.Text = "Procesor:";
            // 
            // lblMemorija
            // 
            this.lblMemorija.AutoSize = true;
            this.lblMemorija.Location = new System.Drawing.Point(45, 90);
            this.lblMemorija.Name = "lblMemorija";
            this.lblMemorija.Size = new System.Drawing.Size(91, 13);
            this.lblMemorija.TabIndex = 7;
            this.lblMemorija.Text = "Kolicina memorije:";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(45, 141);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(76, 13);
            this.lblRam.TabIndex = 8;
            this.lblRam.Text = "Ram memorija:";
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(45, 191);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(65, 13);
            this.lblProizvodjac.TabIndex = 9;
            this.lblProizvodjac.Text = "Proizvodjac:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(45, 238);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model:";
            // 
            // lblNapajanje
            // 
            this.lblNapajanje.AutoSize = true;
            this.lblNapajanje.Location = new System.Drawing.Point(45, 287);
            this.lblNapajanje.Name = "lblNapajanje";
            this.lblNapajanje.Size = new System.Drawing.Size(58, 13);
            this.lblNapajanje.TabIndex = 11;
            this.lblNapajanje.Text = "Napajanje:";
            // 
            // lblObavestenje
            // 
            this.lblObavestenje.AutoSize = true;
            this.lblObavestenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.lblObavestenje.Location = new System.Drawing.Point(272, 47);
            this.lblObavestenje.Name = "lblObavestenje";
            this.lblObavestenje.Size = new System.Drawing.Size(110, 12);
            this.lblObavestenje.TabIndex = 12;
            this.lblObavestenje.Text = "(Moze biti AMD ili INTEL)";
            // 
            // btnProvera
            // 
            this.btnProvera.Location = new System.Drawing.Point(313, 90);
            this.btnProvera.Name = "btnProvera";
            this.btnProvera.Size = new System.Drawing.Size(102, 38);
            this.btnProvera.TabIndex = 13;
            this.btnProvera.Text = "Provera i ispisi litu";
            this.btnProvera.UseVisualStyleBackColor = true;
            this.btnProvera.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(447, 41);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(266, 316);
            this.lista.TabIndex = 14;
            // 
            // btnKreirajListu
            // 
            this.btnKreirajListu.Location = new System.Drawing.Point(313, 158);
            this.btnKreirajListu.Name = "btnKreirajListu";
            this.btnKreirajListu.Size = new System.Drawing.Size(102, 36);
            this.btnKreirajListu.TabIndex = 15;
            this.btnKreirajListu.Text = " Sacuvaj JSON fajl";
            this.btnKreirajListu.UseVisualStyleBackColor = true;
            this.btnKreirajListu.Click += new System.EventHandler(this.btnKreirajListu_Click);
            // 
            // btnProdaj
            // 
            this.btnProdaj.Location = new System.Drawing.Point(48, 397);
            this.btnProdaj.Name = "btnProdaj";
            this.btnProdaj.Size = new System.Drawing.Size(90, 31);
            this.btnProdaj.TabIndex = 16;
            this.btnProdaj.Text = "Prodaj";
            this.btnProdaj.UseVisualStyleBackColor = true;
            this.btnProdaj.Click += new System.EventHandler(this.btnProdaj_Click);
            // 
            // btnDostava
            // 
            this.btnDostava.Location = new System.Drawing.Point(158, 397);
            this.btnDostava.Name = "btnDostava";
            this.btnDostava.Size = new System.Drawing.Size(90, 31);
            this.btnDostava.TabIndex = 17;
            this.btnDostava.Text = "Dostava";
            this.btnDostava.UseVisualStyleBackColor = true;
            this.btnDostava.Click += new System.EventHandler(this.btnDostava_Click);
            // 
            // btnPromocije
            // 
            this.btnPromocije.Location = new System.Drawing.Point(274, 397);
            this.btnPromocije.Name = "btnPromocije";
            this.btnPromocije.Size = new System.Drawing.Size(90, 31);
            this.btnPromocije.TabIndex = 18;
            this.btnPromocije.Text = "Promocije";
            this.btnPromocije.UseVisualStyleBackColor = true;
            this.btnPromocije.Click += new System.EventHandler(this.btnPromocije_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(387, 397);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(90, 31);
            this.btnUnos.TabIndex = 19;
            this.btnUnos.Text = "Unos teksta";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(499, 397);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(90, 31);
            this.btnPokreni.TabIndex = 20;
            this.btnPokreni.Text = "Pokreni Vs";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(605, 397);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(90, 31);
            this.btnOcisti.TabIndex = 21;
            this.btnOcisti.Text = "Ocisti listu";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(48, 332);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(35, 13);
            this.lblCena.TabIndex = 22;
            this.lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(142, 325);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(123, 20);
            this.txtCena.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnPromocije);
            this.Controls.Add(this.btnDostava);
            this.Controls.Add(this.btnProdaj);
            this.Controls.Add(this.btnKreirajListu);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnProvera);
            this.Controls.Add(this.lblObavestenje);
            this.Controls.Add(this.lblNapajanje);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblMemorija);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.txtNapajanje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtMemorija);
            this.Controls.Add(this.txtCpu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.TextBox txtMemorija;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtNapajanje;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label lblMemorija;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblNapajanje;
        private System.Windows.Forms.Label lblObavestenje;
        private System.Windows.Forms.Button btnProvera;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnKreirajListu;
        private System.Windows.Forms.Button btnProdaj;
        private System.Windows.Forms.Button btnDostava;
        private System.Windows.Forms.Button btnPromocije;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtCena;
    }
}

