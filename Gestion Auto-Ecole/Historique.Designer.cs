namespace Gestion_Auto_Ecole
{
    partial class Historique
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historique));
            this.DgvHistorique = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbrInscri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antecedent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlEtat = new System.Windows.Forms.Panel();
            this.TxtAntecedent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNbr = new System.Windows.Forms.TextBox();
            this.BoxInscri = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TablePnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorique)).BeginInit();
            this.PnlEtat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TablePnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvHistorique
            // 
            this.DgvHistorique.AllowUserToAddRows = false;
            this.DgvHistorique.AllowUserToDeleteRows = false;
            this.DgvHistorique.AllowUserToResizeColumns = false;
            this.DgvHistorique.AllowUserToResizeRows = false;
            this.DgvHistorique.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DgvHistorique.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHistorique.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvHistorique.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistorique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Age,
            this.Inscription,
            this.NbrInscri,
            this.Antecedent});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHistorique.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvHistorique.EnableHeadersVisualStyles = false;
            this.DgvHistorique.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.DgvHistorique.Location = new System.Drawing.Point(0, 118);
            this.DgvHistorique.MultiSelect = false;
            this.DgvHistorique.Name = "DgvHistorique";
            this.DgvHistorique.ReadOnly = true;
            this.DgvHistorique.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvHistorique.RowHeadersVisible = false;
            this.DgvHistorique.RowHeadersWidth = 51;
            this.DgvHistorique.RowTemplate.DividerHeight = 2;
            this.DgvHistorique.RowTemplate.Height = 30;
            this.DgvHistorique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHistorique.Size = new System.Drawing.Size(950, 554);
            this.DgvHistorique.TabIndex = 6;
            this.DgvHistorique.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistorique_CellContentClick);
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
            // Inscription
            // 
            this.Inscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inscription.HeaderText = "Inscription";
            this.Inscription.MinimumWidth = 6;
            this.Inscription.Name = "Inscription";
            this.Inscription.ReadOnly = true;
            // 
            // NbrInscri
            // 
            this.NbrInscri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NbrInscri.HeaderText = "Nombre d\'inscription";
            this.NbrInscri.MinimumWidth = 6;
            this.NbrInscri.Name = "NbrInscri";
            this.NbrInscri.ReadOnly = true;
            // 
            // Antecedent
            // 
            this.Antecedent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Antecedent.HeaderText = "Antécedent";
            this.Antecedent.MinimumWidth = 6;
            this.Antecedent.Name = "Antecedent";
            this.Antecedent.ReadOnly = true;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(329, 299);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(286, 41);
            this.LblTitle.TabIndex = 31;
            this.LblTitle.Text = "Modifier Historique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(513, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Antécedent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Inscription";
            // 
            // PnlEtat
            // 
            this.PnlEtat.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlEtat.Controls.Add(this.TxtAntecedent);
            this.PnlEtat.ForeColor = System.Drawing.Color.White;
            this.PnlEtat.Location = new System.Drawing.Point(632, 391);
            this.PnlEtat.Name = "PnlEtat";
            this.PnlEtat.Size = new System.Drawing.Size(190, 20);
            this.PnlEtat.TabIndex = 28;
            // 
            // TxtAntecedent
            // 
            this.TxtAntecedent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAntecedent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAntecedent.Location = new System.Drawing.Point(0, 0);
            this.TxtAntecedent.MaxLength = 15;
            this.TxtAntecedent.Name = "TxtAntecedent";
            this.TxtAntecedent.Size = new System.Drawing.Size(190, 15);
            this.TxtAntecedent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre d\'inscription";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.TxtNbr);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(225, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 20);
            this.panel1.TabIndex = 32;
            // 
            // TxtNbr
            // 
            this.TxtNbr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNbr.Location = new System.Drawing.Point(0, 0);
            this.TxtNbr.MaxLength = 2;
            this.TxtNbr.Name = "TxtNbr";
            this.TxtNbr.Size = new System.Drawing.Size(190, 15);
            this.TxtNbr.TabIndex = 0;
            // 
            // BoxInscri
            // 
            this.BoxInscri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxInscri.FormattingEnabled = true;
            this.BoxInscri.Items.AddRange(new object[] {
            "1ére Inscription",
            "Re-inscription"});
            this.BoxInscri.Location = new System.Drawing.Point(225, 386);
            this.BoxInscri.Name = "BoxInscri";
            this.BoxInscri.Size = new System.Drawing.Size(190, 24);
            this.BoxInscri.TabIndex = 34;
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(709, 486);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(102, 80);
            this.BtnCancel.TabIndex = 36;
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
            this.BtnSave.Location = new System.Drawing.Point(576, 486);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 80);
            this.BtnSave.TabIndex = 35;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TablePnlTop
            // 
            this.TablePnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TablePnlTop.ColumnCount = 7;
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.TablePnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.TablePnlTop.Controls.Add(this.BtnEdit, 0, 0);
            this.TablePnlTop.Controls.Add(this.BtnPrint, 3, 0);
            this.TablePnlTop.Controls.Add(this.BtnRefresh, 2, 0);
            this.TablePnlTop.Controls.Add(this.BtnDelete, 1, 0);
            this.TablePnlTop.Controls.Add(this.TxtSearch, 1, 1);
            this.TablePnlTop.Controls.Add(this.pictureBox1, 6, 1);
            this.TablePnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TablePnlTop.Location = new System.Drawing.Point(0, 0);
            this.TablePnlTop.Name = "TablePnlTop";
            this.TablePnlTop.RowCount = 2;
            this.TablePnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.20472F));
            this.TablePnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.79528F));
            this.TablePnlTop.Size = new System.Drawing.Size(950, 127);
            this.TablePnlTop.TabIndex = 37;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(3, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(84, 72);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Editer";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrint.FlatAppearance.BorderSize = 0;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(414, 3);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(84, 72);
            this.BtnPrint.TabIndex = 3;
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
            this.BtnRefresh.Location = new System.Drawing.Point(243, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(165, 72);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(93, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(144, 72);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
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
            this.pictureBox1.Location = new System.Drawing.Point(841, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.DgvHistorique);
            this.Controls.Add(this.TablePnlTop);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BoxInscri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlEtat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historique";
            this.Text = "Historique";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorique)).EndInit();
            this.PnlEtat.ResumeLayout(false);
            this.PnlEtat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TablePnlTop.ResumeLayout(false);
            this.TablePnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvHistorique;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlEtat;
        private System.Windows.Forms.TextBox TxtAntecedent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtNbr;
        private System.Windows.Forms.ComboBox BoxInscri;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TableLayoutPanel TablePnlTop;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbrInscri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antecedent;
    }
}