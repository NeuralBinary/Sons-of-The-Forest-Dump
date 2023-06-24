using System;
using Il2CppDummyDll;

namespace TriangleNet.Tools
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class AdjacencyMatrix
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004F")]
		public int[] ColumnPointers
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000050")]
		public int[] RowIndices
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x24B8760", Offset = "0x24B6D60", VA = "0x1824B8760")]
		public AdjacencyMatrix(Mesh mesh)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x24B8960", Offset = "0x24B6F60", VA = "0x1824B8960")]
		public AdjacencyMatrix(int[] pcol, int[] irow)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x24B8B10", Offset = "0x24B7110", VA = "0x1824B8B10")]
		public int Bandwidth()
		{
			return 0;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x24B8C20", Offset = "0x24B7220", VA = "0x1824B8C20")]
		private int[] AdjacencyCount(Mesh mesh)
		{
			return null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x24B9130", Offset = "0x24B7730", VA = "0x1824B9130")]
		private int[] AdjacencySet(Mesh mesh, int[] pcol)
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x24B97A0", Offset = "0x24B7DA0", VA = "0x1824B97A0")]
		public void SortIndices()
		{
		}

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x10")]
		private int nnz;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x18")]
		private int[] pcol;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x20")]
		private int[] irow;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x28")]
		public readonly int N;
	}
}
