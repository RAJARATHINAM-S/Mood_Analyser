using System;


namespace ModeAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MoodAnalyserAppWithCore.MoodAnalyser obj = new MoodAnalyserAppWithCore.MoodAnalyser("SAD");
            var a = obj.analyseMood();
            Console.WriteLine(a);

        }
    }
}
