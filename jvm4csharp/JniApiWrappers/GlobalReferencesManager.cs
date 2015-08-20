using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    internal class GlobalReferencesManager
    {
        private readonly IDictionary<string, Class> _classes = new Dictionary<string, Class>();
        private readonly SemaphoreSlim _classesLock = new SemaphoreSlim(1);

        public bool TryGetClass(string className, out Class clazz)
        {
            try
            {
                _classesLock.Wait();
                return _classes.TryGetValue(className, out clazz);
            }
            finally
            {
                _classesLock.Release();
            }
        }

        public void SetClass(string className, Class clazz)
        {
            try
            {
                _classesLock.Wait();
                _classes[className] = clazz;
            }
            finally
            {
                _classesLock.Release();
            }
        }

        public void ValidateDeleteReference(IJavaObject javaObject)
        {
            Debug.Assert(javaObject != null);

            if (javaObject is Class)
                throw new InvalidOperationException("Cannot delete global reference to 'java.lang.Class' object.");
        }
    }
}
