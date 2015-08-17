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
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/Member")]
	public interface Member : IJavaObject
	{
		[JavaSignature("()I")]
		int getModifiers();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getName();
		
		[JavaSignature("()Ljava/lang/Class;")]
		Class<IJavaObject> getDeclaringClass();
		
		[JavaSignature("()Z")]
		bool isSynthetic();
	}
	
	public static class Member_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("I")]
		public static int PUBLIC
		{
			get { return Static.GetField<int>(typeof(Member), "PUBLIC", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DECLARED
		{
			get { return Static.GetField<int>(typeof(Member), "DECLARED", "I"); }
		}
	
	}
}
