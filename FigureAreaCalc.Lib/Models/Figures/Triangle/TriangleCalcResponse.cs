namespace FigureAreaCalc.Lib.Models.Figures.Triangle;

public class TriangleCalcResponse : CalcResponse
{
    public bool IsRectangular { get; }

    public TriangleCalcResponse(double area, bool isRectangular) : base(area)
    {
        IsRectangular = isRectangular;
    }
}