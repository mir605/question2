// See https://aka.ms/new-console-template for more information

using System;

class MatrixMultiplication
{
    static void Main()
    {
        Console.Write("Matrisin boyutunu girin (n): ");
        int n = int.Parse(Console.ReadLine()); // Matris boyutunu al

        int[,] matrixA = new int[n, n]; // İlk matris
        int[,] matrixB = new int[n, n]; // İkici matris
        int[,] resultMatrix = new int[n, n]; //  çarpım matrisi

        
        Console.WriteLine("Birinci matrisin elemanlarını girin:");// İlk matrisin elemanlarını alma
        for (int i = 0; i < n; i++)
          for (int j = 0; j < n; j++)
                matrixA[i, j] = int.Parse(Console.ReadLine());

       
        Console.WriteLine("İkinci matrisin elemanlarını girin:"); // İkinci matrisin elemanlarını alıyoruz
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
             matrixB[i, j] = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < n; i++)// Matris çarpımını hesaplıyoruz
            for (int j = 0; j < n; j++)
               for (int k = 0; k < n; k++)// k a ve b matrisindeki ortak elemanları temsil eder, a matrisinin ilk satırı b matrisisnin ilk sütunu ile çarpılır
                  resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];

       
        Console.WriteLine("Matrislerin çarpımı:"); // Sonuç matrisini yazdırıyoruz
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(resultMatrix[i, j] + "\t");
             Console.WriteLine();
        }
    }
}










