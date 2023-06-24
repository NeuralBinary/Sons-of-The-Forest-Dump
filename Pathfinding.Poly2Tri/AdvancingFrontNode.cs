using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class AdvancingFrontNode
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x28A72D0", Offset = "0x28A58D0", VA = "0x1828A72D0")]
		public AdvancingFrontNode(TriangulationPoint point)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000009")]
		public bool HasNext
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x28A7340", Offset = "0x28A5940", VA = "0x1828A7340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x1700000A")]
		public bool HasPrev
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x12AF770", Offset = "0x12ADD70", VA = "0x1812AF770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode Next;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode Prev;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public double Value;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		public TriangulationPoint Point;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		public DelaunayTriangle Triangle;
	}
}
