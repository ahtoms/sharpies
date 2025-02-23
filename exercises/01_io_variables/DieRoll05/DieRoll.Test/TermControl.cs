namespace DieRoll.Test;

using System.Reflection;

public class TermController
{

    private TextWriter stdout;
    private TextReader stdin;
    private TextWriter stderr;

    private StringWriter? stdoutRecorder;
    private StringReader? stdinRecorder;
    private StringWriter? stderrRecorder;


    public TermController()
    {
        stdout = Console.Out;
        stdin = Console.In;
        stderr = Console.Error;
    }


    public MethodInfo? GetMain(string programName) {
        MethodInfo? mMatch = null;
        foreach(var m in Type.GetType(programName)
            .GetMethods(BindingFlags.NonPublic | BindingFlags.Static)) {
            if(m.Name.ToString() == "Main" || m.Name.ToString() == "<Main>$") {
                mMatch = m;
                break;
            }

            }
            return mMatch;
    }

    public TermController FindAndInvokeMain(string programName, string[] args) {
        MethodInfo? m = GetMain(programName);
        if(m != null) {
            m.Invoke(null, new object[] { args });
        }
        return this;
    }

    public TermController ResetAll()
    {
        ResetStdErr();
        ResetStdIn();
        ResetStdOut();
        return this;
    }

    public TermController SetStringInput(string input)
    {
        stdinRecorder = new StringReader(input);
        Console.SetIn(stdinRecorder);
        return this;
    }

    public TermController ResetStdIn()
    {
        Console.SetIn(stdin);
        return this;
    }

    public TermController RecordStdOut()
    {
        stdoutRecorder = new StringWriter();
        Console.SetOut(stdoutRecorder);
        return this;
    }

    public void FlushStdOut()
    {
        stdoutRecorder.Flush();
    }

    public string GetOutputString()
    {
        return stdoutRecorder.ToString();
    }

    public TermController ResetStdOut()
    {
        Console.SetOut(stdout);
        return this;
    }

    public TermController RecordStdErr()
    {
        stderrRecorder = new StringWriter();
        Console.SetError(stderrRecorder);
        return this;
    }

    public string GetErrorString()
    {
        return stderrRecorder.ToString();
    }

    public TermController ResetStdErr()
    {
        Console.SetError(stderr);
        return this;
    }

}
