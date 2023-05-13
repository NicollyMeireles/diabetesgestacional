int glicemia;
string diagnostico;
Divisao();

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("DIABETES GESTACIONAL");
Divisao();

Console.Write("Glicemia (em mg/dL)...: ");
glicemia = Convert.ToInt32(Console.ReadLine());
Divisao();



if (glicemia > 126)
{
    diagnostico = "Diabetes Mellitus na gravidez";
}
else
{
    if (glicemia >= 92)
    {
        diagnostico = "Compatível com Diabetes Gestacional";
    }
    else
    {
        diagnostico = "Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
    }
}

Divisao();
Console.WriteLine();
Console.WriteLine(diagnostico);
Divisao();

void Divisao()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
    Console.ResetColor();
}
