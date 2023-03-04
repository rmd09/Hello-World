class Program 
{

    static string InPutHandler(string[] input)
    {

        //Основной код 
 
        //Или код по умолчанию:
        string result = string.Empty;
        foreach (string line in input)
        {
            result += line + "\n";
        }
        return result;
    }









    static string pathInput = $"{Environment.CurrentDirectory}\\input.txt";
    static string pathOutput = $"{Environment.CurrentDirectory}\\output.txt";
    public static void Main()
    {
        string[] input = File.ReadAllLines(pathInput);
        if (File.Exists(pathOutput))
        {
            File.Delete(pathOutput);
        }
        string output = InPutHandler(input);
        File.WriteAllText(pathOutput, output);
        Console.WriteLine(output);
    }
}