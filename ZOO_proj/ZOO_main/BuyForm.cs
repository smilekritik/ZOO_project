using System;
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
            bool anyChoosed = false;
            Aviary _aviary;
            /* if (BeerCheckBox.Checked == true || FoxCheckBox.Checked == true || LionCheckBox.Checked == true || RiceCheckBox.Checked == true || WolfCheckBox.Checked == true)
             {
                 anyChoosed = true;
             }
             if (anyChoosed != true)
             {
                     MessageBox.Show("Будь-ласка, оберіть кого хочете відвідувати.");
             }*/

            _ticket = new Ticket(NameBox.Text, SonameBox.Text);
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
                //_ticket.GetInfo();
                //_ticket.GetPerson().GetInfo()
                MessageBox.Show(_ticket.GetPerson().GetInfo() + "  birds");
                //+ _ticket.GetAviary().GetInfo()
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
    }
}
