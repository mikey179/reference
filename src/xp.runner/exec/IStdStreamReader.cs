using System;
using System.IO;

namespace Xp.Runners.Exec
{
    public interface IStdStreamReader
    {
        /// <summary>Creates a new reader</summary>
        void Start(StreamReader reader);

        /// <summary>Wait until we've read until the end</summary>
        bool WaitForEnd();
    }
}