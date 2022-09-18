using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures.Circle;
using FigureAreaCalc.Lib.Service;
using Microsoft.AspNetCore.Mvc;

namespace FigureAreaCalc.Api.Controllers;

public class CircleController : FigureAreaCalcController
{
    private readonly ICalcService _calcService;

    public CircleController(ICalcService circleService)
    {
        _calcService = circleService;
    }
    
    /// <summary>
    /// Получение площади круга по радиусу
    /// </summary>
    /// <param name="radius">Радиус</param>
    /// <returns>Возвращаем значение площади</returns>
    /// <response code="200">Успешный расчет площади</response>
    /// <response code="500">Ошибка сервера</response>
    [HttpGet("[action]")]
    public IActionResult GetAreaByRadius(double radius)
    {
        try
        {
            return Ok(_calcService.CalcArea(new Circle(radius)));
        }
        catch (Exception e)
        {
            return Problem(e.Message);
        }
    }
    
    /// <summary>
    /// Получение площади круга по диаметру
    /// </summary>
    /// <param name="diametr">Диаметр</param>
    /// <returns>Возвращаем значение площади</returns>
    /// <response code="200">Успешный расчет площади</response>
    /// <response code="500">Ошибка сервера</response>
    [HttpGet("[action]")]
    public IActionResult GetAreaByDiametr(double diametr)
    {
        try
        {
            return Ok(_calcService.CalcArea(new Circle(diametr / 2)));
        }
        catch (Exception e)
        {
            return Problem(e.Message);
        }
    }
}