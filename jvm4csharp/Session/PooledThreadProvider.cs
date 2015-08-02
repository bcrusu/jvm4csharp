using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace jvm4csharp.Session
{
    internal class PooledThreadProvider : IJvmThreadProvider
    {
        private readonly int _minPoolSize;
        private readonly LinkedList<IJvmThread> _pendingThreads;
        private readonly ISet<IJvmThread> _activeThreads;
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1);

        private int _threadIdCounter;

        public PooledThreadProvider(int minPoolSize)
        {
            if (minPoolSize < 0)
                throw new ArgumentException(nameof(minPoolSize));

            _pendingThreads = new LinkedList<IJvmThread>();
            _activeThreads = new HashSet<IJvmThread>();

            _minPoolSize = minPoolSize;
        }

        public IJvmThread GetThread()
        {
            try
            {
                _lock.Wait();

                IJvmThread result;
                if (_pendingThreads.Count > 0)
                {
                    result = _pendingThreads.First.Value;
                    _pendingThreads.RemoveFirst();
                }
                else
                    result = CreateThread();

                _activeThreads.Add(result);
                return result;
            }
            finally
            {
                _lock.Release();
            }
        }

        public void ReturnThread(IJvmThread thread)
        {
            Debug.Assert(thread != null);

            if (thread.IsAttached)
                throw new InvalidOperationException("Invalid thread state. Cannot return attached thread to pool.");

            if (!(thread is PooledThread))
                throw new InvalidOperationException("Invalid thread type.");

            try
            {
                _lock.Wait();

                if (!_activeThreads.Contains(thread))
                    throw new InvalidOperationException("Pool does not contain thread.");

                _activeThreads.Remove(thread);

                if (_pendingThreads.Count < _minPoolSize)
                    _pendingThreads.AddLast(thread);
                else
                    thread.Dispose();
            }
            finally
            {
                _lock.Release();
            }
        }

        private IJvmThread CreateThread()
        {
            Interlocked.Increment(ref _threadIdCounter);
            return new PooledThread(this, _threadIdCounter);
        }

        public void Dispose()
        {
            //TODO:
        }
    }
}
