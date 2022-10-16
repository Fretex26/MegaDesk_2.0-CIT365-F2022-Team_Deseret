using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_Barragan.Desk;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MegaDesk_Barragan
{
    public partial class AddQuote : Form
    {

        #region Add Quote Variables
        public string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        Desk.Material Material;
        int RushDays = 0;
        int QuoteTotal;
        #endregion

        public AddQuote()
        {
            InitializeComponent();
            List<Desk.Material> MaterialList = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
            //materialUpDown = MaterialList;
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
            Desk desk = new Desk();

            //New Code - Angela
            DateTime today = DateTime.Now;
            CustomerName = custName.Text;
            DeskWidth = int.Parse(withTextBox.Text);
            DeskDepth = int.Parse(depthTextBox.Text);
            Drawers = int.Parse(drawersTextBox.Text);
            //Material = (Desk.Material)materialUpDown.SelectedItem;
            if (rushOrderTextBox.Text == "3" ||
                rushOrderTextBox.Text == "5" ||
                rushOrderTextBox.Text == "7")
                RushDays = int.Parse(rushOrderTextBox.Text);
            else
                RushDays = 14;
            int DesktopMaterial = 0;

            switch (materialUpDown.SelectedItem)
            {
                case "Laminate":
                    DesktopMaterial = (int)Desk.Material.Laminate;
                    break;
                case "Oak":
                    DesktopMaterial = (int)Desk.Material.Oak;
                    break;
                case "Rosewood":
                    DesktopMaterial = (int)Desk.Material.Rosewood;
                    break;
                case "Veneer":
                    DesktopMaterial = (int)Desk.Material.Veneer;
                    break;
                case "Pine":
                    DesktopMaterial = (int)Desk.Material.Pine;
                    break;
            }

            DeskQuote NewQuote = new DeskQuote(CustomerName, today, DeskWidth, DeskDepth, Drawers, DesktopMaterial, RushDays);
            QuoteTotal = NewQuote.CalcQuote();

            //Serializing data to JSON file
            string jsonWrite = JsonConvert.SerializeObject(NewQuote);
            const string jsonFile = @"quotes\quotes.json";
            Console.WriteLine(jsonFile);

            if (!File.Exists(jsonFile))
            {
                using (StreamWriter sw = File.CreateText(jsonFile)) { }
            }
            using (StreamWriter swa = File.AppendText(jsonFile)) { swa.WriteLine(jsonWrite); }

            MessageBox.Show("Quote Submitted");

            //old code
            /*            DateTime today = DateTime.Now;

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
                            );*/

            //Sending data to be desplayed in the Display Quote View
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.customerName.Text = custName.Text;
            displayQuote.width.Text = withTextBox.Text;
            displayQuote.depth.Text = depthTextBox.Text;
            displayQuote.numOfDrawers.Text = drawersTextBox.Text;
            displayQuote.material.Text = materialUpDown.Text;
            displayQuote.rushOrder.Text = rushOrderTextBox.Text;
            if (rushOrderTextBox.Text == "3" ||
                rushOrderTextBox.Text == "5" ||
                rushOrderTextBox.Text == "7")
                displayQuote.rushOrder.Text = rushOrderTextBox.Text;
            else
                displayQuote.rushOrder.Text = "14";
            displayQuote.quoteDate.Text = today.ToString("dd MMMM yyyy");
            displayQuote.quoteAmount.Text = ($"${NewQuote.total.ToString()}");   

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
