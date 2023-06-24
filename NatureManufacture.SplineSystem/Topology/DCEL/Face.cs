using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class Face
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000028B0 File Offset: 0x00000AB0
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public int ID
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public HalfEdge Edge
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000028C8 File Offset: 0x00000AC8
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public bool Bounded
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			set
			{
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x24B7C10", Offset = "0x24B6210", VA = "0x1824B7C10")]
		public Face(Point generator)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x24B7CD0", Offset = "0x24B62D0", VA = "0x1824B7CD0")]
		public Face(Point generator, HalfEdge edge)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x24B7DB0", Offset = "0x24B63B0", VA = "0x1824B7DB0")]
		public IEnumerable<HalfEdge> EnumerateEdges()
		{
			return null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x24B7E50", Offset = "0x24B6450", VA = "0x1824B7E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Face Empty;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x10")]
		internal int id;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x18")]
		internal Point generator;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x20")]
		internal HalfEdge edge;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x28")]
		internal bool bounded;
	}
}
