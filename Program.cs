// See https://aka.ms/new-console-template for more information
// es un comentario

Console.WriteLine("claculadora programadornea style!");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("toes que gonorrea, que putas es la operacion que quiere hacer en esta chimbada de calculadora?");
Console.WriteLine("escriba alguna de estas operaciones (+,-,/,*):");

string operation = Console.ReadLine();

Console.WriteLine("entre pues el primer numero carechimba:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ahora entre el segundo numero en el cual quiere realizar la operacion:");
double y = Convert.ToDouble(Console.ReadLine());



double result = 0.0;

if (operation == "+")
{
    //suma
    result = Sum(x,y);
} 
else if (operation == "-")
{
    //restamos
    result = Substract(x, y);
}
else if (operation == "/")
{
    //dividimos
    result = Divide(x, y);
}
else if (operation == "*")
{
    //multiplicamos
    result = Multiply(x,y);
}
else
{
    // si es cualquier otra cosa que el usuario entre
    Console.WriteLine("REKT hasta la chimba, elegiste una operacion invalida");
    return;
}
Console.WriteLine($"usted ah elegido la siguiente chimbada: {x} {operation} {y}");

Console.WriteLine("-------------");
Console.WriteLine($"el resultado de esta carechimba operacion es: {result}");

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("aki termina esta chimbada!");

double Sum(double _x, double _y)
{
    return Math.Abs(_x) + Math.Abs(_y);
}

double Substract(double _x, double _y)
{
    return Math.Abs(_x) - Math.Abs(_y);
}

double Multiply(double _x, double _y)
{
    return _x * _y;
}

double Divide(double _x, double _y)
{
    return _x / _y;
}



// int (un numero entero)
// string (un texto cualquiera)
// double (un numero con punto)
// bool (si o no, falso o verdadero)
// un solo caracter

// esto es en python
// print("hola gono")
// prit("hola gono")

