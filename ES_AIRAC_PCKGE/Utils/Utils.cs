namespace ES_AIRAC_PCKGE.Utils;

public class Utils
{

    public static void Consolelogger(SeverityLevel severityLevel, string message)
    {
        message = DateTime.Now.ToString("HH:mm:ss") + ": " + message;
        SetSeverityLevel(severityLevel);
        Console.WriteLine(message);
    }

    private static void SetSeverityLevel(Enum severityLevel)
    {
        switch (severityLevel)
        {
            case SeverityLevel.Info:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case SeverityLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case SeverityLevel.Error:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
        }
    }
}