using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class VoxelSpan
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x6ED380", Offset = "0x6EB980", VA = "0x1806ED380")]
		public VoxelSpan(uint b, uint t, int area)
		{
		}

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x10")]
		public uint bottom;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x14")]
		public uint top;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x18")]
		public VoxelSpan next;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x20")]
		public int area;
	}
}
