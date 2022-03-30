namespace Gestion_Auto_Ecole
{
    partial class Voitures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voitures));
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
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.DgvVoitures = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilométrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.LblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblGarage = new System.Windows.Forms.Label();
            this.PnlGarage = new System.Windows.Forms.Panel();
            this.TxtGarage = new System.Windows.Forms.TextBox();
            this.LblDateVisite = new System.Windows.Forms.Label();
            this.LblKm = new System.Windows.Forms.Label();
            this.PnlKm = new System.Windows.Forms.Panel();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.LblMatricule = new System.Windows.Forms.Label();
            this.PnlMatricule = new System.Windows.Forms.Panel();
            this.TxtMatricule = new System.Windows.Forms.TextBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.PnlNom = new System.Windows.Forms.Panel();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TablePnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVoitures)).BeginInit();
            this.PnlGarage.SuspendLayout();
            this.PnlKm.SuspendLayout();
            this.PnlMatricule.SuspendLayout();
            this.PnlNom.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePnlTop
            // 
            this.TablePnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TablePnlTop.ColumnCount = 7;
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76035F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23965F));
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
            this.TablePnlTop.TabIndex = 1;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAjouter.FlatAppearance.BorderSize = 0;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
            this.BtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouter.Image")));
            this.BtnAjouter.Location = new System.Drawing.Point(3, 3);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(84, 72);
            this.BtnAjouter.TabIndex = 0;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrint.FlatAppearance.BorderSize = 0;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_print_40;
            this.BtnPrint.Location = new System.Drawing.Point(421, 3);
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
            this.BtnRefresh.Location = new System.Drawing.Point(331, 3);
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
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.Location = new System.Drawing.Point(183, 3);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(142, 72);
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
            this.BtnEditer.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditer.Image")));
            this.BtnEditer.Location = new System.Drawing.Point(93, 3);
            this.BtnEditer.Name = "BtnEditer";
            this.BtnEditer.Size = new System.Drawing.Size(84, 72);
            this.BtnEditer.TabIndex = 1;
            this.BtnEditer.Text = "Editer";
            this.BtnEditer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditer.UseVisualStyleBackColor = true;
            this.BtnEditer.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtSearch
            // 
            this.TablePnlTop.SetColumnSpan(this.TxtSearch, 5);
            this.TxtSearch.Location = new System.Drawing.Point(90, 84);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(707, 22);
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
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.DgvVoitures);
            this.pnlAdd.Controls.Add(this.bunifuDatePicker1);
            this.pnlAdd.Controls.Add(this.LblTitle);
            this.pnlAdd.Controls.Add(this.button2);
            this.pnlAdd.Controls.Add(this.BtnSave);
            this.pnlAdd.Controls.Add(this.LblGarage);
            this.pnlAdd.Controls.Add(this.PnlGarage);
            this.pnlAdd.Controls.Add(this.LblDateVisite);
            this.pnlAdd.Controls.Add(this.LblKm);
            this.pnlAdd.Controls.Add(this.PnlKm);
            this.pnlAdd.Controls.Add(this.LblMatricule);
            this.pnlAdd.Controls.Add(this.PnlMatricule);
            this.pnlAdd.Controls.Add(this.LblNom);
            this.pnlAdd.Controls.Add(this.PnlNom);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd.Location = new System.Drawing.Point(0, 127);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlAdd.Size = new System.Drawing.Size(950, 573);
            this.pnlAdd.TabIndex = 2;
            this.pnlAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdd_Paint);
            // 
            // DgvVoitures
            // 
            this.DgvVoitures.AllowUserToAddRows = false;
            this.DgvVoitures.AllowUserToDeleteRows = false;
            this.DgvVoitures.AllowUserToResizeColumns = false;
            this.DgvVoitures.AllowUserToResizeRows = false;
            this.DgvVoitures.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DgvVoitures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvVoitures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvVoitures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVoitures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVoitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVoitures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Matricule,
            this.Kilométrage,
            this.DateVisite,
            this.Garage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVoitures.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvVoitures.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvVoitures.EnableHeadersVisualStyles = false;
            this.DgvVoitures.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.DgvVoitures.Location = new System.Drawing.Point(10, 0);
            this.DgvVoitures.MultiSelect = false;
            this.DgvVoitures.Name = "DgvVoitures";
            this.DgvVoitures.ReadOnly = true;
            this.DgvVoitures.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvVoitures.RowHeadersVisible = false;
            this.DgvVoitures.RowHeadersWidth = 51;
            this.DgvVoitures.RowTemplate.DividerHeight = 2;
            this.DgvVoitures.RowTemplate.Height = 30;
            this.DgvVoitures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVoitures.Size = new System.Drawing.Size(930, 561);
            this.DgvVoitures.TabIndex = 0;
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
            // Matricule
            // 
            this.Matricule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.MinimumWidth = 6;
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            // 
            // Kilométrage
            // 
            this.Kilométrage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kilométrage.HeaderText = "Kilométrage";
            this.Kilométrage.MinimumWidth = 6;
            this.Kilométrage.Name = "Kilométrage";
            this.Kilométrage.ReadOnly = true;
            // 
            // DateVisite
            // 
            this.DateVisite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateVisite.HeaderText = "Date Visite";
            this.DateVisite.MinimumWidth = 6;
            this.DateVisite.Name = "DateVisite";
            this.DateVisite.ReadOnly = true;
            // 
            // Garage
            // 
            this.Garage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Garage.HeaderText = "Garage";
            this.Garage.MinimumWidth = 6;
            this.Garage.Name = "Garage";
            this.Garage.ReadOnly = true;
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.White;
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(268, 473);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(222, 32);
            this.bunifuDatePicker1.TabIndex = 15;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(326, 153);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(255, 44);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Ajouter Voiture";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_cancel_40;
            this.button2.Location = new System.Drawing.Point(712, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 80);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_save_40;
            this.BtnSave.Location = new System.Drawing.Point(622, 353);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(84, 80);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // LblGarage
            // 
            this.LblGarage.AutoSize = true;
            this.LblGarage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGarage.ForeColor = System.Drawing.Color.White;
            this.LblGarage.Location = new System.Drawing.Point(528, 257);
            this.LblGarage.Name = "LblGarage";
            this.LblGarage.Size = new System.Drawing.Size(76, 28);
            this.LblGarage.TabIndex = 10;
            this.LblGarage.Text = "Garage";
            // 
            // PnlGarage
            // 
            this.PnlGarage.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlGarage.Controls.Add(this.TxtGarage);
            this.PnlGarage.Location = new System.Drawing.Point(625, 263);
            this.PnlGarage.Name = "PnlGarage";
            this.PnlGarage.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PnlGarage.Size = new System.Drawing.Size(190, 20);
            this.PnlGarage.TabIndex = 9;
            // 
            // TxtGarage
            // 
            this.TxtGarage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGarage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGarage.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGarage.Location = new System.Drawing.Point(0, 0);
            this.TxtGarage.MaxLength = 15;
            this.TxtGarage.Name = "TxtGarage";
            this.TxtGarage.Size = new System.Drawing.Size(190, 18);
            this.TxtGarage.TabIndex = 0;
            // 
            // LblDateVisite
            // 
            this.LblDateVisite.AutoSize = true;
            this.LblDateVisite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateVisite.ForeColor = System.Drawing.Color.White;
            this.LblDateVisite.Location = new System.Drawing.Point(126, 473);
            this.LblDateVisite.Name = "LblDateVisite";
            this.LblDateVisite.Size = new System.Drawing.Size(110, 28);
            this.LblDateVisite.TabIndex = 8;
            this.LblDateVisite.Text = "Date Visite";
            // 
            // LblKm
            // 
            this.LblKm.AutoSize = true;
            this.LblKm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKm.ForeColor = System.Drawing.Color.White;
            this.LblKm.Location = new System.Drawing.Point(126, 394);
            this.LblKm.Name = "LblKm";
            this.LblKm.Size = new System.Drawing.Size(122, 28);
            this.LblKm.TabIndex = 6;
            this.LblKm.Text = "Kilométrage";
            // 
            // PnlKm
            // 
            this.PnlKm.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlKm.Controls.Add(this.TxtKm);
            this.PnlKm.Location = new System.Drawing.Point(268, 402);
            this.PnlKm.Name = "PnlKm";
            this.PnlKm.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PnlKm.Size = new System.Drawing.Size(190, 20);
            this.PnlKm.TabIndex = 5;
            // 
            // TxtKm
            // 
            this.TxtKm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtKm.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKm.Location = new System.Drawing.Point(0, 0);
            this.TxtKm.MaxLength = 15;
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(190, 18);
            this.TxtKm.TabIndex = 0;
            // 
            // LblMatricule
            // 
            this.LblMatricule.AutoSize = true;
            this.LblMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatricule.ForeColor = System.Drawing.Color.White;
            this.LblMatricule.Location = new System.Drawing.Point(126, 334);
            this.LblMatricule.Name = "LblMatricule";
            this.LblMatricule.Size = new System.Drawing.Size(96, 28);
            this.LblMatricule.TabIndex = 4;
            this.LblMatricule.Text = "Matricule";
            // 
            // PnlMatricule
            // 
            this.PnlMatricule.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlMatricule.Controls.Add(this.TxtMatricule);
            this.PnlMatricule.Location = new System.Drawing.Point(268, 334);
            this.PnlMatricule.Name = "PnlMatricule";
            this.PnlMatricule.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.PnlMatricule.Size = new System.Drawing.Size(190, 20);
            this.PnlMatricule.TabIndex = 3;
            // 
            // TxtMatricule
            // 
            this.TxtMatricule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMatricule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricule.Location = new System.Drawing.Point(0, 0);
            this.TxtMatricule.MaxLength = 15;
            this.TxtMatricule.Name = "TxtMatricule";
            this.TxtMatricule.Size = new System.Drawing.Size(190, 18);
            this.TxtMatricule.TabIndex = 0;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.ForeColor = System.Drawing.Color.White;
            this.LblNom.Location = new System.Drawing.Point(126, 260);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(57, 28);
            this.LblNom.TabIndex = 2;
            this.LblNom.Text = "Nom";
            // 
            // PnlNom
            // 
            this.PnlNom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlNom.Controls.Add(this.TxtNom);
            this.PnlNom.Location = new System.Drawing.Point(268, 266);
            this.PnlNom.Name = "PnlNom";
            this.PnlNom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.PnlNom.Size = new System.Drawing.Size(190, 20);
            this.PnlNom.TabIndex = 1;
            // 
            // TxtNom
            // 
            this.TxtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNom.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(0, 0);
            this.TxtNom.MaxLength = 15;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(190, 18);
            this.TxtNom.TabIndex = 0;
            // 
            // Voitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.TablePnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voitures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voitures";
            this.TablePnlTop.ResumeLayout(false);
            this.TablePnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVoitures)).EndInit();
            this.PnlGarage.ResumeLayout(false);
            this.PnlGarage.PerformLayout();
            this.PnlKm.ResumeLayout(false);
            this.PnlKm.PerformLayout();
            this.PnlMatricule.ResumeLayout(false);
            this.PnlMatricule.PerformLayout();
            this.PnlNom.ResumeLayout(false);
            this.PnlNom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePnlTop;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnEditer;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.DataGridView DgvVoitures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilométrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Garage;
        private System.Windows.Forms.Panel PnlNom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LblGarage;
        private System.Windows.Forms.Panel PnlGarage;
        private System.Windows.Forms.Label LblDateVisite;
        private System.Windows.Forms.Label LblKm;
        private System.Windows.Forms.Panel PnlKm;
        private System.Windows.Forms.Label LblMatricule;
        private System.Windows.Forms.Panel PnlMatricule;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.TextBox TxtGarage;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.TextBox TxtMatricule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblTitle;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
    }
}