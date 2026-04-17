
class Paciente
{
    private string nombre;
    private long dpi;
    private int telefono;
    private int edad;

    public string Nombre {
        get { return nombre; }
        set
        {
            if (value.Length >= 3)
                nombre = value;
            else
                Console.WriteLine("El nombre debe tener al menos 3 caracteres");
        }
        
        }

    public long DPI
    {

        get { return dpi; }
        set {

            if (value.ToString().Length == 13)
                dpi = value;
            else
            {
                Console.WriteLine("El numero ingresado no tiene 13 digitos");
            }

        }

    }
    public int Telefono
    {
        get { return telefono; }
        set {
            if (value == 8)
            telefono = value;
            else
            {
                Console.WriteLine("El numero ingresado no tiene 8 digitos");
            }
            }

    }

    public int Edad
    {
        get { return edad; }
        set {
            if (value > 0)
                edad = value;
            else
                Console.WriteLine("La edad debe de ser mayor a cero (0)");
        }

    }

    public Paciente(string nombre, long dpi, int telefono, int edad)
    {
        this.nombre = nombre;
        this.dpi = dpi;
        this.telefono = telefono;
        this.edad = edad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Lista de pacientes");
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Dpi: "+ dpi);
        Console.WriteLine("Edad:"+edad);
        Console.WriteLine("Numero de telefono: "+telefono);
    }

}

class Program
{
    static void Main()
    {
        string nombre; int dpi;
        int telefono; int edad;


        Console.WriteLine("Solicitud de Pacientes");
        Console.WriteLine("Ingrese el nobmre: ");
        nombre = Console.ReadLine();    
        Console.WriteLine("Ingrese su Dpi: ");
        while (!int.TryParse(Console.ReadLine(), out dpi) || dpi == 13)
        {
            Console.WriteLine("Dato erroneo");
        }
        Console.WriteLine("Ingrese la edad: ");

        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.WriteLine("Dato erroneo");
        }

        Console.WriteLine("Ingrese el numero telefonico");

        while (!int.TryParse(Console.ReadLine(), out telefono))
        {
            Console.WriteLine("Dato erroneo");
        }

        Paciente datos = new Paciente (nombre,dpi,telefono,edad);
        datos.MostrarInformacion();
    }

}