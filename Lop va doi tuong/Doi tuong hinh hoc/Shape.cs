using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doi_tuong_hinh_hoc
{

    public class Shape
    {
        private String color = "green";
        private bool filled = true;

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public Shape()
        {

        }

        public Shape(String color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public String GetColor()
        {
            return color;
        }

        public void SetColor(String color)
        {
            this.color = color;
        }
        public bool IsFilled()
        {
            return filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public override String ToString()
        {
            return "A Shape with color of " + GetColor() + " and " + (IsFilled() ? "filled" : "not filled");

        }
    }
}

