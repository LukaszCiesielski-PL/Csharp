using System;

namespace RationalLib
{
    public readonly struct Rational32
    {
        private readonly int numerator;
        public int Numerator => numerator;

        private readonly int denominator;
        public int Denominator => denominator;

        public static Rational32 ZERO;
        public static Rational32 ONE;
        public static Rational32 HALF;

        static Rational32()
        {
            ZERO = new Rational32(0, 1);
            ONE = new Rational32(1, 1);
            HALF = new Rational32(1, 2);
        }

        public Rational32(int numerator, int denominator = 1)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString() => $"{Numerator}/{Denominator}";
        
    }
}
