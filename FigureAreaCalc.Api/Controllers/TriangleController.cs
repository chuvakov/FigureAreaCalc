using FigureAreaCalc.Lib.Models.Figures.Triangle;
using FigureAreaCalc.Lib.Service;
using Microsoft.AspNetCore.Mvc;

namespace FigureAreaCalc.Api.Controllers;

public class TriangleController : FigureAreaCalcController
{
    private readonly ICalcService _calcService;

    public TriangleController(ICalcService calcService)
    {
        _calcService = calcService;
    }
    
    /// <summary>
    /// Получение площади треугольника по трем сторонам
    /// </summary>
    /// <param name="sideA">Сторона A</param>
    /// <param name="sideB">Сторона B</param>
    /// <param name="sideC">Сторона C</param>
    /// <returns>Возвращаем значение площади и является ли треугольник прямоугольным</returns>
    /// <response code="200">Успешный расчет площади</response>
    /// <response code="500">Ошибка сервера</response>
    [HttpGet("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(TriangleCalcResponse))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult GetArea(double sideA, double sideB, double sideC)
    {
        try
        {
            return Ok(_calcService.CalcArea<TriangleCalcResponse>(new Triangle(sideA, sideB, sideC)));
        }
        catch (Exception e)
        {
            return Problem(e.Message);
        }
    }
}