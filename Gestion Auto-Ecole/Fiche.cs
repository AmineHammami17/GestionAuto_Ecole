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
    public partial class Fiche : Form
    {
        public Fiche()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            {
                DgvFiche.Height = 0;
                LblTitle.Text = "Ajouter Candidat";
                TablePnlTop.Enabled = false;
            }

        }

        private void BtnEditer_Click(object sender, EventArgs e)
        {
            DgvFiche.Height = 0;
            LblTitle.Text = "Editer Candidat";
            TablePnlTop.Enabled = false;
            if (DgvFiche.CurrentRow != null)
            {
                TxtNom.Text = DgvFiche.CurrentRow.Cells[1].Value.ToString();
                TxtPrénom.Text = DgvFiche.CurrentRow.Cells[2].Value.ToString();
                TxtAge.Text = DgvFiche.CurrentRow.Cells[3].Value.ToString();
                TxtCin.Text = DgvFiche.CurrentRow.Cells[4].Value.ToString();
                TxtEtat.Text = DgvFiche.CurrentRow.Cells[5].Value.ToString();


            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DgvFiche.Height = 430;
            LblTitle.Text = "";
            TablePnlTop.Enabled = true;

        }
    }
}
