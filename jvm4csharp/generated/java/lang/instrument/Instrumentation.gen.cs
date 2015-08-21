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
using jvm4csharp.java.util.jar;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.instrument
{
	[JavaProxy("java/lang/instrument/Instrumentation")]
	public partial interface Instrumentation : IJavaObject
	{
		[JavaSignature("(Ljava/lang/instrument/ClassFileTransformer;Z)V")]
		void addTransformer(ClassFileTransformer arg0, bool arg1);
		
		[JavaSignature("(Ljava/lang/instrument/ClassFileTransformer;)V")]
		void addTransformer(ClassFileTransformer arg0);
		
		[JavaSignature("(Ljava/util/jar/JarFile;)V")]
		void appendToBootstrapClassLoaderSearch(JarFile arg0);
		
		[JavaSignature("(Ljava/util/jar/JarFile;)V")]
		void appendToSystemClassLoaderSearch(JarFile arg0);
		
		[JavaSignature("()[Ljava/lang/Class;")]
		ObjectArray<Class<IJavaObject>> getAllLoadedClasses();
		
		[JavaSignature("(Ljava/lang/ClassLoader;)[Ljava/lang/Class;")]
		ObjectArray<Class<IJavaObject>> getInitiatedClasses(ClassLoader arg0);
		
		[JavaSignature("(Ljava/lang/Object;)J")]
		long getObjectSize(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		bool isModifiableClass(Class<IJavaObject> arg0);
		
		[JavaSignature("()Z")]
		bool isNativeMethodPrefixSupported();
		
		[JavaSignature("()Z")]
		bool isRedefineClassesSupported();
		
		[JavaSignature("()Z")]
		bool isRetransformClassesSupported();
		
		[JavaSignature("([Ljava/lang/instrument/ClassDefinition;)V")]
		void redefineClasses(ObjectArray<ClassDefinition> arg0);
		
		[JavaSignature("(Ljava/lang/instrument/ClassFileTransformer;)Z")]
		bool removeTransformer(ClassFileTransformer arg0);
		
		[JavaSignature("([Ljava/lang/Class;)V")]
		void retransformClasses(ObjectArray<Class<IJavaObject>> arg0);
		
		[JavaSignature("(Ljava/lang/instrument/ClassFileTransformer;Ljava/lang/String;)V")]
		void setNativeMethodPrefix(ClassFileTransformer arg0, String arg1);
	}
}
