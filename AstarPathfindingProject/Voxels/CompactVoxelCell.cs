using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public struct CompactVoxelCell
	{
		// Token: 0x060008DF RID: 2271 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public CompactVoxelCell(uint i, uint c)
		{
		}

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0x0")]
		public uint index;

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x4")]
		public uint count;
	}
}
