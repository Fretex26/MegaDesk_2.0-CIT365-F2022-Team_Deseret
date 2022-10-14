using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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
            double materialPrice = 0;

            //Asign the price to the materialPrice variable according to the material
            switch (material)
            {
                case Desk.DesktopMaterial.Oak:
                    materialPrice = 200;
                    break;

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

            return GetRushOrder(area, rushDays) + price;
        }
        private double GetRushOrder(double area, double rushDays)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                double rushPrice = 0;
                int[,] rushPrices = new int[3, 3];
                using (StreamReader sr = new StreamReader("rushOrderPrices.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            line = sr.ReadLine();
                            rushPrices[i, j] = Convert.ToInt32(line);
                        }
                    }
                }

                //Adds to the price the amount of money according to the rush Order, if no option was selected it just ignores all of this
                switch (rushDays)
                {
                    case 3:
                        if (area < 1000)
                            rushPrice = rushPrices[0, 0];
                        else if (area < 2001)
                            rushPrice = rushPrices[0, 1];
                        else if (area > 2000)
                            rushPrice = rushPrices[0, 2];
                        break;

                    case 5:
                        if (area < 1000)
                            rushPrice = rushPrices[1, 0];
                        else if (area < 2001)
                            rushPrice = rushPrices[1, 1];
                        else if (area > 2000)
                            rushPrice = rushPrices[1, 2];
                        break;

                    case 7:
                        if (area < 1000)
                            rushPrice = rushPrices[2, 0];
                        else if (area < 2001)
                            rushPrice = rushPrices[2, 1];
                        else if (area > 2000)
                            rushPrice = rushPrices[2, 2];
                        break;

                    default:
                        break;
                }
                return rushPrice;

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read because:");
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
