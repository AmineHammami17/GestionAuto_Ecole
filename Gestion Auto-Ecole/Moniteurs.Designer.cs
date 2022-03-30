namespace Gestion_Auto_Ecole
{
    partial class Moniteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moniteurs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablePnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnEditer = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvMoniteurs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlNom = new System.Windows.Forms.Panel();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.PnlPrenom = new System.Windows.Forms.Panel();
            this.TxtPrénom = new System.Windows.Forms.TextBox();
            this.PnlNumero = new System.Windows.Forms.Panel();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.PnlSalaire = new System.Windows.Forms.Panel();
            this.TxtSalaire = new System.Windows.Forms.TextBox();
            this.PnlHeures = new System.Windows.Forms.Panel();
            this.TxtHeures = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TablePnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMoniteurs)).BeginInit();
            this.PnlNom.SuspendLayout();
            this.PnlPrenom.SuspendLayout();
            this.PnlNumero.SuspendLayout();
            this.PnlSalaire.SuspendLayout();
            this.PnlHeures.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePnlTop
            // 
            this.TablePnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TablePnlTop.ColumnCount = 7;
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.48387F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.51613F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.TablePnlTop.Controls.Add(this.BtnAjouter, 0, 0);
            this.TablePnlTop.Controls.Add(this.BtnPrint, 4, 0);
            this.TablePnlTop.Controls.Add(this.BtnRefresh, 3, 0);
            this.TablePnlTop.Controls.Add(this.BtnSupprimer, 2, 0);
            this.TablePnlTop.Controls.Add(this.BtnEditer, 1, 0);
            this.TablePnlTop.Controls.Add(this.TxtSearch, 1, 1);
            this.TablePnlTop.Controls.Add(this.pictureBox1, 6, 1);
            this.TablePnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TablePnlTop.Location = new System.Drawing.Point(0, 0);
            this.TablePnlTop.Name = "TablePnlTop";
            this.TablePnlTop.RowCount = 2;
            this.TablePnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.20472F));
            this.TablePnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.79528F));
            this.TablePnlTop.Size = new System.Drawing.Size(950, 127);
            this.TablePnlTop.TabIndex = 2;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAjouter.FlatAppearance.BorderSize = 0;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
            this.BtnAjouter.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_add_user_male_40;
            this.BtnAjouter.Location = new System.Drawing.Point(3, 3);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(84, 72);
            this.BtnAjouter.TabIndex = 0;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrint.FlatAppearance.BorderSize = 0;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_print_40;
            this.BtnPrint.Location = new System.Drawing.Point(445, 3);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(84, 72);
            this.BtnPrint.TabIndex = 4;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(355, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(84, 72);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSupprimer.FlatAppearance.BorderSize = 0;
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_denied_40;
            this.BtnSupprimer.Location = new System.Drawing.Point(183, 3);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(166, 72);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            // 
            // BtnEditer
            // 
            this.BtnEditer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEditer.FlatAppearance.BorderSize = 0;
            this.BtnEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditer.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditer.ForeColor = System.Drawing.Color.White;
            this.BtnEditer.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_registration_40;
            this.BtnEditer.Location = new System.Drawing.Point(93, 3);
            this.BtnEditer.Name = "BtnEditer";
            this.BtnEditer.Size = new System.Drawing.Size(84, 72);
            this.BtnEditer.TabIndex = 1;
            this.BtnEditer.Text = "Editer";
            this.BtnEditer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditer.UseVisualStyleBackColor = true;
            this.BtnEditer.Click += new System.EventHandler(this.BtnEditer_Click);
            // 
            // TxtSearch
            // 
            this.TablePnlTop.SetColumnSpan(this.TxtSearch, 5);
            this.TxtSearch.Location = new System.Drawing.Point(90, 84);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(706, 22);
            this.TxtSearch.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(845, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DgvMoniteurs
            // 
            this.DgvMoniteurs.AllowUserToAddRows = false;
            this.DgvMoniteurs.AllowUserToDeleteRows = false;
            this.DgvMoniteurs.AllowUserToResizeColumns = false;
            this.DgvMoniteurs.AllowUserToResizeRows = false;
            this.DgvMoniteurs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DgvMoniteurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMoniteurs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvMoniteurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMoniteurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMoniteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMoniteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Prenom,
            this.Numero,
            this.Salaire,
            this.Heures});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMoniteurs.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMoniteurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvMoniteurs.EnableHeadersVisualStyles = false;
            this.DgvMoniteurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.DgvMoniteurs.Location = new System.Drawing.Point(0, 127);
            this.DgvMoniteurs.MultiSelect = false;
            this.DgvMoniteurs.Name = "DgvMoniteurs";
            this.DgvMoniteurs.ReadOnly = true;
            this.DgvMoniteurs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvMoniteurs.RowHeadersVisible = false;
            this.DgvMoniteurs.RowHeadersWidth = 51;
            this.DgvMoniteurs.RowTemplate.DividerHeight = 2;
            this.DgvMoniteurs.RowTemplate.Height = 30;
            this.DgvMoniteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMoniteurs.Size = new System.Drawing.Size(950, 545);
            this.DgvMoniteurs.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero.HeaderText = "Numéro";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Salaire
            // 
            this.Salaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salaire.HeaderText = "Salaire";
            this.Salaire.MinimumWidth = 6;
            this.Salaire.Name = "Salaire";
            this.Salaire.ReadOnly = true;
            // 
            // Heures
            // 
            this.Heures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Heures.HeaderText = "Heures Effectués";
            this.Heures.MinimumWidth = 6;
            this.Heures.Name = "Heures";
            this.Heures.ReadOnly = true;
            // 
            // PnlNom
            // 
            this.PnlNom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlNom.Controls.Add(this.TxtNom);
            this.PnlNom.ForeColor = System.Drawing.Color.White;
            this.PnlNom.Location = new System.Drawing.Point(204, 383);
            this.PnlNom.Name = "PnlNom";
            this.PnlNom.Size = new System.Drawing.Size(190, 20);
            this.PnlNom.TabIndex = 4;
            // 
            // TxtNom
            // 
            this.TxtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNom.Location = new System.Drawing.Point(0, 0);
            this.TxtNom.MaxLength = 15;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(190, 15);
            this.TxtNom.TabIndex = 0;
            // 
            // PnlPrenom
            // 
            this.PnlPrenom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlPrenom.Controls.Add(this.TxtPrénom);
            this.PnlPrenom.ForeColor = System.Drawing.Color.White;
            this.PnlPrenom.Location = new System.Drawing.Point(204, 448);
            this.PnlPrenom.Name = "PnlPrenom";
            this.PnlPrenom.Size = new System.Drawing.Size(190, 20);
            this.PnlPrenom.TabIndex = 5;
            // 
            // TxtPrénom
            // 
            this.TxtPrénom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrénom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPrénom.Location = new System.Drawing.Point(0, 0);
            this.TxtPrénom.MaxLength = 15;
            this.TxtPrénom.Name = "TxtPrénom";
            this.TxtPrénom.Size = new System.Drawing.Size(190, 15);
            this.TxtPrénom.TabIndex = 1;
            // 
            // PnlNumero
            // 
            this.PnlNumero.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlNumero.Controls.Add(this.TxtNumero);
            this.PnlNumero.ForeColor = System.Drawing.Color.White;
            this.PnlNumero.Location = new System.Drawing.Point(204, 510);
            this.PnlNumero.Name = "PnlNumero";
            this.PnlNumero.Size = new System.Drawing.Size(190, 20);
            this.PnlNumero.TabIndex = 5;
            // 
            // TxtNumero
            // 
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNumero.Location = new System.Drawing.Point(0, 0);
            this.TxtNumero.MaxLength = 8;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(190, 15);
            this.TxtNumero.TabIndex = 1;
            // 
            // PnlSalaire
            // 
            this.PnlSalaire.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSalaire.Controls.Add(this.TxtSalaire);
            this.PnlSalaire.ForeColor = System.Drawing.Color.White;
            this.PnlSalaire.Location = new System.Drawing.Point(204, 581);
            this.PnlSalaire.Name = "PnlSalaire";
            this.PnlSalaire.Size = new System.Drawing.Size(190, 20);
            this.PnlSalaire.TabIndex = 5;
            // 
            // TxtSalaire
            // 
            this.TxtSalaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSalaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSalaire.Location = new System.Drawing.Point(0, 0);
            this.TxtSalaire.MaxLength = 10;
            this.TxtSalaire.Name = "TxtSalaire";
            this.TxtSalaire.Size = new System.Drawing.Size(190, 15);
            this.TxtSalaire.TabIndex = 1;
            // 
            // PnlHeures
            // 
            this.PnlHeures.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlHeures.Controls.Add(this.TxtHeures);
            this.PnlHeures.ForeColor = System.Drawing.Color.White;
            this.PnlHeures.Location = new System.Drawing.Point(599, 383);
            this.PnlHeures.Name = "PnlHeures";
            this.PnlHeures.Size = new System.Drawing.Size(190, 20);
            this.PnlHeures.TabIndex = 5;
            // 
            // TxtHeures
            // 
            this.TxtHeures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHeures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtHeures.Location = new System.Drawing.Point(0, 0);
            this.TxtHeures.MaxLength = 5;
            this.TxtHeures.Name = "TxtHeures";
            this.TxtHeures.Size = new System.Drawing.Size(190, 15);
            this.TxtHeures.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numéro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(116, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(486, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Heures";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(344, 312);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(256, 41);
            this.LblTitle.TabIndex = 13;
            this.LblTitle.Text = "Ajouter Moniteur";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(698, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 72);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(565, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 72);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Moniteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.DgvMoniteurs);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlHeures);
            this.Controls.Add(this.PnlSalaire);
            this.Controls.Add(this.PnlNumero);
            this.Controls.Add(this.PnlPrenom);
            this.Controls.Add(this.PnlNom);
            this.Controls.Add(this.TablePnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Moniteurs";
            this.Text = "Moniteurs";
            this.TablePnlTop.ResumeLayout(false);
            this.TablePnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMoniteurs)).EndInit();
            this.PnlNom.ResumeLayout(false);
            this.PnlNom.PerformLayout();
            this.PnlPrenom.ResumeLayout(false);
            this.PnlPrenom.PerformLayout();
            this.PnlNumero.ResumeLayout(false);
            this.PnlNumero.PerformLayout();
            this.PnlSalaire.ResumeLayout(false);
            this.PnlSalaire.PerformLayout();
            this.PnlHeures.ResumeLayout(false);
            this.PnlHeures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePnlTop;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnEditer;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvMoniteurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heures;
        private System.Windows.Forms.Panel PnlNom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Panel PnlPrenom;
        private System.Windows.Forms.TextBox TxtPrénom;
        private System.Windows.Forms.Panel PnlNumero;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Panel PnlSalaire;
        private System.Windows.Forms.TextBox TxtSalaire;
        private System.Windows.Forms.Panel PnlHeures;
        private System.Windows.Forms.TextBox TxtHeures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblTitle;
    }
}