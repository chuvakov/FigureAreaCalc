using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures;

namespace FigureAreaCalc.Lib.Service;

public interface ICalcService
{
    TResponse CalcArea<TResponse>(IFigure figure) where TResponse : CalcResponse;
    CalcResponse CalcArea(IFigure figure);
}