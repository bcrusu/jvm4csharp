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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/DatagramSocketImpl")]
	public abstract partial class DatagramSocketImpl : Object, SocketOptions
	{
		protected DatagramSocketImpl(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(I)Ljava/lang/Object;")]
		public IJavaObject getOption(int arg0)
		{
			return Instance.CallMethod<IJavaObject>("getOption", "(I)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(ILjava/lang/Object;)V")]
		public void setOption(int arg0, IJavaObject arg1)
		{
			Instance.CallMethod("setOption", "(ILjava/lang/Object;)V", arg0, arg1);
		}
	}
}
