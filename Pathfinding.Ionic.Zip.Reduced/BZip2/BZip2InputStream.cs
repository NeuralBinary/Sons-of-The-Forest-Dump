using System;
using System.IO;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.BZip2
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class BZip2InputStream : Stream
	{
		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2882EE0", Offset = "0x28814E0", VA = "0x182882EE0")]
		public BZip2InputStream(Stream input)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2883030", Offset = "0x2881630", VA = "0x182883030")]
		public BZip2InputStream(Stream input, bool leaveOpen)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2883190", Offset = "0x2881790", VA = "0x182883190", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x2883470", Offset = "0x2881A70", VA = "0x182883470")]
		private void MakeMaps()
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x28834E0", Offset = "0x2881AE0", VA = "0x1828834E0", Slot = "35")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x170000C9")]
		public override bool CanRead
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x28838C0", Offset = "0x2881EC0", VA = "0x1828838C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x170000CA")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x170000CB")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2883950", Offset = "0x2881F50", VA = "0x182883950", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x28839E0", Offset = "0x2881FE0", VA = "0x1828839E0", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x170000CC")]
		public override long Length
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2883A60", Offset = "0x2882060", VA = "0x182883A60", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		public override long Position
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2883AA0", Offset = "0x28820A0", VA = "0x182883AA0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2883AE0", Offset = "0x28820E0", VA = "0x182883AE0", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2883B20", Offset = "0x2882120", VA = "0x182883B20", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2883B60", Offset = "0x2882160", VA = "0x182883B60", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2883BA0", Offset = "0x28821A0", VA = "0x182883BA0", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2883C20", Offset = "0x2882220", VA = "0x182883C20")]
		private void init()
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2883DF0", Offset = "0x28823F0", VA = "0x182883DF0")]
		private void CheckMagicChar(char expected, int position)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2883F10", Offset = "0x2882510", VA = "0x182883F10")]
		private void InitBlock()
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2884280", Offset = "0x2882880", VA = "0x182884280")]
		private void EndBlock()
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2884370", Offset = "0x2882970", VA = "0x182884370")]
		private void complete()
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2884490", Offset = "0x2882A90", VA = "0x182884490", Slot = "19")]
		public override void Close()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x28845D0", Offset = "0x2882BD0", VA = "0x1828845D0")]
		private int GetBits(int n)
		{
			return 0;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x28846B0", Offset = "0x2882CB0", VA = "0x1828846B0")]
		private bool bsGetBit()
		{
			return default(bool);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x28846D0", Offset = "0x2882CD0", VA = "0x1828846D0")]
		private char bsGetUByte()
		{
			return '\0';
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x28846E0", Offset = "0x2882CE0", VA = "0x1828846E0")]
		private uint bsGetInt()
		{
			return 0U;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2884760", Offset = "0x2882D60", VA = "0x182884760")]
		private static void hbCreateDecodeTables(int[] limit, int[] bbase, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x28849F0", Offset = "0x2882FF0", VA = "0x1828849F0")]
		private void recvDecodingTables()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2884DA0", Offset = "0x28833A0", VA = "0x182884DA0")]
		private void createHuffmanDecodingTables(int alphaSize, int nGroups)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2885160", Offset = "0x2883760", VA = "0x182885160")]
		private void getAndMoveToFrontDecode()
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2885D10", Offset = "0x2884310", VA = "0x182885D10")]
		private int getAndMoveToFrontDecode0(int groupNo)
		{
			return 0;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2885F00", Offset = "0x2884500", VA = "0x182885F00")]
		private void SetupBlock()
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x28863E0", Offset = "0x28849E0", VA = "0x1828863E0")]
		private void SetupRandPartA()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2886560", Offset = "0x2884B60", VA = "0x182886560")]
		private void SetupNoRandPartA()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2886630", Offset = "0x2884C30", VA = "0x182886630")]
		private void SetupRandPartB()
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x28867B0", Offset = "0x2884DB0", VA = "0x1828867B0")]
		private void SetupRandPartC()
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2886820", Offset = "0x2884E20", VA = "0x182886820")]
		private void SetupNoRandPartB()
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x28868D0", Offset = "0x2884ED0", VA = "0x1828868D0")]
		private void SetupNoRandPartC()
		{
		}

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x28")]
		private bool _disposed;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x29")]
		private bool _leaveOpen;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x30")]
		private long totalBytesRead;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x38")]
		private int last;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x3C")]
		private int origPtr;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x40")]
		private int blockSize100k;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x44")]
		private bool blockRandomised;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x48")]
		private int bsBuff;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x4C")]
		private int bsLive;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x50")]
		private readonly CRC32 crc;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x58")]
		private int nInUse;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x60")]
		private Stream input;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x68")]
		private int currentChar;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x6C")]
		private BZip2InputStream.CState currentState;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x70")]
		private uint storedBlockCRC;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x74")]
		private uint storedCombinedCRC;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x78")]
		private uint computedBlockCRC;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x7C")]
		private uint computedCombinedCRC;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x80")]
		private int su_count;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x84")]
		private int su_ch2;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x88")]
		private int su_chPrev;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x8C")]
		private int su_i2;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x90")]
		private int su_j2;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x94")]
		private int su_rNToGo;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x98")]
		private int su_rTPos;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x9C")]
		private int su_tPos;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0xA0")]
		private char su_z;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xA8")]
		private BZip2InputStream.DecompressionState data;

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		private enum CState
		{
			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			EOF,
			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40001C6")]
			START_BLOCK,
			// Token: 0x040001C7 RID: 455
			[Token(Token = "0x40001C7")]
			RAND_PART_A,
			// Token: 0x040001C8 RID: 456
			[Token(Token = "0x40001C8")]
			RAND_PART_B,
			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40001C9")]
			RAND_PART_C,
			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40001CA")]
			NO_RAND_PART_A,
			// Token: 0x040001CB RID: 459
			[Token(Token = "0x40001CB")]
			NO_RAND_PART_B,
			// Token: 0x040001CC RID: 460
			[Token(Token = "0x40001CC")]
			NO_RAND_PART_C
		}

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		private sealed class DecompressionState
		{
			// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2886940", Offset = "0x2884F40", VA = "0x182886940")]
			public DecompressionState(int blockSize100k)
			{
			}

			// Token: 0x06000335 RID: 821 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x28870D0", Offset = "0x28856D0", VA = "0x1828870D0")]
			public int[] initTT(int length)
			{
				return null;
			}

			// Token: 0x040001CD RID: 461
			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool[] inUse;

			// Token: 0x040001CE RID: 462
			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x18")]
			public readonly byte[] seqToUnseq;

			// Token: 0x040001CF RID: 463
			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x20")]
			public readonly byte[] selector;

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x28")]
			public readonly byte[] selectorMtf;

			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x30")]
			public readonly int[] unzftab;

			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x38")]
			public readonly int[][] gLimit;

			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x40")]
			public readonly int[][] gBase;

			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x48")]
			public readonly int[][] gPerm;

			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x50")]
			public readonly int[] gMinlen;

			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x58")]
			public readonly int[] cftab;

			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x60")]
			public readonly byte[] getAndMoveToFrontDecode_yy;

			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x68")]
			public readonly char[][] temp_charArray2d;

			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x70")]
			public readonly byte[] recvDecodingTables_pos;

			// Token: 0x040001DA RID: 474
			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x78")]
			public int[] tt;

			// Token: 0x040001DB RID: 475
			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x80")]
			public byte[] ll8;
		}
	}
}
