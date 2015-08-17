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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/Externalizable")]
	public interface Externalizable : Serializable
	{
		[JavaSignature("(Ljava/io/ObjectOutput;)V")]
		void writeExternal(ObjectOutput arg0);
		
		[JavaSignature("(Ljava/io/ObjectInput;)V")]
		void readExternal(ObjectInput arg0);
	}
}
