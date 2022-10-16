using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_Barragan.Desk;
using static MegaDesk_Barragan.ViewAllQuotes;

namespace MegaDesk_Barragan
{
    class DeskQuote
    {
        //new code - Angela
        #region Quote Variables
        public int rushDays;
        public string customerName;
        public DateTime quoteDate;
        public int total;
        public Desk Desk = new Desk();
        #endregion

        #region Quote Restraints
        private const int PRICE_BASE = 200;
        private const int SIZE_CAPACITY = 1000;
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_AREA = 1;
        private const int RUSH_CAPACITY = 2000;
        int materiale;
        #endregion

        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int numberOfDrawers, Desk.Material material, int rushDays)
        {
            customerName = customerName;
            quoteDate = quoteDate;
            Desk.width = width;
            Desk.depth = depth;
            Desk.numberOfDrawers = numberOfDrawers;
            materiale = Convert.ToInt32( material);
            this.rushDays = rushDays;

            //Desk Area
            Desk.Area = Desk.width * Desk.depth;
        }

        public int CalcQuote()
        {
            return total = PRICE_BASE + AreaCost() + DrawerCost() + (int)Desk.DesktopMaterial + RushCost();
        }

        private int AreaCost()
        {
            if (Desk.Area > SIZE_CAPACITY)
            {
                //return (Desk.Area - SIZE_CAPACITY) * PRICE_PER_AREA;
                return Desk.Area * PRICE_PER_AREA;
            }
            else
            {
                return 0;
            }
        }

        private int DrawerCost()
        {
            int DrawerCost = Desk.numberOfDrawers * PRICE_PER_DRAWER;
            return DrawerCost;
        }

        #region Rush Cost

        //insert code for rushorder text file

        private int RushCosta()
        {
            int rushCost = 0;

            switch (rushDays) {
                case 3:
                    if (Desk.Area < SIZE_CAPACITY)
                        rushCost += 60; //These totals will be switched out with the text file
                    if (Desk.Area > SIZE_CAPACITY && Desk.Area < RUSH_CAPACITY)
                        rushCost += 70;
                    if (Desk.Area > RUSH_CAPACITY)
                        rushCost += 80;
                    break;

                case 5:
                    if (Desk.Area < SIZE_CAPACITY)
                        rushCost += 40;
                    if (Desk.Area > SIZE_CAPACITY && Desk.Area < RUSH_CAPACITY)
                        rushCost += 50;
                    if (Desk.Area > RUSH_CAPACITY)
                        rushCost += 60;
                    break;

                case 7:
                    if (Desk.Area < SIZE_CAPACITY)
                        rushCost += 30;
                    if (Desk.Area > SIZE_CAPACITY && Desk.Area < RUSH_CAPACITY)
                        rushCost += 35;
                    if (Desk.Area > RUSH_CAPACITY)
                        rushCost += 40;
                    break;

                default:
                    break;
            }

            return rushCost;
        }

        private int RushCost()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                int rushPrice = 0;
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
                        if (Desk.Area < 1000)
                            rushPrice = rushPrices[0, 0];
                        else if (Desk.Area < 2001)
                            rushPrice = rushPrices[0, 1];
                        else if (Desk.Area > 2000)
                            rushPrice = rushPrices[0, 2];
                        break;

                    case 5:
                        if (Desk.Area < 1000)
                            rushPrice = rushPrices[1, 0];
                        else if (Desk.Area < 2001)
                            rushPrice = rushPrices[1, 1];
                        else if (Desk.Area > 2000)
                            rushPrice = rushPrices[1, 2];
                        break;

                    case 7:
                        if (Desk.Area < 1000)
                            rushPrice = rushPrices[2, 0];
                        else if (Desk.Area < 2001)
                            rushPrice = rushPrices[2, 1];
                        else if (Desk.Area > 2000)
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

        #endregion

        //Old code
        /*public Desk desk;
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
        }*/
    }
}
