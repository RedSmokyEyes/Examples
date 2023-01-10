int[] array = {12, 20, 35, 4, 59, 66, 78, 82,};

int n = array.Length;
int find = 82;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1;
    index++;
}
