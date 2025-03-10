
class NumeroCurioso
{
    //Atributos

    private double A
    {
        get;
    }
    private double B
    {
        get;
    }
    private double C
    {
        get;
    }
    //Constructor
    public NumeroCurioso(double aa, double bb, double cc)
    {
        double numero = Math.Pow(aa, 2) + Math.Pow(bb, 2) + Math.Pow(cc, 2);

        numero = numero > 0.9999999 ? 1 : numero;


        if (numero == 1 || numero == 0)
        {
            if (aa > 0.999)
                aa = 1;
            if (bb > 0.999)
                bb = 1;
            if (cc > 0.999)
                cc = 1;

            A = aa;
            B = bb;
            C = cc;
        }
        else
        {
            throw new NumeroNoCuriosoException("Las coordenadas no cumplen con la condicion");
        }
    }
    public static NumeroCurioso operator +(NumeroCurioso n1, NumeroCurioso n2)
    {
        NumeroCurioso resultado;

        double numero = Math.Pow(n1.A + n2.A, 2) + Math.Pow(n1.B + n2.B, 2) + Math.Pow(n1.C + n2.C, 2);
        if (numero != 0)
        {
            double denominador = Math.Sqrt(numero);
            double nuevoA = (n1.A + n2.A) / denominador;
            double nuevoB = (n1.B + n2.B) / denominador;
            double nuevoC = (n1.C + n2.C) / denominador;
            resultado = new NumeroCurioso(nuevoA, nuevoB, nuevoC);
        }
        else
            resultado = new NumeroCurioso(0, 0, 0);
        return resultado;
    }
    public static NumeroCurioso operator -(NumeroCurioso n1, NumeroCurioso n2)
    {
        NumeroCurioso resultado;
        double numero = Math.Pow(n1.A - n2.A, 2) + Math.Pow(n1.B - n2.B, 2) + Math.Pow(n1.C - n2.C, 2);
        if (numero != 0)
        {
            double denominador = Math.Sqrt(numero);
            double nuevoA = (n1.A - n2.A) / denominador;
            double nuevoB = (n1.B - n2.B) / denominador;
            double nuevoC = (n1.C - n2.C) / denominador;
            resultado = new NumeroCurioso(nuevoA, nuevoB, nuevoC);
        }
        else
            resultado = new NumeroCurioso(0, 0, 0);
        return resultado;

    }
    public override string ToString()
    {
        return "Este numero curioso es: (" + A.ToString("N2") + "," + B.ToString("N2") + "," + C.ToString("N2") + ")";
    }
}