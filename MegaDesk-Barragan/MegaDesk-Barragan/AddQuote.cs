using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Barragan
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        //To check if the input in int
        private bool CheckInt(string answer)
        {
            try
            {
                int isint = Convert.ToInt32(answer);
                return isint >= 0;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error is: {e.Message}");
                return false;
            }
        }

        //To check whatever limits we need
        private bool CheckLimits(string answer, int minlimit, int maxlimit)
        {
            try 
            {
                int number = Convert.ToInt32(answer);
                if (number < minlimit)
                    return true;
                else if (number > maxlimit)
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                return false;
            }

        }
        //The Next three functions are to check limits and numbers on the with depth and drawers text box
        private void withTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!CheckInt(withTextBox.Text))
            {
                errorWidth.Text = "Please Just numbers";
            }
            else
            {
                errorWidth.Text = "";
            }

            if ( CheckLimits(withTextBox.Text, 24, 96))
                errorWidth.Text = "Betwen 24 and 96 please";
        }

        private void depthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!CheckInt(depthTextBox.Text))
            {
                errorDepth.Text = "Please Just numbers";
            }
            else
            {
                errorDepth.Text = "";
            }

            if (CheckLimits(depthTextBox.Text, 12, 48))
                errorDepth.Text = "Betwen 12 and 48 please";
        }

        private void drawersTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!CheckInt(drawersTextBox.Text))
            {
                errorDrawers.Text = "Please Just numbers";
            }
            else
            {
                errorDrawers.Text = "";
            }

            if (CheckLimits(drawersTextBox.Text, 0, 7))
                errorDrawers.Text = "Betwen 0 and 7 please";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        
        private void submitQuote_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            //Desk creation
            Desk desk = new Desk(
                Convert.ToDouble(withTextBox.Text),
                Convert.ToDouble(depthTextBox.Text),
                Convert.ToDouble(drawersTextBox.Text), 
                materialUpDown.Text);

            //If they choose Normal or don't choose any thing for the rush option
            if (CheckInt(rushOrderTextBox.Text))
                Convert.ToDouble(rushOrderTextBox.Text);
            else
                rushOrderTextBox.Text = "14";

            //DeskQuote creation
            DeskQuote deskQuote = new DeskQuote(
                desk,
                Convert.ToDouble(rushOrderTextBox.Text),
                custName.Text,
                today.ToString("dd MMMM yyyy")
                );

            //Serializing data to JSON file
            string jsonCreate = JsonConvert.SerializeObject(deskQuote);
            string jsonFile = @"quotes.json";

            //Sending data to be desplayed in the Display Quote View
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.customerName.Text = custName.Text;
            displayQuote.width.Text = withTextBox.Text;
            displayQuote.depth.Text = depthTextBox.Text;
            displayQuote.numOfDrawers.Text = drawersTextBox.Text;
            displayQuote.material.Text = materialUpDown.Text;
            displayQuote.rushOrder.Text = rushOrderTextBox.Text;
            displayQuote.quoteDate.Text = today.ToString("dd MMMM yyyy");
            displayQuote.quoteAmount.Text = ($"${deskQuote.total.ToString()}");   

            displayQuote.Show();
            this.Close();
        }

        //To avoid letters in the depth field
        private void depthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && !char.IsControl(c))
            {
                e.Handled = true;
            }
        }

        private void materialUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
