using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Barragan
{
    internal class DeskQuote
    {
        public Desk desk;
        public double rushDays;
        public string customerName;
        public string quoteDate;
        public double total;

        public DeskQuote(Desk desk, double rushDays, string customerName, string quoteDate)
        {
            this.desk = desk;
            this.rushDays = rushDays;
            this.customerName = customerName;
            this.quoteDate = quoteDate;
            this.total = getDeskQuoteTotalPrice(desk, rushDays);
        }

        private double getDeskQuoteTotalPrice(Desk desk, double rushDays)
        {
            double basePrice = 200;
            double width = desk.width;
            double depth = desk.depth;
            double numOfDrawers = desk.numberOfDrawers;
            double drawersPrice = 50;
            Desk.DesktopMaterial material = desk.material;
            double rushOrder = rushDays;
            double materialPrice = 0;

            //Asign the price to the materialPrice variable according to the material
            switch (material)
            {
                case Desk.DesktopMaterial.Laminate:
                    materialPrice = 100;
                    break;

                case Desk.DesktopMaterial.Pine:
                    materialPrice = 50;
                    break;

                case Desk.DesktopMaterial.Rosewood:
                    materialPrice = 300;
                    break;

                case Desk.DesktopMaterial.Veneer:
                    materialPrice = 125;
                    break;
            }

            double area = width * depth;

            double price = basePrice + (numOfDrawers * drawersPrice) + materialPrice;

            if (area > 1000)
            {
                price = price + area;
            }

            //Adds to the price the amount of money according to the rush Order, if no option was selected it just ignores all of this
            switch (rushOrder)
            {
                case 3:
                    if (area < 1000)
                        price = price + 60;
                    else if (area < 2001)
                        price = price + 70;
                    else if (area > 2000)
                        price = price + 80;
                    break;

                case 5:
                    if (area < 1000)
                        price = price + 40;
                    else if (area < 2001)
                        price = price + 50;
                    else if (area > 2000)
                        price = price + 60;
                    break;

                case 7:
                    if (area < 1000)
                        price = price + 30;
                    else if (area < 2001)
                        price = price + 35;
                    else if (area > 2000)
                        price = price + 40;
                    break;

                default:
                    break;
            }

            return price;

        }
    }
}
