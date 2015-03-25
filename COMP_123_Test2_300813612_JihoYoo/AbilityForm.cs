﻿/* 
 *  File Name: COMP_123_Test2_300813612_JihoYoo 
 *  Author's name: Jiho Yoo 
 *  Date : 3/25/2015 
 *  App description : Randomly generates a role-­‐playing character’s ability scores. 
 *
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_123_Test2_300813612_JihoYoo
{
    public partial class AbilityForm : Form
    {
        Random rnd = new Random(); //Random Key

        //Private instance valiables
        private int fighting;
        private int agililty;
        private int strength;
        private int endurance;       
        private int reason;
        private int intuition;
        private int psyche;


        //Constructor 
        public AbilityForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Event Handler in the AbilityForm’s code.
        private void RollButton_Click(object sender, EventArgs e)
        {

            //set up random numbers from 1 to 100.
            fighting = rnd.Next(1, 101);
            agililty = rnd.Next(1, 101);
            strength = rnd.Next(1, 101);
            endurance = rnd.Next(1, 101);
            reason = rnd.Next(1, 101);
            intuition = rnd.Next(1, 101);
            psyche = rnd.Next(1, 101);

            //TextBoxs convert to string for each valiables
            FightingTextBox.Text = Convert.ToString(fighting);
            AgilityTextBox.Text = Convert.ToString(agililty);
            StrengthTextBox.Text = Convert.ToString(strength);
            EnduranceTextBox.Text = Convert.ToString(endurance);
            ReasonTextBox.Text = Convert.ToString(reason);
            IntuitionTextBox.Text = Convert.ToString(intuition);
            PsycheTextBox.Text = Convert.ToString(psyche);
            
            
           

        }

        private void AgilityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PsycheLabel_Click(object sender, EventArgs e)
        {

        }

        private void IntuitionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IntuitionLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReasonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReasonLabel_Click(object sender, EventArgs e)
        {

        }

        private void StrengthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StrengthLabel_Click(object sender, EventArgs e)
        {

        }

        private void PsycheTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgilityLabel_Click(object sender, EventArgs e)
        {

        }

        private void FightingTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
