using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class VertexCirculator
	{
		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x24D15F0", Offset = "0x24CFBF0", VA = "0x1824D15F0")]
		public VertexCirculator(Mesh mesh)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x24D16C0", Offset = "0x24CFCC0", VA = "0x1824D16C0")]
		public IEnumerable<Vertex> EnumerateVertices(Vertex vertex)
		{
			return null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x24D17D0", Offset = "0x24CFDD0", VA = "0x1824D17D0")]
		public IEnumerable<ITriangle> EnumerateTriangles(Vertex vertex)
		{
			return null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x24D18E0", Offset = "0x24CFEE0", VA = "0x1824D18E0")]
		private void BuildCache(Vertex vertex, bool vertices)
		{
		}

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x10")]
		private List<Otri> cache;
	}
}
