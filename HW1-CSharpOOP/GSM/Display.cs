using System;

namespace DefineClass
{
    class Display
    {
        private double size;
        private int num_colors;

        public Display(double size, int num_colors)
        {
            this.size = size;
            this.num_colors = num_colors;
        }

        public double Size
        {
            get
            {
                return size;
            }

            set
            {
                if (size < 22.62)
                {
                    throw new ArgumentException("Size of display cannot be less than 22.62");
                }

                size = value;
            }
        }

        public int NumColors
        {
            get
            {
                return num_colors;
            }

            set
            {
                if (num_colors < 2)
                {
                    throw new ArgumentException("Number of colors cannot be less than two");
                }

                num_colors = value;
            }
        }

        public override string ToString()
        {
            return "Size: " + size + "\nNumber of colors: " + num_colors + "\n";
        }
    }
}