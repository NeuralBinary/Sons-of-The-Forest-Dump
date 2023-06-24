using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Data
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	internal class BadTriangle
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x24D2800", Offset = "0x24D0E00", VA = "0x1824D2800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BadTriangle()
		{
		}

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x10")]
		public Otri poortri;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x20")]
		public double key;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x28")]
		public Vertex org;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x30")]
		public Vertex dest;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x38")]
		public Vertex apex;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x40")]
		public BadTriangle next;
	}
}
