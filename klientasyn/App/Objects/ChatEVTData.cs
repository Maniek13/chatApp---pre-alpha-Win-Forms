﻿using System.Threading;

namespace Klient.App.Objects
{
    class ChatEVTData
    {
        public string Name { get; set; }
        public ManualResetEvent Set = new ManualResetEvent(false);
        public ManualResetEvent msgsShowed = new ManualResetEvent(false);
        public string Msg { get; set; }
    }
}
