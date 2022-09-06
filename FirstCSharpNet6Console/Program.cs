// See https://aka.ms/new-console-template for more information

using FirstCSharpNet6Console;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de aplicaciones web 2022-01";
int edad = 20;
double salario = 1200;

var alumno = "Luis Chang";
var peso = 75;

var persona1 = new Persona();
persona1.dni = 88477488;
persona1.nombreCompleto = "Luis Chang";
persona1.telefono = "9987-99291";
persona1.estado = true;

var persona2 = new Persona()
{
    dni = 88766633,
    nombreCompleto = "Juan Perez",
    telefono = "9956-90988",
    estado = true
};

var persona3 = new Persona(44009988,"Paolo Guerrero","9954-99902",false);

var personas = new List<Persona>();
personas.Add(persona1);
personas.Add(persona2);
personas.Add(persona3);


foreach (var item in personas)
{
    Console.WriteLine(item.dni + " | " + item.nombreCompleto);
}

var busqueda = personas.Find(x => x.dni == 88477488);

if (busqueda != null)
    Console.WriteLine("La persona encontrada es : " + busqueda.nombreCompleto);
else
    Console.WriteLine("El DNI no existe...");
