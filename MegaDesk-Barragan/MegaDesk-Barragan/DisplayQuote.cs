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
    public partial class DisplayQuote : Form
    {
        public static DisplayQuote displayQuote;
        public Label customerName;
        public Label width;
        public Label depth;
        public Label numOfDrawers;
        public Label material;
        public Label rushOrder;
        public Label quoteDate;
        public Label quoteAmount;
        public DisplayQuote()
        {
            InitializeComponent();
            displayQuote = this;
            customerName = customer_NameFQ;
            width = desk_WidthFQ;
            depth = desk_DepthFQ;
            numOfDrawers = number_Of_DrawersFQ;
            material = desktop_MaterialFQ;
            rushOrder = rush_OrderFQ;
            quoteDate = currentDate;
            quoteAmount = price;
        }
    }
}
