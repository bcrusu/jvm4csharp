//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang.reflect;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/MethodHandles")]
	public partial class MethodHandles : Object
	{
		protected MethodHandles(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle throwException(Class<IJavaObject> arg0, Class<Throwable> arg1)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "throwException", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle identity(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "identity", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodType;I)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle spreadInvoker(MethodType arg0, int arg1)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "spreadInvoker", "(Ljava/lang/invoke/MethodType;I)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;[I)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle permuteArguments(MethodHandle arg0, MethodType arg1, IntArray arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "permuteArguments", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;[I)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle exactInvoker(MethodType arg0)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "exactInvoker", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle foldArguments(MethodHandle arg0, MethodHandle arg1)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "foldArguments", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodHandles/Lookup;")]
		public static MethodHandles_.Lookup lookup()
		{
			return Static.CallMethod<MethodHandles_.Lookup>(typeof(MethodHandles), "lookup", "()Ljava/lang/invoke/MethodHandles/Lookup;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle arrayElementGetter(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "arrayElementGetter", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle collectArguments(MethodHandle arg0, int arg1, MethodHandle arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "collectArguments", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle constant(Class<IJavaObject> arg0, IJavaObject arg1)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "constant", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle dropArguments(MethodHandle arg0, int arg1, ObjectArray<Class<IJavaObject>> arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "dropArguments", "(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;ILjava/util/List;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle dropArguments(MethodHandle arg0, int arg1, List<Class<IJavaObject>> arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "dropArguments", "(Ljava/lang/invoke/MethodHandle;ILjava/util/List;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle invoker(MethodType arg0)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "invoker", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodHandles/Lookup;")]
		public static MethodHandles_.Lookup publicLookup()
		{
			return Static.CallMethod<MethodHandles_.Lookup>(typeof(MethodHandles), "publicLookup", "()Ljava/lang/invoke/MethodHandles/Lookup;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle arrayElementSetter(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "arrayElementSetter", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle catchException(MethodHandle arg0, Class<Throwable> arg1, MethodHandle arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "catchException", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle explicitCastArguments(MethodHandle arg0, MethodType arg1)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "explicitCastArguments", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle filterArguments(MethodHandle arg0, int arg1, ObjectArray<MethodHandle> arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "filterArguments", "(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle filterReturnValue(MethodHandle arg0, MethodHandle arg1)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "filterReturnValue", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle guardWithTest(MethodHandle arg0, MethodHandle arg1, MethodHandle arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "guardWithTest", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle insertArguments(MethodHandle arg0, int arg1, ObjectArray<IJavaObject> arg2)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandles), "insertArguments", "(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/reflect/Member;")]
		public static T reflectAs<T>(Class<T> arg0, MethodHandle arg1)
			where T : Member
		{
			return Static.CallMethod<T>(typeof(MethodHandles), "reflectAs", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/reflect/Member;", arg0, arg1);
		}
	}
	
	public static partial class MethodHandles_
	{
		[JavaProxy("java/lang/invoke/MethodHandles/Lookup")]
		public partial class Lookup : Object
		{
			protected Lookup(ProxyCtor p) : base(p) {}
		
			[JavaSignature("I")]
			public static int PUBLIC
			{
				get { return Static.GetField<int>(typeof(Lookup), "PUBLIC", "I"); }
			}
			
			[JavaSignature("I")]
			public static int PRIVATE
			{
				get { return Static.GetField<int>(typeof(Lookup), "PRIVATE", "I"); }
			}
			
			[JavaSignature("I")]
			public static int PROTECTED
			{
				get { return Static.GetField<int>(typeof(Lookup), "PROTECTED", "I"); }
			}
			
			[JavaSignature("I")]
			public static int PACKAGE
			{
				get { return Static.GetField<int>(typeof(Lookup), "PACKAGE", "I"); }
			}
		
			[JavaSignature("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandles/Lookup;")]
			public MethodHandles_.Lookup @in(Class<IJavaObject> arg0)
			{
				return Instance.CallMethod<MethodHandles_.Lookup>("in", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandles/Lookup;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findStatic(Class<IJavaObject> arg0, String arg1, MethodType arg2)
			{
				return Instance.CallMethod<MethodHandle>("findStatic", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findVirtual(Class<IJavaObject> arg0, String arg1, MethodType arg2)
			{
				return Instance.CallMethod<MethodHandle>("findVirtual", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findConstructor(Class<IJavaObject> arg0, MethodType arg1)
			{
				return Instance.CallMethod<MethodHandle>("findConstructor", "(Ljava/lang/Class;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findGetter(Class<IJavaObject> arg0, String arg1, Class<IJavaObject> arg2)
			{
				return Instance.CallMethod<MethodHandle>("findGetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findSetter(Class<IJavaObject> arg0, String arg1, Class<IJavaObject> arg2)
			{
				return Instance.CallMethod<MethodHandle>("findSetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findSpecial(Class<IJavaObject> arg0, String arg1, MethodType arg2, Class<IJavaObject> arg3)
			{
				return Instance.CallMethod<MethodHandle>("findSpecial", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2, arg3);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findStaticGetter(Class<IJavaObject> arg0, String arg1, Class<IJavaObject> arg2)
			{
				return Instance.CallMethod<MethodHandle>("findStaticGetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle findStaticSetter(Class<IJavaObject> arg0, String arg1, Class<IJavaObject> arg2)
			{
				return Instance.CallMethod<MethodHandle>("findStaticSetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
			}
			
			[JavaSignature("()Ljava/lang/Class;")]
			public Class<IJavaObject> lookupClass()
			{
				return Instance.CallMethod<Class<IJavaObject>>("lookupClass", "()Ljava/lang/Class;");
			}
			
			[JavaSignature("()I")]
			public int lookupModes()
			{
				return Instance.CallMethod<int>("lookupModes", "()I");
			}
			
			[JavaSignature("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandleInfo;")]
			public MethodHandleInfo revealDirect(MethodHandle arg0)
			{
				return Instance.CallMethod<MethodHandleInfo>("revealDirect", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandleInfo;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle unreflect(Method arg0)
			{
				return Instance.CallMethod<MethodHandle>("unreflect", "(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/reflect/Constructor;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle unreflectConstructor(Constructor<IJavaObject> arg0)
			{
				return Instance.CallMethod<MethodHandle>("unreflectConstructor", "(Ljava/lang/reflect/Constructor;)Ljava/lang/invoke/MethodHandle;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle unreflectGetter(Field arg0)
			{
				return Instance.CallMethod<MethodHandle>("unreflectGetter", "(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle unreflectSetter(Field arg0)
			{
				return Instance.CallMethod<MethodHandle>("unreflectSetter", "(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/reflect/Method;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle unreflectSpecial(Method arg0, Class<IJavaObject> arg1)
			{
				return Instance.CallMethod<MethodHandle>("unreflectSpecial", "(Ljava/lang/reflect/Method;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
			public MethodHandle bind(IJavaObject arg0, String arg1, MethodType arg2)
			{
				return Instance.CallMethod<MethodHandle>("bind", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0, arg1, arg2);
			}
		}
	}
}
