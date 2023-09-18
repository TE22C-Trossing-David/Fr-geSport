bool gameRestart = true;
int poäng = 0;
string frågan1 = "Vad heter jag?";
string svaren1 = "1. david 2. Daniel 3. Dante";



 Fråga fråga1 = new Fråga();
fråga1.frågaText = frågan1;
fråga1.svarText = svaren1;

while (gameRestart)
{
    Console.WriteLine(fråga1.frågaText);
    Console.ReadLine();

}


public class Fråga
{
    public string frågaText;
    public string svarText;

    Console.WriteLine(frågaText);
    Console.WriteLine(svarText);
    Console.ReadLine()
}
