namespace GitAufgabe;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Git Übungen (Hausaufgaben");
        Console.WriteLine("Wie schätzen Sie Ihre Berufserfahrung ein?");
        Console.WriteLine("1 – Anfänger");
        Console.WriteLine("2 – Mittel");
        Console.WriteLine("3 – Fortgeschritten");
        Console.WriteLine("4 – Experte");
        Console.Write("Bitte wählen Sie eine Option: ");
        string? auswahl = Console.ReadLine();
        switch (auswahl)
        {
            case "1":
                Console.WriteLine("Sie haben Anfänger-Erfahrung ausgewählt.");
                break;
            case "2":
                Console.WriteLine("Sie haben mittlere Erfahrung ausgewählt.");
                break;
            case "3":
                Console.WriteLine("Sie haben fortgeschrittene Erfahrung ausgewählt.");
                break;
            case "4":
                Console.WriteLine("Sie haben Experten-Erfahrung ausgewählt.");
                break;
            default:
                Console.WriteLine("Ungültige Auswahl.");
                break;
        }
        
        Console.WriteLine("Text für den dritten Commit");
    }
}
