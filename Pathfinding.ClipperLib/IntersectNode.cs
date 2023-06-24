using System;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	internal class IntersectNode
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public IntersectNode()
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		public TEdge Edge1;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		public TEdge Edge2;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		public IntPoint Pt;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x30")]
		public IntersectNode Next;
	}
}
