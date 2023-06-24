using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class ParallelBZip2OutputStream : Stream
	{
		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x28887D0", Offset = "0x2886DD0", VA = "0x1828887D0")]
		public ParallelBZip2OutputStream(Stream output)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2888850", Offset = "0x2886E50", VA = "0x182888850")]
		public ParallelBZip2OutputStream(Stream output, int blockSize)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2888870", Offset = "0x2886E70", VA = "0x182888870")]
		public ParallelBZip2OutputStream(Stream output, bool leaveOpen)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2888900", Offset = "0x2886F00", VA = "0x182888900")]
		public ParallelBZip2OutputStream(Stream output, int blockSize, bool leaveOpen)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2888E50", Offset = "0x2887450", VA = "0x182888E50")]
		private void InitializePoolOfWorkItems()
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		public int MaxWorkers
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2889290", Offset = "0x2887890", VA = "0x182889290")]
			set
			{
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2889310", Offset = "0x2887910", VA = "0x182889310", Slot = "19")]
		public override void Close()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x2889500", Offset = "0x2887B00", VA = "0x182889500")]
		private void FlushOutput(bool lastInput)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x28896F0", Offset = "0x2887CF0", VA = "0x1828896F0", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2889760", Offset = "0x2887D60", VA = "0x182889760")]
		private void EmitHeader()
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2889820", Offset = "0x2887E20", VA = "0x182889820")]
		private void EmitTrailer()
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x170000D9")]
		public int BlockSize
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2889950", Offset = "0x2887F50", VA = "0x182889950", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2889E20", Offset = "0x2888420", VA = "0x182889E20")]
		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x288A600", Offset = "0x2888C00", VA = "0x18288A600")]
		private void CompressOne(object wi)
		{
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x170000DA")]
		public override bool CanRead
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x170000DB")]
		public override bool CanSeek
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x170000DC")]
		public override bool CanWrite
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x288A920", Offset = "0x2888F20", VA = "0x18288A920", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x170000DD")]
		public override long Length
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x288A9A0", Offset = "0x2888FA0", VA = "0x18288A9A0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000037C8 File Offset: 0x000019C8
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DE")]
		public override long Position
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x288A9E0", Offset = "0x2888FE0", VA = "0x18288A9E0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x170000DF")]
		public long BytesWrittenOut
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x288AA20", Offset = "0x2889020", VA = "0x18288AA20", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x288AA60", Offset = "0x2889060", VA = "0x18288AA60", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x288AAA0", Offset = "0x28890A0", VA = "0x18288AAA0", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x288AAE0", Offset = "0x28890E0", VA = "0x18288AAE0")]
		[Conditional("Trace")]
		private void TraceOutput(ParallelBZip2OutputStream.TraceBits bits, string format, params object[] varParams)
		{
		}

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BufferPairsPerCore;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x28")]
		private int _maxWorkers;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x2C")]
		private bool firstWriteDone;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x30")]
		private int lastFilled;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x34")]
		private int lastWritten;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x38")]
		private int latestCompressed;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x3C")]
		private int currentlyFilling;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x40")]
		private Exception pendingException;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x48")]
		private bool handlingException;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x49")]
		private bool emitting;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x50")]
		private Queue<int> toWrite;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x58")]
		private Queue<int> toFill;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x60")]
		private List<WorkItem> pool;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x68")]
		private object latestLock;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x70")]
		private object eLock;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x78")]
		private object outputLock;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x80")]
		private AutoResetEvent newlyCompressedBlob;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x88")]
		private long totalBytesWrittenIn;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x90")]
		private long totalBytesWrittenOut;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x98")]
		private bool leaveOpen;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x9C")]
		private uint combinedCRC;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0xA0")]
		private Stream output;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0xA8")]
		private BitWriter bw;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0xB0")]
		private int blockSize100k;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0xB4")]
		private ParallelBZip2OutputStream.TraceBits desiredTrace;

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		[Flags]
		private enum TraceBits : uint
		{
			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			None = 0U,
			// Token: 0x0400021A RID: 538
			[Token(Token = "0x400021A")]
			Crc = 1U,
			// Token: 0x0400021B RID: 539
			[Token(Token = "0x400021B")]
			Write = 2U,
			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			All = 4294967295U
		}
	}
}
