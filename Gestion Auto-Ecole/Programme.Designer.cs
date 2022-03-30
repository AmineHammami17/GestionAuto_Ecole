namespace Gestion_Auto_Ecole
{
    partial class Programme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programme));
            this.DgvProgramme = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moniteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablePnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnEditer = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateSession = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.LblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblDateVisite = new System.Windows.Forms.Label();
            this.LblKm = new System.Windows.Forms.Label();
            this.PnlKm = new System.Windows.Forms.Panel();
            this.TxtMoniteur = new System.Windows.Forms.TextBox();
            this.LblMatricule = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.PnlNom = new System.Windows.Forms.Panel();
            this.TxtCin = new System.Windows.Forms.TextBox();
            this.PnlMatricule = new System.Windows.Forms.Panel();
            this.BoxSession = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProgramme)).BeginInit();
            this.TablePnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlKm.SuspendLayout();
            this.PnlNom.SuspendLayout();
            this.PnlMatricule.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvProgramme
            // 
            this.DgvProgramme.AllowUserToAddRows = false;
            this.DgvProgramme.AllowUserToDeleteRows = false;
            this.DgvProgramme.AllowUserToResizeColumns = false;
            this.DgvProgramme.AllowUserToResizeRows = false;
            this.DgvProgramme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DgvProgramme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProgramme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProgramme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProgramme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProgramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProgramme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Age,
            this.Session,
            this.Date,
            this.Moniteur});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProgramme.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProgramme.EnableHeadersVisualStyles = false;
            this.DgvProgramme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.DgvProgramme.Location = new System.Drawing.Point(0, 133);
            this.DgvProgramme.MultiSelect = false;
            this.DgvProgramme.Name = "DgvProgramme";
            this.DgvProgramme.ReadOnly = true;
            this.DgvProgramme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvProgramme.RowHeadersVisible = false;
            this.DgvProgramme.RowHeadersWidth = 51;
            this.DgvProgramme.RowTemplate.DividerHeight = 2;
            this.DgvProgramme.RowTemplate.Height = 30;
            this.DgvProgramme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProgramme.Size = new System.Drawing.Size(950, 555);
            this.DgvProgramme.TabIndex = 40;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.HeaderText = "Cin";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Session
            // 
            this.Session.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Session.HeaderText = "Session";
            this.Session.MinimumWidth = 6;
            this.Session.Name = "Session";
            this.Session.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Moniteur
            // 
            this.Moniteur.HeaderText = "Moniteur";
            this.Moniteur.MinimumWidth = 6;
            this.Moniteur.Name = "Moniteur";
            this.Moniteur.ReadOnly = true;
            this.Moniteur.Width = 125;
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
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
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
            this.TablePnlTop.TabIndex = 41;
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
            this.BtnPrint.Location = new System.Drawing.Point(422, 3);
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
            this.BtnRefresh.Location = new System.Drawing.Point(332, 3);
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
            this.BtnSupprimer.Size = new System.Drawing.Size(143, 72);
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
            this.BtnEditer.Click += new System.EventHandler(this.BtnEditer_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(844, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DateSession
            // 
            this.DateSession.BackColor = System.Drawing.Color.White;
            this.DateSession.BorderRadius = 1;
            this.DateSession.Color = System.Drawing.Color.Silver;
            this.DateSession.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DateSession.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DateSession.DisabledColor = System.Drawing.Color.Gray;
            this.DateSession.DisplayWeekNumbers = false;
            this.DateSession.DPHeight = 0;
            this.DateSession.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateSession.FillDatePicker = false;
            this.DateSession.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateSession.ForeColor = System.Drawing.Color.Black;
            this.DateSession.Icon = ((System.Drawing.Image)(resources.GetObject("DateSession.Icon")));
            this.DateSession.IconColor = System.Drawing.Color.Gray;
            this.DateSession.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DateSession.LeftTextMargin = 5;
            this.DateSession.Location = new System.Drawing.Point(266, 587);
            this.DateSession.MinimumSize = new System.Drawing.Size(4, 32);
            this.DateSession.Name = "DateSession";
            this.DateSession.Size = new System.Drawing.Size(222, 32);
            this.DateSession.TabIndex = 54;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(324, 267);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(258, 44);
            this.LblTitle.TabIndex = 53;
            this.LblTitle.Text = "Ajouter Session";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_cancel_40;
            this.button2.Location = new System.Drawing.Point(708, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 80);
            this.button2.TabIndex = 52;
            this.button2.Text = "Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = global::Gestion_Auto_Ecole.Properties.Resources.icons8_save_40;
            this.BtnSave.Location = new System.Drawing.Point(618, 446);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(84, 80);
            this.BtnSave.TabIndex = 51;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // LblDateVisite
            // 
            this.LblDateVisite.AutoSize = true;
            this.LblDateVisite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateVisite.ForeColor = System.Drawing.Color.White;
            this.LblDateVisite.Location = new System.Drawing.Point(124, 587);
            this.LblDateVisite.Name = "LblDateVisite";
            this.LblDateVisite.Size = new System.Drawing.Size(54, 28);
            this.LblDateVisite.TabIndex = 48;
            this.LblDateVisite.Text = "Date";
            // 
            // LblKm
            // 
            this.LblKm.AutoSize = true;
            this.LblKm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKm.ForeColor = System.Drawing.Color.White;
            this.LblKm.Location = new System.Drawing.Point(124, 508);
            this.LblKm.Name = "LblKm";
            this.LblKm.Size = new System.Drawing.Size(96, 28);
            this.LblKm.TabIndex = 47;
            this.LblKm.Text = "Moniteur";
            // 
            // PnlKm
            // 
            this.PnlKm.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlKm.Controls.Add(this.TxtMoniteur);
            this.PnlKm.Location = new System.Drawing.Point(266, 516);
            this.PnlKm.Name = "PnlKm";
            this.PnlKm.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PnlKm.Size = new System.Drawing.Size(190, 20);
            this.PnlKm.TabIndex = 46;
            // 
            // TxtMoniteur
            // 
            this.TxtMoniteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMoniteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMoniteur.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMoniteur.Location = new System.Drawing.Point(0, 0);
            this.TxtMoniteur.MaxLength = 10;
            this.TxtMoniteur.Name = "TxtMoniteur";
            this.TxtMoniteur.Size = new System.Drawing.Size(190, 18);
            this.TxtMoniteur.TabIndex = 0;
            // 
            // LblMatricule
            // 
            this.LblMatricule.AutoSize = true;
            this.LblMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatricule.ForeColor = System.Drawing.Color.White;
            this.LblMatricule.Location = new System.Drawing.Point(124, 448);
            this.LblMatricule.Name = "LblMatricule";
            this.LblMatricule.Size = new System.Drawing.Size(81, 28);
            this.LblMatricule.TabIndex = 45;
            this.LblMatricule.Text = "Session";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.ForeColor = System.Drawing.Color.White;
            this.LblNom.Location = new System.Drawing.Point(124, 374);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(41, 28);
            this.LblNom.TabIndex = 43;
            this.LblNom.Text = "Cin";
            // 
            // PnlNom
            // 
            this.PnlNom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlNom.Controls.Add(this.TxtCin);
            this.PnlNom.Location = new System.Drawing.Point(266, 380);
            this.PnlNom.Name = "PnlNom";
            this.PnlNom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.PnlNom.Size = new System.Drawing.Size(190, 20);
            this.PnlNom.TabIndex = 42;
            // 
            // TxtCin
            // 
            this.TxtCin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCin.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCin.Location = new System.Drawing.Point(0, 0);
            this.TxtCin.MaxLength = 8;
            this.TxtCin.Name = "TxtCin";
            this.TxtCin.Size = new System.Drawing.Size(190, 18);
            this.TxtCin.TabIndex = 0;
            // 
            // PnlMatricule
            // 
            this.PnlMatricule.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlMatricule.Controls.Add(this.BoxSession);
            this.PnlMatricule.Location = new System.Drawing.Point(266, 448);
            this.PnlMatricule.Name = "PnlMatricule";
            this.PnlMatricule.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.PnlMatricule.Size = new System.Drawing.Size(190, 20);
            this.PnlMatricule.TabIndex = 44;
            // 
            // BoxSession
            // 
            this.BoxSession.FormattingEnabled = true;
            this.BoxSession.Items.AddRange(new object[] {
            "Code",
            "Conduit"});
            this.BoxSession.Location = new System.Drawing.Point(0, -2);
            this.BoxSession.Name = "BoxSession";
            this.BoxSession.Size = new System.Drawing.Size(190, 24);
            this.BoxSession.TabIndex = 35;
            // 
            // Programme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.DgvProgramme);
            this.Controls.Add(this.DateSession);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblDateVisite);
            this.Controls.Add(this.LblKm);
            this.Controls.Add(this.PnlKm);
            this.Controls.Add(this.LblMatricule);
            this.Controls.Add(this.PnlMatricule);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.PnlNom);
            this.Controls.Add(this.TablePnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Programme";
            this.Text = "Programme";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProgramme)).EndInit();
            this.TablePnlTop.ResumeLayout(false);
            this.TablePnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlKm.ResumeLayout(false);
            this.PnlKm.PerformLayout();
            this.PnlNom.ResumeLayout(false);
            this.PnlNom.PerformLayout();
            this.PnlMatricule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moniteur;
        private System.Windows.Forms.TableLayoutPanel TablePnlTop;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnEditer;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDatePicker DateSession;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblDateVisite;
        private System.Windows.Forms.Label LblKm;
        private System.Windows.Forms.Panel PnlKm;
        private System.Windows.Forms.TextBox TxtMoniteur;
        private System.Windows.Forms.Label LblMatricule;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Panel PnlNom;
        private System.Windows.Forms.TextBox TxtCin;
        private System.Windows.Forms.Panel PnlMatricule;
        private System.Windows.Forms.ComboBox BoxSession;
    }
}