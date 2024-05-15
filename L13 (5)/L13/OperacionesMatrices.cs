using System.Data;
using Microsoft.VisualBasic;

class OperacionesMatrices
{

    public int[,] matriz = new int[0,0];

    public OperacionesMatrices()
    {
    }

    public void CrearMatriz()
    {
        int cantidadFilas = 0;
        int cantidadCols = 0;

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = Int32.Parse(Console.ReadLine());

        matriz = new int[cantidadFilas,cantidadCols];
    }

    public void IngresarDatosMatriz()
    {
        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = Int32.Parse(Console.ReadLine());
            }
        }
    }  

    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0),matriz.GetLength(1)];

        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

    public void ImprimirMatriz()
    {

        for(int i = 0; i < matriz.GetLength(0); i++){
         for(int z=0;  z< matriz.GetLength(1); z++) {
            Console.Write(" " + matriz[z,i]);
        }
        Console.WriteLine(" ");
        }

    }


}