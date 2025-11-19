using Part2_s36444;

namespace Part2_s36444_Tests;

public class Tests
{

    //-------------------------------------
    // +

    [Test]
    public void TestPositiveNumberAddition()
    {
        var calculator = new Calculator(1, 2, '+');
        Assert.That(calculator.Calculate(), Is.EqualTo(3.000).Within(0.001));
    }

    [Test]
    public void TestNegativeNumberAddition()
    {
        var calculator = new Calculator(-1, -2, '+');
        Assert.That(calculator.Calculate(), Is.EqualTo(-3.000).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberAddition1()
    {
        var calculator = new Calculator(-1, 2, '+');
        Assert.That(calculator.Calculate(), Is.EqualTo(1.000).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberAddition2()
    {
        var calculator = new Calculator(1, -2, '+');
        Assert.That(calculator.Calculate(), Is.EqualTo(-1.000).Within(0.001));
    }

    [Test]
    public void TestDoubleNumberAddition()
    {
        var calculator = new Calculator(1.14, 2.36, '+');
        Assert.That(calculator.Calculate(), Is.EqualTo(3.500).Within(0.001));
    }

    [Test]
    public void TestExtraHugeNumbersAddition()
    {
        var calculator = new Calculator(double.MaxValue, double.MaxValue, '+');
        Assert.That(double.IsInfinity(calculator.Calculate()), Is.True);
    }


    //-------------------------------------
    // -

    [Test]
    public void TestPositiveNumberSubstraction()
    {
        var calculator = new Calculator(1, 2, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(-1.000).Within(0.001));
    }

    [Test]
    public void TestNegativeNumberSubstraction()
    {
        var calculator = new Calculator(-1, -2, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(1.000).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberSubstraction1()
    {
        var calculator = new Calculator(-1, 2, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(-3.000).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberSubstraction2()
    {
        var calculator = new Calculator(1, -2, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(3.000).Within(0.001));
    }

    [Test]
    public void TestDoubleNumberSubstraction()
    {
        var calculator = new Calculator(5.14, 1.10, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(4.040).Within(0.001));
    }

    [Test]
    public void TestExtraHugeNumbersSubstraction()
    {
        var calculator = new Calculator(double.MaxValue, double.MaxValue, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(0.000).Within(0.001));
    }


    //-------------------------------------
    // *

    [Test]
    public void TestPositiveNumberMultiplication()
    {
        var calculator = new Calculator(2, 3, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(6.000).Within(0.001));
    }

    [Test]
    public void TestNegativeNumberMultiplication()
    {
        var calculator = new Calculator(-2, -3, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(6.000).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberMultiplication1()
    {
        var calculator = new Calculator(-2, 3, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(-6.000).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberMultiplication2()
    {
        var calculator = new Calculator(2, -3, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(-6.000).Within(0.001));
    }

    [Test]
    public void TestDoubleNumberMultiplication()
    {
        var calculator = new Calculator(1.23, 2.36, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(2.903).Within(0.001));
    }

    [Test]
    public void TestExtraHugeNumbersMultiplication()
    {
        var calculator = new Calculator(double.MaxValue, double.MaxValue, '*');
        Assert.That(double.IsInfinity(calculator.Calculate()), Is.True);
    }


    //-------------------------------------
    // /

    [Test]
    public void TestPositiveNumberDivision()
    {
        var calculator = new Calculator(9, 2, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(4.500).Within(0.001));
    }

    [Test]
    public void TestNegativeNumberDivision()
    {
        var calculator = new Calculator(-9, -2, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(4.500).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberDivision1()
    {
        var calculator = new Calculator(-9, 2, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(-4.500).Within(0.001));
    }

    [Test]
    public void TestDifferentNumberDivision2()
    {
        var calculator = new Calculator(9, -2, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(-4.500).Within(0.001));
    }

    [Test]
    public void TestDoubleNumberDivision()
    {
        var calculator = new Calculator(5.23, 2.36, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(2.216).Within(0.001));
    }

    [Test]
    public void TestExtraHugeNumbersDivision()
    {
        var calculator = new Calculator(double.MaxValue, double.MaxValue, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(1.000).Within(0.001));
    }

    [Test]
    public void TestDivisionByZero()
    {
        var calculator = new Calculator(9, 0, '/');
        Assert.That(calculator.Calculate(), Is.NaN);
    }

    [Test]
    public void TestZeroNumberDivision()
    {
        var calculator = new Calculator(0, 2, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(0.000).Within(0.001));
    }

    [Test]
    public void TestZeroByZeroDivision()
    {
        var calculator = new Calculator(0, 0, '/');
        Assert.That(calculator.Calculate(), Is.NaN);
    }

    [Test]
    public void TestDivisionByOne()
    {
        var calculator = new Calculator(2, 1, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(2.000).Within(0.001));
    }


    //-------------------------------------
    // other

    [Test]
    public void TestWrongOperationDivision1()
    {
        var calculator = new Calculator(0, 0, '1');
        Assert.That(calculator.Calculate(), Is.NaN);
    }

    [Test]
    public void TestWrongOperationDivision2()
    {
        var calculator = new Calculator(0, 0, ' ');
        Assert.That(calculator.Calculate(), Is.NaN);
    }


}
