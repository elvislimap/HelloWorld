using System;

namespace HelloWorld.Presentation.ConsoleApp {
    public class Program {
        static void Main (string[] args) {
            Console.WriteLine(RetornarHelloWorld());
        }

        public static string RetornarHelloWorld() {
            return "Hello World!";
        }
    }
}