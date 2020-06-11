using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    public class Round
    {
        private double radius;
        public Point Center { get; private set; }
        public double Radius 
        {
            get => radius;
            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Radius not be a negative!");
                radius = value;
            }
        }
        public double Сircumference => Math.PI * Radius * 2;
        public double Area => Math.Pow(Radius, 2) * Math.PI;

        public Round(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Center: {Center.X}, {Center.Y}{Environment.NewLine}" +
                $"Radius: {radius}{Environment.NewLine}" +
                $"Сircumference: {Сircumference}{Environment.NewLine}" +
                $"Area: {Area}";
        }
    }
}
