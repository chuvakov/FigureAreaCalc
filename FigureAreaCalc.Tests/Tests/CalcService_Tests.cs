using System;
using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures.Circle;
using FigureAreaCalc.Lib.Models.Figures.Triangle;
using FigureAreaCalc.Lib.Service;
using Shouldly;
using Xunit;

namespace FigureAreaCalc.Tests.Tests;

public class CalcService_Tests : FigureAreaCalcTestBase
{
    private readonly ICalcService _calcService;

    public CalcService_Tests()
    {
        _calcService = Resolve<ICalcService>();
    }
    
    [Fact]
    public void GetArea_Circle()
    {
        // Arrange
        var circle = new Circle(Math.PI);

        // Act
        CalcResponse result = _calcService.CalcArea(circle);

        // Assert
        result.ShouldNotBeNull();
        result.Area.ShouldBe(Math.Round(Math.Pow(Math.PI, 3), 6));
    }
    
    [Fact]
    public void GetArea_Triangle()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        
        // Act
        TriangleCalcResponse result = _calcService.CalcArea<TriangleCalcResponse>(triangle);
        
        // Assert
        result.ShouldNotBeNull();
        result.Area.ShouldBe(6);
        result.IsRectangular.ShouldBeTrue();
    }
}