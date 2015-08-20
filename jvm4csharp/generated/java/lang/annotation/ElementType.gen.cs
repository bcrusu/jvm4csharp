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
namespace jvm4csharp.java.lang.annotation
{
	[JavaProxy("java/lang/annotation/ElementType")]
	public partial class ElementType : Enum<ElementType>
	{
		protected ElementType(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType TYPE
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "TYPE", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType FIELD
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "FIELD", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType METHOD
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "METHOD", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType PARAMETER
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "PARAMETER", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType CONSTRUCTOR
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "CONSTRUCTOR", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType LOCAL_VARIABLE
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "LOCAL_VARIABLE", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType ANNOTATION_TYPE
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "ANNOTATION_TYPE", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType PACKAGE
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "PACKAGE", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType TYPE_PARAMETER
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "TYPE_PARAMETER", "Ljava/lang/annotation/ElementType;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/ElementType;")]
		public static ElementType TYPE_USE
		{
			get { return Static.GetField<ElementType>(typeof(ElementType), "TYPE_USE", "Ljava/lang/annotation/ElementType;"); }
		}
	
		[JavaSignature("()[Ljava/lang/annotation/ElementType;")]
		public static ObjectArray<ElementType> values()
		{
			return Static.CallMethod<ObjectArray<ElementType>>(typeof(ElementType), "values", "()[Ljava/lang/annotation/ElementType;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/annotation/ElementType;")]
		public static ElementType valueOf(String arg0)
		{
			return Static.CallMethod<ElementType>(typeof(ElementType), "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/ElementType;", arg0);
		}
	}
}
