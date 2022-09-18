using System;
using System.Text.RegularExpressions;
using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures.Circle;
using Shouldly;
using Xunit;

namespace FigureAreaCalc.Tests.Tests;

public class Circle_Tests : FigureAreaCalcTestBase
{
    [Fact]
    public void GetArea()
    {
        // Arrange
        var circle = new Circle(Math.PI);

        // Act
        CalcResponse result = circle.GetArea();

        // Assert
        result.ShouldNotBeNull();
        result.Area.ShouldBe(Math.Round(Math.Pow(Math.PI, 3), 6));
    }
}