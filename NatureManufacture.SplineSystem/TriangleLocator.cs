using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class TriangleLocator
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x24A7080", Offset = "0x24A5680", VA = "0x1824A7080")]
		public TriangleLocator(Mesh mesh)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x24A70F0", Offset = "0x24A56F0", VA = "0x1824A70F0")]
		public TriangleLocator(Mesh mesh, IPredicates predicates)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x24A7340", Offset = "0x24A5940", VA = "0x1824A7340")]
		public void Update(ref Otri otri)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x24A73B0", Offset = "0x24A59B0", VA = "0x1824A73B0")]
		public void Reset()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x24A7420", Offset = "0x24A5A20", VA = "0x1824A7420")]
		public LocateResult PreciseLocate(Point searchpoint, ref Otri searchtri, bool stopatsubsegment)
		{
			return LocateResult.InTriangle;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x24A79D0", Offset = "0x24A5FD0", VA = "0x1824A79D0")]
		public LocateResult Locate(Point searchpoint, ref Otri searchtri)
		{
			return LocateResult.InTriangle;
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x10")]
		private TriangleSampler sampler;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x18")]
		private Mesh mesh;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x20")]
		private IPredicates predicates;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x28")]
		internal Otri recenttri;
	}
}
