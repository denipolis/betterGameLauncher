using System;
using System.Diagnostics;

namespace BetterGameLauncher
{
    class ProcessManager
    {
        public VirtualConsole console;

        public void Kill(Process proc, bool killTree = false)
        {
            try { proc.Kill(killTree); }
            catch (Exception e) { console.Write($"KillProcess: {proc.ProcessName}.exe. ProcessId: {proc.Id}. Exception: " + e.Message, VirtualConsole.writeTypes.Error); }
            finally { console.Write($"KillProcess: {proc.ProcessName}.exe. ProcessId: {proc.Id}. Exception: Nothing", VirtualConsole.writeTypes.Ok); }
        }
        public Process Start(ProcessStartInfo info, ProcessPriorityClass priority = ProcessPriorityClass.Normal)
        {
            using (Process proc = Process.Start(info))
            {
                proc.PriorityClass = priority;
                return proc;
            }
        }
        public Process Find(string name)
        {
            Process[] proc = Process.GetProcessesByName(name);
            if (proc.Length > 0)
                return proc[0];
            return null;
        }
    }
}
