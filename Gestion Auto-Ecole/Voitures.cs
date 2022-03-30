using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Auto_Ecole
{
    public partial class Voitures : Form
    {
        public Voitures()
        {
            InitializeComponent();
        }

        private void pnlAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgvVoitures.Height = 0;
            LblTitle.Text = "Ajouter Voiture";
            TablePnlTop.Enabled = false;
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            DgvVoitures.Height = 0;
            LblTitle.Text = "Editer Voiture";
            TablePnlTop.Enabled = false;
            if (DgvVoitures.CurrentRow != null)
            {
                TxtNom.Text = DgvVoitures.CurrentRow.Cells[1].Value.ToString();
                TxtKm.Text = DgvVoitures.CurrentRow.Cells[2].Value.ToString();
                TxtKm.Text = DgvVoitures.CurrentRow.Cells[3].Value.ToString();
                TxtGarage.Text = DgvVoitures.CurrentRow.Cells[5].Value.ToString();

            }

           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DgvVoitures.Height = 430;
            LblTitle.Text = "";
            TablePnlTop.Enabled = true;
        }
    }
}
    

