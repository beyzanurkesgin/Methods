using System;

namespace Oop3
{
    partial class DatabaseLoggerService
    {
        class FileLoggerService : ILoggerService
        {
            public void Log()
            {
                Console.WriteLine("Dosyaya Loglandı");
            }
        }

    }
}
