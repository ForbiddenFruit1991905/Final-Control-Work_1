string[] array = new string [5] {"999", "***", "Sonya", "Linz", "art"};
var new_array = new string[array.Length];

int count = 0;
for(int i=0; i < array.Length; i++)
{
if(array[i].Length <= 3)
        {
        new_array[count] = array[i];
        count++;
        }
}
Console.WriteLine("[" + string.Join(", ", new_array, 0, count) + "]"); 
