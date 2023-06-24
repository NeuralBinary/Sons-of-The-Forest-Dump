using System;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	internal class OutPt
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OutPt()
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		public int Idx;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x18")]
		public IntPoint Pt;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		public OutPt Next;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x30")]
		public OutPt Prev;
	}
}
