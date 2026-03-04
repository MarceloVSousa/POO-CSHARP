class Conversor: Padrao
{
    public override double RealDolar(double real)
    {
        double dolar;
        dolar = real * 5.18;
        return dolar;
    }

    public override double DolarReal(double dolar)
    {
        double real;
        real = dolar / 5.18;
        return real;
    }
}