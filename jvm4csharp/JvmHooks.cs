using System;
using jvm4csharp.JniApi;

namespace jvm4csharp
{
    public sealed class JvmHooks
    {
        private JniHooksSig.Exit _exitHook;
        private JniHooksSig.Abort _abortHook;

        internal JvmHooks()
        {
        }

        public void SetExitHook(Action<int> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (_exitHook != null) throw new InvalidOperationException("Exit hook was already set.");

            _exitHook = code => { action(code); };
        }

        public void SetAbortHook(Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (_abortHook != null) throw new InvalidOperationException("Abort hook was already set.");

            _abortHook = () => { action(); };
        }

        internal JniHooksSig.Exit GetExitHook()
        {
            return _exitHook;
        }

        internal JniHooksSig.Abort GetAbortHook()
        {
            return _abortHook;
        }
    }
}
