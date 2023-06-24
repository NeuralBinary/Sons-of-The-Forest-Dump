using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	internal struct Triangle
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x200B960", Offset = "0x2009F60", VA = "0x18200B960")]
		public void clear()
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x200B9B0", Offset = "0x2009FB0", VA = "0x18200B9B0")]
		public void set_vertex(int j, int vi, int ni = -1, int ui = -1)
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x200BA10", Offset = "0x200A010", VA = "0x18200BA10")]
		public void move_vertex(int jFrom, int jTo)
		{
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0000830C File Offset: 0x0000650C
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x200BAA0", Offset = "0x200A0A0", VA = "0x18200BAA0")]
		public bool is_complex()
		{
			return default(bool);
		}

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		public const int InvalidMaterialID = -1;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		public const int InvalidGroupID = -1;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x0")]
		public Index3i vIndices;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0xC")]
		public Index3i vNormals;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x18")]
		public Index3i vUVs;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x24")]
		public int nMaterialID;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x28")]
		public int nGroupID;
	}
}
