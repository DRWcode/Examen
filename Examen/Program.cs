using Examen;

try
{
    // Ingresar datos del alumno
    Console.WriteLine("Nombre del estudiante:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Numero de cuenta:");
    string numCuenta = Console.ReadLine();
    Console.WriteLine("Correo electronico:");
    string email = Console.ReadLine();

    // Crear objeto Alumno
    Alumno alumno = new Asignatura()
    {
        Nombre = nombre,
        NumeroCuenta = numCuenta,
        Email = email
    };

    // Ingresar datos de la asignatura
    Console.WriteLine("Nombre de la clase:");
    string nombreClase = Console.ReadLine();
    Console.WriteLine("Horario:");
    string horario = Console.ReadLine();
    Console.WriteLine("Nombre del docente:");
    string docente = Console.ReadLine();

    // Crear objeto Asignatura
    Asignatura asignatura = new Asignatura()
    {
        NombreClase = nombreClase,
        Horario = horario,
        Docente = docente
    };

    

    // Ingresar notas parciales
    Console.WriteLine("\n-----------------");
    Console.WriteLine("Ingrese nota primer parcial:");
    double nota1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese nota segundo parcial:");
    double nota2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese nota tercer parcial:");
    double nota3 = Convert.ToDouble(Console.ReadLine());

    // Crear objeto Nota
    Nota nota = new Nota();
    double notaFinal = nota.CalcularNotaFinal(nota1, nota2, nota3);

    // Mostrar mensaje de nota
    Console.WriteLine("\n****************************");
    Console.WriteLine("Nombre del estudiante: " + alumno.Nombre);
    Console.WriteLine("Numero de cuenta: " + alumno.NumeroCuenta);
    Console.WriteLine("Correo electronico: " + alumno.Email);
    Console.WriteLine("Nombre de la clase: " + asignatura.NombreClase);
    Console.WriteLine("Horario: " + asignatura.Horario);
    Console.WriteLine("Nombre del docente: " + asignatura.Docente);
    Console.WriteLine("Su Nota Final:  " + notaFinal+"% " + nota.MensajeNota(notaFinal));
    Console.WriteLine("**********************");
}
catch (FormatException)
{
    Console.WriteLine("Error: Se esperaba un valor numérico para la nota.");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}