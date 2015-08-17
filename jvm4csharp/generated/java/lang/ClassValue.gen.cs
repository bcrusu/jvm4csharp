//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/ClassValue")]
	public abstract class ClassValue<T> : Object
		where T : IJavaObject
	{
		protected ClassValue(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Class;)V")]
		public void @remove(Class<IJavaObject> arg0)
		{
			Instance.CallMethod("remove", "(Ljava/lang/Class;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/Object;")]
		public T @get(Class<IJavaObject> arg0)
		{
			return Instance.CallMethod<T>("get", "(Ljava/lang/Class;)Ljava/lang/Object;", arg0);
		}
	}
}
