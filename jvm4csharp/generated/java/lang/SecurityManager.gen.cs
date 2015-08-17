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
using jvm4csharp.java.net;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/SecurityManager")]
	public class SecurityManager : Object
	{
		protected SecurityManager(ProxyCtor p) : base(p) {}
		
		public SecurityManager() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkPackageAccess(String arg0)
		{
			Instance.CallMethod("checkPackageAccess", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;I)V")]
		public void checkMemberAccess(Class<IJavaObject> arg0, int arg1)
		{
			Instance.CallMethod("checkMemberAccess", "(Ljava/lang/Class;I)V", arg0, arg1);
		}
		
		[JavaSignature("()V")]
		public void checkCreateClassLoader()
		{
			Instance.CallMethod("checkCreateClassLoader", "()V");
		}
		
		[JavaSignature("()V")]
		public void checkPropertiesAccess()
		{
			Instance.CallMethod("checkPropertiesAccess", "()V");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkPropertyAccess(String arg0)
		{
			Instance.CallMethod("checkPropertyAccess", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/ThreadGroup;")]
		public ThreadGroup getThreadGroup()
		{
			return Instance.CallMethod<ThreadGroup>("getThreadGroup", "()Ljava/lang/ThreadGroup;");
		}
		
		[JavaSignature("(Ljava/lang/String;I)V")]
		public void checkAccept(String arg0, int arg1)
		{
			Instance.CallMethod("checkAccept", "(Ljava/lang/String;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/ThreadGroup;)V")]
		public void checkAccess(ThreadGroup arg0)
		{
			Instance.CallMethod("checkAccess", "(Ljava/lang/ThreadGroup;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread;)V")]
		public void checkAccess(Thread arg0)
		{
			Instance.CallMethod("checkAccess", "(Ljava/lang/Thread;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void checkAwtEventQueueAccess()
		{
			Instance.CallMethod("checkAwtEventQueueAccess", "()V");
		}
		
		[JavaSignature("(Ljava/lang/String;ILjava/lang/Object;)V")]
		public void checkConnect(String arg0, int arg1, IJavaObject arg2)
		{
			Instance.CallMethod("checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;I)V")]
		public void checkConnect(String arg0, int arg1)
		{
			Instance.CallMethod("checkConnect", "(Ljava/lang/String;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkDelete(String arg0)
		{
			Instance.CallMethod("checkDelete", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkExec(String arg0)
		{
			Instance.CallMethod("checkExec", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void checkExit(int arg0)
		{
			Instance.CallMethod("checkExit", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkLink(String arg0)
		{
			Instance.CallMethod("checkLink", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void checkListen(int arg0)
		{
			Instance.CallMethod("checkListen", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;B)V")]
		public void checkMulticast(InetAddress arg0, byte arg1)
		{
			Instance.CallMethod("checkMulticast", "(Ljava/net/InetAddress;B)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)V")]
		public void checkMulticast(InetAddress arg0)
		{
			Instance.CallMethod("checkMulticast", "(Ljava/net/InetAddress;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkPackageDefinition(String arg0)
		{
			Instance.CallMethod("checkPackageDefinition", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void checkPrintJobAccess()
		{
			Instance.CallMethod("checkPrintJobAccess", "()V");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkRead(String arg0)
		{
			Instance.CallMethod("checkRead", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/Object;)V")]
		public void checkRead(String arg0, IJavaObject arg1)
		{
			Instance.CallMethod("checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/io/FileDescriptor;)V")]
		public void checkRead(FileDescriptor arg0)
		{
			Instance.CallMethod("checkRead", "(Ljava/io/FileDescriptor;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkSecurityAccess(String arg0)
		{
			Instance.CallMethod("checkSecurityAccess", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void checkSetFactory()
		{
			Instance.CallMethod("checkSetFactory", "()V");
		}
		
		[JavaSignature("()V")]
		public void checkSystemClipboardAccess()
		{
			Instance.CallMethod("checkSystemClipboardAccess", "()V");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool checkTopLevelWindow(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("checkTopLevelWindow", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void checkWrite(String arg0)
		{
			Instance.CallMethod("checkWrite", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/FileDescriptor;)V")]
		public void checkWrite(FileDescriptor arg0)
		{
			Instance.CallMethod("checkWrite", "(Ljava/io/FileDescriptor;)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool getInCheck()
		{
			return Instance.CallMethod<bool>("getInCheck", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject getSecurityContext()
		{
			return Instance.CallMethod<IJavaObject>("getSecurityContext", "()Ljava/lang/Object;");
		}
	}
}
