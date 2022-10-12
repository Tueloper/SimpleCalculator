namespace SimpleCalculatorLogic;

public class SimpleCalculator
{
    //addition method of 2 numbers
    public static double AddNumbers(double num1, double num2)
    {
        //return added numbers
        return num1 + num2;
    }

    //subtraction method of 2 numbers
    public static double SubstractNumbers(double num1, double num2)
    {
        //return subtracted numbers
        return num1 - num2;
    }

    //multiplication method of 2 numbers
    public static double MultiplyNumbers(double num1, double num2)
    {
        //return mutliplied numbers
        return num1 * num2;
    }

    //division method of 2 numbers
    public static double DivideNumbers(double num1, double num2)
    {
        //checked if the 2nd number is zero so that you can catch the error
        //if not make the division
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