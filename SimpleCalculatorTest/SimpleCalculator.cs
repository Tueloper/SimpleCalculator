namespace SimpleCalculatorTest;

[TestClass]
public class SimpleCalculator
{
    private double ed;
    //.....................................................................................
    //This are addition logic tests
    //.....................................................................................

    [TestMethod]
    public void Add_Two_Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(13, 12);
        Assert.AreEqual(25, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_One_Number_And_Variable_To_Get_An_Positive_Number_Since_Variable_Defaults_To_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(ed, 32);
        Assert.AreEqual(32, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(-22, -2);
        Assert.AreEqual(-24, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(22, -452);
        Assert.AreEqual(-430, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_One_Positive_Double_And__Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(2.4, 20);
        Assert.AreEqual(22.4, result);
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
    public void Add_Two_Zero_Numbers_And_Return_A_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(0, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    
    [TestMethod]
    public void Add_Two_Negative_Decimal_Numbers_Correctly_And_Return_Negative()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(-2.2, -4.2);
        Assert.AreEqual(-6.4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    public void Add_One_Positive_And_Zero_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(0, 5);
        Assert.AreEqual(5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Add_Positve_2_Point_1 ()
    {
        var result =  SimpleCalculatorLogic.SimpleCalculator.AddNumbers(2.1, 1.1);
        Assert.AreEqual(3.2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    //.....................................................................................
    //This are Subtraction logic tests
    //.....................................................................................

    [TestMethod]
    public void Subtract_Two_Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(13, 12);
        Assert.AreEqual(25, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Number_And_Variable_To_Get_An_Positive_Number_Since_Variable_Defaults_To_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(ed, 32);
        Assert.AreEqual(32, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(-22, -2);
        Assert.AreEqual(-24, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(22, -452);
        Assert.AreEqual(-430, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_Double_And__Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(2.4, 20);
        Assert.AreEqual(22.4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_One_Positive_Double_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(5.5, -30);
        Assert.AreEqual(-24.5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_Two_Zero_Numbers_And_Return_A_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(0, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_Two_Negative_Decimal_Numbers_Correctly_And_Return_Negative()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(-2.2, -4.2);
        Assert.AreEqual(-6.4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Zero_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(0, 5);
        Assert.AreEqual(5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Positve_2_Point_1()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(2.1, 1.1);
        Assert.AreEqual(3.2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
}
