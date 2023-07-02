double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[] InputLineCoef(int lineNumber)
{
    double[] lineData = new double[2];
    lineData[0] = Prompt($"Введите коэффициент k для {lineNumber} уравнения: ");
    lineData[1] = Prompt($"Введите коэффициент b для {lineNumber} уравнения: ");
    return lineData;
}
double[] FindCoord(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[0] = (lineData2[1] - lineData1[1]) / (lineData1[0] - lineData2[0]);
    coord[1] = coord[0] * lineData1[0] + lineData1[1];
    return coord; 
}
bool TestLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[0] == lineData2[0])
    {
        if(lineData1[1] == lineData2[1])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}
Console.Clear();
double[] LineData1 = InputLineCoef(1);
double[] LineData2 = InputLineCoef(2);
if (TestLines(LineData1, LineData2))
{
    double[] Coord = FindCoord(LineData1, LineData2);
    Console.WriteLine($"Координаты пересечения прямых y = {LineData1[0]} * x + {LineData1[1]} и y = {LineData2[0]} * x + {LineData2[1]} -> [{Coord[0]};{Coord[1]}]");
}