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
    public partial class Tarifs : Form
    {
        public Tarifs()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            DgvTarifs.Height = 0;
            LblTitle.Text = "Ajouter Tarif";
            TablePnlTop.Enabled = false;

        }

        private void BtnEditer_Click(object sender, EventArgs e)
        {
            DgvTarifs.Height = 0;
            LblTitle.Text = "Editer Tarif";
            TablePnlTop.Enabled = false;
            if (DgvTarifs.CurrentRow != null)
            {
                TxtType.Text = DgvTarifs.CurrentRow.Cells[1].Value.ToString();
                TxtPrix.Text = DgvTarifs.CurrentRow.Cells[2].Value.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvTarifs.Height = 430;
            LblTitle.Text = "";
            TablePnlTop.Enabled = true;
        }
    }
}
