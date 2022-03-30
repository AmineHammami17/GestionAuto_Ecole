namespace Gestion_Auto_Ecole
{
    partial class Tarifs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarifs));
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
            this.DgvTarifs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlNom = new System.Windows.Forms.Panel();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.TablePnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarifs)).BeginInit();
            this.PnlNom.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.TablePnlTop.TabIndex = 2;
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
            // DgvTarifs
            // 
            this.DgvTarifs.AllowUserToAddRows = false;
            this.DgvTarifs.AllowUserToDeleteRows = false;
            this.DgvTarifs.AllowUserToResizeColumns = false;
            this.DgvTarifs.AllowUserToResizeRows = false;
            this.DgvTarifs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DgvTarifs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvTarifs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvTarifs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTarifs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTarifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTarifs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Prix});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTarifs.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTarifs.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvTarifs.EnableHeadersVisualStyles = false;
            this.DgvTarifs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.DgvTarifs.Location = new System.Drawing.Point(0, 127);
            this.DgvTarifs.MultiSelect = false;
            this.DgvTarifs.Name = "DgvTarifs";
            this.DgvTarifs.ReadOnly = true;
            this.DgvTarifs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvTarifs.RowHeadersVisible = false;
            this.DgvTarifs.RowHeadersWidth = 51;
            this.DgvTarifs.RowTemplate.DividerHeight = 2;
            this.DgvTarifs.RowTemplate.Height = 30;
            this.DgvTarifs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTarifs.Size = new System.Drawing.Size(950, 561);
            this.DgvTarifs.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(336, 303);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(187, 41);
            this.LblTitle.TabIndex = 26;
            this.LblTitle.Text = "Ajouter Tarif";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(473, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 72);
            this.button2.TabIndex = 25;
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
            this.button1.Location = new System.Drawing.Point(330, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 72);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Type";
            // 
            // PnlNom
            // 
            this.PnlNom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlNom.Controls.Add(this.TxtType);
            this.PnlNom.ForeColor = System.Drawing.Color.White;
            this.PnlNom.Location = new System.Drawing.Point(206, 385);
            this.PnlNom.Name = "PnlNom";
            this.PnlNom.Size = new System.Drawing.Size(190, 20);
            this.PnlNom.TabIndex = 14;
            // 
            // TxtType
            // 
            this.TxtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtType.Location = new System.Drawing.Point(0, 0);
            this.TxtType.MaxLength = 15;
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(190, 15);
            this.TxtType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(502, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Prix";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.TxtPrix);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(590, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 20);
            this.panel1.TabIndex = 27;
            // 
            // TxtPrix
            // 
            this.TxtPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPrix.Location = new System.Drawing.Point(0, 0);
            this.TxtPrix.MaxLength = 10;
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(190, 15);
            this.TxtPrix.TabIndex = 0;
            // 
            // Tarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.DgvTarifs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlNom);
            this.Controls.Add(this.TablePnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tarifs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifs";
            this.TablePnlTop.ResumeLayout(false);
            this.TablePnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarifs)).EndInit();
            this.PnlNom.ResumeLayout(false);
            this.PnlNom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePnlTop;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnEditer;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvTarifs;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlNom;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPrix;
    }
}