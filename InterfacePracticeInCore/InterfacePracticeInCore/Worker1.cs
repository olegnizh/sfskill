using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InterfacePracticeInCore
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Worker1 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker1 окончил свою работу");
        }
    }

    public class Worker2 : IWorker
    {
        ILogger Logger { get; }
        public Worker2(ILogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Worker2 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker2 окончил свою работу");
        }
    }

    public class Worker3 : IWorker
    {
        ILogger Logger { get; }
        public Worker3(ILogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Worker3 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker3 окончил свою работу");
        }
    }


}
