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
    public partial class Formation : Form
    {
        public Formation()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DgvFormation.Height = 430;
            LblTitle.Text = "";
            TablePnlTop.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DgvFormation.Height = 0;
            LblTitle.Text = "Editer Formation";
            TablePnlTop.Enabled = false;
            if (DgvFormation.CurrentRow != null)
            {
                TxtCode.Text = DgvFormation.CurrentRow.Cells[2].Value.ToString();
                TxtConduite.Text = DgvFormation.CurrentRow.Cells[3].Value.ToString();
              


            }
        }
    }
}
