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
    public void Subtract_Two_Positive_Whole_Number_Correctly_And_Return_A_Positive_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(13, 12);
        Assert.AreEqual(1, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Number_And_Variable_To_Get_An_Negative_Number_Since_Variable_Defaults_To_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(ed, 32);
        Assert.AreEqual(-32, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Negative_Nubmber()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(-22, -2);
        Assert.AreEqual(-20, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Negative_Correctly_And_Return_A_Positive_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(22, -452);
        Assert.AreEqual(474, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_Decimal_And_Positive_Whole_Number_Correctly_And_Return_A_Negative()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(2.4, 20);
        Assert.AreEqual(-17.6, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_One_Positive_Decimal_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(5.5, -30);
        Assert.AreEqual(35.5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_Two_Zero_Numbers_And_Return_A_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(0, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Subtract_Two_Negative_Decimal_Numbers_Correctly_And_Return_Positive()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(-2.2, -4.2);
        Assert.AreEqual(2.0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_One_Positive_And_Zero_Correctly_And_Return_A_Negative_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(0, 5);
        Assert.AreEqual(-5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Subtract_Two_Positve_Whole_Numbers()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(2.1, 1.1);
        Assert.AreEqual(1.0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }



    //.....................................................................................
    //This are Multiplication logic tests
    //.....................................................................................

    [TestMethod]
    public void Multiply_Two_Positive_Whole_Number_Correctly_And_Return_A_Positive_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(3, 2);
        Assert.AreEqual(6, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Number_And_Variable_To_Get_An_Negative_Number_Since_Variable_Defaults_To_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(ed, 32);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Negative_Nubmber()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(-2, -2);
        Assert.AreEqual(4, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Positive_And_Negative_Correctly_And_Return_A_Positive_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(2, -4);
        Assert.AreEqual(-8, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Positive_Decimal_And_Positive_Whole_Number_Correctly_And_Return_A_Negative()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(2.4, 2);
        Assert.AreEqual(4.8, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Multiply_One_Positive_Decimal_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(5.5, -3);
        Assert.AreEqual(-16.5, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Multiply_Two_Zero_Numbers_And_Return_A_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(0, 0);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Multiply_Two_Negative_Decimal_Numbers_Correctly_And_Return_Positive()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(-2.3, -1.7);
        Assert.AreEqual(3.9099999999999997, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_One_Positive_And_Zero_Correctly_And_Return_A_Negative_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(0, 5);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Multiply_Two_Positve_Whole_Numbers()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(3.3, 1.1);
        Assert.AreEqual(3.63, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    //.....................................................................................
    //This are Division logic tests
    //.....................................................................................

    [TestMethod]
    public void Divide_Two_Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(13, 1);
        Assert.AreEqual(13, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_One_Number_And_Variable_To_Get_An_Positive_Number_Since_Variable_Defaults_To_Zero()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(ed, 32);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_Two_Negative_Whole_Numbers_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(-22, -2);
        Assert.AreEqual(11, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_One_Positive_And_Negative_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(22, -1);
        Assert.AreEqual(-22, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_One_Positive_Double_And__Positive_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(2.4, 2);
        Assert.AreEqual(1.2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Divide_One_Positive_Double_And_Negative_Whole_Number_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(5.5, -5);
        Assert.AreEqual(-1.1, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }


    [TestMethod]
    public void Divide_Two_Zero_Numbers_And_Return_A_Exception_Error()
    {
        Assert.ThrowsException<DivideByZeroException>(() => SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(0, 0));
    }


    [TestMethod]
    public void Divide_Two_Negative_Decimal_Numbers_Correctly_And_Return_Negative()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(-2.2, -1.1);
        Assert.AreEqual(2, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_One_Positive_And_Zero_Correctly_And_Return_A_Double()
    {
        var result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(0, 5);
        Assert.AreEqual(0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }

    [TestMethod]
    public void Divide_By_Zero_And_Return_A_Exception_Error()
    {
        Assert.ThrowsException<DivideByZeroException>(() => SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(2.1, 0));
    }

}
