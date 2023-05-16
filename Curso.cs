using Biblioteca;

namespace Computacion;

public class Curso
{
    private int division;

    private int año;

    private int cicloLectivo;

    private ETurno turno;

    private List<Alumno> alumnos;

    public Curso(int año, int division, int cicloLectivo, ETurno turno)
    {
        Validacion.ValidarRango(año, "El año es incorrecto");
        this.año = año;
        Validacion.ValidarRango(division, "La division es incorrecto");
        this.division = division;
        Validacion.ValidarRango(cicloLectivo, "El cicloLectivo es incorrecto");
        this.cicloLectivo = cicloLectivo;
        this.turno = turno;

        alumnos = new List<Alumno>();
    }

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