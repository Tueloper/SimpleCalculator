namespace SimpleCalculatorLogic;

public class SimpleCalculator
{
    public static double AddNumbers(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double SubstractNumbers(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double MultiplyNumbers(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double DivideNumbers(double num1, double num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            throw new DivideByZeroException();
        }
    }
}