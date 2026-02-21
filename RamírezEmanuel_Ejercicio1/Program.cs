Console.WriteLine("");
Console.WriteLine("Ingrese el tipo de atención: ");
Console.WriteLine("");
Console.WriteLine("- 1. Emergencia");
Console.WriteLine("- 2. Consulta");
Console.WriteLine("- 3. Pediatría");
Console.WriteLine("- 4. Traumatología");
Console.WriteLine("");
int atencion=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la edad del paciente: ");
Console.WriteLine("");
int edad=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la temperatura del paciente (°C): ");
Console.WriteLine("");
double temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la saturación de oxígeno del paciente (%): ");
Console.WriteLine("");
double saturacion = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el nivel de dolor del paciente (1-10): ");
Console.WriteLine("");
int dolor = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la presión sistólica del paciente (mmHg): ");
Console.WriteLine("");
int presion = int.Parse(Console.ReadLine());
Console.WriteLine("");
if (edad>=0 && temperatura>=0 && temperatura<=50 && saturacion>=0 && saturacion<=100 && dolor>=1 && dolor<=10 && presion>=0 && presion<=200)
{
    
}
else
{
    Console.WriteLine("Los datos son inválidos");
    Console.WriteLine("Por favor ingrese valores que sean válidos");
}