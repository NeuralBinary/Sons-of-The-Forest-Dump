using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Data
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	internal class BadTriQueue
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x1700007F")]
		public int Count
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x24D2870", Offset = "0x24D0E70", VA = "0x1824D2870")]
		public BadTriQueue()
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x24D29F0", Offset = "0x24D0FF0", VA = "0x1824D29F0")]
		public void Enqueue(BadTriangle badtri)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x24D2D10", Offset = "0x24D1310", VA = "0x1824D2D10")]
		public void Enqueue(ref Otri enqtri, double minedge, Vertex apex, Vertex org, Vertex dest)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x24D2EF0", Offset = "0x24D14F0", VA = "0x1824D2EF0")]
		public BadTriangle Dequeue()
		{
			return null;
		}

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		private const double SQRT2 = 1.4142135623730951;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x10")]
		private BadTriangle[] queuefront;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x18")]
		private BadTriangle[] queuetail;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x20")]
		private int[] nextnonemptyq;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x28")]
		private int firstnonemptyq;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x2C")]
		private int count;
	}
}
