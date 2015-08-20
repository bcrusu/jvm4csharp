//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/DirectoryStream")]
	public partial interface DirectoryStream<T> : Closeable, Iterable<T>
		where T : IJavaObject
	{
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<T> iterator();
	}
	
	public static class DirectoryStream_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
	
		[JavaProxy("java/nio/file/DirectoryStream/Filter")]
		public partial interface Filter<T> : IJavaObject
			where T : IJavaObject
		{
			[JavaSignature("(Ljava/lang/Object;)Z")]
			bool accept(T arg0);
		}
	}
}
