using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	internal sealed class InfTree
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InfTree()
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2893F50", Offset = "0x2892550", VA = "0x182893F50")]
		private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
		{
			return 0;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2894850", Offset = "0x2892E50", VA = "0x182894850")]
		internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2894A50", Offset = "0x2893050", VA = "0x182894A50")]
		internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2894E30", Offset = "0x2893430", VA = "0x182894E30")]
		internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2894F20", Offset = "0x2893520", VA = "0x182894F20")]
		private void initWorkArea(int vsize)
		{
		}

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		private const int MANY = 1440;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		private const int Z_OK = 0;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		private const int Z_STREAM_END = 1;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		private const int Z_ERRNO = -1;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		internal const int fixed_bl = 9;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		internal const int fixed_bd = 5;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		internal const int BMAX = 15;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] fixed_tl;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] fixed_td;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[] cplens;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] cplext;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly int[] cpdist;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly int[] cpdext;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x10")]
		internal int[] hn;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x18")]
		internal int[] v;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x20")]
		internal int[] c;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x28")]
		internal int[] r;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x30")]
		internal int[] u;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x38")]
		internal int[] x;
	}
}
