using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class DTSweepEdgeEvent
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DTSweepEdgeEvent()
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		public DTSweepConstraint ConstrainedEdge;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		public bool Right;
	}
}
