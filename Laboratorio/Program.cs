using Laboratorio.Entidades;

Persona persona = new Persona();

Console.WriteLine("Ingresa tu altura en metro: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("\nIngresa tu peso en kg: ");
double peso = double.Parse(Console.ReadLine());

persona.calcularIMC(peso, altura);


Console.WriteLine("\nIngresa tu nombre: ");
string Nombre = Console.ReadLine();

Console.WriteLine("\nIngresa tu sexo: ");
string Sexo = Console.ReadLine();

Console.WriteLine("\nIngresa tu edad: ");
int Edad = Int32.Parse(Console.ReadLine());

persona.esMayorDeEdad(Edad, Nombre, Sexo);

