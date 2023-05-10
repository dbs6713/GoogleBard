using Python.Runtime;
using Serilog;

var log = new LoggerConfiguration()
    .WriteTo.File("bard.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Runtime.PythonDLL = @"/usr/local/Cellar/python@3.11/3.11.3/Frameworks/Python.framework/Versions/3.11/lib/libpython3.11.dylib";
PythonEngine.Initialize();
PythonEngine.BeginAllowThreads();

using (Py.GIL())
{
    dynamic os = Py.Import("os");
    dynamic bard = Py.Import("Bard");

    var bardToken = os.environ.get("BARD_SESSION");
    var chatbot = bard.Chatbot(bardToken);

    do
    {
        Console.Write("\nAsk Bard a question: ");

        string? question = Console.ReadLine();

        log.Information("[QUESTION] {question}", question);

        Console.WriteLine("---");

        var answer = chatbot.ask(question)["content"];

        log.Information("[ANSWER] {answer}", answer);

        Console.WriteLine(answer);

        Console.Write("---\nAsk Bard another question? (y/n): ");
    } while (Console.ReadKey().Key != ConsoleKey.N);
}
