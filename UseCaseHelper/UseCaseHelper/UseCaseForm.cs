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
        string selectedCase;
        Point a = new Point(0, 0);
        Point b = new Point(0, 0);
        Data lists = new Data();
        Point locatie;
        Graphics formGraphics;
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
                    string naam = "";
                    aantalUsecases++;
                    Beschrijving beschrijving = new Beschrijving();
                    if (beschrijving.ShowDialog(this) == DialogResult.OK)
                    {
                        naam = beschrijving.getNaam();
                        lists.addCase(naam, beschrijving.getSamenvatting(), beschrijving.getAannamen(), beschrijving.getBeschrijving(), beschrijving.getUitzonderingen(), beschrijving.getResultaten());
                    }
                    beschrijving.Close();
                    CreateCase(naam);
                }
                else
                {

                }
            }
           
        }

        
        private void CreateCase(string naam)
        {
            Button Usecase = new Button();
            Usecase.BackgroundImage = UseCaseHelper.Properties.Resources.usecaseimage;
            Usecase.Text = "   " + naam + "   ";
            Usecase.Location = locatie;
            Usecase.FlatStyle = FlatStyle.Flat;
            Usecase.AutoSize = true;
            Usecase.Height += 30;
            Usecase.Width += 35;
            Usecase.MouseClick += Case_MouseClick;
            Usecase.BackgroundImageLayout = ImageLayout.Stretch;
            Usecase.FlatAppearance.BorderSize = 0;
            Controls.Add(Usecase);
            Usecase.BringToFront();
        }
        private void selectedActor_MouseClick(object sender, MouseEventArgs e)
        {
            if (Selectbtn.Checked == true & Linebtn.Checked == true)
            {
                string ID = (((PictureBox)sender).Name).ToString();
                ID = ID.Substring(ID.Length - 1, 1);
                selectedActor = Convert.ToInt32(ID);
                switch (selected)
                {
                    case true:
                        b = (((PictureBox)sender).Location);
                        b.Y += 80;
                        selected = false;
                        break;
                    case false:
                        a = (((PictureBox)sender).Location);
                        a.Y += 80;
                        selected = true;
                        break;
                }
            }
            //lijn maken
            if (Createbtn.Checked == true)
            {
                switch (selected)
                {
                    case true:
                        if (Linebtn.Checked == true)
                        {
                            b = (((PictureBox)sender).Location);
                            b.Y += 80;
                            string ID = (((PictureBox)sender).Name).ToString();
                            ID = ID.Substring(ID.Length - 1, 1);
                            selectedActor = Convert.ToInt32(ID);
                            Pen myPen;
                            myPen = new Pen(Color.Black);
                            formGraphics = CreateGraphics();
                            formGraphics.DrawLine(myPen, a.X, a.Y, b.X, b.Y);
                            lists.addLine(selectedActor, selectedCase);
                            selected = false;
                        }
                        break;
                    case false:
                        if (Linebtn.Checked == true)
                        {
                            a = (((PictureBox)sender).Location);
                            a.Y += 80;
                            string ID = (((PictureBox)sender).Name).ToString();
                            ID = ID.Substring(ID.Length - 1, 1);
                            selectedActor = Convert.ToInt32(ID);
                            selected = true;
                        }
                        break;
                }
            }
            
        }

        private void Case_MouseClick(object sender, MouseEventArgs e)
        {
            if (Selectbtn.Checked == true & Linebtn.Checked == true)
            {
                string ID = (((Button)sender).Text).ToString();
                selectedCase = lists.getCaseID(ID).ToString();
                switch (selected)
                {
                    case true:
                        b = (((Button)sender).Location);
                        b.X += 50;
                        b.Y -= 100;
                        selected = false;
                        break;
                    case false:
                        a = (((Button)sender).Location);
                        a.X += 50;
                        a.Y -= 100;
                        selected = true;
                        break;
                }
            }
            
            //case wijzigen
            if (Selectbtn.Checked == true & Usecasebtn.Checked == true)
            {
                string naam;
               
                foreach (Usecase item in lists.Caselist)
                {
                    if (((Button)sender).Text == "   " + item.naam + "   ")
                    {
                        Beschrijving beschrijving = new Beschrijving(item);
                        if (beschrijving.ShowDialog(this) == DialogResult.OK)
                        {
                            naam = beschrijving.getNaam();
                            lists.deleteCase(naam, beschrijving.getSamenvatting(), beschrijving.getAannamen(), beschrijving.getBeschrijving(), beschrijving.getUitzonderingen(), beschrijving.getResultaten());
                            CreateCase(naam);
                        }
                    }
                }

                
            }
            //lijn aanmaken
            if (Createbtn.Checked == true)
            {
                switch (selected)
                {
                    case true:
                        if (Linebtn.Checked == true)
                        {
                            b = (((Button)sender).Location);
                            b.X += 50;
                            b.Y -= 100;
                            string ID = (((Button)sender).Text).ToString();
                            selectedCase = ID;
                            Pen myPen;
                            myPen = new Pen(Color.Black);
                            formGraphics = panel.CreateGraphics();
                            formGraphics.DrawLine(myPen, a.X, a.Y, b.X, b.Y);
                            lists.addLine(selectedActor, selectedCase);
                            selected = false;
                        }
                        break;
                    case false:
                        if (!selected)
                        {
                            if (Linebtn.Checked == true)
                            {
                                a = (((Button)sender).Location);
                                a.X += 50;
                                a.Y -= 100;
                                string ID = (((Button)sender).Text).ToString();
                                selectedCase = ID;
                                selected = true;
                            }
                        }
                        break;
                }
            }
            
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (Linebtn.Checked & Selectbtn.Checked)
            {
                if (selectedCase != null)
                {
                    lists.removeLine(selectedActor, selectedCase);
                    Pen myPen;
                    myPen = new Pen(Color.White);
                    formGraphics = panel.CreateGraphics();
                    formGraphics.DrawLine(myPen, a.X, a.Y, b.X, b.Y);
                }

            }
        }
    }
}
