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
	[JavaProxy("java/lang/reflect/Modifier")]
	public class Modifier : Object
	{
		protected Modifier(ProxyCtor p) : base(p) {}
		
		public Modifier() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("I")]
		public static int PUBLIC
		{
			get { return Static.GetField<int>(typeof(Modifier), "PUBLIC", "I"); }
		}
		
		[JavaSignature("I")]
		public static int PRIVATE
		{
			get { return Static.GetField<int>(typeof(Modifier), "PRIVATE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int PROTECTED
		{
			get { return Static.GetField<int>(typeof(Modifier), "PROTECTED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int STATIC
		{
			get { return Static.GetField<int>(typeof(Modifier), "STATIC", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FINAL
		{
			get { return Static.GetField<int>(typeof(Modifier), "FINAL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SYNCHRONIZED
		{
			get { return Static.GetField<int>(typeof(Modifier), "SYNCHRONIZED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int VOLATILE
		{
			get { return Static.GetField<int>(typeof(Modifier), "VOLATILE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int TRANSIENT
		{
			get { return Static.GetField<int>(typeof(Modifier), "TRANSIENT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NATIVE
		{
			get { return Static.GetField<int>(typeof(Modifier), "NATIVE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int INTERFACE
		{
			get { return Static.GetField<int>(typeof(Modifier), "INTERFACE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ABSTRACT
		{
			get { return Static.GetField<int>(typeof(Modifier), "ABSTRACT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int STRICT
		{
			get { return Static.GetField<int>(typeof(Modifier), "STRICT", "I"); }
		}
	
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String toString(int arg0)
		{
			return Static.CallMethod<String>(typeof(Modifier), "toString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isInterface(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isInterface", "(I)Z", arg0);
		}
		
		[JavaSignature("()I")]
		public static int classModifiers()
		{
			return Static.CallMethod<int>(typeof(Modifier), "classModifiers", "()I");
		}
		
		[JavaSignature("(I)Z")]
		public static bool isAbstract(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isAbstract", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isStatic(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isStatic", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isProtected(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isProtected", "(I)Z", arg0);
		}
		
		[JavaSignature("()I")]
		public static int methodModifiers()
		{
			return Static.CallMethod<int>(typeof(Modifier), "methodModifiers", "()I");
		}
		
		[JavaSignature("()I")]
		public static int constructorModifiers()
		{
			return Static.CallMethod<int>(typeof(Modifier), "constructorModifiers", "()I");
		}
		
		[JavaSignature("(I)Z")]
		public static bool isFinal(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isFinal", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isPublic(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isPublic", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isVolatile(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isVolatile", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isNative(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isNative", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isPrivate(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isPrivate", "(I)Z", arg0);
		}
		
		[JavaSignature("()I")]
		public static int fieldModifiers()
		{
			return Static.CallMethod<int>(typeof(Modifier), "fieldModifiers", "()I");
		}
		
		[JavaSignature("()I")]
		public static int interfaceModifiers()
		{
			return Static.CallMethod<int>(typeof(Modifier), "interfaceModifiers", "()I");
		}
		
		[JavaSignature("(I)Z")]
		public static bool isStrict(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isStrict", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isSynchronized(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isSynchronized", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isTransient(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Modifier), "isTransient", "(I)Z", arg0);
		}
		
		[JavaSignature("()I")]
		public static int parameterModifiers()
		{
			return Static.CallMethod<int>(typeof(Modifier), "parameterModifiers", "()I");
		}
	}
}
