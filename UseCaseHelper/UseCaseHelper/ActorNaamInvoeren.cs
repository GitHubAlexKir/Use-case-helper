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
    public partial class ActorNaamInvoeren : Form
    {
        public ActorNaamInvoeren()
        {
            InitializeComponent();
            Invoerbtn.DialogResult = DialogResult.OK;
        }

        public string getNaam()
        {
            return Actornaamtextbox.Text;
        }
    }
}
