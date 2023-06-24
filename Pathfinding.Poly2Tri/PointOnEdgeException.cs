using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class PointOnEdgeException : NotImplementedException
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x28ADA60", Offset = "0x28AC060", VA = "0x1828ADA60")]
		public PointOnEdgeException(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c)
		{
		}

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x90")]
		public readonly TriangulationPoint A;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x98")]
		public readonly TriangulationPoint B;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xA0")]
		public readonly TriangulationPoint C;
	}
}
