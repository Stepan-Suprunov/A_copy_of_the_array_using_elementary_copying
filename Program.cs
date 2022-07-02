// Копия массива с помощью элементарного копирования


int[] array = {1, 3, 5, 9, -6, 5, 0};
int[] copy = new int[array.Length];

for (int i = 0; i < copy.Length; i++)
{
    copy[i] = array[i];
    Console.Write(copy[i] + " ");
}