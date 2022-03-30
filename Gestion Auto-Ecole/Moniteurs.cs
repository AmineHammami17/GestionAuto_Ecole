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
    public partial class Moniteurs : Form
    {
        public Moniteurs()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            DgvMoniteurs.Height = 0;
            LblTitle.Text = "Ajouter Moniteur";
            TablePnlTop.Enabled = false;
        }

        private void BtnEditer_Click(object sender, EventArgs e)
        {
            DgvMoniteurs.Height = 0;
            LblTitle.Text = "Editer Moniteur";
            TablePnlTop.Enabled = false;
            if (DgvMoniteurs.CurrentRow != null)
            {
                TxtNom.Text = DgvMoniteurs.CurrentRow.Cells[1].Value.ToString();
                TxtPrénom.Text = DgvMoniteurs.CurrentRow.Cells[2].Value.ToString();
                TxtNumero.Text = DgvMoniteurs.CurrentRow.Cells[3].Value.ToString();
                TxtSalaire.Text = DgvMoniteurs.CurrentRow.Cells[4].Value.ToString();
                TxtHeures.Text = DgvMoniteurs.CurrentRow.Cells[5].Value.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvMoniteurs.Height = 430;
            LblTitle.Text = "";
            TablePnlTop.Enabled = true;
        }
    }
}
