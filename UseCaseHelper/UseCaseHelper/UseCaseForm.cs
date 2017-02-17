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
    public partial class UseCaseForm : Form
    {
        int aantalActors = 0;
        Data lists = new Data();
        public UseCaseForm()
        {
            InitializeComponent();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            //Actors
            if (Actorbtn.Checked == true)
            {
                //Actors toevoegen
                if (Createbtn.Checked == true && aantalActors < 3)
                {
                    aantalActors++;
                    ActorNaamInvoeren naamInvoeren = new ActorNaamInvoeren();
                    if (naamInvoeren.ShowDialog(this) == DialogResult.OK)
                    {
                        addActor(naamInvoeren.getNaam());
                    }
                    naamInvoeren.Close();
                    switch (aantalActors)
                    {
                        case 1:
                            Actorbox1.Visible = true;
                            Actor1lbl.Visible = true;
                            break;
                        case 2:
                            Actorbox2.Visible = true;
                            Actor2lbl.Visible = true;
                            break;
                        case 3:
                            Actorbox3.Visible = true;
                            Actor3lbl.Visible = true;
                            break;
                    }
                }
                else
                {

                }
            }
        }
        public void addActor(string naam)
        {
            lists.addActor(aantalActors, naam);
            foreach (Actor item in lists.Actorlist)
            {
                if (item.ID == 1)
                {
                    Actor1lbl.Text = item.naam;
                }
                if (item.ID == 2)
                {
                    Actor2lbl.Text = item.naam;
                }
                if (item.ID == 3)
                {
                    Actor3lbl.Text = item.naam;
                }
            }
        }
    }
}
