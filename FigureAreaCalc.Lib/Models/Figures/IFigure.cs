namespace FigureAreaCalc.Lib.Models.Figures;

public interface IFigure
{
    /// <summary>
    /// Расчитывает площадь фигуры
    /// </summary>
    /// <returns>Возвращаем значение площади фигуры</returns>
    CalcResponse GetArea();
}