using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	public struct VoxelContour
	{
		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x0")]
		public int nverts;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x8")]
		public int[] verts;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x10")]
		public int[] rverts;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x18")]
		public int reg;

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x1C")]
		public int area;
	}
}
