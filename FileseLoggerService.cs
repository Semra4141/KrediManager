using System;

namespace OOP3
{
    class FileseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
}
