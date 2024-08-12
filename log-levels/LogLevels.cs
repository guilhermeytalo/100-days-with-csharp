using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        var msgTimmed = logLine.Trim();
        
        
        return msgTimmed;
    }

    public static string LogLevel(string logLine)
    {
        string level = logLine;
        return $"{level}: <MESSAGE>";
    }

    public static string Reformat(string logLine)
    {
        string reformat = logLine;
        return $"{reformat} ([<LEVEL>])";
    }
}
