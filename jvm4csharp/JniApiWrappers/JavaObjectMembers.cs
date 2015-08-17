using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    // ReSharper disable InconsistentNaming
    internal static class JavaObjectMembers
    {
        public static Class getClass(this IJavaProxy proxy)
        {
            return proxy.ProxyState.Class;
        }

        public static int hashCode(this IJavaProxy proxy)
        {
            return JvmContext.Current.JniEnv.Classes.CallMethod<int>(proxy, "hashCode", "()I");
        }

        public static bool equals(this IJavaProxy proxy, IJavaObject obj)
        {
            return JvmContext.Current.JniEnv.Classes.CallMethod<bool>(proxy, "equals", "(Ljava/lang/Object;)Z", obj);
        }

        public static String toString(this IJavaProxy proxy)
        {
            return JvmContext.Current.JniEnv.Classes.CallMethod<String>(proxy, "toString", "()Ljava/lang/String;");
        }

        public static void notify(this IJavaProxy proxy)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod<JavaVoid>(proxy, "notify", "()V");
        }

        public static void notifyAll(this IJavaProxy proxy)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod<JavaVoid>(proxy, "notifyAll", "()V");
        }

        public static void wait(this IJavaProxy proxy)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod<JavaVoid>(proxy, "wait", "()V");
        }

        public static void wait(this IJavaProxy proxy, long timeout)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod<JavaVoid>(proxy, "wait", "(J)V", timeout);
        }

        public static void wait(this IJavaProxy proxy, long timeout, int nanos)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod<JavaVoid>(proxy, "wait", "(JI)V", timeout, nanos);
        }
    }
}
