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
using jvm4csharp.java.lang;
using jvm4csharp.java.util;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/Collator")]
	public abstract class Collator : Object, Comparator<IJavaObject>, Cloneable
	{
		protected Collator(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int PRIMARY
		{
			get { return Static.GetField<int>(typeof(Collator), "PRIMARY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SECONDARY
		{
			get { return Static.GetField<int>(typeof(Collator), "SECONDARY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int TERTIARY
		{
			get { return Static.GetField<int>(typeof(Collator), "TERTIARY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int IDENTICAL
		{
			get { return Static.GetField<int>(typeof(Collator), "IDENTICAL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NO_DECOMPOSITION
		{
			get { return Static.GetField<int>(typeof(Collator), "NO_DECOMPOSITION", "I"); }
		}
		
		[JavaSignature("I")]
		public static int CANONICAL_DECOMPOSITION
		{
			get { return Static.GetField<int>(typeof(Collator), "CANONICAL_DECOMPOSITION", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FULL_DECOMPOSITION
		{
			get { return Static.GetField<int>(typeof(Collator), "FULL_DECOMPOSITION", "I"); }
		}
	
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Z")]
		public bool equals(String arg0, String arg1)
		{
			return Instance.CallMethod<bool>("equals", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)I")]
		public int compare(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<int>("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)I")]
		public int compare(String arg0, String arg1)
		{
			return Instance.CallMethod<int>("compare", "(Ljava/lang/String;Ljava/lang/String;)I", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/text/Collator;")]
		public static Collator getInstance()
		{
			return Static.CallMethod<Collator>(typeof(Collator), "getInstance", "()Ljava/text/Collator;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/Collator;")]
		public static Collator getInstance(Locale arg0)
		{
			return Static.CallMethod<Collator>(typeof(Collator), "getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;", arg0);
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(Collator), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("()I")]
		public int getStrength()
		{
			return Instance.CallMethod<int>("getStrength", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/text/CollationKey;")]
		public CollationKey getCollationKey(String arg0)
		{
			return Instance.CallMethod<CollationKey>("getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", arg0);
		}
		
		[JavaSignature("()I")]
		public int getDecomposition()
		{
			return Instance.CallMethod<int>("getDecomposition", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void setDecomposition(int arg0)
		{
			Instance.CallMethod("setDecomposition", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setStrength(int arg0)
		{
			Instance.CallMethod("setStrength", "(I)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Comparator;")]
		public Comparator<IJavaObject> reversed()
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("reversed", "()Ljava/util/Comparator;");
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/Comparator;")]
		public Comparator<IJavaObject> thenComparing<U>(Function<IJavaObject, U> arg0)
			where U : Comparable<IJavaObject>
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("thenComparing", "(Ljava/util/function/Function;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Comparator;")]
		public Comparator<IJavaObject> thenComparing(Comparator<IJavaObject> arg0)
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("thenComparing", "(Ljava/util/Comparator;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;")]
		public Comparator<IJavaObject> thenComparing<U>(Function<IJavaObject, U> arg0, Comparator<IJavaObject> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("thenComparing", "(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;")]
		public Comparator<IJavaObject> thenComparingDouble(ToDoubleFunction<IJavaObject> arg0)
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("thenComparingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;")]
		public Comparator<IJavaObject> thenComparingInt(ToIntFunction<IJavaObject> arg0)
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("thenComparingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;")]
		public Comparator<IJavaObject> thenComparingLong(ToLongFunction<IJavaObject> arg0)
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("thenComparingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;", arg0);
		}
	}
}
