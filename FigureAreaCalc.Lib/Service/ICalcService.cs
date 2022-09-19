using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures;

namespace FigureAreaCalc.Lib.Service;

public interface ICalcService
{
    /// <summary>
    /// Получение величины фигуры
    /// </summary>
    /// <param name="figure">Фигура</param>
    /// <typeparam name="TResponse">Тип возвращаемого значения</typeparam>
    /// <returns>Результат расчета</returns>
    TResponse CalcArea<TResponse>(IFigure figure) where TResponse : CalcResponse;
    
    /// <summary>
    /// Получение величины фигуры
    /// </summary>
    /// <param name="figure">Фигура</param>
    /// <returns>Результат расчета</returns>
    CalcResponse CalcArea(IFigure figure);
}