//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/Constructor")]
	public class Constructor<T> : Executable
		where T : IJavaObject
	{
		protected Constructor(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([Ljava/lang/Object;)Ljava/lang/Object;")]
		public T newInstance(ObjectArray<IJavaObject> arg0)
		{
			return Instance.CallMethod<T>("newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
	}
}
