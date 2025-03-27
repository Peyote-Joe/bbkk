using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
public class ComparadorDescendente : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x); 
    }
}
class Polinomio
{
    private SortedDictionary<int, int> Monomios { get; set; }
    public Polinomio(string polinomio)
    {
        Monomios = new SortedDictionary<int, int>( new ComparadorDescendente());
        string patron = @"(?<Coeficiente>[+-]?\d*)?(?<Incognita>[xX])(?<Exponente>\d*)";
        var coincidencia = Regex.Matches(polinomio, patron);

        foreach (Match match in coincidencia)
        {
            int coeficiente = 1;
            int exponente = 0;

            var coeficienteGrupo = match.Groups["Coeficiente"].Value;
            var exponenteGrupo = match.Groups["Exponente"].Value;

            if (coeficienteGrupo != "")
            {
                coeficiente = int.Parse(coeficienteGrupo);
            }

            if (match.Groups["Incognita"].Value != "")
            {
                exponente = exponenteGrupo == "" ? 1 : int.Parse(exponenteGrupo);
            }

            if (Monomios.ContainsKey(exponente))
            {
                Monomios[exponente] += coeficiente;
            }
            else
            {
                Monomios.Add(exponente, coeficiente);
            }
        }
    }

    public static Polinomio Suma(Polinomio p1, Polinomio p2)
    {
        SortedDictionary<int, int> resultado = new SortedDictionary<int, int>();
        foreach (var item in p1.Monomios)
        {
            resultado[item.Key] = item.Value;
        }
        foreach (var item in p2.Monomios)
        {
            if (resultado.ContainsKey(item.Key))
            {
                resultado[item.Key] += item.Value;
            }
            else
            {
                resultado.Add(item.Key, item.Value);
            }
        }


        string resultadoPolinomio = "";
        foreach (var item in resultado)
        {
            
            if (item.Value != 0)
            {
                resultadoPolinomio += (item.Value > 0 ? "+" : "") + item.Value + "x" + (item.Key > 1 ? item.Key.ToString() : "");
            }
        }

        return new Polinomio(resultadoPolinomio);

    }

    public override string ToString()
    {
        string polinomio = "";
        foreach (var monomio in Monomios)
        {
            polinomio += (monomio.Value > 0 ? "+" : "") + monomio.Value + "x" + (monomio.Key > 1 ? monomio.Key.ToString() : "");
        }
        return polinomio;
    }


}