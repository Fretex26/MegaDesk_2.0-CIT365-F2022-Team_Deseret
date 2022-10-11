using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Barragan
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void add_New_Quote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Show();
            this.Hide();
        }

        private void view_Quote_Click(object sender, EventArgs e)
        {
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Show();
            this.Hide();
        }

        private void search_Quotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes searchQuotes = new ViewAllQuotes();
            searchQuotes.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
