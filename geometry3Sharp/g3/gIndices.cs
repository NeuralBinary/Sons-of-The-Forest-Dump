using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	public static class gIndices
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x1E2D780", Offset = "0x1E2BD80", VA = "0x181E2D780")]
		public static IEnumerable<Vector3i> Grid3Indices(int nx, int ny, int nz)
		{
			return null;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x1E2D800", Offset = "0x1E2BE00", VA = "0x181E2D800")]
		public static IEnumerable<Vector3i> Grid3IndicesYZ(int ny, int nz)
		{
			return null;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x1E2D870", Offset = "0x1E2BE70", VA = "0x181E2D870")]
		public static IEnumerable<Vector3i> Grid3IndicesXZ(int nx, int nz)
		{
			return null;
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x1E2D8E0", Offset = "0x1E2BEE0", VA = "0x181E2D8E0")]
		public static IEnumerable<Vector3i> Grid3IndicesXY(int nx, int ny)
		{
			return null;
		}

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2i[] GridOffsets4;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Vector2i[] GridOffsets8;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int[,] BoxFaces;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int[] BoxFaceNormals;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Vector3i[] GridOffsets6;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Vector3i[] GridOffsets26;
	}
}
