using System;
using System.Threading;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using ShinyTrain.Hubs;

namespace ShinyTrain
{
    public static class Crier
    {
        private static CancellationTokenSource cts;

        public static void Start()
        {
            if (cts == null)
            {
                // Create the token source.
                cts = new CancellationTokenSource();

                // Pass the token to the cancelable operation.
                ThreadPool.QueueUserWorkItem(new WaitCallback(DoSomeWork), cts.Token);

                // Request cancellation.
            }
        }

        private static void DoSomeWork(object state)
        {
            var shinyHub = GlobalHost.ConnectionManager.GetHubContext<ShinyHub>();

            while (cts != null && cts.IsCancellationRequested == false)
            {
                hub.Send("tick", JsonConvert.SerializeObject(new
                {
                    source = "server",
                    timestamp = DateTime.Now
                }));

                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }

        public static void Stop()
        {
            if (cts != null)
            {
                cts.Cancel();
                Console.WriteLine("Cancellation set in token source...");
                Thread.Sleep(1000);
                // Cancellation should have happened, so call Dispose.
                cts.Dispose();
                cts = null;
            }
        }
    }
}