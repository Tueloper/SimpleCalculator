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
    public void Add_One_Number_And_Letter_To_Get_An_Error()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(ed, 32);
        Assert.AreEqual(-230, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_Two_Negative_Numbers_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(-22, -2);
        Assert.AreEqual(-24, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(22, -452);
        Assert.AreEqual(-230, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_One_Positive_Double_And__Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(2.4, 20);
        Assert.AreEqual(24.4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    
    [TestMethod]
    public void Add_One_Positive_Double_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(5.5, -30);
        Assert.AreEqual(-24.5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    
    [TestMethod]
    public void Add_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(22, -452);
        Assert.AreEqual(-230, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    
    [TestMethod]
    public void Add_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(22, -452);
        Assert.AreEqual(-230, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(22, -452);
        Assert.AreEqual(-230, result);
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
