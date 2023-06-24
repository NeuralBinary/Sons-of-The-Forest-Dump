using System;
using Il2CppDummyDll;

namespace TriangleNet.Topology.DCEL
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class HalfEdge
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public int ID
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public int Boundary
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public Vertex Origin
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public Face Face
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public HalfEdge Twin
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public HalfEdge Next
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			set
			{
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public HalfEdge(Vertex origin)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x24B8160", Offset = "0x24B6760", VA = "0x1824B8160")]
		public HalfEdge(Vertex origin, Face face)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x24B8280", Offset = "0x24B6880", VA = "0x1824B8280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x10")]
		internal int id;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x14")]
		internal int mark;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x18")]
		internal Vertex origin;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x20")]
		internal Face face;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x28")]
		internal HalfEdge twin;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x30")]
		internal HalfEdge next;
	}
}
