using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelector
{
    public partial class Form1 : Form
    {
        public int Days = 0;
        public int RegCost = 0;
        public int LodgeRate = 0;
        public int LodgeCost = 0;
        public int TotCost = 0;

        /*
        LodgeCost = Days * LodgeRate
        TotCost = RegCost + LodgeCost
        */

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotCost_Click(object sender, EventArgs e)
        {

        }
        
        //workshops
        private void listWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWorkshops.SelectedIndex != -1)
            {
                //Handling Stress
                if (listWorkshops.SelectedItem.ToString() == "Handling Stress"){
                    Days = 3;
                    RegCost = 1000;
                }
                //Time Management
                if (listWorkshops.SelectedItem.ToString() == "Time Management")
                {
                    Days = 3;
                    RegCost = 800;
                }
                //Supervision Skills
                if (listWorkshops.SelectedItem.ToString() == "Supervision Skills")
                {
                    Days = 3;
                    RegCost = 1500;
                }
                //Negotiation
                if (listWorkshops.SelectedItem.ToString() == "Negotiation")
                {
                    Days = 5;
                    RegCost = 1300;
                }
                //How To Interview
                if (listWorkshops.SelectedItem.ToString() == "How To Interview")
                {
                    Days = 1;
                    RegCost = 500;
                }
            }
        }

        //cities
        private void listCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCities.SelectedIndex != -1)
            {
                //Austin
                if (listCities.SelectedItem.ToString() == "Austin")
                {
                    LodgeRate = 150;
                }
                //Chicago
                if (listCities.SelectedItem.ToString() == "Chicago")
                {
                    LodgeRate = 225;
                }
                //Dallas
                if (listCities.SelectedItem.ToString() == "Dallas")
                {
                    LodgeRate = 175;
                }
                //Orlando
                if (listCities.SelectedItem.ToString() == "Orlando")
                {
                    LodgeRate = 300;
                }
                //Phoenix
                if (listCities.SelectedItem.ToString() == "Phoenix")
                {
                    LodgeRate = 175;
                }
                //Raleigh
                if (listCities.SelectedItem.ToString() == "Raleigh")
                {
                    LodgeRate = 150;
                }
            }
        }

        //calculate button
        private void btnCalc_Click(object sender, EventArgs e)
        {
            LodgeCost = Days * LodgeRate;
            TotCost = RegCost + LodgeCost;

            lblRegCost.Text = "$" + RegCost;
            lblLodCost.Text = "$" + LodgeRate + " per night x " + Days+  " days = "+  LodgeCost;
            lblTotCost.Text = "$" + TotCost;

        }

    }
}
