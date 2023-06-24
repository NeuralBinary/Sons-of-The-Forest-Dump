using System;
using System.Threading;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	internal class ThreadControlQueue
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x66C9F0", Offset = "0x66AFF0", VA = "0x18066C9F0")]
		public ThreadControlQueue(int numReceivers)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x170000BD")]
		public bool IsEmpty
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x66CB40", Offset = "0x66B140", VA = "0x18066CB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x170000BE")]
		public bool IsTerminating
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x66CB50", Offset = "0x66B150", VA = "0x18066CB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x66CB60", Offset = "0x66B160", VA = "0x18066CB60")]
		public void Block()
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x66CD10", Offset = "0x66B310", VA = "0x18066CD10")]
		public void Unblock()
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x66CEC0", Offset = "0x66B4C0", VA = "0x18066CEC0")]
		public void Lock()
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x66CF00", Offset = "0x66B500", VA = "0x18066CF00")]
		public void Unlock()
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x170000BF")]
		public bool AllReceiversBlocked
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x66CF30", Offset = "0x66B530", VA = "0x18066CF30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x66D0A0", Offset = "0x66B6A0", VA = "0x18066D0A0")]
		public void PushFront(Path path)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x66D440", Offset = "0x66BA40", VA = "0x18066D440")]
		public void Push(Path path)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x66D7D0", Offset = "0x66BDD0", VA = "0x18066D7D0")]
		private void Starving()
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x66D850", Offset = "0x66BE50", VA = "0x18066D850")]
		public void TerminateReceivers()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x66DA00", Offset = "0x66C000", VA = "0x18066DA00")]
		public Path Pop()
		{
			return null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x66DE90", Offset = "0x66C490", VA = "0x18066DE90")]
		public void ReceiverTerminated()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x66DEF0", Offset = "0x66C4F0", VA = "0x18066DEF0")]
		public Path PopNoBlock(bool blockedBefore)
		{
			return null;
		}

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x10")]
		private Path head;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x18")]
		private Path tail;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x20")]
		private readonly object lockObj;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x28")]
		private readonly int numReceivers;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x2C")]
		private bool blocked;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x30")]
		private int blockedReceivers;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x34")]
		private bool starving;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x35")]
		private bool terminate;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x38")]
		private ManualResetEvent block;

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		public class QueueTerminationException : Exception
		{
			// Token: 0x060003E2 RID: 994 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x66E290", Offset = "0x66C890", VA = "0x18066E290")]
			public QueueTerminationException()
			{
			}
		}
	}
}
