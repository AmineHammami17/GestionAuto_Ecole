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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Programme());

            hideSubMenu();
        }
     

        private void hideSubMenu()
        {
            panelBureau.Visible = false;
            panelClients.Visible = false;
            PanelParametres.Visible = false;    

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClients);  

        }

        private void BtnBureau_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBureau);

        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Fiche());
            hideSubMenu();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Historique());

            hideSubMenu();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Formation());

            hideSubMenu();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Moniteurs());
            hideSubMenu();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Tarifs());

            hideSubMenu();

        }

        private void BtnVoitures_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildFormInPanel(new Voitures());


        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelParametres);
        }
    }
}
