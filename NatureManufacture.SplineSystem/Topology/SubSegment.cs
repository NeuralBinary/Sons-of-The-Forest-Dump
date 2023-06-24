using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public class SubSegment : ISegment, IEdge
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x24B62E0", Offset = "0x24B48E0", VA = "0x1824B62E0")]
		public SubSegment()
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000037")]
		public int P0
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x24B6460", Offset = "0x24B4A60", VA = "0x1824B6460", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x17000038")]
		public int P1
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x24B6490", Offset = "0x24B4A90", VA = "0x1824B6490", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x17000039")]
		public int Label
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x24B64C0", Offset = "0x24B4AC0", VA = "0x1824B64C0", Slot = "4")]
		public Vertex GetVertex(int index)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x24B64F0", Offset = "0x24B4AF0", VA = "0x1824B64F0", Slot = "5")]
		public ITriangle GetTriangle(int index)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x24B6540", Offset = "0x24B4B40", VA = "0x1824B6540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x10")]
		internal int hash;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x18")]
		internal Osub[] subsegs;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x20")]
		internal Vertex[] vertices;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x28")]
		internal Otri[] triangles;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x30")]
		internal int boundary;
	}
}
