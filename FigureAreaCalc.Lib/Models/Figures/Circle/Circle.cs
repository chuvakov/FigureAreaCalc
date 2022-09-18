namespace FigureAreaCalc.Lib.Models.Figures.Circle;

public class Circle : Figure
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        _radius = radius;
    }
    
    /// <summary>
    /// Расчитывает площадь круга
    /// </summary>
    /// <returns>Возвращаем значение площади круга</returns>
    public override CalcResponse GetArea()
    {
        Area = Math.PI * Math.Pow(_radius, 2);
        return new CalcResponse(Math.Round(Area, 6));
    }
}