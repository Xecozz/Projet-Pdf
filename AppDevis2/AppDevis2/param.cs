using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevis2
{
    public partial class param : Form
    {
        public string coordonnees = null;
        public bool verify = false;
        public param()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
          coordonnees = clientSave.Text;
          verify = true;
          MessageBox.Show("Informations enregistré!");
          Close();

        }
    }
}
