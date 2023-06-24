using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class Triangle : ITriangle
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x24B65A0", Offset = "0x24B4BA0", VA = "0x1824B65A0")]
		public Triangle()
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public int ID
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public int Label
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public double Area
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1D0B420", Offset = "0x1D09A20", VA = "0x181D0B420", Slot = "8")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1D0B430", Offset = "0x1D09A30", VA = "0x181D0B430", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x24B64C0", Offset = "0x24B4AC0", VA = "0x1824B64C0", Slot = "10")]
		public Vertex GetVertex(int index)
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x24B6720", Offset = "0x24B4D20", VA = "0x1824B6720", Slot = "11")]
		public int GetVertexID(int index)
		{
			return 0;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x24B6760", Offset = "0x24B4D60", VA = "0x1824B6760", Slot = "12")]
		public ITriangle GetNeighbor(int index)
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x24B67B0", Offset = "0x24B4DB0", VA = "0x1824B67B0", Slot = "13")]
		public int GetNeighborID(int index)
		{
			return 0;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x24B64F0", Offset = "0x24B4AF0", VA = "0x1824B64F0", Slot = "14")]
		public ISegment GetSegment(int index)
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x24B6810", Offset = "0x24B4E10", VA = "0x1824B6810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x10")]
		internal int hash;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x14")]
		internal int id;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x18")]
		internal Otri[] neighbors;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x20")]
		internal Vertex[] vertices;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x28")]
		internal Osub[] subsegs;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x30")]
		internal int label;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x38")]
		internal double area;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x40")]
		internal bool infected;
	}
}
