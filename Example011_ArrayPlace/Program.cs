int[] array = {12, 56, 22, 13, 10, 58, 22, 18, 27};
int n = array.Length;
int find = 22;
int index = 0;

while (index < n)
{
  if (array[index] == find)
   {
    Console.WriteLine(index);
    break;
   }
    index++;
}


