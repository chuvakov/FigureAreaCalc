using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures;

namespace FigureAreaCalc.Lib.Service;

public class CalcService : ICalcService
{
    public TResponse CalcArea<TResponse>(IFigure figure) where TResponse : CalcResponse
    {
        return (TResponse)figure.GetArea();
    }

    public CalcResponse CalcArea(IFigure figure)
    {
        return figure.GetArea();
    }
}