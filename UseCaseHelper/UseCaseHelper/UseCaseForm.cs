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
        int aantalUsecases = 0;
        bool selected = false;
        int selectedActor;
        Data lists = new Data();
        Point locatie;
        public UseCaseForm()
        {
            InitializeComponent();
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

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            locatie = e.Location;
            locatie.Y += 100;
            locatie.X -= 45;
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
            //Usecases
            if (Usecasebtn.Checked == true)
            {
                if (Createbtn.Checked == true)
                {
                    aantalUsecases++;
                    //ActorNaamInvoeren naamInvoeren = new ActorNaamInvoeren();
                    //if (naamInvoeren.ShowDialog(this) == DialogResult.OK)
                    //{
                    //    addActor(naamInvoeren.getNaam());
                    //}
                    //naamInvoeren.Close();
                    Button Usecase = new Button();
                    Usecase.BackgroundImage = UseCaseHelper.Properties.Resources.usecaseimage;
                    Usecase.Text = "   " + "gebruiker aanmaken" + "   ";
                    Usecase.Location = locatie;
                    Usecase.FlatStyle = FlatStyle.Flat;
                    Usecase.AutoSize = true;
                    Usecase.Height += 30;
                    Usecase.Width += 35;
                    Usecase.BackgroundImageLayout = ImageLayout.Stretch;
                    Usecase.FlatAppearance.BorderSize = 0;
                    Controls.Add(Usecase);
                    Usecase.BringToFront();
                }
                else
                {

                }
            }
           
        }

        private void selectedActor_MouseClick(object sender, MouseEventArgs e)
        {
            if (Linebtn.Checked == true)
            {
                string ID = (((PictureBox)sender).Name).ToString();
                ID = ID.Substring(ID.Length - 1, 1);
                selectedActor = Convert.ToInt32(ID); 
            }
            
        }
    }
}
