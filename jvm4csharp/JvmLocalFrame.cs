using System;
using System.Diagnostics;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp
{
    public sealed class JvmLocalFrame : IDisposable
    {
        private readonly JniEnvWrapper _jniEnvWrapper;

        internal JvmLocalFrame(JniEnvWrapper jniEnvWrapper, int minCapacity)
        {
            Debug.Assert(jniEnvWrapper != null);
            _jniEnvWrapper = jniEnvWrapper;
            MinCapacity = minCapacity;
        }

        public int MinCapacity { get; private set; }

        public void Dispose()
        {
            Pop();
        }

        public void EnsureCapacity(int minCapacity)
        {
            _jniEnvWrapper.EnsureLocalCapacity(minCapacity);
            MinCapacity = minCapacity;
        }

        public T Pop<T>(T referenceToKeep)
            where T : IJavaObject
        {
            if (referenceToKeep == null) throw new ArgumentNullException(nameof(referenceToKeep));
            return _jniEnvWrapper.PopLocalFrame<T>((IJavaProxy)referenceToKeep);
        }

        public void Pop()
        {
            _jniEnvWrapper.PopLocalFrame();
        }
    }
}
