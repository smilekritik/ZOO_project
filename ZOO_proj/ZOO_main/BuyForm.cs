using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOO_main
{
    public partial class BuyForm : Form
    {
        List<Ticket> _ticketsAll = new List<Ticket>();
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {

        }

        private void BuyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("tickets.dat", FileMode.Create))
            {

                binaryFormatter.Serialize(fs, _ticketsAll);

            }

        }

        private void BuyTicketButton_Click_1(object sender, EventArgs e)
        {
            Aviary _aviary;
            Ticket _ticket;
            try
            {
                _ticket = new Ticket(NameBox.Text, SonameBox.Text, dateTimePicker1.Value);
                if (ZooListBox.CheckedItems.Contains("Земноводних тварин") == true || ZooListBox.CheckedItems.Contains("Птахів") == true)
                {
                    decimal total = numericUpDown1.Value;
                    if (ZooListBox.CheckedItems.Contains("Земноводних тварин") == true)
                    {
                        _aviary = new Aviary("Земноводних тварин", total);
                        _ticket.AddAviary(_aviary);
                    }
                    if(ZooListBox.CheckedItems.Contains("Птахів") == true)
                    {
                        _aviary = new Aviary("Птахів", total);
                        _ticket.AddAviary(_aviary);
                    }
                    _ticketsAll.Add(_ticket);
                    lbinfo.Text = "";
                    lbinfo.Text = "Ваш квиток: " + _ticket.GetPerson().GetInfo() + " " + _ticket.GetAviaryInfo();
                    MessageBox.Show("Дякуємо за придбаний білет!");
                }
                else
                {
                    MessageBox.Show("Ви повинні обрати хочаб одних тварин!");
                }
                
            }
            catch (PersonException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}" + $" Ви ввели  { ex.Name }" );
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SonameBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ZooListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbinfo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
