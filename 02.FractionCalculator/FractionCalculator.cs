namespace _02.FractionCalculator
{
    using System;

    public static class FractionCalculator
    {
        public static void Main()
        {
            try
            {
                var fraction1 = new Fraction(22, 7);
                var fraction2 = new Fraction(40, 4);
                var result = fraction1 + fraction2;
                Console.WriteLine(result.Numerator);
                Console.WriteLine(result.Denominator);
                Console.WriteLine(result);

                var fractionOnTheLimit = new Fraction(long.MaxValue, 2);
                var result2 = fractionOnTheLimit + fraction1;
            }

            catch (Exception ex) when (ex is ArgumentOutOfRangeException
                                    || ex is ArgumentException
                                    || ex is InvalidOperationException)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}