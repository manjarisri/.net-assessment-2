using System;
using System.Collections.Generic;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating activities for a workflow
            var activities = new List<IActivity>
            {
                new EmailActivity(),
                new FileTransferActivity()
                // Add more activities as needed
            };

            // Running the workflow
            var engine = new WorkflowEngine();
            engine.Run(activities);

            Console.WriteLine("Workflow completed.");
        }
    }

    public interface IActivity
    {
        void Execute();
    }
}
