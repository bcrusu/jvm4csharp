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
using jvm4csharp.java.lang;
using jvm4csharp.java.nio.channels.spi;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/Pipe")]
	public abstract partial class Pipe : Object
	{
		protected Pipe(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/channels/Pipe;")]
		public static Pipe open()
		{
			return Static.CallMethod<Pipe>(typeof(Pipe), "open", "()Ljava/nio/channels/Pipe;");
		}
		
		[JavaSignature("()Ljava/nio/channels/Pipe/SourceChannel;")]
		public Pipe_.SourceChannel source()
		{
			return Instance.CallMethod<Pipe_.SourceChannel>("source", "()Ljava/nio/channels/Pipe/SourceChannel;");
		}
		
		[JavaSignature("()Ljava/nio/channels/Pipe/SinkChannel;")]
		public Pipe_.SinkChannel sink()
		{
			return Instance.CallMethod<Pipe_.SinkChannel>("sink", "()Ljava/nio/channels/Pipe/SinkChannel;");
		}
	}
	
	public static partial class Pipe_
	{
		[JavaProxy("java/nio/channels/Pipe/SinkChannel")]
		public abstract partial class SinkChannel : AbstractSelectableChannel, WritableByteChannel, GatheringByteChannel
		{
			protected SinkChannel(ProxyCtor p) : base(p) {}
		
			[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
			public int write(ByteBuffer arg0)
			{
				return Instance.CallMethod<int>("write", "(Ljava/nio/ByteBuffer;)I", arg0);
			}
			
			[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
			public long write(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
			{
				return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
			}
			
			[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
			public long write(ObjectArray<ByteBuffer> arg0)
			{
				return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;)J", arg0);
			}
		}
		
		[JavaProxy("java/nio/channels/Pipe/SourceChannel")]
		public abstract partial class SourceChannel : AbstractSelectableChannel, ReadableByteChannel, ScatteringByteChannel
		{
			protected SourceChannel(ProxyCtor p) : base(p) {}
		
			[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
			public int read(ByteBuffer arg0)
			{
				return Instance.CallMethod<int>("read", "(Ljava/nio/ByteBuffer;)I", arg0);
			}
			
			[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
			public long read(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
			{
				return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
			}
			
			[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
			public long read(ObjectArray<ByteBuffer> arg0)
			{
				return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;)J", arg0);
			}
		}
	}
}
