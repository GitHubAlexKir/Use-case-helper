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
        private Usecase item;

        public Beschrijving(Usecase item, string Actors)
        {
            InitializeComponent();
            Invoerbtn.DialogResult = DialogResult.OK;
            this.item = item;
            Naamtextbox.Text = item.naam;
            Samenvattingtextbox.Text = item.samenvatting;
            Aannamentextbox.Text = item.aannamen;
            Beschrijvingtextbox.Text = item.beschrijving;
            uitzonderingentextbox.Text = item.uitzonderingen;
            Resultaattextbox.Text = item.resultaat;
            Actortextbox.Text = Actors;
        }

        public Beschrijving()
        {
            InitializeComponent();
            Invoerbtn.DialogResult = DialogResult.OK;
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
    }
}
