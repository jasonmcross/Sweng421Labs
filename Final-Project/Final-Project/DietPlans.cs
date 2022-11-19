﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class DietPlans : Form
    {
        public DietPlans()
        {
            InitializeComponent();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.mm.Show();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DietPlans_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newItemMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.adds.Show();
        }

        private void saveCBMI_Click(object sender, EventArgs e)
        {
            ListManager.SerializeLists();
            MessageBox.Show("Cookbook saved!");
        }

        private void closeMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchMI_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.ss.Show();
        }

        private void makeAMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.mam.Show();
        }

        private void entreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Entrees";
        }

        private void sideDishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Side Dishes";
        }

        private void dessertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Desserts";
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormManager.vs.Show();
            FormManager.vs.vsLbl.Text = "Snacks";
        }

        private void aboutMI_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void standardBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.category.Contains("Standard"));
            List<Recipe> resultsSides = ListManager.sideList.FindAll(x => x.category.Contains("Standard"));
            List<Recipe> resultsDesserts = ListManager.dessertList.FindAll(x => x.category.Contains("Standard"));
            List<Recipe> resultsSnacks = ListManager.snackList.FindAll(x => x.category.Contains("Standard"));
        }

        private void ketoBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.category.Contains("Keto"));
            List<Recipe> resultsSides = ListManager.sideList.FindAll(x => x.category.Contains("Keto"));
            List<Recipe> resultsDesserts = ListManager.dessertList.FindAll(x => x.category.Contains("Keto"));
            List<Recipe> resultsSnacks = ListManager.snackList.FindAll(x => x.category.Contains("Keto"));
        }

        private void sbBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.category.Contains("South Beach"));
            List<Recipe> resultsSides = ListManager.sideList.FindAll(x => x.category.Contains("South Beach"));
            List<Recipe> resultsDesserts = ListManager.dessertList.FindAll(x => x.category.Contains("South Beach"));
            List<Recipe> resultsSnacks = ListManager.snackList.FindAll(x => x.category.Contains("South Beach"));
        }

        private void sfBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> resultsEntree = ListManager.entreeList.FindAll(x => x.category.Contains("See Food"));
            List<Recipe> resultsSides = ListManager.sideList.FindAll(x => x.category.Contains("See Food"));
            List<Recipe> resultsDesserts = ListManager.dessertList.FindAll(x => x.category.Contains("See Food"));
            List<Recipe> resultsSnacks = ListManager.snackList.FindAll(x => x.category.Contains("See Food"));
        }
    }
}
