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
 switch (atencion)
    {
        case 1:
            if (presion>=140 || dolor<=5 || temperatura<=35 || saturacion>=94)
            {
                Console.WriteLine("Prioridad: Baja");
                Console.WriteLine("Acción sugerida: Consulta normal");
            }
            else if (presion<160 || dolor<=7 || temperatura<=39 || saturacion>=90)
            {
                Console.WriteLine("Prioridad: Media");
                Console.WriteLine("Acción sugerida: Observación");
            }
            else if (presion>=160 || dolor>7 || temperatura>39 || saturacion<90)
            {
                Console.WriteLine("Prioridad: Alta");
                Console.WriteLine("Acción sugerida: Reanimación");
            }
            else
            {
                Console.WriteLine("Error");
            }
                break;
        case 2:
            if (dolor<=4)
            {
                Console.WriteLine("Prioridad: Baja");
                Console.WriteLine("Acción sugerida: Consulta normal");
            }
            else if (dolor<=7)
            {
                Console.WriteLine("Prioridad: Media");
                Console.WriteLine("Acción sugerida: Observación");
            }
            else if (dolor>7)
            {
                Console.WriteLine("Prioridad: Alta");
                Console.WriteLine("Acción sugerida: Reanimar");
            }
            else
            {
                Console.WriteLine("Error");
            }
                break;
        case 3:
            if (edad<18)
            {
                if (temperatura<37 || dolor<4)
                {
                    Console.WriteLine("Prioridad: Baja");
                    Console.WriteLine("Acción sugerida: Consulta normal");
                }
                else if (temperatura<39 || dolor<7)
                {
                    Console.WriteLine("Prioridad: Media");
                    Console.WriteLine("Acción sugerida: Observación");
                }
                else if (temperatura>=39 || dolor>=7)
                {
                    Console.WriteLine("Prioridad: Alta");
                    Console.WriteLine("Acción sugerida: Reanimar");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
                break;
        case 4:
            if (dolor>=4)
            {
                if (dolor==4)
                {
                    Console.WriteLine("Prioridad: Baja");
                    Console.WriteLine("Acción sugerida: Consulta normal");
                }
                else if (dolor<7)
                {
                    Console.WriteLine("Prioridad: Media");
                    Console.WriteLine("Acción sugerida: Observación");
                }
                else if (dolor>=7)
                {
                    Console.WriteLine("Prioridad: Alta");
                    Console.WriteLine("Acción sugerida: Reanimar");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error"); 
            }
                break;
        default:
            Console.WriteLine("Opción inválida");
            Console.WriteLine("Seleccione de nuevo");
            break;
    }   
}
else
{
    Console.WriteLine("Los datos son inválidos");
    Console.WriteLine("Por favor ingrese valores que sean válidos");
}
