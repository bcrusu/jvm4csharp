using System;
using System.Threading.Tasks;

namespace jvm4csharp.Session
{
    internal static class TaskHelpers
    {
        public static Exception UnwrapException(Exception e)
        {
            var ex = e as AggregateException;
            if (ex != null)
            {
                return ex.InnerException;
            }

            return e;
        }

        public static Action RunSync<T>(Func<T> func)
        {
            var tsc = new TaskCompletionSource<T>();

            return () =>
            {
                try
                {
                    var result = func();
                    tsc.SetResult(result);
                }
                catch (Exception e)
                {
                    tsc.SetException(e);
                }
            };
        }

        public static Task RunSync(Action action)
        {
            var tsc = new TaskCompletionSource<int>();

            try
            {
                action();
                tsc.SetResult(0);
            }
            catch (Exception e)
            {
                tsc.SetException(e);
            }

            return tsc.Task;
        }
    }
}
