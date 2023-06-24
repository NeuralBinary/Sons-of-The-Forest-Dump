using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public class InputTriangle : ITriangle
	{
		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x24DF460", Offset = "0x24DDA60", VA = "0x1824DF460")]
		public InputTriangle(int p0, int p1, int p2)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public int ID
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00003000 File Offset: 0x00001200
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public int Label
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008D")]
		public double Area
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10", Slot = "8")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "10")]
		public Vertex GetVertex(int index)
		{
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x175F3B0", Offset = "0x175D9B0", VA = "0x18175F3B0", Slot = "11")]
		public int GetVertexID(int index)
		{
			return 0;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "12")]
		public ITriangle GetNeighbor(int index)
		{
			return null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60", Slot = "13")]
		public int GetNeighborID(int index)
		{
			return 0;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "14")]
		public ISegment GetSegment(int index)
		{
			return null;
		}

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x10")]
		internal int[] vertices;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x18")]
		internal int label;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x20")]
		internal double area;
	}
}
