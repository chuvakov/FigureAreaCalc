namespace FigureAreaCalc.Lib.Models.Figures;

public abstract class Figure : IFigure
{
    protected double Area { get; set; }
    protected double Perimeter { get; set; }
    
    public abstract CalcResponse GetArea();
}