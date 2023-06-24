using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	public struct VoxelCell
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x6ED120", Offset = "0x6EB720", VA = "0x1806ED120")]
		public void AddSpan(uint bottom, uint top, int area, int voxelWalkableClimb)
		{
		}

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0x0")]
		public VoxelSpan firstSpan;
	}
}
