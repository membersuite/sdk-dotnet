using System;
using System.Threading;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    ///     Wrapper class for syncronized access
    /// </summary>
    /// <remarks>Copied from http://thevalerios.net/matt/2008/09/using-readerwriterlockslim/</remarks>
    public class ReaderWriterLockManager : IDisposable
    {
        private readonly ReaderWriterLockSlim _readerWriterLock;
        private bool _isDisposed;

        public ReaderWriterLockManager()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ReaderWriterLockManager" /> class.
        /// </summary>
        /// <param name="ReaderWriterLock">The reader writer lock.</param>
        public ReaderWriterLockManager(ReaderWriterLockSlim ReaderWriterLock)
        {
            if (ReaderWriterLock == null) throw new ArgumentNullException("ReaderWriterLock");
            _readerWriterLock = ReaderWriterLock;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_readerWriterLock.IsReadLockHeld)
                        _readerWriterLock.ExitReadLock();

                    if (_readerWriterLock.IsUpgradeableReadLockHeld)
                        _readerWriterLock.ExitUpgradeableReadLock();

                    if (_readerWriterLock.IsWriteLockHeld)
                        _readerWriterLock.ExitWriteLock();
                }
            }

            _isDisposed = true;
        }
    }
}