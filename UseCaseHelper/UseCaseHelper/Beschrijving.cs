using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class Beschrijving : Form
    {
        public string naam = "";
        public string samenvatting = "";
        public string aannamen = "";
        public string beschrijving = "";
        public string uitzonderingen = "";
        public string resulaten = "";
        public string actoren = "";

        public Beschrijving()
        {
            InitializeComponent();
            Invoerbtn.DialogResult = DialogResult.OK;
            Naamtextbox.Text = naam;
            Samenvattingtextbox.Text = samenvatting;
            Aannamentextbox.Text = aannamen;
            Beschrijvingtextbox.Text = beschrijving;
            uitzonderingentextbox.Text = uitzonderingen;
            Resultaattextbox.Text = resulaten;
            Actortextbox.Text = actoren;
        }

        public string getNaam()
        {
            return Naamtextbox.Text;
        }

        public string getSamenvatting()
        {
            return Samenvattingtextbox.Text;
        }

        public string getAannamen()
        {
            return Aannamentextbox.Text;
        }

        public string getBeschrijving()
        {
            return Beschrijvingtextbox.Text;
        }

        public string getUitzonderingen()
        {
            return uitzonderingentextbox.Text;
        }

        public string getResultaten()
        { 
            return Resultaattextbox.Text;
        }

        public void setNaam(string tekst)
        {
            naam = tekst;
        }

        public void setSamenvatting(string tekst)
        {
            samenvatting = tekst;
        }

        public void setAannamen(string tekst)
        {
            aannamen = tekst;
        }

        public void setBeschrijving(string tekst)
        {
            beschrijving = tekst;
        }

        public void setUitzonderingen(string tekst)
        {
            uitzonderingen = tekst;
        }

        public void setResultaten(string tekst)
        {
            resulaten = tekst;
        }

        public void setActors(int[] actors)
        {
            string actor = "";
            foreach (int item in actors)
            {
                actoren += item + " ,";
            }
            actoren = actor;
        }
    }
}
