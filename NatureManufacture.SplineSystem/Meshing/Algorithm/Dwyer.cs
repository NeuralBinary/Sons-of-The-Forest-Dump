using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Algorithm
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public class Dwyer : ITriangulator
	{
		// Token: 0x060002C3 RID: 707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x24D2FE0", Offset = "0x24D15E0", VA = "0x1824D2FE0", Slot = "4")]
		public IMesh Triangulate(IList<Vertex> points, Configuration config)
		{
			return null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x24D3890", Offset = "0x24D1E90", VA = "0x1824D3890")]
		private void MergeHulls(ref Otri farleft, ref Otri innerleft, ref Otri innerright, ref Otri farright, int axis)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x24D5D40", Offset = "0x24D4340", VA = "0x1824D5D40")]
		private void DivconqRecurse(int left, int right, int axis, ref Otri farleft, ref Otri farright)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x24D6D70", Offset = "0x24D5370", VA = "0x1824D6D70")]
		private int RemoveGhosts(ref Otri startghost)
		{
			return 0;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1487590", Offset = "0x1485B90", VA = "0x181487590")]
		public Dwyer()
		{
		}

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x18")]
		public bool UseDwyer;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x20")]
		private Vertex[] sortarray;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x28")]
		private Mesh mesh;
	}
}
