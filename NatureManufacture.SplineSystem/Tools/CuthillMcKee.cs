using System;
using Il2CppDummyDll;

namespace TriangleNet.Tools
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class CuthillMcKee
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x24B9880", Offset = "0x24B7E80", VA = "0x1824B9880")]
		public int[] Renumber(Mesh mesh)
		{
			return null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x24B9910", Offset = "0x24B7F10", VA = "0x1824B9910")]
		public int[] Renumber(AdjacencyMatrix matrix)
		{
			return null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x24B9E10", Offset = "0x24B8410", VA = "0x1824B9E10")]
		private int[] GenerateRcm()
		{
			return null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x24BA1A0", Offset = "0x24B87A0", VA = "0x1824BA1A0")]
		private void Rcm(int root, int[] mask, int[] perm, int offset, ref int iccsze)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x24BA500", Offset = "0x24B8B00", VA = "0x1824BA500")]
		private void FindRoot(ref int root, int[] mask, ref int level_num, int[] level_row, int[] level, int offset)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x24BA740", Offset = "0x24B8D40", VA = "0x1824BA740")]
		private void GetLevelSet(ref int root, int[] mask, ref int level_num, int[] level_row, int[] level, int offset)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x24BA950", Offset = "0x24B8F50", VA = "0x1824BA950")]
		private void Degree(int root, int[] mask, int[] deg, ref int iccsze, int[] ls, int offset)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x24BAC10", Offset = "0x24B9210", VA = "0x1824BAC10")]
		private int PermBandwidth(int[] perm, int[] perm_inv)
		{
			return 0;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x24BADA0", Offset = "0x24B93A0", VA = "0x1824BADA0")]
		private int[] PermInverse(int[] perm)
		{
			return null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x24BAE30", Offset = "0x24B9430", VA = "0x1824BAE30")]
		private void ReverseVector(int[] a, int offset, int size)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x24BAED0", Offset = "0x24B94D0", VA = "0x1824BAED0")]
		private void Shift(int[] a, bool up)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CuthillMcKee()
		{
		}

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x10")]
		private AdjacencyMatrix matrix;
	}
}
