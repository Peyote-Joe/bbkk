// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Numeros curiosos:
    (0,0,0)
    (1,0,0)
    (0,1,0)
    (0,0,1)
*/
NumeroCurioso n1 = new NumeroCurioso(1,0,0);
NumeroCurioso n2 = new NumeroCurioso(0,1,0);
//NumeroCurioso numeroNoCurioso = new NumeroCurioso(2,2,2);
System.Console.WriteLine(n1);
System.Console.WriteLine(n2);
NumeroCurioso N3 = n1 + n2;
System.Console.WriteLine(N3);
