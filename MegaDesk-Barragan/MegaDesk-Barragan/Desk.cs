using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Barragan
{
    class Desk
    {
        #region desk variables
        public int width { get; set; }
        public int depth { get; set; }
        public int numberOfDrawers { get; set; }
        public Material DesktopMaterial { get; set; }
        public int Area { get; set; }
        #endregion

        //Desk constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        //Materials 
        public enum Material
        {
            Laminate = 100,
            Oak = 200,
            Rosewood = 300,
            Veneer = 125,
            Pine = 50
        }

        //old code

        /*public double width;
        public double depth;
        public double numberOfDrawers;
        public string materialFQ;
        public DesktopMaterial material;
        
        public enum DesktopMaterial
        {
            Laminate = 100, 
            Oak = 200,
            Rosewood = 300,
            Veneer = 125,
            Pine = 50
        }

        public Desk (double width, double depth, double numberOfDrawers, string materialFQ)
        {
            this.width = width;
            this.depth = depth;
            this.numberOfDrawers = numberOfDrawers;
            this.materialFQ = materialFQ;
            material = getDesktopMaterial(materialFQ);
        }

        //This function converts the string of the material input to the DesktopMaterial enum
        private DesktopMaterial getDesktopMaterial(string materialFQ)
        {
            switch (materialFQ)
            {
                case "Laminate":
                    material = DesktopMaterial.Laminate;
                    break;
                case "Oak":
                    material = DesktopMaterial.Oak;
                    break;
                case "Rosewood":
                    material = DesktopMaterial.Rosewood;
                    break;
                case "Veneer":
                    material = DesktopMaterial.Veneer;
                    break;
                case "Pine":
                    material = DesktopMaterial.Pine;
                    break;
            }

            return material;
        }*/
    }
}
