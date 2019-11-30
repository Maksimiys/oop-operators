using System;

namespace operators_Library
{
    public class Fraction
    {
        Int64 Denominator, Numerator;
        public Fraction(long num, long den)
        {
            if (den <= 0)
            {
                Numerator = -num;
                Denominator = -den;
            }
            else
            {
                Numerator = num;
                Denominator = den;
            }
        }
        public Fraction(long num)
        {
            
            Numerator = num;
            Denominator = 1;
        }
        public Fraction(double num)
        {
            double k = 0;
            double num1 = num;
            while(num1%1>0)
            {
                num1 *= 10;
                k++;
            }
            Numerator = (long)num1;
            Denominator = (long)Math.Pow((double)10,k);
            //Numerator = num;
            //Denominator = 1;
        }
        public static Fraction operator +(Fraction a)
        {
            return new Fraction(a.Numerator, a.Denominator);
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denominator);
        }
       
        public static Fraction operator +(Fraction a, Fraction b)
        {
            long product = a.Denominator * b.Denominator;
            long nsk = product /NSK(a.Denominator, b.Denominator);
            Fraction res= new Fraction(a.Numerator*(nsk/a.Denominator)+b.Numerator*(nsk/b.Denominator),nsk);
            res.Simplify();
            return res;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            long product = a.Denominator * b.Denominator;
            long nsk = product / NSK(a.Denominator, b.Denominator);
            Fraction res = new Fraction(a.Numerator * (nsk / a.Denominator) - b.Numerator * (nsk / b.Denominator), nsk);
            res.Simplify();
            return res;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction res = new Fraction(a.Numerator *b.Numerator,a.Denominator*b.Denominator);
            res.Simplify();
            return res;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction res= new Fraction(a.Numerator * b.Denominator, a.Denominator * a.Numerator);
            res.Simplify();
            return res;
        }
        public static bool operator >(Fraction a , Fraction b)
        {
            return (double)a > (double)b;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return (double)a < (double)b;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return (double)a >= (double)b;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return (double)a <= (double)b;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return (double)a == (double)b;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return (double)a > (double)b;
        }
        public void Simplify()
        {
           long num = Numerator,den=Denominator,nsk=0;
            while(nsk!=1 && num!=0)
            {
                nsk = NSK(num, den);
                num = num / nsk;
                den = den / nsk;
            }
            Numerator = num;
            Denominator = den;

        }
        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / a.Denominator;
        }
        public static long NSK(long a,long b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            else
                return NSK(b, a % b);
            
        }
        public override string ToString()
        {
            return Numerator+"/"+ Denominator;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
