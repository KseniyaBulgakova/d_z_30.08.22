Console.Clear();

int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine();

int[,,] arrayZ = new int[x, y, z];
CreateArray(arrayZ);
WriteArray(arrayZ);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] arrayZ)
{
  for (int i = 0; i < arrayZ.GetLength(0); i++)
  {
    for (int j = 0; j < arrayZ.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arrayZ.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={arrayZ[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] arrayZ)
{
  int[] temp = new int[arrayZ.GetLength(0) * arrayZ.GetLength(1) * arrayZ.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arrayZ.GetLength(0); x++)
  {
    for (int y = 0; y < arrayZ.GetLength(1); y++)
    {
      for (int z = 0; z < arrayZ.GetLength(2); z++)
      {
        arrayZ[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


