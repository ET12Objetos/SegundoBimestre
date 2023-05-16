namespace Computacion;

public class Alumno
{
    public string nombre { get; private set; }
    public int edad { get; private set; }

    public Alumno(string nombre, int edad)
    {
        Validacion.ValidarCadena(nombre, "Nombre incorrecto");
        this.nombre = nombre;
        Validacion.ValidarRango(edad, "Edad incorrecta");
        this.edad = edad;
    }
}