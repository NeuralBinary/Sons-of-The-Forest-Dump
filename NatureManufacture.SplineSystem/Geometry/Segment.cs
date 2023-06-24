using System;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class Segment : ISegment, IEdge
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000033A8 File Offset: 0x000015A8
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B1")]
		public int Label
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x170000B2")]
		public int P0
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x210F730", Offset = "0x210DD30", VA = "0x18210F730", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003BB RID: 955 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x170000B3")]
		public int P1
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x24EADF0", Offset = "0x24E93F0", VA = "0x1824EADF0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x24EAE10", Offset = "0x24E9410", VA = "0x1824EAE10")]
		public Segment(Vertex v0, Vertex v1)
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9D2340", Offset = "0x9D0940", VA = "0x1809D2340")]
		public Segment(Vertex v0, Vertex v1, int label)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x24EAE30", Offset = "0x24E9430", VA = "0x1824EAE30", Slot = "4")]
		public Vertex GetVertex(int index)
		{
			return null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x24EAEA0", Offset = "0x24E94A0", VA = "0x1824EAEA0", Slot = "5")]
		public ITriangle GetTriangle(int index)
		{
			return null;
		}

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x10")]
		private Vertex v0;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x18")]
		private Vertex v1;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x20")]
		private int label;
	}
}
