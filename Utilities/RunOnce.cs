using System;
using System.Threading;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    ///     When wrapped in a using class, this will ensure that a piece of code is only run once
    /// </summary>
    public class RunOnce : IDisposable
    {
        private readonly object _lock;

        /// <summary>
        ///     This event makes sure that any other callers wait until the first
        ///     process is done.
        /// </summary>
        private readonly ManualResetEvent _signal = new ManualResetEvent(false);

        private bool _isDisposed;

        private RunOnce(object lockObject)
        {
            ShouldRun = false;
            _lock = lockObject;
            if (Monitor.TryEnter(_lock, 0)) // means I was able to run
                ShouldRun = true;
        }

        /// <summary>
        ///     Gets a value indicating whether the code should run
        /// </summary>
        /// <value><c>true</c> if [should run]; otherwise, <c>false</c>.</value>
        public bool ShouldRun { get; private set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public static void Execute(object lockObject, Action actionToRun)
        {
            using (var ro = new RunOnce(lockObject))
            {
                if (ro.ShouldRun)
                    actionToRun();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (ShouldRun) // means I got the lock
                    {
                        Monitor.Exit(_lock);
                        _signal.Set();
                    }
                    else
                    // you should wait
                    // we use a manualresetevent b/c if set has already been
                    // called, then this will just word
                        _signal.WaitOne(10000); // wait only ten seconds
                }
            }

            _isDisposed = true;
        }
    }
}