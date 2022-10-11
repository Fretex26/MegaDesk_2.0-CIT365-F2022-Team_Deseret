using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Barragan
{
    internal class Desk
    {

        public double width;
        public double depth;
        public double numberOfDrawers;
        public string materialFQ;
        public DesktopMaterial material;
        
        public enum DesktopMaterial
        {
            Laminate, 
            Oak,
            Rosewood,
            Veneer,
            Pine
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
        }
    }
}
