using System;
public class Fraction
{
    private int _numerator;
    private int _denominator;
    private string _fractionString;
    private double _decimalValue;
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    public string GetFractionString()
    {
        _fractionString = $"{_numerator}/{ _denominator}";
        return _fractionString;
    }
    public double GetDecimalValue()
    {
        _decimalValue = (double)_numerator / (double)_denominator;
        return _decimalValue;
    }
}
