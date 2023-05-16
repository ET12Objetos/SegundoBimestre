namespace Computacion;

public class Curso
{
    private int division;

    private int año;

    private int cicloLectivo;

    //private string turno;
    private ETurno turno;

    private List<Alumno> alumnos;

    public Curso(int año, int division, int cicloLectivo, ETurno turno)
    {
        ValidarRango(año, "El año es incorrecto");
        this.año = año;
        ValidarRango(division, "La division es incorrecto");
        this.division = division;
        ValidarRango(cicloLectivo, "El cicloLectivo es incorrecto");
        this.cicloLectivo = cicloLectivo;
        //ValidarCadena(turno, "El turno es incorrecto");
        this.turno = turno;

        alumnos = new List<Alumno>();
    }

    private void ValidarRango(int valor, string mensajeError)
    {
        if (valor <= 0)
            throw new Exception(mensajeError);
    }

    // private void ValidarCadena(string cadena, string mensajeError)
    // {
    //     if (string.IsNullOrEmpty(cadena))
    //         throw new Exception(mensajeError);
    // }

    public void AgregarUn(Alumno alumno)
    {
        this.alumnos.Add(alumno);
    }

    public void Informar()
    {
        foreach (Alumno alumno in alumnos)
        {
            System.Console.WriteLine($"Nombre: {alumno.nombre} Edad: {alumno.edad}");
        }
    }
}