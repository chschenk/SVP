﻿namespace SVP
{
    partial class frmDetermineWinner
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
            this.dvResultList = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.placement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reevaluate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvResultList)).BeginInit();
            this.SuspendLayout();
            // 
            // dvResultList
            // 
            this.dvResultList.AllowUserToAddRows = false;
            this.dvResultList.AllowUserToDeleteRows = false;
            this.dvResultList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResultList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placement,
            this.memberName,
            this.Points,
            this.Reevaluate});
            this.dvResultList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvResultList.Location = new System.Drawing.Point(0, 0);
            this.dvResultList.Name = "dvResultList";
            this.dvResultList.RowHeadersVisible = false;
            this.dvResultList.Size = new System.Drawing.Size(710, 204);
            this.dvResultList.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(606, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // placement
            // 
            this.placement.HeaderText = "Plazierung";
            this.placement.Name = "placement";
            this.placement.ReadOnly = true;
            // 
            // memberName
            // 
            this.memberName.HeaderText = "Name";
            this.memberName.Name = "memberName";
            this.memberName.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.HeaderText = "Ringe";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // Reevaluate
            // 
            this.Reevaluate.HeaderText = "Erneut werten?";
            this.Reevaluate.Name = "Reevaluate";
            // 
            // frmDetermineWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 255);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dvResultList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDetermineWinner";
            this.ShowInTaskbar = false;
            this.Text = "Gewinner festlegen";
            this.Load += new System.EventHandler(this.frmDetermineWinner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvResultList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvResultList;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn placement;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reevaluate;
    }
}