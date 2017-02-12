﻿using DisagLib;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Web;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Net;

namespace SVP
{
    public partial class AddCompetitionWizard : Form
    {
        private competition myCompetition;
        public AddCompetitionWizard()
        {
            InitializeComponent();
        }

        private void startPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            myCompetition = new competition();
            //myCompetition.group = dfsg
        }

        private void addPricePage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(txtPriceName.Text.Length > 0)
            {
                myCompetition.price.Add(new price() { name = txtPriceName.Text });
                txtPriceName.Text = "";
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void addAwardPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtAwardName.Text.Length > 0)
            {
                //myCompetition.award.Add(new award() { name = txtAwardName.Text });
                txtAwardName.Text = "";
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void competitionOverviewPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbAddAward.Checked)
                competitionOverviewPage.NextPage = addAwardPage;
            else if (rbAddPrice.Checked)
                competitionOverviewPage.NextPage = addPricePage;
            else if (rbFinished.Checked)
                competitionOverviewPage.NextPage = null;
        }

        private void rbOverview_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddAward.Checked)
                competitionOverviewPage.NextPage = addAwardPage;
            else if (rbAddPrice.Checked)
                competitionOverviewPage.NextPage = addPricePage;
            else if (rbFinished.Checked)
                competitionOverviewPage.NextPage = null;
        }

        private void competitionOverviewPage_Enter(object sender, EventArgs e)
        {
            dvCompetition.Rows.Clear();
            foreach (award a in myCompetition.award)
            {
                DataGridViewRow row = new DataGridViewRow();
                //row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe" });
                dvCompetition.Rows.Add(row);
            }
            foreach (price p in myCompetition.price)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                dvCompetition.Rows.Add(row);
            }
        }
    }
}