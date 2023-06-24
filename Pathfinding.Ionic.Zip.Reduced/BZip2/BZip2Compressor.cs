using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.BZip2
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	internal class BZip2Compressor
	{
		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x287D810", Offset = "0x287BE10", VA = "0x18287D810")]
		public BZip2Compressor(BitWriter writer)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x287D880", Offset = "0x287BE80", VA = "0x18287D880")]
		public BZip2Compressor(BitWriter writer, int blockSize)
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x287DBD0", Offset = "0x287C1D0", VA = "0x18287DBD0")]
		private void Reset()
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x170000C5")]
		public int BlockSize
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00003420 File Offset: 0x00001620
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		public uint Crc32
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x287DC40", Offset = "0x287C240", VA = "0x18287DC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public int AvailableBytesOut
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x233AD40", Offset = "0x2339340", VA = "0x18233AD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x170000C8")]
		public int UncompressedBytes
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x287DC50", Offset = "0x287C250", VA = "0x18287DC50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x287DC60", Offset = "0x287C260", VA = "0x18287DC60")]
		public int Fill(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x287DD90", Offset = "0x287C390", VA = "0x18287DD90")]
		private int write0(byte b)
		{
			return 0;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x287DE40", Offset = "0x287C440", VA = "0x18287DE40")]
		private bool AddRunToOutputBlock(bool final)
		{
			return default(bool);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x287E180", Offset = "0x287C780", VA = "0x18287E180")]
		public void CompressAndWrite()
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x287E2F0", Offset = "0x287C8F0", VA = "0x18287E2F0")]
		private void randomiseBlock()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x287E430", Offset = "0x287CA30", VA = "0x18287E430")]
		private void mainSort()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x287EDF0", Offset = "0x287D3F0", VA = "0x18287EDF0")]
		private void blockSort()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x287EFF0", Offset = "0x287D5F0", VA = "0x18287EFF0")]
		private bool mainSimpleSort(BZip2Compressor.CompressionState dataShadow, int lo, int hi, int d)
		{
			return default(bool);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x287F760", Offset = "0x287DD60", VA = "0x18287F760")]
		private static void vswap(int[] fmap, int p1, int p2, int n)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x287F7E0", Offset = "0x287DDE0", VA = "0x18287F7E0")]
		private static byte med3(byte a, byte b, byte c)
		{
			return 0;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x287F820", Offset = "0x287DE20", VA = "0x18287F820")]
		private void mainQSort3(BZip2Compressor.CompressionState dataShadow, int loSt, int hiSt, int dSt)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x287FEB0", Offset = "0x287E4B0", VA = "0x18287FEB0")]
		private void generateMTFValues()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2880370", Offset = "0x287E970", VA = "0x182880370")]
		private static void hbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x28803F0", Offset = "0x287E9F0", VA = "0x1828803F0")]
		private void sendMTFValues()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x28809B0", Offset = "0x287EFB0", VA = "0x1828809B0")]
		private void sendMTFValues0(int nGroups, int alphaSize)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2880BD0", Offset = "0x287F1D0", VA = "0x182880BD0")]
		private static void hbMakeCodeLengths(byte[] len, int[] freq, BZip2Compressor.CompressionState state1, int alphaSize, int maxLen)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x28811C0", Offset = "0x287F7C0", VA = "0x1828811C0")]
		private int sendMTFValues1(int nGroups, int alphaSize)
		{
			return 0;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2881920", Offset = "0x287FF20", VA = "0x182881920")]
		private void sendMTFValues2(int nGroups, int nSelectors)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2881A10", Offset = "0x2880010", VA = "0x182881A10")]
		private void sendMTFValues3(int nGroups, int alphaSize)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2881BA0", Offset = "0x28801A0", VA = "0x182881BA0")]
		private void sendMTFValues4()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2881D80", Offset = "0x2880380", VA = "0x182881D80")]
		private void sendMTFValues5(int nGroups, int nSelectors)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2881E70", Offset = "0x2880470", VA = "0x182881E70")]
		private void sendMTFValues6(int nGroups, int alphaSize)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2881FE0", Offset = "0x28805E0", VA = "0x182881FE0")]
		private void sendMTFValues7(int nSelectors)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x28821D0", Offset = "0x28807D0", VA = "0x1828821D0")]
		private void moveToFrontCodeAndSend()
		{
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x10")]
		private int blockSize100k;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x14")]
		private int currentByte;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x18")]
		private int runLength;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x1C")]
		private int last;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x20")]
		private int outBlockFillThreshold;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x28")]
		private BZip2Compressor.CompressionState cstate;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x30")]
		private readonly CRC32 crc;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x38")]
		private BitWriter bw;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x40")]
		private int runs;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x44")]
		private int workDone;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x48")]
		private int workLimit;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x4C")]
		private bool firstAttempt;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x4D")]
		private bool blockRandomised;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x50")]
		private int origPtr;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x54")]
		private int nInUse;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x58")]
		private int nMTF;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SETMASK;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int CLEARMASK;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte GREATER_ICOST;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x9")]
		private static readonly byte LESSER_ICOST;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int SMALL_THRESH;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int DEPTH_THRESH;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int WORK_FACTOR;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] increments;

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		private class CompressionState
		{
			// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2882220", Offset = "0x2880820", VA = "0x182882220")]
			public CompressionState(int blockSize100k)
			{
			}

			// Token: 0x0400018D RID: 397
			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool[] inUse;

			// Token: 0x0400018E RID: 398
			[Token(Token = "0x400018E")]
			[FieldOffset(Offset = "0x18")]
			public readonly byte[] unseqToSeq;

			// Token: 0x0400018F RID: 399
			[Token(Token = "0x400018F")]
			[FieldOffset(Offset = "0x20")]
			public readonly int[] mtfFreq;

			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			[FieldOffset(Offset = "0x28")]
			public readonly byte[] selector;

			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			[FieldOffset(Offset = "0x30")]
			public readonly byte[] selectorMtf;

			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x38")]
			public readonly byte[] generateMTFValues_yy;

			// Token: 0x04000193 RID: 403
			[Token(Token = "0x4000193")]
			[FieldOffset(Offset = "0x40")]
			public byte[][] sendMTFValues_len;

			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x48")]
			public int[][] sendMTFValues_rfreq;

			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x50")]
			public readonly int[] sendMTFValues_fave;

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x58")]
			public readonly short[] sendMTFValues_cost;

			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x60")]
			public int[][] sendMTFValues_code;

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x68")]
			public readonly byte[] sendMTFValues2_pos;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x70")]
			public readonly bool[] sentMTFValues4_inUse16;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x78")]
			public readonly int[] stack_ll;

			// Token: 0x0400019B RID: 411
			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x80")]
			public readonly int[] stack_hh;

			// Token: 0x0400019C RID: 412
			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0x88")]
			public readonly int[] stack_dd;

			// Token: 0x0400019D RID: 413
			[Token(Token = "0x400019D")]
			[FieldOffset(Offset = "0x90")]
			public readonly int[] mainSort_runningOrder;

			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x98")]
			public readonly int[] mainSort_copy;

			// Token: 0x0400019F RID: 415
			[Token(Token = "0x400019F")]
			[FieldOffset(Offset = "0xA0")]
			public readonly bool[] mainSort_bigDone;

			// Token: 0x040001A0 RID: 416
			[Token(Token = "0x40001A0")]
			[FieldOffset(Offset = "0xA8")]
			public int[] heap;

			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0xB0")]
			public int[] weight;

			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0xB8")]
			public int[] parent;

			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			[FieldOffset(Offset = "0xC0")]
			public readonly int[] ftab;

			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			[FieldOffset(Offset = "0xC8")]
			public byte[] block;

			// Token: 0x040001A5 RID: 421
			[Token(Token = "0x40001A5")]
			[FieldOffset(Offset = "0xD0")]
			public int[] fmap;

			// Token: 0x040001A6 RID: 422
			[Token(Token = "0x40001A6")]
			[FieldOffset(Offset = "0xD8")]
			public char[] sfmap;

			// Token: 0x040001A7 RID: 423
			[Token(Token = "0x40001A7")]
			[FieldOffset(Offset = "0xE0")]
			public char[] quadrant;
		}
	}
}
