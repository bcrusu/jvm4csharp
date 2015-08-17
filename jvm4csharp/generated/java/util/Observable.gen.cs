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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Observable")]
	public class Observable : Object
	{
		protected Observable(ProxyCtor p) : base(p) {}
		
		public Observable() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/util/Observer;)V")]
		public void addObserver(Observer arg0)
		{
			Instance.CallMethod("addObserver", "(Ljava/util/Observer;)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int countObservers()
		{
			return Instance.CallMethod<int>("countObservers", "()I");
		}
		
		[JavaSignature("(Ljava/util/Observer;)V")]
		public void deleteObserver(Observer arg0)
		{
			Instance.CallMethod("deleteObserver", "(Ljava/util/Observer;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void deleteObservers()
		{
			Instance.CallMethod("deleteObservers", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool hasChanged()
		{
			return Instance.CallMethod<bool>("hasChanged", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void notifyObservers(IJavaObject arg0)
		{
			Instance.CallMethod("notifyObservers", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void notifyObservers()
		{
			Instance.CallMethod("notifyObservers", "()V");
		}
	}
}
