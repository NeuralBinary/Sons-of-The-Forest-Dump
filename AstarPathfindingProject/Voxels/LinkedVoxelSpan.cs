using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	public struct LinkedVoxelSpan
	{
		// Token: 0x060008D6 RID: 2262 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x6EC960", Offset = "0x6EAF60", VA = "0x1806EC960")]
		public LinkedVoxelSpan(uint bottom, uint top, int area)
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x6EC980", Offset = "0x6EAF80", VA = "0x1806EC980")]
		public LinkedVoxelSpan(uint bottom, uint top, int area, int next)
		{
		}

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x0")]
		public uint bottom;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x4")]
		public uint top;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x8")]
		public int next;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0xC")]
		public int area;
	}
}
