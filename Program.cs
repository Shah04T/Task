using System.Globalization;

Console.Write("Сколько предложений вы будите вводить?:");
int num = Convert.ToInt32(Console.ReadLine());
string results = string.Empty;
int count = 0;
string[] sentences = new string[num];
for (int i = 0; i < num; i++)
{
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string fchr = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    if (fchr.Length <= 3)
    {
        sentences[count]=fchr;
        count++;
    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    fchr = string.Empty;
}
results += "[ ";
for (int i = 0; i < count; i++)
{
    results += sentences[i];
    if (i != count-1)
    {
        results += ", ";
    }
}
results += "]";
Console.Write(results);