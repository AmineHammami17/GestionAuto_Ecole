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

       

        private void Moniteurs_Load(object sender, EventArgs e)
        {
            DgvMoniteurs.Rows.Add(new object[] { "1", "Hammami", "Amine", "1000", "20", "27898205" });
            DgvMoniteurs.Rows.Add(new object[] { "2", "Sancho", "Jadon", "5000", "40", "99205999" });

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DgvMoniteurs.Height = 498;
            LblTitle.Text = "";
            TablePnlTop.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DgvMoniteurs.Height = 0;
            LblTitle.Text = "Ajouter Moniteur";
            TablePnlTop.Enabled = false;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DgvMoniteurs.Height = 0;
            LblTitle.Text = "Editer Moniteur";
            TablePnlTop.Enabled= false; 
            if (DgvMoniteurs.CurrentRow != null)
            {
                TxtNom.Text=DgvMoniteurs.CurrentRow.Cells[1].Value.ToString();
                TxtPrénom.Text = DgvMoniteurs.CurrentRow.Cells[2].Value.ToString();
                TxtHeures.Text = DgvMoniteurs.CurrentRow.Cells[4].Value.ToString();
                TxtSalaire.Text = DgvMoniteurs.CurrentRow.Cells[3].Value.ToString();
                TxtNumTel.Text = DgvMoniteurs.CurrentRow.Cells[5].Value.ToString();

            }
        }
    }
}


