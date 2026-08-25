//PASSO A PASSO DO EXERCICIO 06a
//1 - Criar um vetor de valores numericos
//2 - usar um loop de repetiçao
// 3 - gerar valores aleatorios
// 4- guardar no vetor

int[] VetorNaoOrdenado = new int[100];
int temp;
Random random = new Random();
for(int i = 0; i < VetorNaoOrdenado.Length; i++)
{
    VetorNaoOrdenado[i] = random.Next(1, 100);
    Console.Write(VetorNaoOrdenado[i] + " ");
}

for(int i = 0; i < VetorNaoOrdenado.Length; i++)
{
    for(int j = 0; j < VetorNaoOrdenado.Length - i - 1; j++)
    {
        if(VetorNaoOrdenado[j] > VetorNaoOrdenado[j + 1])
        {
            temp = VetorNaoOrdenado[j];
            VetorNaoOrdenado[j] = VetorNaoOrdenado[j+1];
            VetorNaoOrdenado[j+1] = temp;
        }
    }
}

Console.WriteLine("\n Ordenado: \n");
for(int i = 0; i < VetorNaoOrdenado.Length; i++)
{
    Console.Write(VetorNaoOrdenado[i] + " ");
}