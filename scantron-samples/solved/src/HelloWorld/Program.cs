using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var messenger = new Messenger();
            Console.WriteLine(messenger.GetMessage());
        }
    }
}
