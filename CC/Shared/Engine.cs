using System;
using System.Diagnostics;

namespace CC.Shared
{
    public class Engine
    {
        /*
        public Engine()
        {
            engineProcess = new System.Diagnostics.Process();
            /*
            switch (engine)
            {
                case EngineList.Hannibal:
                    engineProcess.StartInfo.FileName = "Hannibal1.7x64.exe";
                    break;
                case EngineList.StockFish:
                    engineProcess.StartInfo.FileName = "stockfish_14_x64_avx2.exe";
                    break;
                case EngineList.Ufim802:
                    engineProcess.StartInfo.FileName = "ufim802.exe";
                    break;
                default:
                    break;
            }
            engineProcess.StartInfo.FileName = "ufim802.exe";

            engineProcess.StartInfo.UseShellExecute = false;
            engineProcess.StartInfo.RedirectStandardInput = true;
            engineProcess.StartInfo.RedirectStandardOutput = true;
        }

        //returns true if the process is started, otherwise it returns false
        public bool run()
        {
            return engineProcess.Start(); ;
        }

        public bool stop()
        {
            engineProcess.Close();
            return false;
        }

        public String query(String fen)
        {
            engineProcess.StandardInput.WriteLine("position fen " + fen);

            string processString = "go movetime 5000";

            // Process 20 deep
            // string processString = "go depth 20";

            engineProcess.StandardInput.WriteLine(processString);

            string bestMoveInAlgebraicNotation = engineProcess.StandardOutput.ReadLine();

            String nextMove = engineProcess.StandardOutput.ReadLine();
            return nextMove;
        }

        public static String query(String fen)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c DIR"; // Note the /c command (*)
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            string err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            process.WaitForExit();
            return "";
        }*/
    }

}
