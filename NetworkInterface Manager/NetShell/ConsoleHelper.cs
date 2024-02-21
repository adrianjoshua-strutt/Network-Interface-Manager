using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
namespace NetworkInterface_Manager.NetShell
{
    public class ConsoleHelper
    {

        public static String[] RunCommand(String command, bool noOutput = false, int start = 3, int end = 2) {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("netsh",command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            Process p = Process.Start(procStartInfo);
            string output = p.StandardOutput.ReadToEnd();
            if (noOutput) {
                return new String[] {output};
            }
            String[] lines = output.Split('\n');
            String[] ret = new String[lines.Length - (start+end)];
            for (int i = start; i < lines.Length - end; i++)
            {
                if (lines[i] == "") {
                    continue;
                }
                string line = lines[i];
                line = line.Trim();
                line = Regex.Replace(line, @"(\s)\s+", "$1");
                ret[i - start] = line;
            }
            return ret;
        }

        public static String ReadSplittedArrayToEnd(String[] splitted, int startIndex) {
            String ret = splitted[startIndex];
            for (int j = startIndex+1; j < splitted.Length; j++)
            {
                ret += " " + splitted[j];
            }
            return ret;
        }
    }
}
