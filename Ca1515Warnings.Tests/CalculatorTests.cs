using FluentAssertions;

namespace Ca1515Warnings.Tests;

internal class CalculatorTests
{
    [Test]
    public void TestAdd()
    {
        var calculator = new Calculator();
        calculator.Add(4);
        calculator.Value.Should().Be(4);
    }
}
