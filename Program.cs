using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //un algoritmo que determine si un estudiante ganó o perdió segun el promedio

        Console.WriteLine("Hello, World!");
        //Variables
        string materia;
        int n1, n2, n3, n4, n5;
        double promedio;

        //enviar info al asuario
        Console.WriteLine("Digite una Materia: ");
        materia = Console.ReadLine();
        Console.WriteLine("Ingrese sus notas: ");
        n1=Convert.ToInt32(materia);    
        n2=Convert.ToInt32(materia);
        n3=Convert.ToInt32(materia);
        n4=Convert.ToInt32(materia);
        n5=Convert.ToInt32(materia);

        //Proceso
        promedio = (n1 + n2 + n3 + n4 + n5) / 5;

        //Evaluar si gano o perdio
        if (promedio < 70)
           Console.WriteLine("Estudiante reprobado con: "+promedio);
        else
            Console.WriteLine("Estudiante reprobado con:" + promedio);
    }
}