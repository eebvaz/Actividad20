
class Paciente
{
    private string nombre;
    private long dpi;
    private long telefono;
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
    public long Telefono
    {
        get { return telefono; }
        set {
            if (value.ToString().Length == 8)
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

    public Paciente(string nombre, long dpi, long telefono, int edad)
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
        string nombre; long dpi;
        long telefono; int edad;
        bool validacion;


        Console.WriteLine("Solicitud de Pacientes");
        Console.WriteLine("Ingrese el nombre: ");
        nombre = Console.ReadLine();


        do
        {
            Console.Write("Ingrese su DPI: ");
            validacion = long.TryParse(Console.ReadLine(), out dpi);

            if (!validacion || dpi.ToString().Length != 13)
            {
                Console.WriteLine("El DPI no valido. Debe tener 13 digitos.");
                validacion = false;
            }

        } while (!validacion);

        do
        {
            Console.Write("Ingrese la edad: ");
            validacion = int.TryParse(Console.ReadLine(), out edad);
            if (!validacion || edad < 0)
            {
                Console.WriteLine("Edad no valida. Ingrese denuevo.");
                validacion = false;
            }
        } while (!validacion);


        do
        {
            Console.Write("Ingrese su numero telefonico: ");
            validacion = long.TryParse(Console.ReadLine(), out telefono);

            if (!validacion || telefono.ToString().Length != 8)
            {
                Console.WriteLine("El numero telefonico debe de tener 8 digitos.");
                validacion = false;
            }

        } while (!validacion);

        Console.Clear();
        Paciente datos = new Paciente (nombre ,dpi, telefono , edad);
        datos.MostrarInformacion();

        Console.ReadKey();
    }

}