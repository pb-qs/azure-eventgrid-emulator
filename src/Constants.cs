﻿namespace Qs.EventGrid.Emulator
{
    public static class Constants
    {
        public readonly static string Namespace = typeof(Startup).Assembly.FullName;
        public const int Port = 7075; // change this port to match the EventGrid subscriber's endpoint (eg- the Azure Function) //todo: would be better with IConfiguration/IOptions
    }
}
