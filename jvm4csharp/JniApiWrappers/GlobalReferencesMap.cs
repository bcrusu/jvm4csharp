using System;
using System.Collections.Generic;
using System.Diagnostics;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    // TODO: add locks; rename to manager
    internal class GlobalReferencesMap
    {
        private readonly IDictionary<string, Class> _classes = new Dictionary<string, Class>();

        public bool TryGetClass(string className, out Class clazz)
        {
            return _classes.TryGetValue(className, out clazz);
        }

        public void SetClass(string className, Class clazz)
        {
            _classes[className] = clazz;
        }

        public void ValidateDeleteReference(IJavaProxy proxy)
        {
            Debug.Assert(proxy != null);

            if (proxy is Class)
                throw new InvalidOperationException("Cannot delete global reference to 'java.lang.Class' object.");
        }
    }
}
