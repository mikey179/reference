using System.Diagnostics;

namespace Xp.Runners
{
    public class RunOnce : ExecutionModel
    {
        /// <summary>Execute the process and return its exitcode</summary>
        public override int Execute(Process proc)
        {
            return Run(proc);
        }
    }
}