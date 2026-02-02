Console.Write("Coloque su nombre: ");
string? nombre = Console.ReadLine();

Console.Write("Coloque su apellido: ");
string? apellido = Console.ReadLine();

Console.Write("Coloque su edad: ");
int? edad = int.Parse(Console.ReadLine());

Console.Write("Coloque su altura: ");
double? altura = double.Parse(Console.ReadLine());


Console.WriteLine($"¡Bienvenido {nombre} {apellido}! Tu edad es {edad} años y tu altura es {altura} metros.");
