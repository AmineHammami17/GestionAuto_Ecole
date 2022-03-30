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
    public partial class Programme : Form
    {
        public Programme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvProgramme.Height = 430;
            LblTitle.Text = "";
            TablePnlTop.Enabled = true;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            DgvProgramme.Height = 0;
            LblTitle.Text = "Ajouter Session";
            TablePnlTop.Enabled = false;
        }

        private void BtnEditer_Click(object sender, EventArgs e)
        {
            DgvProgramme.Height = 0;
            LblTitle.Text = "Editer Session";
            TablePnlTop.Enabled = false;
            if (DgvProgramme.CurrentRow != null)
            {
                TxtCin.Text = DgvProgramme.CurrentRow.Cells[1].Value.ToString();
                BoxSession.Text = DgvProgramme.CurrentRow.Cells[2].Value.ToString();
                TxtMoniteur.Text = DgvProgramme.CurrentRow.Cells[3].Value.ToString();
                DateSession.Text = DgvProgramme.CurrentRow.Cells[4].Value.ToString();

            }
        }
    }
}
