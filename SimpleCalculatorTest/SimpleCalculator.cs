namespace SimpleCalculatorTest;

[TestClass]
public class SimpleCalculator
{
    [TestMethod]
    public void Add_Two_Positive_One_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(1, 1);
        Assert.AreEqual(2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_Positve_2_Point_1 ()
    {
        var result =  SimpleCalculatorLogic.SimpleCalculator.AddNumbers(2.1, 1.1);
        Assert.AreEqual(3.2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
}
