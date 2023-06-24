using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	internal class BlobSend
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000006")]
		public BlobTransportEndpoint Endpoint
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x17000007")]
		public int BlobId
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x17000008")]
		public bool Complete
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x76BE10", Offset = "0x76A410", VA = "0x18076BE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x17000009")]
		public long TransferTimeMs
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x76BE20", Offset = "0x76A420", VA = "0x18076BE20")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x76BE30", Offset = "0x76A430", VA = "0x18076BE30")]
		public BlobSend(BlobTransportEndpoint ep, byte[] data, byte channel, Stopwatch sw)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x76C330", Offset = "0x76A930", VA = "0x18076C330")]
		public Block CreateNextBlock()
		{
			return default(Block);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x76C7C0", Offset = "0x76ADC0", VA = "0x18076C7C0")]
		public bool CanSendNextBlock()
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x76D2B0", Offset = "0x76B8B0", VA = "0x18076D2B0")]
		public bool AckBlock(BlockAck blockAck)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x76D440", Offset = "0x76BA40", VA = "0x18076D440")]
		private Block CreateBlock(int blockId)
		{
			return default(Block);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x76D5F0", Offset = "0x76BBF0", VA = "0x18076D5F0")]
		private int GetNextBlobId()
		{
			return 0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x76D7B0", Offset = "0x76BDB0", VA = "0x18076D7B0")]
		private static double Lerp(double a, double b, double t)
		{
			return 0.0;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x76D7C0", Offset = "0x76BDC0", VA = "0x18076D7C0")]
		private float Progress()
		{
			return 0f;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x76D810", Offset = "0x76BE10", VA = "0x18076D810")]
		private double EffectiveBandwidth()
		{
			return 0.0;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x76D890", Offset = "0x76BE90", VA = "0x18076D890")]
		private string Status()
		{
			return null;
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		private static int _nextBlobId;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object _nextBlobIdLock;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		private Stopwatch _stopwatch;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		private BlobTransportEndpoint _ep;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _data;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		private Queue<int> _mainBlockQueue;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		private Queue<int> _retryBlockQueue;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<int> _blockAcks;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		private byte _channel;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x44")]
		private int _blobId;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		private int _blockCount;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		private long _totalSentBlocks;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		private long _totalReceivedAcks;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x60")]
		private long _startTimeMs;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x68")]
		private long _completionTimeMs;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x70")]
		private double _blockSendReserve;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x78")]
		private long _lastBlockSendReserveUpdateTimeMs;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x80")]
		private long _lastBlockSendLogStatusTimeMs;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x88")]
		private readonly Queue<long> _lastReceivedAcksMeasureWindow;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x90")]
		private readonly Queue<long> _lastOutgoingBlocksMeasureWindow;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x98")]
		private double _measuredAckPerMs;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xA0")]
		private double _measuredOutgoingBlocksPerMs;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xA8")]
		private long _postQueueSwapTimeMs;
	}
}
