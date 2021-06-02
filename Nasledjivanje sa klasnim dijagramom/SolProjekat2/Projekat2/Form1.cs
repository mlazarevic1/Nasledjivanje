using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization; //Koristimo zbog json serijalizacije
using System.IO;
using System.Diagnostics;

namespace Projekat2
{
    public partial class Form1 : Form
    {
        List<desktop> ListaDesktop = new List<desktop>(); // Treba da bude klas koju pozivam a ne string
        public Form1()
        {
            InitializeComponent();
        }


        //Ispis konstruktora i dodavanje svojstava u listu
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {

                

                desktop d = new desktop()
                {
                
                    Procesor = txtCpu.Text,
                    memorija = Convert.ToInt32(txtMemorija.Text),
                    ramMemorija = Convert.ToInt32(txtRam.Text),
                    Proizvodjac = txtProizvodjac.Text,
                    model = txtModel.Text,
                    Napajanje = Convert.ToInt32(txtNapajanje.Text),
                    cena = Convert.ToInt32(txtCena.Text)

                };


                ListaDesktop.Add(d);
                lista.Items.Add("Procesor: " + d.Procesor);
                lista.Items.Add("Memorija: " + d.memorija + "TB");
                lista.Items.Add("Ram memorija: " + d.ramMemorija + "GB");
                lista.Items.Add("Proizvodjac: " + d.Proizvodjac);
                lista.Items.Add("Model: " + d.model);
                lista.Items.Add("Napajanje: " + d.Napajanje + "W");
                lista.Items.Add("Cena: " + d.cena);
                lista.Items.Add("**********************************************************");

                MessageBox.Show("Sve ste uneli kako treba");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        // Serilizacija
        private void btnKreirajListu_Click(object sender, EventArgs e)
        {


            JavaScriptSerializer js = new JavaScriptSerializer();

            string strJSON = js.Serialize(ListaDesktop);
            MessageBox.Show(strJSON);

            StreamWriter Json = new StreamWriter(@"D:\Projekat2 cuvanje JSON\Desktop.json", true);
            Json.Write(strJSON);
            Json.Flush();
            Json.Close();

            Process.Start("notepad.exe", @"D:\Projekat2 cuvanje JSON\Desktop.json");
            



        }

        private void btnProdaj_Click(object sender, EventArgs e)
        {
            desktop d = new desktop();
            
            
            lista.Items.Add(d.Prodaj());
            
        }

        private void btnDostava_Click(object sender, EventArgs e)
        {
            desktop d = new desktop();

            
            lista.Items.Add(d.Dostava());

        }

        private void btnPromocije_Click(object sender, EventArgs e)
        {
            desktop d = new desktop();

            
            lista.Items.Add(d.Promocije());

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            desktop d = new desktop();

            
            lista.Items.Add(d.UnosTeksta());

        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            desktop d = new desktop();

            
            lista.Items.Add(d.PokreniVS());


        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            ListaDesktop.Clear();
            lista.Items.Clear();


        }
    }
}
