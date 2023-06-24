using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	internal sealed class InflateCodes
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		internal InflateCodes()
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2896F10", Offset = "0x2895510", VA = "0x182896F10")]
		internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2897040", Offset = "0x2895640", VA = "0x182897040")]
		internal int Process(InflateBlocks blocks, int r)
		{
			return 0;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2897B40", Offset = "0x2896140", VA = "0x182897B40")]
		internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		private const int START = 0;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		private const int LEN = 1;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		private const int LENEXT = 2;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		private const int DIST = 3;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		private const int DISTEXT = 4;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		private const int COPY = 5;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		private const int LIT = 6;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		private const int WASH = 7;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		private const int END = 8;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		private const int BADCODE = 9;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x10")]
		internal int mode;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x14")]
		internal int len;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x18")]
		internal int[] tree;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x20")]
		internal int tree_index;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x24")]
		internal int need;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x28")]
		internal int lit;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x2C")]
		internal int bitsToGet;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x30")]
		internal int dist;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x34")]
		internal byte lbits;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x35")]
		internal byte dbits;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x38")]
		internal int[] ltree;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x40")]
		internal int ltree_index;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x48")]
		internal int[] dtree;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x50")]
		internal int dtree_index;
	}
}
