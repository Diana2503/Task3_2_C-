using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2_C_
{
    internal class Wheel
    {
        private int diameter;
        private bool isGood;
        private int width;
        private int height;
        private String type;

        public Wheel(int diameter, bool isGood, int width, int height, string type)
        {
            this.diameter = diameter;
            this.isGood = isGood;
            this.width = width;
            this.height = height;
            this.type = type;
        }

        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public bool IsGood
        { 
            get { return isGood; }
            set { isGood = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
