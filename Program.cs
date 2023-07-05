//// Tipos de datos
//int myInt = 5;
//double myDouble = 3.434;
//float myFloat = 4.56f;
//decimal myDecimal = 4.56m;

//string myString = "Cristian";

//bool myBool = true;

//var myVar = true;


//Console.WriteLine($"Mi valor entero es.: {myInt,20:N2}"); // String format
//Console.WriteLine($"Mi valor doble es..: {myDouble, 20:N2}");
//Console.WriteLine($"Mi valor float es..: {myFloat, 20:P2}");
//Console.WriteLine($"Mi valor decimal es: {myDecimal,20:C2}");
//Console.WriteLine($"Mi nombres es......: {myString}");
//Console.WriteLine($"Mi bolleano es.....: {(myBool ? "Correcto": "incorrecto")}");  // if en una sola linea ternarios




using OOPConcepts.Logica;

try
{
    var fecha1 = new Date()
    {
        Yaer = 2023,
        Month = 2,
        Day = 28,
    };
    Console.WriteLine(fecha1);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("Sigo en pie ..!");













