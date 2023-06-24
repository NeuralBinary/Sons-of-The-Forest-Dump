using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing.Algorithm
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public class Incremental : ITriangulator
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x24D73E0", Offset = "0x24D59E0", VA = "0x1824D73E0", Slot = "4")]
		public IMesh Triangulate(IList<Vertex> points, Configuration config)
		{
			return null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x24D7880", Offset = "0x24D5E80", VA = "0x1824D7880")]
		private void GetBoundingBox()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x24D7E10", Offset = "0x24D6410", VA = "0x1824D7E10")]
		private int RemoveBox()
		{
			return 0;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Incremental()
		{
		}

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x10")]
		private Mesh mesh;
	}
}
