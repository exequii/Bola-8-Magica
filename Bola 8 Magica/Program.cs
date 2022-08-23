
public class Program
{
    public static void Main(string[] args)
    {
        string[] respuestas = new string[] { "Si", "No", "Tal vez", "Mejor no decirte", "Es cierto", "Muy dudoso" };

        Console.WriteLine("Ingrese su pregunta:");
        string pregunta = Console.ReadLine();
        int indexArray = generarNumeroAleatorio(0, respuestas.Length);
        string respuesta = obtenerRespuestaAleatoria(respuestas,indexArray);
        Console.WriteLine("Su respuesta a la pregunta " + pregunta + " es: " +respuesta);
    }
    
    public static int generarNumeroAleatorio(int minimo, int maximo)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(minimo, maximo);
        return numeroAleatorio;
    }

    public static string obtenerRespuestaAleatoria(string[] respuestas,int indexArray)
    {
        return respuestas[indexArray];
    }

}




