using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_2and3_Returns5() => Assert.Equal(5, _calc.Add(2, 3));

    [Fact]
    public void Subtract_5and2_Returns3() => Assert.Equal(3, _calc.Subtract(5, 2));

    [Fact]
    public void Multiply_3and4_Returns12() => Assert.Equal(12, _calc.Multiply(3, 4));

    [Fact]
    public void Divide_10and2_Returns5() => Assert.Equal(5, _calc.Divide(10, 2));

    [Fact]
    public void Divide_ByZero_ThrowsException() =>
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
}
