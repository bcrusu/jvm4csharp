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
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/FieldPosition")]
	public partial class FieldPosition : Object
	{
		protected FieldPosition(ProxyCtor p) : base(p) {}
		
		public FieldPosition(Format.Field arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/text/Format/Field;I)V", arg0, arg1);
		}
		
		public FieldPosition(Format.Field arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/text/Format/Field;)V", arg0);
		}
		
		public FieldPosition(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()I")]
		public int getField()
		{
			return Instance.CallMethod<int>("getField", "()I");
		}
		
		[JavaSignature("()I")]
		public int getBeginIndex()
		{
			return Instance.CallMethod<int>("getBeginIndex", "()I");
		}
		
		[JavaSignature("()I")]
		public int getEndIndex()
		{
			return Instance.CallMethod<int>("getEndIndex", "()I");
		}
		
		[JavaSignature("()Ljava/text/Format/Field;")]
		public Format.Field getFieldAttribute()
		{
			return Instance.CallMethod<Format.Field>("getFieldAttribute", "()Ljava/text/Format/Field;");
		}
		
		[JavaSignature("(I)V")]
		public void setBeginIndex(int arg0)
		{
			Instance.CallMethod("setBeginIndex", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setEndIndex(int arg0)
		{
			Instance.CallMethod("setEndIndex", "(I)V", arg0);
		}
	}
}
