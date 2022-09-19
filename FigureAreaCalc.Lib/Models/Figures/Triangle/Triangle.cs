namespace FigureAreaCalc.Lib.Models.Figures.Triangle;

public class Triangle : Figure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    private readonly double _halfPerimeter;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        Perimeter = _sideA + _sideB + _sideC;
        _halfPerimeter = Perimeter / 2;
    }
    
    public override CalcResponse GetArea()
    {
        Area = Math.Sqrt(_halfPerimeter * (_halfPerimeter - _sideA) * (_halfPerimeter - _sideB) * (_halfPerimeter - _sideC));

        return new TriangleCalcResponse(area: Math.Round(Area, 6),
            isRectangular: CheckRectangular());
    }
    
    /// <summary>
    /// Вспомогательный метод для проверки является ли треугольник прямоугольным
    /// </summary>
    /// <returns>Возвращает является ли треугольник прямоугольным</returns>
    private bool CheckRectangular()
    {
        return Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2) ||
               Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2) ||
               Math.Pow(_sideC, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2);
    }
}