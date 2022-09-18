namespace FigureAreaCalc.Lib.Models;

public class CalcResponse
{
    public double Area { get; }
    
    public CalcResponse(double area) => Area = area;
}