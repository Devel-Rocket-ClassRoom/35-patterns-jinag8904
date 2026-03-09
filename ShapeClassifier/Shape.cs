using System;

class Shape
{

}

class Circle : Shape
{
    public int Radius { get; set; }
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
}

class Square : Shape
{
    public int Side { get; set; }
}