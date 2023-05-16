namespace Computacion;

public class Alumno
{
    // private string nombre;
    // private int edad;

    public string nombre { get; private set; }
    public int edad { get; private set; }

    public Alumno(string nombre, int edad)
    {
        ValidarNombre(nombre);
        this.nombre = nombre;
        ValidarEdad(edad);
        this.edad = edad;
    }

    private void ValidarEdad(int edad)
    {
        if (edad <= 0)
            throw new Exception("Edad incorrecta");
    }

    private void ValidarNombre(string nombre)
    {
        if (string.IsNullOrEmpty(nombre))
            throw new Exception("Nombre es incorrecto");
    }
}