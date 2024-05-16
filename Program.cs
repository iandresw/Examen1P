using Examen1P;
try
{

    string? strNota1, strNota2, strNota3, strNombreA, srtCuenta, strEmail, strClase, strHorario, strDocente;
    Asignatura asignatura = new Asignatura();
    Console.WriteLine("Ingrese nombre del estudiante:");
    asignatura.NombreAlumno = Console.ReadLine();
    Console.WriteLine("Ingrese numero de cuenta:");
    asignatura.NumeroCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese el correo electronico:");
    asignatura.Email = Console.ReadLine();
    Console.WriteLine("Ingrese el Nombre de la Clase:");
    asignatura.NombreAsignatura = Console.ReadLine();
    Console.WriteLine("Ingrese el Horario de la Clase:");
    asignatura.Horario = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre del Docente:");
    asignatura.NombreDocente = Console.ReadLine();
    Console.WriteLine("Ingrese nota del primer parcial:");
    strNota1 = Console.ReadLine();
    Console.WriteLine("Ingrese nota del segundo parcial:");
    strNota2 = Console.ReadLine();
    Console.WriteLine("Ingrese nota del tercer parcial:");
    strNota3 = Console.ReadLine();

    if ((strNota1 == "") || (strNota1 is null))
    {
        Console.WriteLine("La Nota del Primer Parcial no es VALIDA! Intente de Nuevo");
        strNota1 = Console.ReadLine();
    }
    else if ((strNota2 == "") || (strNota2 is null))
    {
        Console.WriteLine("La Nota del Segundo Parcial no es VALIDA! Intente de Nuevo");
        strNota2 = Console.ReadLine();
    }
    else if ((strNota3 == "") || (strNota3 is null))
    {
        Console.WriteLine("La Nota del Tercer Parcial no es VALIDA! Intente de Nuevo");
        strNota3 = Console.ReadLine();
    }

    bool valNota1, valNota2, valNota3, valRango;
    valNota1 = int.TryParse(strNota1, out asignatura.N1);
    valNota2 = int.TryParse(strNota2, out asignatura.N2);
    valNota3 = int.TryParse(strNota3, out asignatura.N3);



    if ((asignatura.N1 > 30) || (asignatura.N2 > 30))
    {
        Console.WriteLine("La Nota del Primer o Segundo Parcial no es VALIDA! Sobrepasa el Limite");
        valRango = false;
    }
    else if (asignatura.N3 > 40)
    {
        Console.WriteLine("La Nota del Tercer Parcial no es VALIDA! Sobrepasa el Limite");
        valRango = false;
    }
    else
    {
        valRango = true;
    }


    if (valNota1 && valNota2 && valNota3 && valRango)
    {
        asignatura.Imprimir();
    }
    else if (valNota1 is not true)
    {
        Console.WriteLine("La Nota del Primer Parcial no es VALIDA! Intente de Nuevo");
    }
    else if (valNota2 is not true)
    {
        Console.WriteLine("La Nota del Primer Parcial no es VALIDA! Intente de Nuevo");
    }
    else if (!valNota3)
    {
        Console.WriteLine("La Nota del Primer Parcial no es VALIDA! Intente de Nuevo");
    }
    else
    {
        Console.WriteLine("No se pudo completar");
    }
}catch(Exception e)
{
    Console.WriteLine(e.ToString());
}