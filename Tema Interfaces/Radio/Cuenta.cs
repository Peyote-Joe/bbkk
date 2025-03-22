using System;
class Cuenta{
    //Atributo
    private int saldo;

    public Cuenta(){
        saldo = 100;
    }
    public int GetSaldo(){
        return saldo;
    }


}
class App{
    Cuenta miCuenta = new Cuenta();
    Console.WriteLine(miCuenta.GetSaldo());
}