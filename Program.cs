using System;

namespace Argumentos
{
    class Program
    {
        client Antonio = new client("Antonio Jurado", 438483290, "c/garcia lorca 2", "antonioJurado@hotmail.es", true);
        Console.WriteLine(Antonio);
        public struct client
        {
            public client (string name, int tlf, string direction, string email, bool newClient)
            {
                name = "Jose Rodriguez";
                tlf = 843487190;
                direction = "c/julio romero 21";
                email = "jose@gmail.com";
                newClient = false;
            }

            public string name { get; set; }
            public int tlf { get; set; }
            public string direction { get; set; }
            public string email { get; set; }
            public bool newClient { get; set; }


            public override string ToString() => $"({name}, {tlf}, {direction}, {email}, {newClient})";
            
            
        }

        
    }
}
