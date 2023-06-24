using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class BlobReceive
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000001")]
		public byte[] Data
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000002")]
		public bool Complete
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x76B600", Offset = "0x769C00", VA = "0x18076B600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000003")]
		public long TransferTimeMs
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x76B610", Offset = "0x769C10", VA = "0x18076B610")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000004")]
		public BlobTransportEndpoint Endpoint
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x17000005")]
		public byte Channel
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x76B620", Offset = "0x769C20", VA = "0x18076B620")]
		public BlobReceive(BlobTransportEndpoint ep, Block block, Stopwatch sw)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x76BB00", Offset = "0x76A100", VA = "0x18076BB00")]
		public bool PushBlock(Block block)
		{
			return default(bool);
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private BlobTransportEndpoint _ep;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _data;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<int> _missingBlocks;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		private byte _channel;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x2C")]
		private int _blobId;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		private int _blockCount;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x34")]
		private int _duplicateReceivedCount;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		private long _startTimeMs;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x40")]
		private long _completionTimeMs;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x48")]
		private Stopwatch _stopwatch;
	}
}
