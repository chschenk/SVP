﻿namespace SVP
{
    partial class TabShowMember
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.btn_editMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dvResults = new System.Windows.Forms.DataGridView();
            this.seq_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reevaluate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbExport = new System.Windows.Forms.GroupBox();
            this.btnShowOnMonitor = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dvAwards = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).BeginInit();
            this.gbExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAwards)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.btn_editMember);
            this.gbMember.Controls.Add(this.label2);
            this.gbMember.Controls.Add(this.label1);
            this.gbMember.Controls.Add(this.cbMember);
            this.gbMember.Controls.Add(this.cbClub);
            this.gbMember.Controls.Add(this.btnLoad);
            this.gbMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMember.Location = new System.Drawing.Point(0, 0);
            this.gbMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMember.Name = "gbMember";
            this.gbMember.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMember.Size = new System.Drawing.Size(828, 94);
            this.gbMember.TabIndex = 0;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Mitglied";
            // 
            // btn_editMember
            // 
            this.btn_editMember.Enabled = false;
            this.btn_editMember.Location = new System.Drawing.Point(356, 47);
            this.btn_editMember.Name = "btn_editMember";
            this.btn_editMember.Size = new System.Drawing.Size(93, 23);
            this.btn_editMember.TabIndex = 21;
            this.btn_editMember.Text = "Bearbeiten";
            this.btn_editMember.UseVisualStyleBackColor = true;
            this.btn_editMember.Click += new System.EventHandler(this.btn_editMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mitglied:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Verein:";
            // 
            // cbMember
            // 
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(54, 50);
            this.cbMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(198, 21);
            this.cbMember.TabIndex = 18;
            this.cbMember.SelectedIndexChanged += new System.EventHandler(this.cbMember_SelectedIndexChanged);
            // 
            // cbClub
            // 
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(54, 26);
            this.cbClub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(198, 21);
            this.cbClub.TabIndex = 17;
            this.cbClub.SelectedIndexChanged += new System.EventHandler(this.cbClub_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(256, 47);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(93, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "OK";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dvResults
            // 
            this.dvResults.AllowUserToAddRows = false;
            this.dvResults.AllowUserToDeleteRows = false;
            this.dvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seq_date,
            this.Price,
            this.Profil,
            this.Rings,
            this.Reevaluate});
            this.dvResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvResults.Location = new System.Drawing.Point(0, 94);
            this.dvResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvResults.Name = "dvResults";
            this.dvResults.ReadOnly = true;
            this.dvResults.RowHeadersVisible = false;
            this.dvResults.RowTemplate.Height = 28;
            this.dvResults.Size = new System.Drawing.Size(828, 198);
            this.dvResults.TabIndex = 1;
            // 
            // seq_date
            // 
            this.seq_date.HeaderText = "Datum";
            this.seq_date.Name = "seq_date";
            this.seq_date.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Pokal";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Profil
            // 
            this.Profil.HeaderText = "Profil";
            this.Profil.Name = "Profil";
            this.Profil.ReadOnly = true;
            // 
            // Rings
            // 
            this.Rings.HeaderText = "Ringe";
            this.Rings.Name = "Rings";
            this.Rings.ReadOnly = true;
            // 
            // Reevaluate
            // 
            this.Reevaluate.HeaderText = "Nachgewertet";
            this.Reevaluate.Name = "Reevaluate";
            this.Reevaluate.ReadOnly = true;
            // 
            // gbExport
            // 
            this.gbExport.Controls.Add(this.btnShowOnMonitor);
            this.gbExport.Controls.Add(this.btnExport);
            this.gbExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbExport.Location = new System.Drawing.Point(0, 515);
            this.gbExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbExport.Name = "gbExport";
            this.gbExport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbExport.Size = new System.Drawing.Size(828, 54);
            this.gbExport.TabIndex = 2;
            this.gbExport.TabStop = false;
            this.gbExport.Text = "Exportieren";
            // 
            // btnShowOnMonitor
            // 
            this.btnShowOnMonitor.Location = new System.Drawing.Point(588, 18);
            this.btnShowOnMonitor.Name = "btnShowOnMonitor";
            this.btnShowOnMonitor.Size = new System.Drawing.Size(136, 23);
            this.btnShowOnMonitor.TabIndex = 16;
            this.btnShowOnMonitor.Text = "Alle auf Monitor anzeigen";
            this.btnShowOnMonitor.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(730, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Exportieren";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dvAwards
            // 
            this.dvAwards.AllowUserToAddRows = false;
            this.dvAwards.AllowUserToDeleteRows = false;
            this.dvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.PriceName,
            this.Date});
            this.dvAwards.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvAwards.Location = new System.Drawing.Point(0, 292);
            this.dvAwards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvAwards.Name = "dvAwards";
            this.dvAwards.ReadOnly = true;
            this.dvAwards.RowHeadersVisible = false;
            this.dvAwards.RowTemplate.Height = 28;
            this.dvAwards.Size = new System.Drawing.Size(828, 127);
            this.dvAwards.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.HeaderText = "Typ";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // PriceName
            // 
            this.PriceName.HeaderText = "Name";
            this.PriceName.Name = "PriceName";
            this.PriceName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Datum";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TabShowMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvAwards);
            this.Controls.Add(this.gbExport);
            this.Controls.Add(this.dvResults);
            this.Controls.Add(this.gbMember);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TabShowMember";
            this.Size = new System.Drawing.Size(828, 569);
            this.Load += new System.EventHandler(this.TabShowCompetition_Load);
            this.Enter += new System.EventHandler(this.TabShowCompetition_Enter);
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).EndInit();
            this.gbExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvAwards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.DataGridView dvResults;
        private System.Windows.Forms.GroupBox gbExport;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShowOnMonitor;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Button btn_editMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reevaluate;
    }
}
