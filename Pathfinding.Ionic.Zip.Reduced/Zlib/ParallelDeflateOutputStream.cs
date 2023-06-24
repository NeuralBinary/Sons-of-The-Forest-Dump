using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public class ParallelDeflateOutputStream : Stream
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2899A60", Offset = "0x2898060", VA = "0x182899A60")]
		public ParallelDeflateOutputStream(Stream stream)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2899A90", Offset = "0x2898090", VA = "0x182899A90")]
		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2899AB0", Offset = "0x28980B0", VA = "0x182899AB0")]
		public ParallelDeflateOutputStream(Stream stream, bool leaveOpen)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2899AE0", Offset = "0x28980E0", VA = "0x182899AE0")]
		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level, bool leaveOpen)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2899B10", Offset = "0x2898110", VA = "0x182899B10")]
		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level, CompressionStrategy strategy, bool leaveOpen)
		{
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00003DC8 File Offset: 0x00001FC8
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F8")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xAFF3C0", Offset = "0xAFD9C0", VA = "0x180AFF3C0")]
			[CompilerGenerated]
			get
			{
				return CompressionStrategy.Default;
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xAFF3D0", Offset = "0xAFD9D0", VA = "0x180AFF3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00003DE0 File Offset: 0x00001FE0
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F9")]
		public int MaxBufferPairs
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x2899DB0", Offset = "0x28983B0", VA = "0x182899DB0")]
			set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00003DF8 File Offset: 0x00001FF8
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FA")]
		public int BufferSize
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x2899E30", Offset = "0x2898430", VA = "0x182899E30")]
			set
			{
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x170000FB")]
		public int Crc32
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x671130", Offset = "0x66F730", VA = "0x180671130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x170000FC")]
		public long BytesProcessed
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2899EC0", Offset = "0x28984C0", VA = "0x182899EC0")]
		private void _InitializePoolOfWorkItems()
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x289A3B0", Offset = "0x28989B0", VA = "0x18289A3B0", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x289A690", Offset = "0x2898C90", VA = "0x18289A690")]
		private void _FlushFinish()
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x289A900", Offset = "0x2898F00", VA = "0x18289A900")]
		private void _Flush(bool lastInput)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x289AA10", Offset = "0x2899010", VA = "0x18289AA10", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x289AA90", Offset = "0x2899090", VA = "0x18289AA90", Slot = "19")]
		public override void Close()
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x289AB30", Offset = "0x2899130", VA = "0x18289AB30", Slot = "39")]
		public new void Dispose()
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x289ABB0", Offset = "0x28991B0", VA = "0x18289ABB0")]
		public void Reset(Stream stream)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x289AF70", Offset = "0x2899570", VA = "0x18289AF70")]
		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x289B5F0", Offset = "0x2899BF0", VA = "0x18289B5F0")]
		private void _DeflateOne(object wi)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x289BAE0", Offset = "0x289A0E0", VA = "0x18289BAE0")]
		private bool DeflateOneSegment(WorkItem workitem)
		{
			return default(bool);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x289BC60", Offset = "0x289A260", VA = "0x18289BC60")]
		[Conditional("Trace")]
		private void TraceOutput(ParallelDeflateOutputStream.TraceBits bits, string format, params object[] varParams)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x170000FD")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x170000FE")]
		public override bool CanRead
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x170000FF")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x289BE90", Offset = "0x289A490", VA = "0x18289BE90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x17000100")]
		public override long Length
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x289BEC0", Offset = "0x289A4C0", VA = "0x18289BEC0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00003EB8 File Offset: 0x000020B8
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000101")]
		public override long Position
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x289BF00", Offset = "0x289A500", VA = "0x18289BF00", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x289BF30", Offset = "0x289A530", VA = "0x18289BF30", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x289BF70", Offset = "0x289A570", VA = "0x18289BF70", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x289BFB0", Offset = "0x289A5B0", VA = "0x18289BFB0", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x289BFF0", Offset = "0x289A5F0", VA = "0x18289BFF0", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int IO_BUFFER_SIZE_DEFAULT;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BufferPairsPerCore;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x28")]
		private List<WorkItem> _pool;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x30")]
		private bool _leaveOpen;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x31")]
		private bool emitting;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x38")]
		private Stream _outStream;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x40")]
		private int _maxBufferPairs;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x44")]
		private int _bufferSize;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x48")]
		private AutoResetEvent _newlyCompressedBlob;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x50")]
		private object _outputLock;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x58")]
		private bool _isClosed;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x59")]
		private bool _firstWriteDone;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x5C")]
		private int _currentlyFilling;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x60")]
		private int _lastFilled;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x64")]
		private int _lastWritten;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x68")]
		private int _latestCompressed;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x6C")]
		private int _Crc32;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x70")]
		private CRC32 _runningCrc;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x78")]
		private object _latestLock;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x80")]
		private Queue<int> _toWrite;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x88")]
		private Queue<int> _toFill;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x90")]
		private long _totalBytesProcessed;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x98")]
		private CompressionLevel _compressLevel;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0xA0")]
		private Exception _pendingException;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0xA8")]
		private bool _handlingException;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0xB0")]
		private object _eLock;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0xB8")]
		private ParallelDeflateOutputStream.TraceBits _DesiredTrace;

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		[Flags]
		private enum TraceBits : uint
		{
			// Token: 0x04000317 RID: 791
			[Token(Token = "0x4000317")]
			None = 0U,
			// Token: 0x04000318 RID: 792
			[Token(Token = "0x4000318")]
			NotUsed1 = 1U,
			// Token: 0x04000319 RID: 793
			[Token(Token = "0x4000319")]
			EmitLock = 2U,
			// Token: 0x0400031A RID: 794
			[Token(Token = "0x400031A")]
			EmitEnter = 4U,
			// Token: 0x0400031B RID: 795
			[Token(Token = "0x400031B")]
			EmitBegin = 8U,
			// Token: 0x0400031C RID: 796
			[Token(Token = "0x400031C")]
			EmitDone = 16U,
			// Token: 0x0400031D RID: 797
			[Token(Token = "0x400031D")]
			EmitSkip = 32U,
			// Token: 0x0400031E RID: 798
			[Token(Token = "0x400031E")]
			EmitAll = 58U,
			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			Flush = 64U,
			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			Lifecycle = 128U,
			// Token: 0x04000321 RID: 801
			[Token(Token = "0x4000321")]
			Session = 256U,
			// Token: 0x04000322 RID: 802
			[Token(Token = "0x4000322")]
			Synch = 512U,
			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			Instance = 1024U,
			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4000324")]
			Compress = 2048U,
			// Token: 0x04000325 RID: 805
			[Token(Token = "0x4000325")]
			Write = 4096U,
			// Token: 0x04000326 RID: 806
			[Token(Token = "0x4000326")]
			WriteEnter = 8192U,
			// Token: 0x04000327 RID: 807
			[Token(Token = "0x4000327")]
			WriteTake = 16384U,
			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			All = 4294967295U
		}
	}
}
