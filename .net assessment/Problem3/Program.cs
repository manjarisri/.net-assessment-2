// using System;
// using System.Threading;

// namespace Problem3
// {
//     class Stopwatch
//     {
//         private DateTime _startTime;
//         private bool _isRunning;

//         public void Start()
//         {
//             if (_isRunning)
//                 throw new InvalidOperationException("Stopwatch is already running.");

//             _startTime = DateTime.Now;
//             _isRunning = true;
//         }

//         public TimeSpan Stop()
//         {
//             if (!_isRunning)
//                 throw new InvalidOperationException("Stopwatch is not running.");

//             _isRunning = false;
//             return DateTime.Now - _startTime;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Stopwatch stopwatch = new Stopwatch();

//             // Start the stopwatch
//             stopwatch.Start();

//             // Simulate some operations
//             for (int i = 0; i < 100000000; i++)
//             {
//                 // Simulating operations
//             }

//             // Introduce a delay to simulate operations
//             Thread.Sleep(2000);

//             // Stop the stopwatch and display the duration
//             TimeSpan duration = stopwatch.Stop();
//             Console.WriteLine("Duration: " + duration);

//             // Start the stopwatch again
//             stopwatch.Start();

//             // Simulate some more operations
//             for (int i = 0; i < 50000000; i++)
//             {
//                 // Simulating operations
//             }

//             // Introduce another delay to simulate operations
//             Thread.Sleep(1000);

//             // Stop the stopwatch again and display the duration
//             duration = stopwatch.Stop();
//             Console.WriteLine("Duration: " + duration);
//         }
//     }
// }

using System;

namespace Problem3
{
    class Stopwatch
    {
        private DateTime _startTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public TimeSpan Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");

            _isRunning = false;
            return DateTime.Now - _startTime;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            stopwatch.Start();
            Console.WriteLine("Stopwatch started.");

            // Simulate some operations
            for (int i = 0; i < 100000000; i++)
            {
                // Simulating operations
            }

            // Stop the stopwatch and display the duration
            TimeSpan duration1 = stopwatch.Stop();
            Console.WriteLine("Duration 1: " + duration1);

            // Start the stopwatch again
            stopwatch.Start();
            Console.WriteLine("Stopwatch started again.");

            // Simulate some more operations
            for (int i = 0; i < 50000000; i++)
            {
                // Simulating operations
            }

            // Stop the stopwatch again and display the duration
            TimeSpan duration2 = stopwatch.Stop();
            Console.WriteLine("Duration 2: " + duration2);
        }
    }
}

