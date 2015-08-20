//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/ServiceLoader")]
	public partial class ServiceLoader<S> : Object, Iterable<S>
		where S : IJavaObject
	{
		protected ServiceLoader(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/Iterator;")]
		public Iterator<S> iterator()
		{
			return Instance.CallMethod<Iterator<S>>("iterator", "()Ljava/util/Iterator;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/util/ServiceLoader;")]
		public static ServiceLoader<S1> load<S1>(Class<S1> arg0)
			where S1 : IJavaObject
		{
			return Static.CallMethod<ServiceLoader<S1>>(typeof(ServiceLoader<>), "load", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/util/ServiceLoader;")]
		public static ServiceLoader<S1> load<S1>(Class<S1> arg0, ClassLoader arg1)
			where S1 : IJavaObject
		{
			return Static.CallMethod<ServiceLoader<S1>>(typeof(ServiceLoader<>), "load", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/util/ServiceLoader;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/util/ServiceLoader;")]
		public static ServiceLoader<S1> loadInstalled<S1>(Class<S1> arg0)
			where S1 : IJavaObject
		{
			return Static.CallMethod<ServiceLoader<S1>>(typeof(ServiceLoader<>), "loadInstalled", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;", arg0);
		}
		
		[JavaSignature("()V")]
		public void reload()
		{
			Instance.CallMethod("reload", "()V");
		}
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		public Spliterator<S> spliterator()
		{
			return Instance.CallMethod<Spliterator<S>>("spliterator", "()Ljava/util/Spliterator;");
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		public void forEach(Consumer<IJavaObject> arg0)
		{
			Instance.CallMethod("forEach", "(Ljava/util/function/Consumer;)V", arg0);
		}
	}
}
