﻿using System;

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get
        {
            return this.radius;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius should be positive!", "radius");
            }

            this.radius = value;
        }
    }

    public double CalculateArea()
    {
        double area = Math.PI * Math.Pow(this.Radius, 2);

        return area;
    }

    public double CalculatePerimeter()
    {
        double perimeter = 2 * Math.PI * this.Radius;

        return perimeter;
    }
}