using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class Vertex : Point
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public HalfEdge Leaving
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			set
			{
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x24B8320", Offset = "0x24B6920", VA = "0x1824B8320")]
		public Vertex(double x, double y)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x24B8340", Offset = "0x24B6940", VA = "0x1824B8340")]
		public Vertex(double x, double y, HalfEdge leaving)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x24B83A0", Offset = "0x24B69A0", VA = "0x1824B83A0")]
		public IEnumerable<HalfEdge> EnumerateEdges()
		{
			return null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x24B8440", Offset = "0x24B6A40", VA = "0x1824B8440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x30")]
		internal HalfEdge leaving;
	}
}
