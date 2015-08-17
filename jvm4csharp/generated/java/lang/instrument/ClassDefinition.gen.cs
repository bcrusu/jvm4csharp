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
namespace jvm4csharp.java.lang.instrument
{
	[JavaProxy("java/lang/instrument/ClassDefinition")]
	public class ClassDefinition : Object
	{
		protected ClassDefinition(ProxyCtor p) : base(p) {}
		
		public ClassDefinition(Class<IJavaObject> arg0, ByteArray arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Class;[B)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getDefinitionClass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getDefinitionClass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()[B")]
		public ByteArray getDefinitionClassFile()
		{
			return Instance.CallMethod<ByteArray>("getDefinitionClassFile", "()[B");
		}
	}
}
