using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    // ReSharper disable InconsistentNaming
    internal static class JavaObjectMembers
    {
        public static Class getClass(this IJavaObject javaObject)
        {
            var proxy = WrapperHelpers.GetJavaProxy(javaObject);
            return proxy.ProxyState.Class;
        }

        public static int hashCode(this IJavaObject javaObject)
        {
            return JvmContext.Current.JniEnv.Classes.CallMethod<int>(javaObject, "hashCode", "()I");
        }

        public static bool equals(this IJavaObject javaObject, IJavaObject obj)
        {
            return JvmContext.Current.JniEnv.Classes.CallMethod<bool>(javaObject, "equals", "(Ljava/lang/Object;)Z", obj);
        }

        public static String toString(this IJavaObject javaObject)
        {
            return JvmContext.Current.JniEnv.Classes.CallMethod<String>(javaObject, "toString", "()Ljava/lang/String;");
        }

        public static void notify(this IJavaObject javaObject)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod(javaObject, "notify", "()V");
        }

        public static void notifyAll(this IJavaObject javaObject)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod(javaObject, "notifyAll", "()V");
        }

        public static void wait(this IJavaObject javaObject)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod(javaObject, "wait", "()V");
        }

        public static void wait(this IJavaObject javaObject, long timeout)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod(javaObject, "wait", "(J)V", timeout);
        }

        public static void wait(this IJavaObject javaObject, long timeout, int nanos)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod(javaObject, "wait", "(JI)V", timeout, nanos);
        }
    }
}
