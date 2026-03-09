using System;

Shape[] shapes =
{
    new Circle { Radius = 5 },
    new Circle { Radius = 15 },
    new Rectangle { Width = 4, Height = 6 },
    new Rectangle { Width = 5, Height = 5 },
    new Square { Side = 7 }
};

Console.WriteLine($"원(반지름: 5): {ClassifyShape(shapes[0])}, 넓이: {CalculateArea(shapes[0]):F2}");
Console.WriteLine($"원(반지름: 15): {ClassifyShape(shapes[1])}, 넓이: {CalculateArea(shapes[1]):F2}");
Console.WriteLine($"직사각형(4x6): {ClassifyShape(shapes[2])}, 넓이: {CalculateArea(shapes[2]):F2}");
Console.WriteLine($"직사각형(5x5): {ClassifyShape(shapes[3])}, 넓이: {CalculateArea(shapes[3]):F2}");
Console.WriteLine($"정사각형(7): {ClassifyShape(shapes[4])}, 넓이: {CalculateArea(shapes[4]):F2}");

double CalculateArea(Shape shape) => shape switch
{
    Circle { Radius: var r } => Math.PI * r * r,
    Rectangle { Width: var w, Height: var h } => w * h,
    Square { Side: var s } => s * s
};

string ClassifyShape(Shape shape) => shape switch
{
    Circle { Radius: var r } when r >= 10 => "큰 원",
    Circle => "작은 원",
    Rectangle { Width: var w, Height: var h } when w == h => "정사각형 모양의 직사각형",
    Rectangle => "직사각형",
    Square => "정사각형"
};