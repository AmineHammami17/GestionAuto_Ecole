namespace Gestion_Auto_Ecole
{
    partial class Fiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiche));
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
            this.DgvFiche = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlEtat = new System.Windows.Forms.Panel();
            this.TxtEtat = new System.Windows.Forms.TextBox();
            this.PnlCin = new System.Windows.Forms.Panel();
            this.TxtCin = new System.Windows.Forms.TextBox();
            this.PnlAge = new System.Windows.Forms.Panel();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.PnlPrenom = new System.Windows.Forms.Panel();
            this.TxtPrénom = new System.Windows.Forms.TextBox();
            this.PnlNom = new System.Windows.Forms.Panel();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TablePnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFiche)).BeginInit();
            this.PnlEtat.SuspendLayout();
            this.PnlCin.SuspendLayout();
            this.PnlAge.SuspendLayout();
            this.PnlPrenom.SuspendLayout();
            this.PnlNom.SuspendLayout();
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
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
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
            this.TablePnlTop.TabIndex = 3;
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
            this.BtnPrint.Location = new System.Drawing.Point(444, 3);
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
            this.BtnRefresh.Location = new System.Drawing.Point(354, 3);
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
            this.BtnSupprimer.Size = new System.Drawing.Size(165, 72);
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
            this.pictureBox1.Location = new System.Drawing.Point(842, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DgvFiche
            // 
            this.DgvFiche.AllowUserToAddRows = false;
            this.DgvFiche.AllowUserToDeleteRows = false;
            this.DgvFiche.AllowUserToResizeColumns = false;
            this.DgvFiche.AllowUserToResizeRows = false;
            this.DgvFiche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DgvFiche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvFiche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvFiche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFiche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFiche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Prenom,
            this.Age,
            this.Cin,
            this.Etat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFiche.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvFiche.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvFiche.EnableHeadersVisualStyles = false;
            this.DgvFiche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.DgvFiche.Location = new System.Drawing.Point(0, 127);
            this.DgvFiche.MultiSelect = false;
            this.DgvFiche.Name = "DgvFiche";
            this.DgvFiche.ReadOnly = true;
            this.DgvFiche.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvFiche.RowHeadersVisible = false;
            this.DgvFiche.RowHeadersWidth = 51;
            this.DgvFiche.RowTemplate.DividerHeight = 2;
            this.DgvFiche.RowTemplate.Height = 30;
            this.DgvFiche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFiche.Size = new System.Drawing.Size(950, 561);
            this.DgvFiche.TabIndex = 4;
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
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Cin
            // 
            this.Cin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cin.HeaderText = "Cin";
            this.Cin.MinimumWidth = 6;
            this.Cin.Name = "Cin";
            this.Cin.ReadOnly = true;
            // 
            // Etat
            // 
            this.Etat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Etat.HeaderText = "Etat";
            this.Etat.MinimumWidth = 6;
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(349, 258);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(252, 41);
            this.LblTitle.TabIndex = 26;
            this.LblTitle.Text = "Ajouter Candidat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(491, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Etat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom";
            // 
            // PnlEtat
            // 
            this.PnlEtat.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlEtat.Controls.Add(this.TxtEtat);
            this.PnlEtat.ForeColor = System.Drawing.Color.White;
            this.PnlEtat.Location = new System.Drawing.Point(604, 352);
            this.PnlEtat.Name = "PnlEtat";
            this.PnlEtat.Size = new System.Drawing.Size(190, 20);
            this.PnlEtat.TabIndex = 15;
            // 
            // TxtEtat
            // 
            this.TxtEtat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEtat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEtat.Location = new System.Drawing.Point(0, 0);
            this.TxtEtat.MaxLength = 15;
            this.TxtEtat.Name = "TxtEtat";
            this.TxtEtat.Size = new System.Drawing.Size(190, 15);
            this.TxtEtat.TabIndex = 1;
            // 
            // PnlCin
            // 
            this.PnlCin.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlCin.Controls.Add(this.TxtCin);
            this.PnlCin.ForeColor = System.Drawing.Color.White;
            this.PnlCin.Location = new System.Drawing.Point(209, 550);
            this.PnlCin.Name = "PnlCin";
            this.PnlCin.Size = new System.Drawing.Size(190, 20);
            this.PnlCin.TabIndex = 16;
            // 
            // TxtCin
            // 
            this.TxtCin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCin.Location = new System.Drawing.Point(0, 0);
            this.TxtCin.MaxLength = 8;
            this.TxtCin.Name = "TxtCin";
            this.TxtCin.Size = new System.Drawing.Size(190, 15);
            this.TxtCin.TabIndex = 1;
            // 
            // PnlAge
            // 
            this.PnlAge.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlAge.Controls.Add(this.TxtAge);
            this.PnlAge.ForeColor = System.Drawing.Color.White;
            this.PnlAge.Location = new System.Drawing.Point(209, 479);
            this.PnlAge.Name = "PnlAge";
            this.PnlAge.Size = new System.Drawing.Size(190, 20);
            this.PnlAge.TabIndex = 17;
            // 
            // TxtAge
            // 
            this.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAge.Location = new System.Drawing.Point(0, 0);
            this.TxtAge.MaxLength = 2;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(190, 15);
            this.TxtAge.TabIndex = 1;
            // 
            // PnlPrenom
            // 
            this.PnlPrenom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlPrenom.Controls.Add(this.TxtPrénom);
            this.PnlPrenom.ForeColor = System.Drawing.Color.White;
            this.PnlPrenom.Location = new System.Drawing.Point(209, 417);
            this.PnlPrenom.Name = "PnlPrenom";
            this.PnlPrenom.Size = new System.Drawing.Size(190, 20);
            this.PnlPrenom.TabIndex = 18;
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
            // PnlNom
            // 
            this.PnlNom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlNom.Controls.Add(this.TxtNom);
            this.PnlNom.ForeColor = System.Drawing.Color.White;
            this.PnlNom.Location = new System.Drawing.Point(209, 352);
            this.PnlNom.Name = "PnlNom";
            this.PnlNom.Size = new System.Drawing.Size(190, 20);
            this.PnlNom.TabIndex = 14;
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
            // BtnCancel
            // 
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(703, 451);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 72);
            this.BtnCancel.TabIndex = 25;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(570, 451);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(84, 72);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // Fiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.DgvFiche);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlEtat);
            this.Controls.Add(this.PnlCin);
            this.Controls.Add(this.PnlAge);
            this.Controls.Add(this.PnlPrenom);
            this.Controls.Add(this.PnlNom);
            this.Controls.Add(this.TablePnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fiche";
            this.Text = "Fiche";
            this.TablePnlTop.ResumeLayout(false);
            this.TablePnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFiche)).EndInit();
            this.PnlEtat.ResumeLayout(false);
            this.PnlEtat.PerformLayout();
            this.PnlCin.ResumeLayout(false);
            this.PnlCin.PerformLayout();
            this.PnlAge.ResumeLayout(false);
            this.PnlAge.PerformLayout();
            this.PnlPrenom.ResumeLayout(false);
            this.PnlPrenom.PerformLayout();
            this.PnlNom.ResumeLayout(false);
            this.PnlNom.PerformLayout();
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
        private System.Windows.Forms.DataGridView DgvFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlEtat;
        private System.Windows.Forms.TextBox TxtEtat;
        private System.Windows.Forms.Panel PnlCin;
        private System.Windows.Forms.TextBox TxtCin;
        private System.Windows.Forms.Panel PnlAge;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Panel PnlPrenom;
        private System.Windows.Forms.TextBox TxtPrénom;
        private System.Windows.Forms.Panel PnlNom;
        private System.Windows.Forms.TextBox TxtNom;
    }
}