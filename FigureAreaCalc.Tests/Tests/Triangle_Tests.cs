using FigureAreaCalc.Lib.Models;
using FigureAreaCalc.Lib.Models.Figures.Triangle;
using Microsoft.VisualBasic;
using Shouldly;
using Xunit;

namespace FigureAreaCalc.Tests.Tests;

public class Triangle_Tests : FigureAreaCalcTestBase
{
    [Fact]
    public void GetArea_IsNotRectangular()
    {
        // Arrange
        var triangle = new Triangle(4, 4, 5);

        // Act
        CalcResponse result = triangle.GetArea();

        // Assert
        result.ShouldNotBeNull();
        result.Area.ShouldBe(7.806247);
        
        var triangleResult = result as TriangleCalcResponse;
        triangleResult.ShouldNotBeNull();
        triangleResult.IsRectangular.ShouldBeFalse();
    }
    
    [Fact]
    public void GetArea_IsRectangular()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        
        // Act
        CalcResponse result = triangle.GetArea();
        
        // Assert
        result.ShouldNotBeNull();;
        result.Area.ShouldBe(6);
        
        var triangleResult = result as TriangleCalcResponse;
        triangleResult.ShouldNotBeNull();
        triangleResult.IsRectangular.ShouldBeTrue();
    }
}