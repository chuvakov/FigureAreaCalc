using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures;

namespace FigureAreaCalc.Lib.Service;

public class CalcService : ICalcService
{
    /// <summary>
    /// Получение величины фигуры
    /// </summary>
    /// <param name="figure">Фигура</param>
    /// <typeparam name="TResponse">Тип возвращаемого значения</typeparam>
    /// <returns>Результат расчета</returns>
    public TResponse CalcArea<TResponse>(IFigure figure) where TResponse : CalcResponse
    {
        return (TResponse)figure.GetArea();
    }

    public CalcResponse CalcArea(IFigure figure)
    {
        return figure.GetArea();
    }
}