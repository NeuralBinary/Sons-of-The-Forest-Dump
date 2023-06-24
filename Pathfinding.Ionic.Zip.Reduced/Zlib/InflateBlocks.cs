using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	internal sealed class InflateBlocks
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x28952F0", Offset = "0x28938F0", VA = "0x1828952F0")]
		internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2895740", Offset = "0x2893D40", VA = "0x182895740")]
		internal uint Reset()
		{
			return 0U;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x28957F0", Offset = "0x2893DF0", VA = "0x1828957F0")]
		internal int Process(int r)
		{
			return 0;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2896B90", Offset = "0x2895190", VA = "0x182896B90")]
		internal void Free()
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2896C50", Offset = "0x2895250", VA = "0x182896C50")]
		internal void SetDictionary(byte[] d, int start, int n)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2896CA0", Offset = "0x28952A0", VA = "0x182896CA0")]
		internal int SyncPoint()
		{
			return 0;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2896CB0", Offset = "0x28952B0", VA = "0x182896CB0")]
		internal int Flush(int r)
		{
			return 0;
		}

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		private const int MANY = 1440;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] border;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x10")]
		private InflateBlocks.InflateBlockMode mode;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x14")]
		internal int left;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x18")]
		internal int table;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x1C")]
		internal int index;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x20")]
		internal int[] blens;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x28")]
		internal int[] bb;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x30")]
		internal int[] tb;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x38")]
		internal InflateCodes codes;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x40")]
		internal int last;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x48")]
		internal ZlibCodec _codec;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x50")]
		internal int bitk;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x54")]
		internal int bitb;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x58")]
		internal int[] hufts;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x60")]
		internal byte[] window;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x68")]
		internal int end;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x6C")]
		internal int readAt;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x70")]
		internal int writeAt;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x78")]
		internal object checkfn;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x80")]
		internal uint check;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x88")]
		internal InfTree inftree;

		// Token: 0x02000053 RID: 83
		[Token(Token = "0x2000053")]
		private enum InflateBlockMode
		{
			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			TYPE,
			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			LENS,
			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			STORED,
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			TABLE,
			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			BTREE,
			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			DTREE,
			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			CODES,
			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			DRY,
			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			DONE,
			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			BAD
		}
	}
}
