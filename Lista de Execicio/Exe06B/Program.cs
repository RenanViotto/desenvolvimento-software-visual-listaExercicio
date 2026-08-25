int[] VetorNaoOrdenado = new int[100];
Random random = new Random();
for(int i = 0; i < VetorNaoOrdenado.Length; i++)
{
    VetorNaoOrdenado[i] = random.Next(1, 100);
    Console.Write(VetorNaoOrdenado[i] + " ");
}

Array.Sort(vetorNaoOrdenado);

foreach (int i in vetorNaoOrdenado)
{
  Console.WriteLine(i);
}