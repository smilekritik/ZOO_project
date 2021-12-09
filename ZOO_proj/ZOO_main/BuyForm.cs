﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOO_main
{
    public partial class BuyForm : Form
    {
        Ticket _ticket;
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {

        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            Aviary _aviary;
            //BeerCheckBox.Checked

            try
            {
                _ticket = new Ticket(NameBox.Text, SonameBox.Text);
            }
            catch (PersonException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}" + $" Ви ввели  { ex.Name }" );
            }
            finally { }
            
            if (ZooListBox.CheckedItems.Contains("Земноводні") == true)
            {
                _aviary = new Aviary("Земноводні");
                _ticket.AddAviary(_aviary);
                //_ticket.GetInfo();
                //_ticket.GetPerson().GetInfo()
                MessageBox.Show(_ticket.GetPerson().GetInfo() + "  amphibians");
            }
            else
            {
                _aviary = new Aviary("Птиці");
                _ticket = new Ticket(NameBox.Text, SonameBox.Text, _aviary);
                MessageBox.Show(_ticket.GetPerson().GetInfo() + "  birds");
            }

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SonameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BeerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LionCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WolfCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ZooListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
