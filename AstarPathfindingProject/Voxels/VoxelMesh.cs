using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	public struct VoxelMesh
	{
		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x0")]
		public Int3[] verts;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x8")]
		public int[] tris;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0x10")]
		public int[] areas;
	}
}
