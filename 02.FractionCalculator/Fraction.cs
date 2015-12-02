namespace _02.FractionCalculator
{
    using System;
    using System.Globalization;

    public struct Fraction
    {
        private const string DenominatorCantBeZero = "Denominator can't be equal to 0.";
        private const string FractionOutOfRange = "The {0} of two fractions will be out of allowed range for new fraction";

        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator { get; private set; }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException(DenominatorCantBeZero);
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            try
            {
                var newNumeartor = checked((a.Numerator * b.Denominator) + (a.Denominator * b.Numerator));
                var newDenominator = checked(a.Denominator * b.Denominator);
                return new Fraction(newNumeartor, newDenominator);
            }
            catch (OverflowException)
            {
                throw new InvalidOperationException(
                    string.Format(
                        FractionOutOfRange,
                        "Addition"));
            }
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            try
            {
                var newNumeartor = checked((a.Numerator * b.Denominator) - (a.Denominator * b.Numerator));
                var newDenominator = checked(a.Denominator * b.Denominator);

                return new Fraction(newNumeartor, newDenominator);
            }
            catch (OverflowException)
            {
                throw new InvalidOperationException(
                    string.Format(
                        FractionOutOfRange,
                        "Substraction"));
            }
        }

        public override string ToString()
        {
            return ((decimal)this.Numerator / this.Denominator).ToString(CultureInfo.InvariantCulture);
        }
    }
}